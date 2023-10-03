using BussinessAccessLayer.Model;
using InevntoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Manufactures
{
    public class ManufactureListViewModel:BasePaginate
    {
        public List<Manufacture> manufactures { get; set; } = new List<Manufacture>();

        public override string ControllerName { get => "Manufacture"; }
        public override string ActionName { get => "ListManufactures"; }
    }


}
