namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sale
    {
        public int SaleID { get; set; }

        [StringLength(50)]
        public string Invoice { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime TrDate { get; set; }

        public int CustomerID { get; set; }

        public int UserID { get; set; }

        [StringLength(200)]
        public string Remarks { get; set; }

        public int BranchId { get; set; }

        [StringLength(30)]
        public string OrderNo { get; set; }

        public int PaymentTypeId { get; set; }

        [StringLength(30)]
        public string SaleType { get; set; }

        public string SaleFrom { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
