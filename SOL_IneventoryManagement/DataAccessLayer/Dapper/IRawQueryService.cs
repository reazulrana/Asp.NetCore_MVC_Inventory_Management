using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dapper
{
    public interface IRawQueryService
    {


        public string GetSaletListQuery { get; }
    }
}
