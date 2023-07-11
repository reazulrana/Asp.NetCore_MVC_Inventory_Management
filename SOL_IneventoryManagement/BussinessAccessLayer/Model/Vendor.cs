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
        public string VendorName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }



    }
}
