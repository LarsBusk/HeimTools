namespace NoraJitterTool.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TestSetup")]
    public partial class TestSetup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestSetup()
        {
            Delays = new List<Delays>();
        }

        public int TestSetupId { get; set; }

        [Required]
        public string NoraVersion { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime TestTime { get; set; }

        public string Comment { get; set; }

        public string CsvFileName { get; set; }

        public bool ExcludeFromSummary { get; set; }
        public bool NoDelayedResults { get; set; }

        public bool PhysicalPC { get; set; }

        public int NumberOfCycles { get; set; }

        [Required]
        [StringLength(50)]
        public string PlatformVersion { get; set; }

        public int TestSystemId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Delays> Delays { get; set; }

        public virtual TestSystem TestSystem { get; set; }
    }
}
