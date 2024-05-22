using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoraOpcUaTestServer.States
{
    public class StateServerStarted : IState
    {
        public string StateName => "Server started";
        public bool ForceMeasure { get; set; }
        private OpcUaHelper helper;

        public StateServerStarted(OpcUaHelper opcUaHelper)
        {
            helper = opcUaHelper;
        }

        public void ChangeProduct(string product)
        {
        }

        public void OpenSettings()
        {
        }

        public void StartStopMeasuring(string product)
        {
        }

        public void EnqueueRinse()
        {
        }

        public void StartServer()
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
        }
    }
}
