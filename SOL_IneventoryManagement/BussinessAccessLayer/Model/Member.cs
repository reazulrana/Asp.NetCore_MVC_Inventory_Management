using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Web.Mvc;

namespace BussinessAccessLayer.Model
{
   public class Member
    {
        public Member()
        {
            this.Customers = new HashSet<Customer>();
        }

        [Key]
        public int Id { get; set; }
        public string MemberName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
