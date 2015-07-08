using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using NotFind.Entity;
using NotFind.Data;
using System.Web;

namespace NotFind.Business
{
    public class MyFangJianTianKuCun
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Add(FangJianTianKuCunInfo _FangJianTianKuCunInfo)
        {
            return FangJianTianKuCunData.Add(_FangJianTianKuCunInfo);
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
            return FangJianTianKuCunData.Delete(_F_SN);
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
            return FangJianTianKuCunData.Get(_F_SN);
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            return FangJianTianKuCunData.List();
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
            return FangJianTianKuCunData.Set(_FangJianTianKuCunInfo);
        }
        #endregion
    }

}
