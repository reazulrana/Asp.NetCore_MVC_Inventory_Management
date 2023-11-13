namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNetRoleClaim1
    {
        public int Id { get; set; }

        [Required]
        [StringLength(450)]
        public string RoleId { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        public virtual AspNetRole1 AspNetRole { get; set; }
    }
}
