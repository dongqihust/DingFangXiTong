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
    public class DingDanMingXiData
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Int32 Add(DingDanMingXiInfo _DingDanMingXiInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("D_SuoShuDingDanSN",_DingDanMingXiInfo.D_SuoShuDingDanSN),
                                     new SqlParameter("D_SuoShuBuMenSN",_DingDanMingXiInfo.D_SuoShuBuMenSN),
                                     new SqlParameter("D_SuoShuXiTongSN",_DingDanMingXiInfo.D_SuoShuXiTongSN),
                                     new SqlParameter("D_SuoShuFangJianTian",_DingDanMingXiInfo.D_SuoShuFangJianTian),
                                     new SqlParameter("D_SuoShuChuangWeiTian",_DingDanMingXiInfo.D_SuoShuChuangWeiTian),
                                     new SqlParameter("D_AddDate",_DingDanMingXiInfo.D_AddDate),
                                     new SqlParameter("D_ShiFouShanChu",_DingDanMingXiInfo.D_ShiFouShanChu),
                                  };


            Int32 D_SN = Int32.Parse(SqlHelper.ExecuteScalar(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingDanMingXi_Add", parm).ToString());
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
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingDanMingXi_Delete", parm);
            return true;
        }
        #endregion

        #region 获取
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="_D_SN">SN</param>
        /// <returns></returns>
        public static DingDanMingXiInfo Get(Int32 _D_SN)
        {
            DingDanMingXiInfo _DingDanMingXiInfo = new DingDanMingXiInfo();
            SqlParameter[] parm = { new SqlParameter("D_SN", _D_SN), };
            using (SqlDataReader _SDR = SqlHelper.ExecuteReader(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingDanMingXi_Get", parm))
            {
                if (_SDR.Read())
                {
                    _DingDanMingXiInfo.D_SN = Convert.ToInt32(_SDR["D_SN"]);
                    _DingDanMingXiInfo.D_SuoShuDingDanSN = Convert.ToInt32(_SDR["D_SuoShuDingDanSN"]);
                    _DingDanMingXiInfo.D_SuoShuBuMenSN = Convert.ToInt32(_SDR["D_SuoShuBuMenSN"]);
                    _DingDanMingXiInfo.D_SuoShuXiTongSN = Convert.ToInt32(_SDR["D_SuoShuXiTongSN"]);
                    _DingDanMingXiInfo.D_SuoShuFangJianTian = Convert.ToInt32(_SDR["D_SuoShuFangJianTian"]);
                    _DingDanMingXiInfo.D_SuoShuChuangWeiTian = Convert.ToInt32(_SDR["D_SuoShuChuangWeiTian"]);
                    _DingDanMingXiInfo.D_AddDate = Convert.ToDateTime(_SDR["D_AddDate"]);
                    _DingDanMingXiInfo.D_ShiFouShanChu = Convert.ToBoolean(_SDR["D_ShiFouShanChu"]);
                }
                _SDR.Close();
                _SDR.Dispose();
            }
            return _DingDanMingXiInfo;
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            DataSet _DataSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingDanMingXi_List", null);
            return _DataSet.Tables[0];
        }
        #endregion

        #region 设置
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Set(DingDanMingXiInfo _DingDanMingXiInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("D_SN",_DingDanMingXiInfo.D_SN),
                                     new SqlParameter("D_SuoShuDingDanSN",_DingDanMingXiInfo.D_SuoShuDingDanSN),
                                     new SqlParameter("D_SuoShuBuMenSN",_DingDanMingXiInfo.D_SuoShuBuMenSN),
                                     new SqlParameter("D_SuoShuXiTongSN",_DingDanMingXiInfo.D_SuoShuXiTongSN),
                                     new SqlParameter("D_SuoShuFangJianTian",_DingDanMingXiInfo.D_SuoShuFangJianTian),
                                     new SqlParameter("D_SuoShuChuangWeiTian",_DingDanMingXiInfo.D_SuoShuChuangWeiTian),
                                     new SqlParameter("D_AddDate",_DingDanMingXiInfo.D_AddDate),
                                     new SqlParameter("D_ShiFouShanChu",_DingDanMingXiInfo.D_ShiFouShanChu),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingDanMingXi_Set", parm);
            return true;
        }
        #endregion
    }

}
