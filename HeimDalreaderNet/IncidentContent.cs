namespace HeimDalreaderNet
{
    public class IncidentContent : IContent
    {
        public int Level;
        public int Code;
        public string Source;
        public string Message;
        public string DetailedMessage;
        public string Hint;
        public DateTime TimeStamp;
        public List<ParameterContent> Parameters;

        public string[] Headers
        {
            get
            {
                return new string[] { "Time", "Code", "Source", "Message", "Hint" };
            }

        }

        public object[] Data
        {
            get
            {
                return new object[] { TimeStamp, Code, Source, Message, Hint };
            }
        }
    }
}
