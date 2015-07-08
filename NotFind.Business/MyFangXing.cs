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
    public class MyFangXing
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Add(FangXingInfo _FangXingInfo)
        {
            return FangXingData.Add(_FangXingInfo);
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
            return FangXingData.Delete(_F_SN);
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
            return FangXingData.Get(_F_SN);
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            return FangXingData.List();
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
            return FangXingData.Set(_FangXingInfo);
        }
        #endregion

       

      
    }

}
