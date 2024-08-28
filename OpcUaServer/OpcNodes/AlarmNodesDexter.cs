using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx;

namespace OpcUaServer.OpcNodes
{
    public class AlarmNodesDexter : NodeBase  
    {
        public List<IOpcNode> Nodes => nodes;
        public OpcDataVariableNode<bool> ReferenceMeasurementNeeded;
        public OpcDataVariableNode<bool> BtcNotWorking;
        public OpcDataVariableNode<bool> CanRunInputLineNotActive;
        public OpcDataVariableNode<bool> CurtainCassetteMissingLeft;
        public OpcDataVariableNode<bool> CurtainCassetteMissingRight;
        public OpcDataVariableNode<bool> EmergencyButtonPressed;
        public OpcDataVariableNode<bool> ExternalConveyorInterlockBroken;
        public OpcDataVariableNode<bool> FrontAccessPanelOpen;
        public OpcDataVariableNode<bool> PreprocessedDataLoggingNormalSamplesEnabled;
        public OpcDataVariableNode<bool> XrayCameraIsDriftingHeAir;
        public OpcDataVariableNode<bool> XrayCameraIsDriftingHeDark;
        public OpcDataVariableNode<bool> XrayCameraIsDriftingLeAir;
        public OpcDataVariableNode<bool> XrayCameraIsDriftingLeDark;
        public OpcDataVariableNode<bool> XrayCameraMissing;
        public OpcDataVariableNode<bool> FodRejectionInManualMode;
        public OpcDataVariableNode<bool> WaitConveyorHardwareTest;
        public OpcDataVariableNode<bool> PerformanceTestFailed;
        public OpcDataVariableNode<bool> ConveyorBeltMovingImpeded;
        public OpcDataVariableNode<bool> ConveyorControllerError;
        public OpcDataVariableNode<bool> ConveyorControllerInSafeDisable;
        public OpcDataVariableNode<bool> ConveyorControllerTemperatureHigh;
        public OpcDataVariableNode<bool> ConveyorManualControl;
        public OpcDataVariableNode<bool> ConveyorSteeringOffTrackWarning;
        public OpcDataVariableNode<bool> OutputLineError;
        public OpcDataVariableNode<bool> FpgaError;
        public OpcDataVariableNode<bool> FsuError;
        public OpcDataVariableNode<bool> XrayCameraError;
        public OpcDataVariableNode<bool> XrayLampError;
        public OpcDataVariableNode<bool> XraySourceError;
        public OpcDataVariableNode<bool> XraySourceInSafeDisable;
        public OpcDataVariableNode<bool> XraySourceTemperatureHigh;
        public OpcDataVariableNode<bool> XraySourceThermalShutdown;
        private readonly OpcFolderNode alarmsFolder;
        private List<IOpcNode> nodes = new List<IOpcNode>();

        public AlarmNodesDexter(OpcFolderNode parentFolder)
        {
            this.FolderName = "Alarms";
            alarmsFolder = new OpcFolderNode(parentFolder, FolderName);
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        public void GetNodes()
        {
            ReferenceMeasurementNeeded = CreateOpcUaNode<bool>(alarmsFolder, "ReferenceMeasurementNeeded", nodes);
            BtcNotWorking = CreateOpcUaNode<bool>(alarmsFolder, "BtcNotWorking", nodes);
            CanRunInputLineNotActive = CreateOpcUaNode<bool>(alarmsFolder, "CanRunInputLineNotActive", nodes);
            CurtainCassetteMissingLeft = CreateOpcUaNode<bool>(alarmsFolder, "CurtainCassetteMissingLeft", nodes);
            CurtainCassetteMissingRight = CreateOpcUaNode<bool>(alarmsFolder, "CurtainCassetteMissingRight", nodes);
            EmergencyButtonPressed = CreateOpcUaNode<bool>(alarmsFolder, "EmergencyButtonPressed", nodes);
            ExternalConveyorInterlockBroken = CreateOpcUaNode<bool>(alarmsFolder, "ExternalConveyorInterlockBroken", nodes);
            FrontAccessPanelOpen = CreateOpcUaNode<bool>(alarmsFolder, "FrontAccessPanelOpen", nodes);
            PreprocessedDataLoggingNormalSamplesEnabled = CreateOpcUaNode<bool>(alarmsFolder, "PreprocessedDataLoggingNormalSamplesEnabled", nodes);
            XrayCameraIsDriftingHeAir = CreateOpcUaNode<bool>(alarmsFolder, "XrayCameraIsDriftingHeAir", nodes);
            XrayCameraIsDriftingHeDark = CreateOpcUaNode<bool>(alarmsFolder, "XrayCameraIsDriftingHeDark", nodes);
            XrayCameraIsDriftingLeAir = CreateOpcUaNode<bool>(alarmsFolder, "XrayCameraIsDriftingLeAir", nodes);
            XrayCameraIsDriftingLeDark = CreateOpcUaNode<bool>(alarmsFolder, "XrayCameraIsDriftingLeDark", nodes);
            XrayCameraMissing = CreateOpcUaNode<bool>(alarmsFolder, "XrayCameraMissing", nodes);
            FodRejectionInManualMode = CreateOpcUaNode<bool>(alarmsFolder, "FodRejectionInManualMode", nodes);
            WaitConveyorHardwareTest = CreateOpcUaNode<bool>(alarmsFolder, "WaitConveyorHardwareTest", nodes);
            PerformanceTestFailed = CreateOpcUaNode<bool>(alarmsFolder, "PerformanceTestFailed", nodes);
            ConveyorBeltMovingImpeded = CreateOpcUaNode<bool>(alarmsFolder, "ConveyorBeltMovingImpeded", nodes);
            ConveyorControllerError = CreateOpcUaNode<bool>(alarmsFolder, "ConveyorControllerError", nodes);
            ConveyorControllerInSafeDisable = CreateOpcUaNode<bool>(alarmsFolder, "ConveyorControllerInSafeDisable", nodes);
            ConveyorControllerTemperatureHigh = CreateOpcUaNode<bool>(alarmsFolder, "ConveyorControllerTemperatureHigh", nodes);
            ConveyorManualControl = CreateOpcUaNode<bool>(alarmsFolder, "ConveyorManualControl", nodes);
            ConveyorSteeringOffTrackWarning = CreateOpcUaNode<bool>(alarmsFolder, "ConveyorSteeringOffTrackWarning", nodes);
            OutputLineError = CreateOpcUaNode<bool>(alarmsFolder, "OutputLineError", nodes);
            FpgaError = CreateOpcUaNode<bool>(alarmsFolder, "FpgaError", nodes);
            FsuError = CreateOpcUaNode<bool>(alarmsFolder, "FsuError", nodes);
            XrayCameraError = CreateOpcUaNode<bool>(alarmsFolder, "XrayCameraError", nodes);
            XrayLampError = CreateOpcUaNode<bool>(alarmsFolder, "XrayLampError", nodes);
            XraySourceError = CreateOpcUaNode<bool>(alarmsFolder, "XraySourceError", nodes);
            XraySourceInSafeDisable = CreateOpcUaNode<bool>(alarmsFolder, "XraySourceInSafeDisable", nodes);
            XraySourceTemperatureHigh = CreateOpcUaNode<bool>(alarmsFolder, "XraySourceTemperatureHigh", nodes);
            XraySourceThermalShutdown = CreateOpcUaNode<bool>(alarmsFolder, "XraySourceThermalShutdown", nodes);
        }
    }
}
