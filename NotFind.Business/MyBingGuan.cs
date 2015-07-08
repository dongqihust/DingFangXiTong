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
    public class MyBingGuan
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Add(BingGuanInfo _BingGuanInfo)
        {
            return BingGuanData.Add(_BingGuanInfo);
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="_B_SN">SN</param>
        /// <returns></returns>
        public static Boolean Delete(Int32 _B_SN)
        {
            return BingGuanData.Delete(_B_SN);
        }
        #endregion

        #region 获取
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="_B_SN">SN</param>
        /// <returns></returns>
        public static BingGuanInfo Get(Int32 _B_SN)
        {
            return BingGuanData.Get(_B_SN);
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            return BingGuanData.List();
        }
        #endregion

        #region 设置
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Set(BingGuanInfo _BingGuanInfo)
        {
            return BingGuanData.Set(_BingGuanInfo);
        }
        #endregion
    }

}
