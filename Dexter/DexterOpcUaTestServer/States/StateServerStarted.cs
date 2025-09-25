namespace DexterOpcUaTestServer.States
{
    public class StateServerStarted : IState
    {
        public string StateName => "Server started";
        private OpcUaHelper helper;

        public StateServerStarted(OpcUaHelper opcUaHelper)
        {
            helper = opcUaHelper;
        }

        public void ChangeProduct(string product)
        {
        }

        public void ChangeRecipe(string recipe) { }

        public void OpenSettings()
        {
        }

        public void StartStopMeasuring()
        {
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
