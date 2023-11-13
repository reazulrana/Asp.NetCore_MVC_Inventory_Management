namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Model1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Model1()
        {
            Products = new HashSet<Product1>();
        }

        public int Id { get; set; }

        public int BrandId { get; set; }

        [Required]
        [StringLength(50)]
        public string ModelName { get; set; }

        public virtual Brand1 Brand { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product1> Products { get; set; }
    }
}
