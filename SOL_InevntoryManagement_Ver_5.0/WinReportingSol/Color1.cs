namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Color1
    {
        [StringLength(25)]
        public string ColorName { get; set; }

        public int Id { get; set; }

        public bool IsSelected { get; set; }
    }
}
