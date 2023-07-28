using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Web.Mvc;

namespace BussinessAccessLayer.Model
{
    public class Customer
    {
        public Customer()
        {
            this.Sales = new HashSet<Sale>();
        }


        [Key]
        public int ID { get; set; }
        public int MemberId { get; set; }
        [MaxLength(50, ErrorMessage = "Max Legth is 50 That You Have Excced")]
        public string CustName { get; set; }
        public virtual Member Member { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
        
    }
}
