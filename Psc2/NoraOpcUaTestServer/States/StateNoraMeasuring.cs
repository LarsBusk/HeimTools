namespace NoraOpcUaTestServer.States
{
    public class StateNoraMeasuring : IState
    {
        public string StateName => "Measuring";
        public bool ForceMeasure { get; set; }
        private OpcUaHelper helper;

        public StateNoraMeasuring(OpcUaHelper opcUaHelper)
        {
            helper = opcUaHelper;
            var currentProduct = helper.Nodes.InstrumentNodes.ProductName.Value;
            //helper.StartMeasuring(currentProduct);
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
