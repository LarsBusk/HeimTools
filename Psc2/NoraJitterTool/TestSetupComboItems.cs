using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoraJitterTool
{
    public class TestSetupComboItems : IComparable
    {
        public DateTime TestDateTime;
        public int TestSetupId;

        public TestSetupComboItems(DateTime testDateTime, int testSetupId)
        {
            TestDateTime = testDateTime;
            TestSetupId = testSetupId;
        }

        public int CompareTo(object obj)
        {
            return  - TestDateTime.CompareTo(((TestSetupComboItems) obj).TestDateTime);
        }

        public override string ToString()
        {
            return TestDateTime.ToString("yyyy-MM-dd");
        }
    }
}
