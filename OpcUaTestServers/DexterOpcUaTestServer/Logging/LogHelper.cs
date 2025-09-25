using NiceLittleLogger;
using Opc.UaFx;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace DexterOpcUaTestServer.Logging
{
    public class LogHelper
    {
        private readonly CsvWriter csvWriter;
        private readonly CsvWriter batchJitterCsvWriter;
        private readonly CsvWriter resultJitterCsvWriter;
        private readonly Logger logger;
        private readonly Logger simLogger;
        private readonly Logger rejectLogger;
        private readonly OpcUaHelper helper;
        private DateTime lastOpcServerDateTime = DateTime.MinValue;
        private uint batchCounter;
        private uint resultCounter;
        private readonly Stopwatch rejectTimer;
        private float lastBone = 0;
        private float lastMetal = 0;
        private float sumWeight;
        private float sumFatWeightProduct;
        private float agregatedFat;

        public static bool IsSimulating;

        public LogHelper(OpcUaHelper helper)
        {
            this.helper = helper;
            csvWriter = new CsvWriter("Logs","MeasuredValues.csv",
                "Time;BatchCounter;SampleNumber;Fat;Weight;Bone;Metal;WeightResult;FatResult;CalcWeight;CalcFat\n");
            batchJitterCsvWriter =
                new CsvWriter("Logs", "BatchJitter.csv",
                    "OpcServerTime;SampleTime;BatchCounter;SampleNumber;TimeBetweenSamples;Delay;\n");
            resultJitterCsvWriter =
                new CsvWriter("Logs", "ResultJitter.csv",
                    "OpcServerTime;SampleTime;ResultCounter;SampleNumber;TimeBetweenSamples;Delay;\n");
            logger = new Logger("Logs", "NodeValues.txt");
            simLogger = new Logger("Logs", "SimulatorLog.txt");
            rejectLogger = new Logger("Logs", "RejectTimes.txt");
            rejectTimer = new Stopwatch();
            IsSimulating = false;

            if (!Directory.Exists("Images"))
            {
                Directory.CreateDirectory("Images");
            }

            this.helper.Nodes.InstrumentNodesDexter.BatchCounter.AfterApplyChanges += BatchCounter_AfterApplyChanges;
            this.helper.Nodes.InstrumentNodesDexter.ResultCounter.AfterApplyChanges += ResultCounter_AfterApplyChanges;
            this.helper.Nodes.BatchNodes.ParameterNodes.FatValue.AfterApplyChanges += LogNodeValues;
            this.helper.Nodes.BatchNodes.ParameterNodes.WeightValue.AfterApplyChanges += LogNodeValues;
            this.helper.Nodes.BatchNodes.ParameterNodes.BoneValue.AfterApplyChanges += LogNodeValues;
            this.helper.Nodes.BatchNodes.ParameterNodes.MetalValue.AfterApplyChanges += LogNodeValues;
            this.helper.Nodes.SampleNodes.SampleNumber.AfterApplyChanges += LogNodeValues;
            this.helper.Nodes.RejectorNodes.Active.AfterApplyChanges += Active_AfterApplyChanges; ;
            this.helper.Nodes.InstrumentNodesDexter.ModeN.AfterApplyChanges += LogSim;
            this.helper.Nodes.RejectorNodes.RejectedImageJPG.AfterApplyChanges += RejectedImageJPG_AfterApplyChanges;

            lastBone = this.helper.Nodes.BatchNodes.ParameterNodes.BoneValue.Value;
            lastMetal = this.helper.Nodes.BatchNodes.ParameterNodes.MetalValue.Value;
        }


        public void NewMeasurement()
        {
            lastBone = 0;
            lastMetal = 0;
        }


        private void Active_AfterApplyChanges(object sender, OpcNodeChangesEventArgs e)
        {
            rejectTimer.Stop();
            LogNodeValues(sender, e);
            rejectLogger.LogInfo("Stopwatch stopped.");
            rejectLogger.LogInfo($"Time from sample to reject: {rejectTimer.ElapsedMilliseconds}");
            rejectTimer.Reset();
        }

        private void RejectedImageJPG_AfterApplyChanges(object sender, OpcNodeChangesEventArgs e)
        {
            var node = (OpcDataVariableNode)sender;
            var nodeTime = node.Timestamp ?? DateTime.Now;
            var value = (byte[])node.Value;
            if (value is null)
            {
                return;
            }
            rejectLogger.LogInfo($"Image received length : {value.Length}.");
            using (var image = Image.FromStream(new MemoryStream(value)))
            {
                image.Save($"Images\\{nodeTime.ToString("yyMMddhhmmssfff")}.jpg", ImageFormat.Jpeg);
            }
        }

        private void LogNodeValues(object sender, OpcNodeChangesEventArgs e)
        {
            var node = (OpcDataVariableNode)sender;
            var nodeTime = node.Timestamp ?? DateTime.Now;
            string name = node.DisplayName;
            var value = node.Value;

            if (SettingsForm.LogOptions.LogStates)
            {
                logger.LogInfo($"{name} changed value: {value} at {nodeTime.ToString("O")}");
            }
        }

        private void LogValues(DateTime opcServerDateTime)
        {
            var fatValue = helper.Nodes.BatchNodes.ParameterNodes.FatValue.Value;
            var weightValue = helper.Nodes.BatchNodes.ParameterNodes.WeightValue.Value;
            var fatResult = helper.Nodes.ResultNodes.ParametersNodesDexter.FatValue.Value;
            var weightResult = helper.Nodes.ResultNodes.ParametersNodesDexter.WeightValue.Value;
            var boneValue = helper.Nodes.BatchNodes.ParameterNodes.BoneValue.Value;
            var metalValue = helper.Nodes.BatchNodes.ParameterNodes.MetalValue.Value;
            CheckFo(boneValue, metalValue);
            UpdateAgregatedValues(fatResult, weightResult);

            csvWriter.WriteValues(opcServerDateTime, batchCounter, resultCounter, fatValue, weightValue, boneValue,
                metalValue, weightResult, fatResult, sumWeight, agregatedFat);
        }

        #region EventHandlers

        private void BatchCounter_AfterApplyChanges(object sender, OpcNodeChangesEventArgs e)
        {
            LogNodeValues(sender, e);
            var node = (OpcDataVariableNode)sender;
            var opcServerDateTime = node.Timestamp ?? DateTime.Now;
            batchCounter = (uint)node.Value;
            var timeDif = 0;
            var sampleNumber = helper.Nodes.SampleNodes.SampleNumber.Value;
            var batchDateTime = helper.Nodes.BatchNodes.Timestamp.Value;

            if (lastOpcServerDateTime > DateTime.MinValue)
                timeDif = (int)opcServerDateTime.Subtract(lastOpcServerDateTime).TotalMilliseconds;

            var delay = (int)opcServerDateTime.Subtract(batchDateTime).TotalMilliseconds;

            if (SettingsForm.LogOptions.LogJitter)
            {
                batchJitterCsvWriter.WriteValues(opcServerDateTime, batchDateTime.ToString("yyyy-MM-dd HH:mm:ss,fff"),
                    batchCounter, sampleNumber, timeDif, delay);
            }

            if (SettingsForm.LogOptions.LogMeasuredValues)
            {
                LogValues(opcServerDateTime);
            }

            lastOpcServerDateTime = opcServerDateTime;
        }

        private void ResultCounter_AfterApplyChanges(object sender, OpcNodeChangesEventArgs e)
        {
            LogNodeValues(sender, e);
            var node = (OpcDataVariableNode)sender;
            var opcServerDateTime = node.Timestamp ?? DateTime.Now;
            resultCounter = (uint)node.Value;
            var timeDif = 0;
            var sampleNumber = helper.Nodes.SampleNodes.SampleNumber.Value;
            var resultDateTime = helper.Nodes.ResultNodes.TimeStampNodes.SampleDateTime.Value;
            var fatResult = helper.Nodes.ResultNodes.ParametersNodesDexter.FatValue.Value;
            var weightResult = helper.Nodes.ResultNodes.ParametersNodesDexter.WeightValue.Value;
            UpdateAgregatedValues(fatResult, weightResult);

            if (lastOpcServerDateTime > DateTime.MinValue)
                timeDif = (int)opcServerDateTime.Subtract(lastOpcServerDateTime).TotalMilliseconds;

            var delay = (int)opcServerDateTime.Subtract(resultDateTime).TotalMilliseconds;

            if (SettingsForm.LogOptions.LogJitter)
            {
                resultJitterCsvWriter.WriteValues(opcServerDateTime, resultDateTime.ToString("yyyy-MM-dd HH:mm:ss,fff"),
                    resultCounter, sampleNumber, timeDif, delay);
            }

            lastOpcServerDateTime = opcServerDateTime;
        }

        private void UpdateAgregatedValues(float fatResult, float weightresult)
        {
            sumFatWeightProduct += fatResult * weightresult;
            sumWeight += weightresult;
            agregatedFat = sumFatWeightProduct / sumWeight;

        }

        private void CheckFo(float bone, float metal)
        {
            if (bone > lastBone | metal > lastMetal)
            {
                rejectTimer.Start();
                lastBone = bone;
                lastMetal = metal;
                rejectLogger.LogInfo($"Stopwatch started metal: {metal}, bone: {bone}.");
            }
        }

        private void LogSim(object sender, OpcNodeChangesEventArgs e)
        {
            var node = (OpcDataVariableNode)sender;
            var nodeTime = node.Timestamp ?? DateTime.Now;
            var name = node.Name;
            var parrent = node.Parent.Name;
            var value = node.Value;

            if (IsSimulating)
            {
                simLogger.LogInfo($"{parrent}.{name} changed value: {value} at {nodeTime.ToString("O")}");
            }
        }

        #endregion
    }
}
