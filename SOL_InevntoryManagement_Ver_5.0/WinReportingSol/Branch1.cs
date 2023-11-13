namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Branchs")]
    public partial class Branch1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Branch1()
        {
            Purchases = new HashSet<Purchase1>();
            Sales = new HashSet<Sale1>();
        }

        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(35)]
        public string Contact { get; set; }

        [StringLength(50)]
        public string BranchIncharge { get; set; }

        public bool IsSelected { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase1> Purchases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale1> Sales { get; set; }
    }
}
