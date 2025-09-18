using System;
using System.Collections.Generic;
using System.Drawing.Text;

namespace HeimDalreaderNet
{
    public class ConditionContent : IContent
    {
        public int State;
        public int Code;
        public string Source;
        public string Message;
        public string DetailedMessage;
        public string Hint;
        public DateTime TimeStamp;

        public string[] Headers
        {
            get
            {
                return new string[] { "Time", "State", "Code", "Source", "Message", "Hint" };
            }

        }

        public object[] Data
        {
            get
            {
                return new object[] { TimeStamp, State, Code, Source, Message, Hint };
            }
        }
    }
}
