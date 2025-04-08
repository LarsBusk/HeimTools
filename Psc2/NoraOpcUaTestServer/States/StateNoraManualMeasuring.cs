namespace NoraOpcUaTestServer.States
{
    public class StateNoraManualMeasuring : IState
    {
        public string StateName => "Pipette Measuring";
        public bool ForceMeasure { get; set; }
        private OpcUaHelper helper;

        public StateNoraManualMeasuring(OpcUaHelper opcUaHelper)
        {
            helper = opcUaHelper;
            var currentProduct = helper.Nodes.InstrumentNodes.ProductName.Value;
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
