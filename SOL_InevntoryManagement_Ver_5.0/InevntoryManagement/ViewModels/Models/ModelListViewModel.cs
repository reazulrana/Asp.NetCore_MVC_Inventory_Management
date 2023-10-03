using InevntoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Models
{
    public class ModelListViewModel:BasePaginate
    {
        public List<ModelList> modelLists = new List<ModelList>();
        public override string ControllerName { get => "Model"; }
        public override string ActionName { get => "GetModelList";  }


    }



    public class ModelList
    {
        public int ModelId { get; set; }

        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
    }
}
