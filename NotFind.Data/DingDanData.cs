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
    public class DingDanData
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Add(DingDanInfo _DingDanInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("D_SuoShuBuMenSN",_DingDanInfo.D_SuoShuBuMenSN),
                                     new SqlParameter("D_SuoShuXiTongSN",_DingDanInfo.D_SuoShuXiTongSN),
                                     new SqlParameter("D_TiJiaoRenName",_DingDanInfo.D_TiJiaoRenName),
                                     new SqlParameter("D_TiJiaoRenSN",_DingDanInfo.D_TiJiaoRenSN),
                                     new SqlParameter("D_TiJiaoSuoShuBanJiSN",_DingDanInfo.D_TiJiaoSuoShuBanJiSN),
                                     new SqlParameter("D_TiJiaoRenKaoShiHao",_DingDanInfo.D_TiJiaoRenKaoShiHao),
                                     new SqlParameter("D_AddDate",_DingDanInfo.D_AddDate),
                                     new SqlParameter("D_AddIP",_DingDanInfo.D_AddIP),
                                     new SqlParameter("D_LianXiRen",_DingDanInfo.D_LianXiRen),
                                     new SqlParameter("D_LianXiPhone",_DingDanInfo.D_LianXiPhone),
                                     new SqlParameter("D_LianXiMail",_DingDanInfo.D_LianXiMail),
                                     new SqlParameter("D_Style",_DingDanInfo.D_Style),
                                     new SqlParameter("D_JiaGe",_DingDanInfo.D_JiaGe),
                                     new SqlParameter("D_ZhuangTai",_DingDanInfo.D_ZhuangTai),
                                     new SqlParameter("D_ShiFouShanChu",_DingDanInfo.D_ShiFouShanChu),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingDan_Add", parm);
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
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingDan_Delete", parm);
            return true;
        }
        #endregion

        #region 获取
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="_D_SN">SN</param>
        /// <returns></returns>
        public static DingDanInfo Get(Int32 _D_SN)
        {
            DingDanInfo _DingDanInfo = new DingDanInfo();
            SqlParameter[] parm = { new SqlParameter("D_SN", _D_SN), };
            using (SqlDataReader _SDR = SqlHelper.ExecuteReader(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingDan_Get", parm))
            {
                if (_SDR.Read())
                {
                    _DingDanInfo.D_SN = Convert.ToInt32(_SDR["D_SN"]);
                    _DingDanInfo.D_SuoShuBuMenSN = Convert.ToInt32(_SDR["D_SuoShuBuMenSN"]);
                    _DingDanInfo.D_SuoShuXiTongSN = Convert.ToInt32(_SDR["D_SuoShuXiTongSN"]);
                    _DingDanInfo.D_TiJiaoRenName = Convert.ToString(_SDR["D_TiJiaoRenName"]);
                    _DingDanInfo.D_TiJiaoRenSN = Convert.ToInt32(_SDR["D_TiJiaoRenSN"]);
                    _DingDanInfo.D_TiJiaoSuoShuBanJiSN = Convert.ToInt32(_SDR["D_TiJiaoSuoShuBanJiSN"]);
                    _DingDanInfo.D_TiJiaoRenKaoShiHao = Convert.ToString(_SDR["D_TiJiaoRenKaoShiHao"]);
                    _DingDanInfo.D_AddDate = Convert.ToDateTime(_SDR["D_AddDate"]);
                    _DingDanInfo.D_AddIP = Convert.ToString(_SDR["D_AddIP"]);
                    _DingDanInfo.D_LianXiRen = Convert.ToString(_SDR["D_LianXiRen"]);
                    _DingDanInfo.D_LianXiPhone = Convert.ToString(_SDR["D_LianXiPhone"]);
                    _DingDanInfo.D_LianXiMail = Convert.ToString(_SDR["D_LianXiMail"]);
                    _DingDanInfo.D_Style = Convert.ToInt32(_SDR["D_Style"]);
                    _DingDanInfo.D_JiaGe = Convert.ToDouble(_SDR["D_JiaGe"]);
                    _DingDanInfo.D_ZhuangTai = Convert.ToInt32(_SDR["D_ZhuangTai"]);
                    _DingDanInfo.D_ShiFouShanChu = Convert.ToBoolean(_SDR["D_ShiFouShanChu"]);
                }
                _SDR.Close();
                _SDR.Dispose();
            }
            return _DingDanInfo;
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            DataSet _DataSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingDan_List", null);
            return _DataSet.Tables[0];
        }
        #endregion

        #region 设置
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Set(DingDanInfo _DingDanInfo)
        {
            SqlParameter[] parm ={
                                     new SqlParameter("D_SN",_DingDanInfo.D_SN),
                                     new SqlParameter("D_SuoShuBuMenSN",_DingDanInfo.D_SuoShuBuMenSN),
                                     new SqlParameter("D_SuoShuXiTongSN",_DingDanInfo.D_SuoShuXiTongSN),
                                     new SqlParameter("D_TiJiaoRenName",_DingDanInfo.D_TiJiaoRenName),
                                     new SqlParameter("D_TiJiaoRenSN",_DingDanInfo.D_TiJiaoRenSN),
                                     new SqlParameter("D_TiJiaoSuoShuBanJiSN",_DingDanInfo.D_TiJiaoSuoShuBanJiSN),
                                     new SqlParameter("D_TiJiaoRenKaoShiHao",_DingDanInfo.D_TiJiaoRenKaoShiHao),
                                     new SqlParameter("D_AddDate",_DingDanInfo.D_AddDate),
                                     new SqlParameter("D_AddIP",_DingDanInfo.D_AddIP),
                                     new SqlParameter("D_LianXiRen",_DingDanInfo.D_LianXiRen),
                                     new SqlParameter("D_LianXiPhone",_DingDanInfo.D_LianXiPhone),
                                     new SqlParameter("D_LianXiMail",_DingDanInfo.D_LianXiMail),
                                     new SqlParameter("D_Style",_DingDanInfo.D_Style),
                                     new SqlParameter("D_JiaGe",_DingDanInfo.D_JiaGe),
                                     new SqlParameter("D_ZhuangTai",_DingDanInfo.D_ZhuangTai),
                                     new SqlParameter("D_ShiFouShanChu",_DingDanInfo.D_ShiFouShanChu),
                                  };
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "DingDan_Set", parm);
            return true;
        }
        #endregion
    }

}
