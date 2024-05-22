using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DexterOpcUaTestServer.States
{
    public class StateDexterStopped : IState
    {
        public string StateName => "Stopped";


        private readonly OpcUaHelper helper;

        public StateDexterStopped(OpcUaHelper opcUaHelper)
        {
            helper = opcUaHelper;
            helper.StopMeasuring();
        }

        public void ChangeProduct(string product)
        {
            helper.ChangeProduct(product);
        }

        public void ChangeRecipe(string recipe)
        {
            helper.SetRecipe(recipe);
        }

        public void OpenSettings()
        {
        }

        public void StartStopMeasuring()
        {
            helper.StartMeasuring();
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
