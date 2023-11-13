namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vendor1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendor1()
        {
            Purchases = new HashSet<Purchase1>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string VendorName { get; set; }

        [StringLength(120)]
        public string Address { get; set; }

        [StringLength(36)]
        public string Contact { get; set; }

        public bool IsSelected { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase1> Purchases { get; set; }
    }
}
