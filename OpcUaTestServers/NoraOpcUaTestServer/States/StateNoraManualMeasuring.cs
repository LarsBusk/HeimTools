namespace NoraOpcUaTestServer.States
{
    public class StateNoraManualMeasuring : IState
    {
        public string StateName => $"Prepare Measuring ({state})";
        public bool ForceMeasure { get; set; }
        private readonly OpcUaHelper helper;
        private readonly int state;

        public StateNoraManualMeasuring(OpcUaHelper opcUaHelper, int state)
        {
            helper = opcUaHelper;
            var currentProduct = helper.Nodes.InstrumentNodes.ProductName.Value;
            this.state = state;
        }

        public void ChangeProduct(string product)
        {
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
