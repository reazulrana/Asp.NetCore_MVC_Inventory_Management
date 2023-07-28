using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessAccessLayer.Model
{
   public class Measure
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(25, ErrorMessage = "Max Legth is 25 That You Have Excced")]
        [Required]
        public string Measurements { get; set; }

    }
}
