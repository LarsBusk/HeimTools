using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoraOpcUaTestServer.States
{
    class StateNoraCip : IState
    {
        public string StateName => "CleanInPlace";

        public bool ForceMeasure { get; set; }

        private OpcUaHelper helper;

        public StateNoraCip(OpcUaHelper helper)
        {
            this.helper = helper;
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
            helper.StopMeasuring();
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
        }
    }
}
