namespace NoraOpcUaTestServer.States
{
    public class StateNoraStopped : IState
    {
        public string StateName => "Stopped (0)";

        public bool ForceMeasure
        {
            get => forceMeasure;
            set
            {
                forceMeasure = value;
                if (forceMeasure) helper.StartMeasuring();
            }
        }

        private readonly OpcUaHelper helper;
        private bool forceMeasure;
        private readonly int state;

        public StateNoraStopped(OpcUaHelper opcUaHelper, int state)
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
            helper.StartMeasuring(product);
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
