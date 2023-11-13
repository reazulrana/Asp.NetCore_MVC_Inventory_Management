namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Manufacture1
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string ManufactureName { get; set; }

        public bool IsSelected { get; set; }
    }
}
