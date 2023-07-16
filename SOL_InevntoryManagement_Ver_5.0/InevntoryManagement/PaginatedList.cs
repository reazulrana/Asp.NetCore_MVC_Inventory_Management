using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement
{
    public class PaginatedList<T>:List<T>
    {
      public  int PageIndex { get; set; }
        public int TotalPage { get; set; }
        public int PageSize { get; set; }

        public PaginatedList(List<T> Items,int count,int pageindex,int pagesize)
        {
            this.PageIndex = pageindex;
            this.TotalPage = (int)Math.Ceiling(count / (double)pagesize);
            this.PageSize = pagesize;
            this.AddRange(Items);

        }

        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPage;
        public static PaginatedList<T> Create(List<T> Source,int pageIndex, int pageSize)
        {
            int count = Source.Count();
            var items = Source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PaginatedList<T>(items, count, pageIndex, pageSize);

        }

    }
}
