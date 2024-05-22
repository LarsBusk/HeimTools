using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoraOpcUaTestServer.States
{
    public class StateNoraPreparing : IState
    {
        public string StateName => "PrepareMeasuring";
        public bool ForceMeasure { get; set; }
        private OpcUaHelper helper;

        public StateNoraPreparing(OpcUaHelper opcUaHelper)
        {
            helper = opcUaHelper;
        }

        public void ChangeProduct(string product)
        {
        }

        public void OpenSettings()
        {
            throw new NotImplementedException();
        }

        public void EnqueueRinse()
        {
        }

        public void StartServer()
        {
        }

        public void StartStopMeasuring(string product)
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
            helper.SetCip();
        }
    }
}
