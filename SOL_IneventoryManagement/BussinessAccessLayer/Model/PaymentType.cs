using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessAccessLayer.Model
{
   public class PaymentType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25,ErrorMessage ="You have entered more than 25 character. Max Length is 25")]
        public string Payments { get; set; }
        public bool IsSelected { get; set; }
        public virtual List<Amount> Amounts { get; set; } = new List<Amount>();



    }
}
