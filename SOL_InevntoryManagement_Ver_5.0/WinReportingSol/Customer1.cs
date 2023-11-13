namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer1()
        {
            Sales = new HashSet<Sale1>();
        }

        public int ID { get; set; }

        public int? MemberId { get; set; }

        [Required]
        [StringLength(70)]
        public string CustName { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(40)]
        public string Contact { get; set; }

        public virtual Member1 Member { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale1> Sales { get; set; }
    }
}
