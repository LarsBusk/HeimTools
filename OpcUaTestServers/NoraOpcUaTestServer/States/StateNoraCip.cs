namespace NoraOpcUaTestServer.States
{
    class StateNoraCip : IState
    {
        public string StateName => $"Clean In Place ({state})";

        public bool ForceMeasure { get; set; }

        private readonly OpcUaHelper helper;
        private readonly int state;

        public StateNoraCip(OpcUaHelper helper, int state)
        {
            this.helper = helper;
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
            helper.StopMeasuring();
        }

        public void EnqueueZero()
        {
            helper.EnqueueZero();
        }

        public void StopServer()
        {
            helper.StopServer();
        }

        public void SetCip()
        {
        }
    }
}
