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
    public class ChuangWeiKuCunData
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Add(ChuangWeiKuCunInfo _ChuangWeiKuCunInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("C_SuoShuBuMenSN",_ChuangWeiKuCunInfo.C_SuoShuBuMenSN),
                                     new SqlParameter("C_SuoShuXiTongSN",_ChuangWeiKuCunInfo.C_SuoShuXiTongSN),
                                     new SqlParameter("C_BingGuanSN",_ChuangWeiKuCunInfo.C_BingGuanSN),
                                     new SqlParameter("C_FangXingSN",_ChuangWeiKuCunInfo.C_FangXingSN),
                                     new SqlParameter("C_FangJianSN",_ChuangWeiKuCunInfo.C_FangJianSN),
                                     new SqlParameter("C_ChuangWeiHao",_ChuangWeiKuCunInfo.C_ChuangWeiHao),
                                     new SqlParameter("C_RuZhuStartDate",_ChuangWeiKuCunInfo.C_RuZhuStartDate),
                                     new SqlParameter("C_TuiFangEndDate",_ChuangWeiKuCunInfo.C_TuiFangEndDate),
                                     new SqlParameter("C_ChuangWei1JiaGe",_ChuangWeiKuCunInfo.C_ChuangWei1JiaGe),
                                     new SqlParameter("C_ChuangWei2JiaGe",_ChuangWeiKuCunInfo.C_ChuangWei2JiaGe),
                                     new SqlParameter("C_ChuangWei3JiaGe",_ChuangWeiKuCunInfo.C_ChuangWei3JiaGe),
                                     new SqlParameter("C_ChuangWei4JiaGe",_ChuangWeiKuCunInfo.C_ChuangWei4JiaGe),
                                     new SqlParameter("C_ChuangWei5JiaGe",_ChuangWeiKuCunInfo.C_ChuangWei5JiaGe),
                                     new SqlParameter("C_BaoLiuZhuangTai",_ChuangWeiKuCunInfo.C_BaoLiuZhuangTai),
                                     new SqlParameter("C_ShiFouShanChu",_ChuangWeiKuCunInfo.C_ShiFouShanChu),
                                     new SqlParameter("C_AddDate",_ChuangWeiKuCunInfo.C_AddDate),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "ChuangWeiKuCun_Add", parm);
            return true;
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="_C_SN">SN</param>
        /// <returns></returns>
        public static Boolean Delete(Int32 _C_SN)
        {
            SqlParameter[] parm = { new SqlParameter("C_SN", _C_SN), };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "ChuangWeiKuCun_Delete", parm);
            return true;
        }
        #endregion

        #region 获取
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="_C_SN">SN</param>
        /// <returns></returns>
        public static ChuangWeiKuCunInfo Get(Int32 _C_SN)
        {
            ChuangWeiKuCunInfo _ChuangWeiKuCunInfo = new ChuangWeiKuCunInfo();
            SqlParameter[] parm = { new SqlParameter("C_SN", _C_SN), };
            using (SqlDataReader _SDR = SqlHelper.ExecuteReader(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "ChuangWeiKuCun_Get", parm))
            {
                if (_SDR.Read())
                {
                    _ChuangWeiKuCunInfo.C_SN = Convert.ToInt32(_SDR["C_SN"]);
                    _ChuangWeiKuCunInfo.C_SuoShuBuMenSN = Convert.ToInt32(_SDR["C_SuoShuBuMenSN"]);
                    _ChuangWeiKuCunInfo.C_SuoShuXiTongSN = Convert.ToInt32(_SDR["C_SuoShuXiTongSN"]);
                    _ChuangWeiKuCunInfo.C_BingGuanSN = Convert.ToInt32(_SDR["C_BingGuanSN"]);
                    _ChuangWeiKuCunInfo.C_FangXingSN = Convert.ToInt32(_SDR["C_FangXingSN"]);
                    _ChuangWeiKuCunInfo.C_FangJianSN = Convert.ToInt32(_SDR["C_FangJianSN"]);
                    _ChuangWeiKuCunInfo.C_ChuangWeiHao = Convert.ToInt32(_SDR["C_ChuangWeiHao"]);
                    _ChuangWeiKuCunInfo.C_RuZhuStartDate = Convert.ToDateTime(_SDR["C_RuZhuStartDate"]);
                    _ChuangWeiKuCunInfo.C_TuiFangEndDate = Convert.ToDateTime(_SDR["C_TuiFangEndDate"]);
                    _ChuangWeiKuCunInfo.C_ChuangWei1JiaGe = Convert.ToDouble(_SDR["C_ChuangWei1JiaGe"]);
                    _ChuangWeiKuCunInfo.C_ChuangWei2JiaGe = Convert.ToDouble(_SDR["C_ChuangWei2JiaGe"]);
                    _ChuangWeiKuCunInfo.C_ChuangWei3JiaGe = Convert.ToDouble(_SDR["C_ChuangWei3JiaGe"]);
                    _ChuangWeiKuCunInfo.C_ChuangWei4JiaGe = Convert.ToDouble(_SDR["C_ChuangWei4JiaGe"]);
                    _ChuangWeiKuCunInfo.C_ChuangWei5JiaGe = Convert.ToDouble(_SDR["C_ChuangWei5JiaGe"]);
                    _ChuangWeiKuCunInfo.C_BaoLiuZhuangTai = Convert.ToInt32(_SDR["C_BaoLiuZhuangTai"]);
                    _ChuangWeiKuCunInfo.C_ShiFouShanChu = Convert.ToBoolean(_SDR["C_ShiFouShanChu"]);
                    _ChuangWeiKuCunInfo.C_AddDate = Convert.ToDateTime(_SDR["C_AddDate"]);
                }
                _SDR.Close();
                _SDR.Dispose();
            }
            return _ChuangWeiKuCunInfo;
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            DataSet _DataSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "ChuangWeiKuCun_List", null);
            return _DataSet.Tables[0];
        }
        #endregion

        #region 设置
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Set(ChuangWeiKuCunInfo _ChuangWeiKuCunInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("C_SN",_ChuangWeiKuCunInfo.C_SN),
                                     new SqlParameter("C_SuoShuBuMenSN",_ChuangWeiKuCunInfo.C_SuoShuBuMenSN),
                                     new SqlParameter("C_SuoShuXiTongSN",_ChuangWeiKuCunInfo.C_SuoShuXiTongSN),
                                     new SqlParameter("C_BingGuanSN",_ChuangWeiKuCunInfo.C_BingGuanSN),
                                     new SqlParameter("C_FangXingSN",_ChuangWeiKuCunInfo.C_FangXingSN),
                                     new SqlParameter("C_FangJianSN",_ChuangWeiKuCunInfo.C_FangJianSN),
                                     new SqlParameter("C_ChuangWeiHao",_ChuangWeiKuCunInfo.C_ChuangWeiHao),
                                     new SqlParameter("C_RuZhuStartDate",_ChuangWeiKuCunInfo.C_RuZhuStartDate),
                                     new SqlParameter("C_TuiFangEndDate",_ChuangWeiKuCunInfo.C_TuiFangEndDate),
                                     new SqlParameter("C_ChuangWei1JiaGe",_ChuangWeiKuCunInfo.C_ChuangWei1JiaGe),
                                     new SqlParameter("C_ChuangWei2JiaGe",_ChuangWeiKuCunInfo.C_ChuangWei2JiaGe),
                                     new SqlParameter("C_ChuangWei3JiaGe",_ChuangWeiKuCunInfo.C_ChuangWei3JiaGe),
                                     new SqlParameter("C_ChuangWei4JiaGe",_ChuangWeiKuCunInfo.C_ChuangWei4JiaGe),
                                     new SqlParameter("C_ChuangWei5JiaGe",_ChuangWeiKuCunInfo.C_ChuangWei5JiaGe),
                                     new SqlParameter("C_BaoLiuZhuangTai",_ChuangWeiKuCunInfo.C_BaoLiuZhuangTai),
                                     new SqlParameter("C_ShiFouShanChu",_ChuangWeiKuCunInfo.C_ShiFouShanChu),
                                     new SqlParameter("C_AddDate",_ChuangWeiKuCunInfo.C_AddDate),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "ChuangWeiKuCun_Set", parm);
            return true;
        }
        #endregion
    }

}
