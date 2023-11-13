//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinReportingSol.Ef
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.MasterDetails = new HashSet<MasterDetail>();
        }
    
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int ModelId { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string SizeType { get; set; }
        public int Unitprice { get; set; }
        public int OpeningBalance { get; set; }
        public int OpeningQty { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string PhotoPath { get; set; }
        public string Remarks { get; set; }
        public int DiscountPrice { get; set; }
        public string Bin { get; set; }
        public string Manufacture { get; set; }
        public string Vendor { get; set; }
        public string Measurement { get; set; }
        public int Pipeline { get; set; }
        public string Source { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterDetail> MasterDetails { get; set; }
        public virtual Model Model { get; set; }
    }
}