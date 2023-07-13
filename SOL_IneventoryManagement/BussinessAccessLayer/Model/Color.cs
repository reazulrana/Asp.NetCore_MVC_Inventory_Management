using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessAccessLayer.Model
{
   public class Color
    {
        
        public int Id { get; set; }
        [Key]
        public string ColorName { get; set; }


    }
}
