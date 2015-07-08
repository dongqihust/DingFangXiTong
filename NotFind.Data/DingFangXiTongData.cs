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
    public class DingFangXiTongData
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Add(DingFangXiTongInfo _DingFangXiTongInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("D_SuoShuBuMenSN",_DingFangXiTongInfo.D_SuoShuBuMenSN),
                                     new SqlParameter("D_Name",_DingFangXiTongInfo.D_Name),
                                     new SqlParameter("D_BanJiSNs",_DingFangXiTongInfo.D_BanJiSNs),
                                     new SqlParameter("D_AddDate",_DingFangXiTongInfo.D_AddDate),
                                     new SqlParameter("D_ShiFouShanChu",_DingFangXiTongInfo.D_ShiFouShanChu),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingFangXiTong_Add", parm);
            return true;
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
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingFangXiTong_Delete", parm);
            return true;
        }
        #endregion

        #region 获取
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="_D_SN">SN</param>
        /// <returns></returns>
        public static DingFangXiTongInfo Get(Int32 _D_SN)
        {
            DingFangXiTongInfo _DingFangXiTongInfo = new DingFangXiTongInfo();
            SqlParameter[] parm = { new SqlParameter("D_SN", _D_SN), };
            using (SqlDataReader _SDR = SqlHelper.ExecuteReader(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingFangXiTong_Get", parm))
            {
                if (_SDR.Read())
                {
                    _DingFangXiTongInfo.D_SN = Convert.ToInt32(_SDR["D_SN"]);
                    _DingFangXiTongInfo.D_SuoShuBuMenSN = Convert.ToInt32(_SDR["D_SuoShuBuMenSN"]);
                    _DingFangXiTongInfo.D_Name = Convert.ToString(_SDR["D_Name"]);
                    _DingFangXiTongInfo.D_BanJiSNs = Convert.ToString(_SDR["D_BanJiSNs"]);
                    _DingFangXiTongInfo.D_AddDate = Convert.ToDateTime(_SDR["D_AddDate"]);
                    _DingFangXiTongInfo.D_ShiFouShanChu = Convert.ToBoolean(_SDR["D_ShiFouShanChu"]);
                }
                _SDR.Close();
                _SDR.Dispose();
            }
            return _DingFangXiTongInfo;
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            DataSet _DataSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingFangXiTong_List", null);
            return _DataSet.Tables[0];
        }
        #endregion

        #region 设置
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Set(DingFangXiTongInfo _DingFangXiTongInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("D_SN",_DingFangXiTongInfo.D_SN),
                                     new SqlParameter("D_SuoShuBuMenSN",_DingFangXiTongInfo.D_SuoShuBuMenSN),
                                     new SqlParameter("D_Name",_DingFangXiTongInfo.D_Name),
                                     new SqlParameter("D_BanJiSNs",_DingFangXiTongInfo.D_BanJiSNs),
                                     new SqlParameter("D_AddDate",_DingFangXiTongInfo.D_AddDate),
                                     new SqlParameter("D_ShiFouShanChu",_DingFangXiTongInfo.D_ShiFouShanChu),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingFangXiTong_Set", parm);
            return true;
        }
        #endregion
    }

}
