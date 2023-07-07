using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Web.Mvc;

namespace BussinessAccessLayer.Model
{
    public class Master
    {
        public Master()
        {
            this.MasterDetails = new HashSet<MasterDetail>();
        }

        [Key]
        public int Id { get; set; }
        public int TrID { get; set; }
        public int TrType { get; set; }

        public virtual ICollection<MasterDetail> MasterDetails { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}
