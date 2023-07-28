using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BussinessAccessLayer.Model
{
    public class Vendor
    {
        public Vendor()
        {
            this.Purchases = new HashSet<Purchase>();

        }

        [Key]
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "Max Legth is 50 That You Have Excced")]

        public string VendorName { get; set; }
        [MaxLength(120, ErrorMessage = "Max Legth is 120 That You Have Excced")]

        public string Address { get; set; }
        [MaxLength(36, ErrorMessage = "Max Legth is 36 That You Have Excced")]
        public string Contact { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }



    }
}
