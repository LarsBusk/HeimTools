using NiceLittleLogger;
using OpcUaServer.OpcNodes;
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
        private readonly CsvWriter _csvWriter;
        private readonly CsvWriter _batchJitterCsvWriter;
        private readonly CsvWriter _resultJitterCsvWriter;
        private readonly Logger _logger;
        private readonly Logger _simLogger;
        private readonly Logger _rejectLogger;
        private OpcUaHelper _helper;
        private DateTime _lastOpcServerDateTime = DateTime.MinValue;
        private uint _batchCounter;
        private Stopwatch _rejectTimer;
        private float _lastBone = 0;
        private  float _lastMetal = 0;

        public static bool IsSimulating;

        public LogHelper(OpcUaHelper helper)
        {
            _helper = helper;
            _csvWriter = new CsvWriter("Logs","MeasuredValues.csv",
                "Time;BatchCounter;SampleNumber;Fat;Weight;Bone;Metal\n");
            _batchJitterCsvWriter =
                new CsvWriter("Logs", "BatchJitter.csv",
                    "OpcServerTime;SampleTime;BatchCounter;SampleNumber;TimeBetweenSamples;Delay;\n");
            _resultJitterCsvWriter =
                new CsvWriter("Logs", "ResultJitter.csv",
                    "OpcServerTime;SampleTime;ResultCounter;SampleNumber;TimeBetweenSamples;Delay;\n");
            _logger = new Logger("Logs", "NodeValues.txt");
            _simLogger = new Logger("Logs", "SimulatorLog.txt");
            _rejectLogger = new Logger("Logs", "RejectTimes.txt");
            _rejectTimer = new Stopwatch();
            IsSimulating = false;

            if (!Directory.Exists("Images"))
            {
                Directory.CreateDirectory("Images");
            }

            _helper.Nodes.InstrumentNodesDexter.BatchCounter.AfterApplyChanges += BatchCounter_AfterApplyChanges;
            _helper.Nodes.BatchNodes.ParameterNodes.FatValue.AfterApplyChanges += LogNodeValues;
            _helper.Nodes.BatchNodes.ParameterNodes.WeightValue.AfterApplyChanges += LogNodeValues;
            _helper.Nodes.BatchNodes.ParameterNodes.BoneValue.AfterApplyChanges += LogNodeValues;
            _helper.Nodes.BatchNodes.ParameterNodes.MetalValue.AfterApplyChanges += LogNodeValues;
            _helper.Nodes.SampleNodes.SampleNumber.AfterApplyChanges += LogNodeValues;
            _helper.Nodes.RejectorNodes.Active.AfterApplyChanges += Active_AfterApplyChanges; ;
            _helper.Nodes.InstrumentNodesDexter.ModeN.AfterApplyChanges += LogSim;
            _helper.Nodes.RejectorNodes.RejectedImageJPG.AfterApplyChanges += RejectedImageJPG_AfterApplyChanges;

            _lastBone = _helper.Nodes.BatchNodes.ParameterNodes.BoneValue.Value;
            _lastMetal = _helper.Nodes.BatchNodes.ParameterNodes.MetalValue.Value;
        }

        public void NewMeasurement()
        {
            _lastBone = 0;
            _lastMetal = 0;
        }


        private void Active_AfterApplyChanges(object sender, OpcNodeChangesEventArgs e)
        {
            _rejectTimer.Stop();
            LogNodeValues(sender, e);
            _rejectLogger.LogInfo("Stopwatch stopped.");
            _rejectLogger.LogInfo($"Time from sample to reject: {_rejectTimer.ElapsedMilliseconds}");
            _rejectTimer.Reset();
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
            _rejectLogger.LogInfo($"Image received length : {value.Length}.");
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
                _logger.LogInfo($"{name} changed value: {value} at {nodeTime.ToString("O")}");
            }
        }

        private void LogValues(OpcUaNodes nodes, DateTime opcServerDateTime)
        {
            var fatValue = nodes.BatchNodes.ParameterNodes.FatValue.Value;
            var weightValue = nodes.BatchNodes.ParameterNodes.WeightValue.Value;
            var boneValue = nodes.BatchNodes.ParameterNodes.BoneValue.Value;
            var metalValue = nodes.BatchNodes.ParameterNodes.MetalValue.Value;
            var sampleNumber = nodes.SampleNodes.SampleNumber.Value;
            CheckFo(boneValue, metalValue);

            _csvWriter.WriteValues(opcServerDateTime, _batchCounter, sampleNumber, fatValue,
                weightValue, boneValue,
                metalValue);
        }

        #region EventHandlers

        private void BatchCounter_AfterApplyChanges(object sender, OpcNodeChangesEventArgs e)
        {
            LogNodeValues(sender, e);
            var node = (OpcDataVariableNode)sender;
            var opcServerDateTime = node.Timestamp ?? DateTime.Now;
            _batchCounter = (uint)node.Value;
            var timeDif = 0;
            var sampleNumber = _helper.Nodes.SampleNodes.SampleNumber.Value;
            var batchDateTime = _helper.Nodes.BatchNodes.Timestamp.Value;

            if (_lastOpcServerDateTime > DateTime.MinValue)
                timeDif = (int)opcServerDateTime.Subtract(_lastOpcServerDateTime).TotalMilliseconds;

            var delay = (int)opcServerDateTime.Subtract(batchDateTime).TotalMilliseconds;

            if (SettingsForm.LogOptions.LogJitter)
            {
                _batchJitterCsvWriter.WriteValues(opcServerDateTime, batchDateTime.ToString("yyyy-MM-dd HH:mm:ss,fff"),
                    _batchCounter, sampleNumber, timeDif, delay);
            }

            if (SettingsForm.LogOptions.LogMeasuredValues)
            {
                LogValues(_helper.Nodes, opcServerDateTime);
            }

            _lastOpcServerDateTime = opcServerDateTime;
        }

        private void CheckFo(float bone, float metal)
        {
            if (bone > _lastBone | metal > _lastMetal)
            {
                _rejectTimer.Start();
                _lastBone = bone;
                _lastMetal = metal;
                _rejectLogger.LogInfo($"Stopwatch started metal: {metal}, bone: {bone}.");
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
                _simLogger.LogInfo($"{parrent}.{name} changed value: {value} at {nodeTime.ToString("O")}");
            }
        }

        #endregion
    }
}
