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
    public class FangXingData
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Add(FangXingInfo _FangXingInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("F_SuoShuBuMenSN",_FangXingInfo.F_SuoShuBuMenSN),
                                     new SqlParameter("F_SuoShuXiTongSN",_FangXingInfo.F_SuoShuXiTongSN),
                                     new SqlParameter("F_SuoShuBingGuanSN",_FangXingInfo.F_SuoShuBingGuanSN),
                                     new SqlParameter("F_Name",_FangXingInfo.F_Name),
                                     new SqlParameter("F_Detail",_FangXingInfo.F_Detail),
                                     new SqlParameter("F_ZhengJianJiaGe",_FangXingInfo.F_ZhengJianJiaGe),
                                     new SqlParameter("F_ChuangWei1JiaGe",_FangXingInfo.F_ChuangWei1JiaGe),
                                     new SqlParameter("F_ChuangWei2JiaGe",_FangXingInfo.F_ChuangWei2JiaGe),
                                     new SqlParameter("F_ChuangWei3JiaGe",_FangXingInfo.F_ChuangWei3JiaGe),
                                     new SqlParameter("F_ChuangWei4JiaGe",_FangXingInfo.F_ChuangWei4JiaGe),
                                     new SqlParameter("F_ChuangWei5JiaGe",_FangXingInfo.F_ChuangWei5JiaGe),
                                     new SqlParameter("F_ShiFouShanChu",_FangXingInfo.F_ShiFouShanChu),
                                     new SqlParameter("F_AddDate",_FangXingInfo.F_AddDate),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "FangXing_Add", parm);
            return true;
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="_F_SN">SN</param>
        /// <returns></returns>
        public static Boolean Delete(Int32 _F_SN)
        {
            SqlParameter[] parm = { new SqlParameter("F_SN", _F_SN), };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "FangXing_Delete", parm);
            return true;
        }
        #endregion

        #region 获取
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="_F_SN">SN</param>
        /// <returns></returns>
        public static FangXingInfo Get(Int32 _F_SN)
        {
            FangXingInfo _FangXingInfo = new FangXingInfo();
            SqlParameter[] parm = { new SqlParameter("F_SN", _F_SN), };
            using (SqlDataReader _SDR = SqlHelper.ExecuteReader(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "FangXing_Get", parm))
            {
                if (_SDR.Read())
                {
                    _FangXingInfo.F_SN = Convert.ToInt32(_SDR["F_SN"]);
                    _FangXingInfo.F_SuoShuBuMenSN = Convert.ToInt32(_SDR["F_SuoShuBuMenSN"]);
                    _FangXingInfo.F_SuoShuXiTongSN = Convert.ToInt32(_SDR["F_SuoShuXiTongSN"]);
                    _FangXingInfo.F_SuoShuBingGuanSN = Convert.ToInt32(_SDR["F_SuoShuBingGuanSN"]);
                    _FangXingInfo.F_Name = Convert.ToString(_SDR["F_Name"]);
                    _FangXingInfo.F_Detail = Convert.ToString(_SDR["F_Detail"]);
                    _FangXingInfo.F_ZhengJianJiaGe = Convert.ToDouble(_SDR["F_ZhengJianJiaGe"]);
                    _FangXingInfo.F_ChuangWei1JiaGe = Convert.ToDouble(_SDR["F_ChuangWei1JiaGe"]);
                    _FangXingInfo.F_ChuangWei2JiaGe = Convert.ToDouble(_SDR["F_ChuangWei2JiaGe"]);
                    _FangXingInfo.F_ChuangWei3JiaGe = Convert.ToDouble(_SDR["F_ChuangWei3JiaGe"]);
                    _FangXingInfo.F_ChuangWei4JiaGe = Convert.ToDouble(_SDR["F_ChuangWei4JiaGe"]);
                    _FangXingInfo.F_ChuangWei5JiaGe = Convert.ToDouble(_SDR["F_ChuangWei5JiaGe"]);
                    _FangXingInfo.F_ShiFouShanChu = Convert.ToBoolean(_SDR["F_ShiFouShanChu"]);
                    _FangXingInfo.F_AddDate = Convert.ToDateTime(_SDR["F_AddDate"]);
                }
                _SDR.Close();
                _SDR.Dispose();
            }
            return _FangXingInfo;
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            DataSet _DataSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "FangXing_List", null);
            return _DataSet.Tables[0];
        }
        #endregion

        #region 设置
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Set(FangXingInfo _FangXingInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("F_SN",_FangXingInfo.F_SN),
                                     new SqlParameter("F_SuoShuBuMenSN",_FangXingInfo.F_SuoShuBuMenSN),
                                     new SqlParameter("F_SuoShuXiTongSN",_FangXingInfo.F_SuoShuXiTongSN),
                                     new SqlParameter("F_SuoShuBingGuanSN",_FangXingInfo.F_SuoShuBingGuanSN),
                                     new SqlParameter("F_Name",_FangXingInfo.F_Name),
                                     new SqlParameter("F_Detail",_FangXingInfo.F_Detail),
                                     new SqlParameter("F_ZhengJianJiaGe",_FangXingInfo.F_ZhengJianJiaGe),
                                     new SqlParameter("F_ChuangWei1JiaGe",_FangXingInfo.F_ChuangWei1JiaGe),
                                     new SqlParameter("F_ChuangWei2JiaGe",_FangXingInfo.F_ChuangWei2JiaGe),
                                     new SqlParameter("F_ChuangWei3JiaGe",_FangXingInfo.F_ChuangWei3JiaGe),
                                     new SqlParameter("F_ChuangWei4JiaGe",_FangXingInfo.F_ChuangWei4JiaGe),
                                     new SqlParameter("F_ChuangWei5JiaGe",_FangXingInfo.F_ChuangWei5JiaGe),
                                     new SqlParameter("F_ShiFouShanChu",_FangXingInfo.F_ShiFouShanChu),
                                     new SqlParameter("F_AddDate",_FangXingInfo.F_AddDate),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "FangXing_Set", parm);
            return true;
        }
        #endregion
    }

}
