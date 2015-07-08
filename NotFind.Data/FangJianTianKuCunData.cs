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
    public class FangJianTianKuCunData
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Add(FangJianTianKuCunInfo _FangJianTianKuCunInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("F_SuoShuBuMenSN",_FangJianTianKuCunInfo.F_SuoShuBuMenSN),
                                     new SqlParameter("F_SuoShuXiTongSN",_FangJianTianKuCunInfo.F_SuoShuXiTongSN),
                                     new SqlParameter("F_BingGuanSN",_FangJianTianKuCunInfo.F_BingGuanSN),
                                     new SqlParameter("F_FangXingSN",_FangJianTianKuCunInfo.F_FangXingSN),
                                     new SqlParameter("F_FangJianSN",_FangJianTianKuCunInfo.F_FangJianSN),
                                     new SqlParameter("F_RuZhuStartDate",_FangJianTianKuCunInfo.F_RuZhuStartDate),
                                     new SqlParameter("F_TuiFangEndDate",_FangJianTianKuCunInfo.F_TuiFangEndDate),
                                     new SqlParameter("F_ZhengJianJiaGe",_FangJianTianKuCunInfo.F_ZhengJianJiaGe),
                                     new SqlParameter("F_BaoLiuZhuangTai",_FangJianTianKuCunInfo.F_BaoLiuZhuangTai),
                                     new SqlParameter("F_ShiFouShanChu",_FangJianTianKuCunInfo.F_ShiFouShanChu),
                                     new SqlParameter("F_AddDate",_FangJianTianKuCunInfo.F_AddDate),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "FangJianTianKuCun_Add", parm);
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
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "FangJianTianKuCun_Delete", parm);
            return true;
        }
        #endregion

        #region 获取
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="_F_SN">SN</param>
        /// <returns></returns>
        public static FangJianTianKuCunInfo Get(Int32 _F_SN)
        {
            FangJianTianKuCunInfo _FangJianTianKuCunInfo = new FangJianTianKuCunInfo();
            SqlParameter[] parm = { new SqlParameter("F_SN", _F_SN), };
            using (SqlDataReader _SDR = SqlHelper.ExecuteReader(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "FangJianTianKuCun_Get", parm))
            {
                if (_SDR.Read())
                {
                    _FangJianTianKuCunInfo.F_SN = Convert.ToInt32(_SDR["F_SN"]);
                    _FangJianTianKuCunInfo.F_SuoShuBuMenSN = Convert.ToInt32(_SDR["F_SuoShuBuMenSN"]);
                    _FangJianTianKuCunInfo.F_SuoShuXiTongSN = Convert.ToInt32(_SDR["F_SuoShuXiTongSN"]);
                    _FangJianTianKuCunInfo.F_BingGuanSN = Convert.ToInt32(_SDR["F_BingGuanSN"]);
                    _FangJianTianKuCunInfo.F_FangXingSN = Convert.ToInt32(_SDR["F_FangXingSN"]);
                    _FangJianTianKuCunInfo.F_FangJianSN = Convert.ToInt32(_SDR["F_FangJianSN"]);
                    _FangJianTianKuCunInfo.F_RuZhuStartDate = Convert.ToDateTime(_SDR["F_RuZhuStartDate"]);
                    _FangJianTianKuCunInfo.F_TuiFangEndDate = Convert.ToDateTime(_SDR["F_TuiFangEndDate"]);
                    _FangJianTianKuCunInfo.F_ZhengJianJiaGe = Convert.ToDouble(_SDR["F_ZhengJianJiaGe"]);
                    _FangJianTianKuCunInfo.F_BaoLiuZhuangTai = Convert.ToInt32(_SDR["F_BaoLiuZhuangTai"]);
                    _FangJianTianKuCunInfo.F_ShiFouShanChu = Convert.ToBoolean(_SDR["F_ShiFouShanChu"]);
                    _FangJianTianKuCunInfo.F_AddDate = Convert.ToDateTime(_SDR["F_AddDate"]);
                }
                _SDR.Close();
                _SDR.Dispose();
            }
            return _FangJianTianKuCunInfo;
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            DataSet _DataSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "FangJianTianKuCun_List", null);
            return _DataSet.Tables[0];
        }
        #endregion

        #region 设置
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Set(FangJianTianKuCunInfo _FangJianTianKuCunInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("F_SN",_FangJianTianKuCunInfo.F_SN),
                                     new SqlParameter("F_SuoShuBuMenSN",_FangJianTianKuCunInfo.F_SuoShuBuMenSN),
                                     new SqlParameter("F_SuoShuXiTongSN",_FangJianTianKuCunInfo.F_SuoShuXiTongSN),
                                     new SqlParameter("F_BingGuanSN",_FangJianTianKuCunInfo.F_BingGuanSN),
                                     new SqlParameter("F_FangXingSN",_FangJianTianKuCunInfo.F_FangXingSN),
                                     new SqlParameter("F_FangJianSN",_FangJianTianKuCunInfo.F_FangJianSN),
                                     new SqlParameter("F_RuZhuStartDate",_FangJianTianKuCunInfo.F_RuZhuStartDate),
                                     new SqlParameter("F_TuiFangEndDate",_FangJianTianKuCunInfo.F_TuiFangEndDate),
                                     new SqlParameter("F_ZhengJianJiaGe",_FangJianTianKuCunInfo.F_ZhengJianJiaGe),
                                     new SqlParameter("F_BaoLiuZhuangTai",_FangJianTianKuCunInfo.F_BaoLiuZhuangTai),
                                     new SqlParameter("F_ShiFouShanChu",_FangJianTianKuCunInfo.F_ShiFouShanChu),
                                     new SqlParameter("F_AddDate",_FangJianTianKuCunInfo.F_AddDate),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "FangJianTianKuCun_Set", parm);
            return true;
        }
        #endregion
    }

}
