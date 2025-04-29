namespace NoraOpcUaTestServer.States
{
    public class StateNoraProcessCleaning : IState
    {
        public string StateName => $"Process Cleaning ({state})";

        public bool ForceMeasure { get; set; }

        private readonly OpcUaHelper helper;
        private readonly int state;

        public StateNoraProcessCleaning(OpcUaHelper opcUaHelper, int state)
        {
            helper = opcUaHelper;
            this.state = state;
        }

        public void ChangeProduct(string product)
        {
        }

        public void OpenSettings()
        {
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
