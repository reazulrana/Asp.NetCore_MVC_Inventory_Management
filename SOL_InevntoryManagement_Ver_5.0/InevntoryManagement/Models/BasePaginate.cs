using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.Models
{
    public abstract class BasePaginate
    {

        public BasePaginate()
        {
            PageSize = 10;
            TotalRow = 10;
        }

        private int _PrevousPage;
        private int _nextPage;
        private int _FirstPage;
        private int _LastPage;
        public int TotalPage { get
            {
                int output = (int)Math.Ceiling((decimal)TotalRow / (decimal)PageSize);
                return output;

            } }
        public int TotalRow { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public int NextPage { get => (PageIndex + 1) >= TotalPage ? LastPage : PageIndex + 1; } //{ get => PageIndex < 0 ? 1 : PageIndex < TotalPage ? PageIndex + 1 : TotalPage; }
        public int PrevousPage { get => (PageIndex - 1) <= 0 ? FirstPage : PageIndex - 1; } //{ get => PageIndex-1; }
        public int SkipRow { get => (PageIndex - 1) * PageSize; }

        public int FirstPage { get => 1; }
        public int LastPage { get => TotalPage; }
        public string SearchText { get; set; }
        public virtual string ActionName { get; set; }
        public virtual string ControllerName { get; set; }
        public bool isShow { get => TotalRow==0?false:true; } // it is used for hide component

        public int RowIndex {get =>PageIndex* PageSize <= 0 ? 1 : ((PageIndex* PageSize) - PageSize) + 1;}


        public virtual int DefaultPageSize(int? newpagesize)
        {
            int pasgesize = newpagesize != null ? (int)newpagesize : 10;
            return pasgesize;

        }

        public virtual int DefaultPageIndex(int? pageno)
        {
            int Pageno = pageno != null ? (int)pageno : 1;
            return Pageno;

        }

     
        public int BasePageNo
        {
            get
            {
                return 10;
            }
        }
        public int EndPageNo { get
            {
                int basepage = BasePageNo;
                int totalPage = TotalPage;
                int pageIndex = PageIndex-1;
                int sn = 0; //sn == start no
                if (TotalPage < basepage || PageIndex >= totalPage)
                {
                    sn = TotalPage;
                }
                else { 
                sn = pageIndex <= totalPage ? ((pageIndex / basepage) * basepage) + basepage : ((pageIndex / basepage) * basepage) + (totalPage - ((pageIndex / basepage) * basepage));
                }
                return sn;
            } }

    public int StartPageNo
        {
            get
            {
                int basepage = BasePageNo;
                int totalPage = TotalPage;
                int pageIndex = PageIndex - 1;
                int numberremove = 0;
                int sn = 0; //sn == start no
                int sl = 0;
                if (totalPage < basepage)
                {
                    sn = totalPage;
                    numberremove = 1;
                    sl = 1;

                }
                else
                {

                    //lessthanbasenumber = TotalPage <= basepage?TotalPage:0;
                    sn = pageIndex <= totalPage ? (((pageIndex / basepage) * basepage)) + basepage : (((pageIndex / basepage) * basepage)) + (totalPage - ((pageIndex / basepage) * basepage));
                    numberremove = sn == totalPage ? basepage - Math.Abs(((((pageIndex / basepage) * basepage)) + basepage) - totalPage) : basepage;

                    sl = ((sn - numberremove)) + 1;
                }





                return sl;
            }
        }


        public virtual void ChangeActionName(string actionname=null)
        {

            
            throw new Exception("Thorw Exception");
        }

    }
}
