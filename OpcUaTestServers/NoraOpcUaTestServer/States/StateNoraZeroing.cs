using System;

namespace NoraOpcUaTestServer.States
{
    public class StateNoraZeroing : IState
    {
        public string StateName => $"ZeroSetting ({state})";
        public bool ForceMeasure { get; set; }
        private readonly OpcUaHelper helper;
        private readonly int state;

        public StateNoraZeroing(OpcUaHelper opcUaHelper, int state)
        {
            helper = opcUaHelper;
            this.state = state;
        }

        public void ChangeProduct(string product)
        {
        }

        public void OpenSettings()
        {
            throw new NotImplementedException();
        }

        public void EnqueueRinse()
        {
        }

        public void StartServer()
        {
        }

        public void StartStopMeasuring(string product)
        {
        }

        public void EnqueueZero()
        {
        }

        public void StopServer()
        {
            helper.StopServer();
        }

        public void SetCip()
        {
            helper.SetCip();
        }
    }
}
