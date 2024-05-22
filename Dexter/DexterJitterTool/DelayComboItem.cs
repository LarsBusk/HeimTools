namespace DexterJitterTool
{
    public class DelayComboItem
    {
        public string SampleNumber;
        public int DelayId;

        public DelayComboItem(string sampleNumber, int delayId)
        {
            SampleNumber = sampleNumber;
            DelayId = delayId;
        }

        public override string ToString()
        {
            return SampleNumber;
        }
    }
}
