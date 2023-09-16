namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MasterDetail")]
    public partial class MasterDetail
    {
        [Key]
        public int DID { get; set; }

        public int ProductId { get; set; }

        public int Qty { get; set; }

        public int Price { get; set; }

        public int AmountId { get; set; }

        public virtual Amount Amount { get; set; }

        public virtual Product Product { get; set; }
    }
}
