namespace HeimdalEvents
{
    public class EventContent
    {
        public int Code;
        public string Message;
        public string Hint;
        public string Module;
        public string Type;

        public override string ToString()
        {
            return $"{Module};{Type};{Code};{Message};{Hint}";
        }
    }
}
