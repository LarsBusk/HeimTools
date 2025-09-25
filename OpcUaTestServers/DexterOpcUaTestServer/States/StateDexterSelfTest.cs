using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexterOpcUaTestServer.States
{
    public class StateDexterSelfTest : IState
    {
        public string StateName => "Self test";
        private OpcUaHelper helper;

        public StateDexterSelfTest(OpcUaHelper opcUaHelper)
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
            throw new NotImplementedException();
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
