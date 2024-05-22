using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexterJitterTool
{
    public class TestSetupComboItems
    {
        public DateTime TestDateTime;
        public int TestSetupId;

        public TestSetupComboItems(DateTime testDateTime, int testSetupId)
        {
            TestDateTime = testDateTime;
            TestSetupId = testSetupId;
        }

        public override string ToString()
        {
            return TestDateTime.ToString("yyyy-MM-dd");
        }
    }
}
