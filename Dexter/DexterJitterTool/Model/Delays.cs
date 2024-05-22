using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DexterJitterTool.Model
{
    public partial class Delays
    {
        public int DelaysId { get; set; }

        public int Delay { get; set; }

        public int TimeBetweenSamples { get; set; }

        public int BatchCounter { get; set; }

        public int TestSetupId { get; set; }

        [StringLength(50)]
        public string SampleNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SampleDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime OpcServerTimeStamp { get; set; }

        public virtual TestSetup TestSetup { get; set; }
    }
}
