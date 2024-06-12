using DataAccset.Resource;
using System.Data;
using System.Data.SqlClient;

namespace DataAccset.DbHeper
{
    public class DbHelper
    {

        //public static string DBConnString { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public DbHelper()
        {
        }

        /// <summary>
        /// Thực thi câu lệnh Query
        /// </summary>
        /// <param name="Query"></param>
        /// <returns>Trả về kết quả thực thi câu lệnh truy vấn, dữ liệu vào Datatable<</returns>
        public static DataTable Adapter(string Query, string DBConnString)
        {
           // DBConnString = ConfigurationManager.AppSettings.Get("DbconnSQL");

            using (SqlConnection conn = new SqlConnection(DBConnString))
            {
                conn.Open();
                try
                {
                    if (Query.Length <= 0 || string.IsNullOrEmpty(Query))
                        return null;
                    else
                    {
                        using (DataTable table = new DataTable())
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(Query, conn))
                            {
                                adapter.Fill(table);
                            }
                            return table;
                        }

                    }
                }
                catch (Exception e)
                {
                    //.Show(MessageError.ErrorConnect);
                    return null;
                }
            }

        }
        /// <summary>
        /// // Thực thi Procedure theo điều kiện
        /// </summary>
        /// <param name="sp"> Tên Procedure và danh sách các biến</param>
        /// <returns>Trả về kết quả thực thi procedure, dữ liệu vào Dataset</returns>
        public static ReturnStruct Proc_Report(SqlParam sp, string DBConnString)
        {
            ReturnStruct ret = new ReturnStruct();
            //DBConnString = ConfigurationManager.AppSettings.Get("DbconnSQL");
            using (SqlConnection conn = new SqlConnection(DBConnString))
            {
                try
                {


                    conn.Open();
                    using (DataSet ds = new DataSet())
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand(sp.sProcName, conn))
                            {
                                cmd.CommandTimeout = 60;
                                cmd.CommandType = CommandType.StoredProcedure;
                                // Gán Param
                                foreach (SqlParameter sqlParameter in sp.SetSqlParameter())
                                {
                                    cmd.Parameters.Add(sqlParameter);
                                }

                                SqlDataAdapter sqladp = new SqlDataAdapter(cmd);
                                sqladp.Fill(ds);
                                ret.ReturnDataSet = ds;
                                ret.ReturnMessage = "";
                                ret.ReturnResult = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            ret.ReturnMessage = MessageError.ErrorSqlString +" \n" + ex.Message;
                            ret.ReturnResult = false;
                            return ret;
                        }
                        return ret;
                    }
                }
                catch (Exception ex)
                {
                    ret.ReturnMessage = MessageError.ErrorConnect +" \n" + ex.Message;
                    ret.ReturnResult = false;
                    return ret;

                }
            }
        }
        /// <summary>
        /// Trả về dữ liệu Realtime
        /// </summary>
        /// <param name="sp"></param>
        /// <returns>Dataset</returns>
        public static ReturnStruct Proc_ReportRealtime(SqlParam sp, string DBConnString)
        {
            ReturnStruct ret = new ReturnStruct();
            //DBConnString = ConfigurationManager.AppSettings.Get("DbconnSQL");
            using (SqlConnection conn = new SqlConnection(DBConnString))
            {
                try
                {

                    conn.Open();
                    using (DataSet ds = new DataSet())
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand(sp.sProcName, conn))
                            {
                                cmd.CommandTimeout = 60;
                                cmd.CommandType = CommandType.StoredProcedure;
                                // Gán Param
                                foreach (SqlParameter sqlParameter in sp.SetSqlParameter())
                                {
                                    cmd.Parameters.Add(sqlParameter);
                                }

                                SqlDataAdapter sqladp = new SqlDataAdapter(cmd);
                                sqladp.Fill(ds);
                                ret.ReturnDataSet = ds;
                                ret.ReturnMessage = "";
                                ret.ReturnResult = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            ret.ReturnMessage = MessageError.ErrorSqlString + " \n" + ex.Message;
                            ret.ReturnResult = false;
                            return ret;
                        }
                        return ret;
                    }
                }
                catch (Exception ex)
                {
                    ret.ReturnMessage = MessageError.ErrorConnect + " \n" + ex.Message;
                    ret.ReturnResult = false;
                    return ret;
                }
            }
        }

    }
}
