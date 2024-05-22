using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoraOpcUaTestServer.States
{
    public class StateNoraCleaning : IState
    {
        public string StateName => "ManualCleaning";

        public bool ForceMeasure { get; set; }

        private OpcUaHelper helper;

        public StateNoraCleaning(OpcUaHelper opcUaHelper)
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
            helper.StartMeasuring(product);
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
