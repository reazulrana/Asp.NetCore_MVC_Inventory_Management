namespace WinReportingSol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Amount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Amount()
        {
            MasterDetails = new HashSet<MasterDetail>();
        }

        public int Id { get; set; }

        public int TrID { get; set; }

        public int TrType { get; set; }

        public int TotalAmount { get; set; }

        public int Dues { get; set; }

        public int Transport { get; set; }

        public int Others { get; set; }

        public int GrossAmount { get; set; }

        public int Discount { get; set; }

        public int NetAmount { get; set; }

        public int PaymentTypeId { get; set; }

        public int PaymentOnCash { get; set; }

        public virtual PaymentType PaymentType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterDetail> MasterDetails { get; set; }
    }
}
