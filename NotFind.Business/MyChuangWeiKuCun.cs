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
    public class MyChuangWeiKuCun
    {
        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_UserInfo">实体类</param>
        /// <returns></returns>
        public static Boolean Add(ChuangWeiKuCunInfo _ChuangWeiKuCunInfo)
        {
            return ChuangWeiKuCunData.Add(_ChuangWeiKuCunInfo);
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
            return ChuangWeiKuCunData.Delete(_C_SN);
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
            return ChuangWeiKuCunData.Get(_C_SN);
        }
        #endregion

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            return ChuangWeiKuCunData.List();
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
            return ChuangWeiKuCunData.Set(_ChuangWeiKuCunInfo);
        }
        #endregion
    }

}
