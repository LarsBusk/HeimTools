using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexterOpcUaTestServer.States
{
    public class StateDexterWaitXray : IState
    {
        public string StateName => "Wait X-Ray";
        private OpcUaHelper helper;

        public StateDexterWaitXray(OpcUaHelper opcUaHelper)
        {
            helper = opcUaHelper;
        }

        public void ChangeProduct(string product)
        {
        }

        public void ChangeRecipe(string recipe)
        {
            helper.SetRecipe(recipe);
        }

        public void OpenSettings()
        {
        }

        public void StartServer()
        {
        }

        public void StartStopMeasuring()
        {
        }

        public void StopServer()
        {
            helper.StopServer();
        }
    }
}
