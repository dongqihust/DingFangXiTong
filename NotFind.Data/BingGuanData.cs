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
    public class BingGuanData
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Add(BingGuanInfo _BingGuanInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("B_SuoShuBuMenSN",_BingGuanInfo.B_SuoShuBuMenSN),
                                     new SqlParameter("B_SuoShuDingFangXiTongSN",_BingGuanInfo.B_SuoShuDingFangXiTongSN),
                                     new SqlParameter("B_Name",_BingGuanInfo.B_Name),
                                     new SqlParameter("B_Address",_BingGuanInfo.B_Address),
                                     new SqlParameter("B_Phone",_BingGuanInfo.B_Phone),
                                     new SqlParameter("B_ShiFouShanChu",_BingGuanInfo.B_ShiFouShanChu),
                                     new SqlParameter("B_AddDate",_BingGuanInfo.B_AddDate),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "BingGuan_Add", parm);
            return true;
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="_B_SN">SN</param>
        /// <returns></returns>
        public static Boolean Delete(Int32 _B_SN)
        {
            SqlParameter[] parm = { new SqlParameter("B_SN", _B_SN), };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "BingGuan_Delete", parm);
            return true;
        }
        #endregion

        #region 获取
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="_B_SN">SN</param>
        /// <returns></returns>
        public static BingGuanInfo Get(Int32 _B_SN)
        {
            BingGuanInfo _BingGuanInfo = new BingGuanInfo();
            SqlParameter[] parm = { new SqlParameter("B_SN", _B_SN), };
            using (SqlDataReader _SDR = SqlHelper.ExecuteReader(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "BingGuan_Get", parm))
            {
                if (_SDR.Read())
                {
                    _BingGuanInfo.B_SN = Convert.ToInt32(_SDR["B_SN"]);
                    _BingGuanInfo.B_SuoShuBuMenSN = Convert.ToInt32(_SDR["B_SuoShuBuMenSN"]);
                    _BingGuanInfo.B_SuoShuDingFangXiTongSN = Convert.ToInt32(_SDR["B_SuoShuDingFangXiTongSN"]);
                    _BingGuanInfo.B_Name = Convert.ToString(_SDR["B_Name"]);
                    _BingGuanInfo.B_Address = Convert.ToString(_SDR["B_Address"]);
                    _BingGuanInfo.B_Phone = Convert.ToString(_SDR["B_Phone"]);
                    _BingGuanInfo.B_ShiFouShanChu = Convert.ToBoolean(_SDR["B_ShiFouShanChu"]);
                    _BingGuanInfo.B_AddDate = Convert.ToDateTime(_SDR["B_AddDate"]);
                }
                _SDR.Close();
                _SDR.Dispose();
            }
            return _BingGuanInfo;
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            DataSet _DataSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "BingGuan_List", null);
            return _DataSet.Tables[0];
        }
        #endregion

        #region 设置
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Set(BingGuanInfo _BingGuanInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("B_SN",_BingGuanInfo.B_SN),
                                     new SqlParameter("B_SuoShuBuMenSN",_BingGuanInfo.B_SuoShuBuMenSN),
                                     new SqlParameter("B_SuoShuDingFangXiTongSN",_BingGuanInfo.B_SuoShuDingFangXiTongSN),
                                     new SqlParameter("B_Name",_BingGuanInfo.B_Name),
                                     new SqlParameter("B_Address",_BingGuanInfo.B_Address),
                                     new SqlParameter("B_Phone",_BingGuanInfo.B_Phone),
                                     new SqlParameter("B_ShiFouShanChu",_BingGuanInfo.B_ShiFouShanChu),
                                     new SqlParameter("B_AddDate",_BingGuanInfo.B_AddDate),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "BingGuan_Set", parm);
            return true;
        }
        #endregion
    }

}
