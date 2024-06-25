namespace NoraOpcUaTestServer.States
{
    public class StateNoraProcessCleaning : IState
    {
        public string StateName => "ProcessCleaning";

        public bool ForceMeasure { get; set; }

        private OpcUaHelper helper;

        public StateNoraProcessCleaning(OpcUaHelper opcUaHelper)
        {
            helper = opcUaHelper;
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
