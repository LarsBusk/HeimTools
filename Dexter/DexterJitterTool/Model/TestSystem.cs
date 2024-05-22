using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DexterJitterTool.Model
{

    [Table("TestSystem")]
    public partial class TestSystem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestSystem()
        {
            TestSetup = new HashSet<TestSetup>();
        }

        public int TestSystemId { get; set; }

        [Required]
        [StringLength(50)]
        public string SerialNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public long ChassisId { get; set; }

        [Required]
        [StringLength(50)]
        public string SystemName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestSetup> TestSetup { get; set; }
    }
}
