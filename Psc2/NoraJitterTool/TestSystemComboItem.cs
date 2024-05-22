namespace NoraJitterTool
{
    public class TestSystemComboItem
    {
        public string Name { get; set; }
        public long ChassisId { get; set; }

        public TestSystemComboItem(string name, long chassisId)
        {
            this.Name = name;
            this.ChassisId = chassisId;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
