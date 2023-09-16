namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            MasterDetails = new HashSet<MasterDetail>();
        }

        public int Id { get; set; }

        [StringLength(35)]
        public string Code { get; set; }

        [StringLength(120)]
        public string Description { get; set; }

        public int ModelId { get; set; }

        [StringLength(25)]
        public string Color { get; set; }

        [StringLength(50)]
        public string Size { get; set; }

        [StringLength(2)]
        public string SizeType { get; set; }

        public int Unitprice { get; set; }

        public int OpeningBalance { get; set; }

        public int OpeningQty { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        public string PhotoPath { get; set; }

        [StringLength(250)]
        public string Remarks { get; set; }

        public int DiscountPrice { get; set; }

        [StringLength(10)]
        public string Bin { get; set; }

        [StringLength(50)]
        public string Manufacture { get; set; }

        [StringLength(50)]
        public string Vendor { get; set; }

        [StringLength(10)]
        public string Measurement { get; set; }

        public int Pipeline { get; set; }

        [StringLength(50)]
        public string Source { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterDetail> MasterDetails { get; set; }

        public virtual Model Model { get; set; }
    }
}
