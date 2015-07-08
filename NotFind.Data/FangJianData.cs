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
    public class FangJianData
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Add(FangJianInfo _FangJianInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("F_SuoShuFangXingSN",_FangJianInfo.F_SuoShuFangXingSN),
                                     new SqlParameter("F_FangJianHao",_FangJianInfo.F_FangJianHao),
                                     new SqlParameter("F_ZhengJianJiaGe",_FangJianInfo.F_ZhengJianJiaGe),
                                     new SqlParameter("F_ChuangWei1JiaGe",_FangJianInfo.F_ChuangWei1JiaGe),
                                     new SqlParameter("F_ChuangWei2JiaGe",_FangJianInfo.F_ChuangWei2JiaGe),
                                     new SqlParameter("F_ChuangWei3JiaGe",_FangJianInfo.F_ChuangWei3JiaGe),
                                     new SqlParameter("F_ChuangWei4JiaGe",_FangJianInfo.F_ChuangWei4JiaGe),
                                     new SqlParameter("F_ChuangWei5JiaGe",_FangJianInfo.F_ChuangWei5JiaGe),
                                     new SqlParameter("F_Detail",_FangJianInfo.F_Detail),
                                     new SqlParameter("F_AddDate",_FangJianInfo.F_AddDate),
                                     new SqlParameter("F_ShiFouShanChu",_FangJianInfo.F_ShiFouShanChu),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "FangJian_Add", parm);
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
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "FangJian_Delete", parm);
            return true;
        }
        #endregion

        #region 获取
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="_F_SN">SN</param>
        /// <returns></returns>
        public static FangJianInfo Get(Int32 _F_SN)
        {
            FangJianInfo _FangJianInfo = new FangJianInfo();
            SqlParameter[] parm = { new SqlParameter("F_SN", _F_SN), };
            using (SqlDataReader _SDR = SqlHelper.ExecuteReader(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "FangJian_Get", parm))
            {
                if (_SDR.Read())
                {
                    _FangJianInfo.F_SN = Convert.ToInt32(_SDR["F_SN"]);
                    _FangJianInfo.F_SuoShuFangXingSN = Convert.ToInt32(_SDR["F_SuoShuFangXingSN"]);
                    _FangJianInfo.F_FangJianHao = Convert.ToString(_SDR["F_FangJianHao"]);
                    _FangJianInfo.F_ZhengJianJiaGe = Convert.ToDouble(_SDR["F_ZhengJianJiaGe"]);
                    _FangJianInfo.F_ChuangWei1JiaGe = Convert.ToDouble(_SDR["F_ChuangWei1JiaGe"]);
                    _FangJianInfo.F_ChuangWei2JiaGe = Convert.ToDouble(_SDR["F_ChuangWei2JiaGe"]);
                    _FangJianInfo.F_ChuangWei3JiaGe = Convert.ToDouble(_SDR["F_ChuangWei3JiaGe"]);
                    _FangJianInfo.F_ChuangWei4JiaGe = Convert.ToDouble(_SDR["F_ChuangWei4JiaGe"]);
                    _FangJianInfo.F_ChuangWei5JiaGe = Convert.ToDouble(_SDR["F_ChuangWei5JiaGe"]);
                    _FangJianInfo.F_Detail = Convert.ToString(_SDR["F_Detail"]);
                    _FangJianInfo.F_AddDate = Convert.ToDateTime(_SDR["F_AddDate"]);
                    _FangJianInfo.F_ShiFouShanChu = Convert.ToBoolean(_SDR["F_ShiFouShanChu"]);
                }
                _SDR.Close();
                _SDR.Dispose();
            }
            return _FangJianInfo;
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            DataSet _DataSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "FangJian_List", null);
            return _DataSet.Tables[0];
        }
        #endregion

        #region 设置
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Set(FangJianInfo _FangJianInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("F_SN",_FangJianInfo.F_SN),
                                     new SqlParameter("F_SuoShuFangXingSN",_FangJianInfo.F_SuoShuFangXingSN),
                                     new SqlParameter("F_FangJianHao",_FangJianInfo.F_FangJianHao),
                                     new SqlParameter("F_ZhengJianJiaGe",_FangJianInfo.F_ZhengJianJiaGe),
                                     new SqlParameter("F_ChuangWei1JiaGe",_FangJianInfo.F_ChuangWei1JiaGe),
                                     new SqlParameter("F_ChuangWei2JiaGe",_FangJianInfo.F_ChuangWei2JiaGe),
                                     new SqlParameter("F_ChuangWei3JiaGe",_FangJianInfo.F_ChuangWei3JiaGe),
                                     new SqlParameter("F_ChuangWei4JiaGe",_FangJianInfo.F_ChuangWei4JiaGe),
                                     new SqlParameter("F_ChuangWei5JiaGe",_FangJianInfo.F_ChuangWei5JiaGe),
                                     new SqlParameter("F_Detail",_FangJianInfo.F_Detail),
                                     new SqlParameter("F_AddDate",_FangJianInfo.F_AddDate),
                                     new SqlParameter("F_ShiFouShanChu",_FangJianInfo.F_ShiFouShanChu),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "FangJian_Set", parm);
            return true;
        }
        #endregion
    }

}
