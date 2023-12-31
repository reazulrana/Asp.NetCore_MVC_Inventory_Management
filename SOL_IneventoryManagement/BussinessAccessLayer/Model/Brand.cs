﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BussinessAccessLayer.Model
{
    public class Brand
    {
        public Brand()
        {
            this.Models = new HashSet<Model>();
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(25, ErrorMessage = "Max Legth is 25 That You Have Excced")]
        [Required]
        public string BrandName { get; set; }

        public int CategoryId { get; set; }

        public virtual ICollection<Model> Models { get; set; }
       public virtual Category Category { get; set; }
    }
}
