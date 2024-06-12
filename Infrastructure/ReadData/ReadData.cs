using DataAccset.DbHeper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ReadData
{
    public class ReadData
    {
        string Dbconnection = null;
        public ReturnStruct LoadRateTempChange(long dFromLg, long dToLg, float mM, string eW)
        {
            ReturnStruct returnStruct = new ReturnStruct();
            try
            {
                SqlParam sp = new SqlParam("[rpt_LoadRateTempChange]");
                sp.AddParam("dFrom", dFromLg);
                sp.AddParam("dTo", dToLg);
                sp.AddParam("mM", mM);
                sp.AddParam("EW", eW);
                returnStruct = DbHelper.Proc_ReportRealtime(sp, Dbconnection);
                return returnStruct;
            }
            catch (Exception ex)
            {
                returnStruct.ReturnDataSet = null;
                returnStruct.ReturnResult = false;
                returnStruct.ReturnMessage = ex.Message;
                return returnStruct;
            }
        }

        /// <summary>
        /// Trả về dư liệu realtime biểu đồ nhiệt độ
        /// </summary>
        /// <param name="dFromLg">Từ thời điểm</param>
        /// <param name="eW">'E' Biểu đồ đông || 'W' biểu đồ tây</param>
        /// <returns></returns>
        public ReturnStruct LoadRealTimeTemp(long dFromLg, string eW)
        {
            ReturnStruct returnStruct = new ReturnStruct();
            try
            {
                SqlParam sp = new SqlParam("[rpt_RealTimeTemp]");
                sp.AddParam("dFrom", dFromLg);
                sp.AddParam("EW", eW);
                returnStruct = DbHelper.Proc_ReportRealtime(sp, Dbconnection);
                return returnStruct;

            }
            catch (Exception ex)
            {
                returnStruct.ReturnDataSet = null;
                returnStruct.ReturnResult = false;
                returnStruct.ReturnMessage = ex.Message;
                return returnStruct;
            }
        }

        /// <summary>
        /// Trả về dư liệu realtime biểu đồ tốc độ thay đổi nhiệt độ
        /// </summary>
        /// <param name="dFromLg">Từ thời điêm</param>
        /// <param name="eW">Biểu đồ đông || 'W' biểu đồ tây</param>
        /// <returns></returns>
        public ReturnStruct LoadRealTimeTempChange(long dFromLg, string eW)
        {
            ReturnStruct returnStruct = new ReturnStruct();
            try
            {
                SqlParam sp = new SqlParam("[rpt_RealTimeTempChange]");
                sp.AddParam("dFrom", dFromLg);
                sp.AddParam("EW", eW);
                returnStruct = DbHelper.Proc_ReportRealtime(sp, Dbconnection);
                return returnStruct;
            }
            catch (Exception ex)
            {
                returnStruct.ReturnDataSet = null;
                returnStruct.ReturnResult = false;
                returnStruct.ReturnMessage = ex.Message;
                return returnStruct;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dFromLg">Từ ngày giờ</param>
        /// <param name="dToLg">Đến ngày giờ</param>
        /// <param name="mM">Chiều dài</param>
        /// <param name="eW">E: Đông | W: Tây</param>
        /// <returns></returns>
        public ReturnStruct LoadTemp(long dFromLg, long dToLg, float mM, string eW)
        {
            ReturnStruct returnStruct = new ReturnStruct();
            try
            {
                SqlParam sp = new SqlParam("[rpt_LoadTemp]");
                sp.AddParam("dFrom", dFromLg);
                sp.AddParam("dTo", dToLg);
                sp.AddParam("mM", mM);
                sp.AddParam("EW", eW);
                returnStruct = DbHelper.Proc_ReportRealtime(sp, Dbconnection);
                return returnStruct;

            }
            catch (Exception ex)
            {
                returnStruct.ReturnDataSet = null;
                returnStruct.ReturnResult = false;
                returnStruct.ReturnMessage = ex.Message;
                return returnStruct;
            }
        }

        // ---   ---

        public ReturnStruct LoadRealTimeFlowingStream(long dFromLg)
        {
            ReturnStruct returnStruct = new ReturnStruct();

            try
            {
                SqlParam sp = new SqlParam("rpt_RealTimeFlowingStream");
                sp.AddParam("dFrom", dFromLg);
                returnStruct = DbHelper.Proc_ReportRealtime(sp, Dbconnection);
                return returnStruct;
            }
            catch (Exception ex)
            {
                returnStruct.ReturnDataSet = null;
                returnStruct.ReturnResult = false;
                returnStruct.ReturnMessage = ex.Message;
                return returnStruct;
            }
        }

        public ReturnStruct LoadRealTimeFlowingStreamChange(long dFromLg)
        {
            try
            {
                ReturnStruct returnStruct = new ReturnStruct();
                SqlParam sp = new SqlParam("rpt_RealTimeFlowingStreamChange");
                sp.AddParam("dFrom", dFromLg);
                returnStruct = DbHelper.Proc_ReportRealtime(sp);
                if (returnStruct.ReturnDataSet != null)
                {
                    return returnStruct.ReturnDataSet;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataSet LoadFlowingStreamChange(long dFromLg, long dToLg, float mM)
        {
            try
            {
                ReturnStruct returnStruct = new ReturnStruct();
                SqlParam sp = new SqlParam("rpt_FlowingStreamChange");
                sp.AddParam("dFrom", dFromLg);
                sp.AddParam("dTo", dToLg);
                sp.AddParam("mM", mM);
                returnStruct = DbHelper.Proc_ReportRealtime(sp);
                if (returnStruct.ReturnDataSet != null)
                {
                    return returnStruct.ReturnDataSet;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }



    }
}
