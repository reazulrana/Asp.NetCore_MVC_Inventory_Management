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
            this.Products = new HashSet<Product>();

        }

        [Key]
        public int Id { get; set; }
        public string VendorName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Product> Products { get; set; }



    }
}
