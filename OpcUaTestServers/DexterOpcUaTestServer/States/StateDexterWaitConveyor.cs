using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexterOpcUaTestServer.States
{
    public class StateDexterWaitConveyor : IState
    {
        public string StateName => "Wait conveyor";
        

        private OpcUaHelper helper;

        public StateDexterWaitConveyor(OpcUaHelper opcUaHelper)
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
            helper.StartMeasuring();
        }
        
        public void StopServer()
        {
            helper.StopServer();
        }
    }
}
