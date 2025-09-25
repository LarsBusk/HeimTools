namespace DexterOpcUaTestServer.States
{
    public class StateDexterMeasuring : IState
    {
        public string StateName => "Measuring";
        private OpcUaHelper helper;

        public StateDexterMeasuring(OpcUaHelper opcUaHelper)
        {
            helper = opcUaHelper;
            helper.StartMeasuring();
        }

        public void ChangeProduct(string product)
        {
            helper.ChangeProduct(product);
        }

        public void ChangeRecipe(string recipe) { }

        public void OpenSettings()
        {
        }

        public void StartStopMeasuring()
        {
            helper.StopMeasuring();
        }


        public void StartServer()
        {
        }


        public void StopServer()
        {
            helper.StopServer();
        }
    }
}
