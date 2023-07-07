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

        public string Measurements { get; set; }

    }
}
