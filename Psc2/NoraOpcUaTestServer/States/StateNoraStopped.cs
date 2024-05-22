using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NoraOpcUaTestServer.States
{
    public class StateNoraStopped : IState
    {
        public string StateName => "Stopped";

        public bool ForceMeasure
        {
            get => forceMeasure;
            set
            {
                forceMeasure = value;
                if (forceMeasure) helper.StartMeasuring();
            }
        }

        private readonly OpcUaHelper helper;
        private bool forceMeasure;

        public StateNoraStopped(OpcUaHelper opcUaHelper)
        {
            helper = opcUaHelper;
            //helper.StopMeasuring();
        }

        public void ChangeProduct(string product)
        {
            helper.ChangeProduct(product);
        }

        public void OpenSettings()
        {
        }

        public void StartStopMeasuring(string product)
        {
            helper.StartMeasuring(product);
        }

        public void EnqueueRinse()
        {
            helper.EnqueueClean();
        }

        public void StartServer()
        {
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
            helper.SetCip();
        }
    }
}
