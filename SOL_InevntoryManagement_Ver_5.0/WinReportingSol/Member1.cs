namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Member1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member1()
        {
            Customers = new HashSet<Customer1>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string MemberName { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(36)]
        public string ContactNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer1> Customers { get; set; }
    }
}
