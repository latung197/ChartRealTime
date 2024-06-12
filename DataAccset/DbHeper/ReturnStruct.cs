using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccset.DbHeper
{
    public struct ReturnStruct
    {
        public bool ReturnResult
        {
            set;
            get;
        }
        public DataSet ReturnDataSet
        {
            set;
            get;
        }

        public string ReturnMessage
        {
            set;
            get;
        }
    }
}
