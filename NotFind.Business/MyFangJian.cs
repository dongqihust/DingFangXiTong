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
    public class MyFangJian
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Add(FangJianInfo _FangJianInfo)
        {
            return FangJianData.Add(_FangJianInfo);
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
            return FangJianData.Delete(_F_SN);
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
            return FangJianData.Get(_F_SN);
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            return FangJianData.List();
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
            return FangJianData.Set(_FangJianInfo);
        }
        #endregion
    }

}
