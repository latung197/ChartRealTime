using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccset.DbHeper
{
    public class SqlParam
    {
        public string sProcName = "";
        private DataTable dt = new DataTable();
        public SqlParam(string sProcName)
        {
            this.sProcName = sProcName;

            dt.Columns.Add("param");
            dt.Columns.Add("value");
            dt.Columns["param"].DataType = typeof(string);
            dt.Columns["value"].DataType = typeof(object);
        }

        public void AddParam(string sParam, object sValue)
        {
            if (sProcName == "")
                return;
            DataRow row = dt.NewRow();
            row["param"] = sParam;
            row["value"] = sValue;
            dt.Rows.Add(row);
        }

        public SqlParameter[] SetSqlParameter()
        {
            SqlParameter[] SqlParameterList = new SqlParameter[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SqlParameter SqlParameter = new SqlParameter(dt.Rows[i][0].ToString(), dt.Rows[i][1]);
                SqlParameterList[i] = SqlParameter;
            }
            return SqlParameterList;
        }
    }
}
