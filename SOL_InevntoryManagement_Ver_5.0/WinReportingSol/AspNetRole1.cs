namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNetRole1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetRole1()
        {
            AspNetRoleClaims = new HashSet<AspNetRoleClaim1>();
            AspNetUsers = new HashSet<AspNetUser1>();
        }

        [StringLength(450)]
        public string Id { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(256)]
        public string NormalizedName { get; set; }

        public string ConcurrencyStamp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetRoleClaim1> AspNetRoleClaims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUser1> AspNetUsers { get; set; }
    }
}
