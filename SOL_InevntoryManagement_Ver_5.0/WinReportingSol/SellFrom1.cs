namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SellFrom1
    {
        public int Id { get; set; }

        public string SaleFrom { get; set; }

        public bool IsSelected { get; set; }
    }
}
