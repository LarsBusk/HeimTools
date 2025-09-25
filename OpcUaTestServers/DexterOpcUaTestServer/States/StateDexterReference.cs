using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexterOpcUaTestServer.States
{
    class StateDexterReference : IState
    {
        public string StateName => "Reference";
        
        private OpcUaHelper helper;

        public StateDexterReference(OpcUaHelper helper)
        {
            this.helper = helper;
        }

        public void ChangeProduct(string product)
        {
        }

        public void ChangeRecipe(string recipe) { }

        public void OpenSettings()
        {
        }


        public void StartServer()
        {
        }

        public void StartStopMeasuring()
        {
            helper.StopMeasuring();
        }


        public void StopServer()
        {
            helper.StopServer();
        }
    }
}
