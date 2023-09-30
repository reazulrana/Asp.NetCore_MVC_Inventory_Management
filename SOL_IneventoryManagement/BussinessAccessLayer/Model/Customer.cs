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
       // public int MemberId { get; set; }
        [MaxLength(70, ErrorMessage = "Max Legth is 70 That You Have Excced")]
        [Required]
        [Display(Name ="Customer Name")]
        public string CustName { get; set; }
        
        [MaxLength(100, ErrorMessage = "Max Legth is 100 That You Have Excced")]
        public string Address { get; set; }
        

        [Required]
        [MaxLength(40, ErrorMessage = "Max Legth is 40 That You Have Excced")]
        public string Contact { get; set; }
        //public virtual Member Member { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        
    }
}
