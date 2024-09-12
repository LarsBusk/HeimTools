using System;

namespace OpcUaServer
{
    public class ServerStateEventArgs
    {
        public string NewState;
        public DateTime TimeStamp;

        public ServerStateEventArgs(string newState, DateTime timeStamp)
        {
            this.NewState = newState;
            this.TimeStamp = timeStamp;
        }

    }
}
