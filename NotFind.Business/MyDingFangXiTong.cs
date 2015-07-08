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
    public class MyDingFangXiTong
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Add(DingFangXiTongInfo _DingFangXiTongInfo)
        {
            return DingFangXiTongData.Add(_DingFangXiTongInfo);
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
            return DingFangXiTongData.Delete(_D_SN);
        }
        #endregion

        #region 获取
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="_D_SN">SN</param>
        /// <returns></returns>
        public static DingFangXiTongInfo Get(Int32 _D_SN)
        {
            return DingFangXiTongData.Get(_D_SN);
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            return DingFangXiTongData.List();
        }
        #endregion

        #region 设置
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Set(DingFangXiTongInfo _DingFangXiTongInfo)
        {
            return DingFangXiTongData.Set(_DingFangXiTongInfo);
        }
        #endregion
    }

}
