namespace NoraOpcUaTestServer.States
{
    public class StateNoraMeasuring : IState
    {
        public string StateName => $"Measuring ({state})";
        public bool ForceMeasure { get; set; }
        private readonly OpcUaHelper helper;
        private readonly int state;

        public StateNoraMeasuring(OpcUaHelper opcUaHelper, int state)
        {
            helper = opcUaHelper;
            this.state = state;
        }

        public void ChangeProduct(string product)
        {
            helper.ChangeProduct(product);
        }

        public void OpenSettings()
        {
        }

        public void StartStopMeasuring(string product)
        {
            helper.StopMeasuring();
        }

        public void EnqueueRinse()
        {
            helper.EnqueueClean();
        }

        public void StartServer()
        {
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
            helper.SetCip();
        }
    }
}
