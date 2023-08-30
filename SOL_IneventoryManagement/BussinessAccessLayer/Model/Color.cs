using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessAccessLayer.Model
{
    public class Color
    {

        //[DatabaseGenerated(databaseGeneratedOption:DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [MaxLength(25, ErrorMessage = "Max Legth is 25 That You Have Excced")]
        public string ColorName { get; set; }
        public bool IsSelected { get; set; }
    }
}
