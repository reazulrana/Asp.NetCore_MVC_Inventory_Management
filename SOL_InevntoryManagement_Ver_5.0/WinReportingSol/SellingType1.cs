namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SellingType1
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Types { get; set; }

        public bool IsSelected { get; set; }
    }
}
