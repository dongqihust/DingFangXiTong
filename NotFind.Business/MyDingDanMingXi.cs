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
    public class MyDingDanMingXi
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Int32 Add(DingDanMingXiInfo _DingDanMingXiInfo)
        {
            return DingDanMingXiData.Add(_DingDanMingXiInfo);
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
            return DingDanMingXiData.Delete(_D_SN);
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
            return DingDanMingXiData.Get(_D_SN);
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            return DingDanMingXiData.List();
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
            return DingDanMingXiData.Set(_DingDanMingXiInfo);
        }
        #endregion
    }

}
