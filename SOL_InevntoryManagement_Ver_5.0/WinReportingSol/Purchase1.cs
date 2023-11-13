namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Purchase1
    {
        public int PurchaseID { get; set; }

        [StringLength(50)]
        public string PurchaseNo { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime TrDate { get; set; }

        public int VendorId { get; set; }

        public int SourceId { get; set; }

        [StringLength(200)]
        public string Remarks { get; set; }

        public int BranchId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ReceiveDate { get; set; }

        public int ReceivedByID { get; set; }

        public virtual Branch1 Branch { get; set; }

        public virtual Source1 Source { get; set; }

        public virtual Vendor1 Vendor { get; set; }
    }
}
