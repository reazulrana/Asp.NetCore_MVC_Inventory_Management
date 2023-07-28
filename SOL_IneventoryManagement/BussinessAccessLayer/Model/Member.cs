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
        [MaxLength(25, ErrorMessage = "Max Legth is 25 That You Have Excced")]
        [Required]
        public string MemberName { get; set; }
        [MaxLength(200, ErrorMessage = "Max Legth is 200 That You Have Excced")]
        public string Address { get; set; }
        [MaxLength(36, ErrorMessage = "Max Legth is 36 That You Have Excced")]
        public string ContactNo { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
