using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using NotFind.Entity;
using System.Web;
namespace NotFind.Data
{
    public class DingDanLogsData
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Int32 Add(DingDanLogsInfo _DingDanLogsInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("D_DingDanSN",_DingDanLogsInfo.D_DingDanSN),
                                     new SqlParameter("D_DingDanShuoMing",_DingDanLogsInfo.D_DingDanShuoMing),
                                     new SqlParameter("D_AddIP",_DingDanLogsInfo.D_AddIP),
                                     new SqlParameter("D_AddDate",_DingDanLogsInfo.D_AddDate),
                                  };
       
            Int32 D_SN = Int32.Parse(SqlHelper.ExecuteScalar(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingDanLogs_Add", parm).ToString());
            return D_SN;
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="_D_SN">SN</param>
        /// <returns></returns>
        public static Boolean Delete(Int32 _D_SN)
        {
            SqlParameter[] parm = { new SqlParameter("D_SN", _D_SN), };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingDanLogs_Delete", parm);
            return true;
        }
        #endregion

        #region 获取
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="_D_SN">SN</param>
        /// <returns></returns>
        public static DingDanLogsInfo Get(Int32 _D_SN)
        {
            DingDanLogsInfo _DingDanLogsInfo = new DingDanLogsInfo();
            SqlParameter[] parm = { new SqlParameter("D_SN", _D_SN), };
            using (SqlDataReader _SDR = SqlHelper.ExecuteReader(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingDanLogs_Get", parm))
            {
                if (_SDR.Read())
                {
                    _DingDanLogsInfo.D_SN = Convert.ToInt32(_SDR["D_SN"]);
                    _DingDanLogsInfo.D_DingDanSN = Convert.ToInt32(_SDR["D_DingDanSN"]);
                    _DingDanLogsInfo.D_DingDanShuoMing = Convert.ToString(_SDR["D_DingDanShuoMing"]);
                    _DingDanLogsInfo.D_AddIP = Convert.ToString(_SDR["D_AddIP"]);
                    _DingDanLogsInfo.D_AddDate = Convert.ToDateTime(_SDR["D_AddDate"]);
                }
                _SDR.Close();
                _SDR.Dispose();
            }
            return _DingDanLogsInfo;
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            DataSet _DataSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingDanLogs_List", null);
            return _DataSet.Tables[0];
        }
        #endregion

        #region 设置
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Set(DingDanLogsInfo _DingDanLogsInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("D_SN",_DingDanLogsInfo.D_SN),
                                     new SqlParameter("D_DingDanSN",_DingDanLogsInfo.D_DingDanSN),
                                     new SqlParameter("D_DingDanShuoMing",_DingDanLogsInfo.D_DingDanShuoMing),
                                     new SqlParameter("D_AddIP",_DingDanLogsInfo.D_AddIP),
                                     new SqlParameter("D_AddDate",_DingDanLogsInfo.D_AddDate),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingDanLogs_Set", parm);
            return true;
        }
        #endregion
    }

}
