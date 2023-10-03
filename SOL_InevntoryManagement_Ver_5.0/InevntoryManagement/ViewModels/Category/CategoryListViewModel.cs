using InevntoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Category
{
    public class CategoryListViewModel:BasePaginate
    {

        public List<BussinessAccessLayer.Model.Category> categories { get; set; } = new List<BussinessAccessLayer.Model.Category>();
        public override string ActionName { get=> "CategoryList"; }
        public override string ControllerName { get=>"Category"; }
    }
}
