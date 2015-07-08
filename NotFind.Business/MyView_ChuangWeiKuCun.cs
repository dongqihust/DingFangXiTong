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
    public class MyView_ChuangWeiKuCun
    {
       

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            return View_ChuangWeiKuCunData.List();
        }
        #endregion
        #region 列表
        /// <summary>
        /// 分页列表
        /// </summary>
        /// <param name="_RuZhuStartDate">入住时间</param>
        /// <param name="_TuiFangEndDate">退房时间</param>
        /// <param name="_ShiFouShanChu">是否删除</param>
        /// <param name="_BaoLiuZhuangTai">保留状态</param>
        /// <param name="_XiTongSN">系统SN</param>
        /// <param name="_BingGuanSN">宾馆SN</param>
        /// <param name="_FangXingSN">房型SN</param>
        /// <param name="_sql">sql</param>
        /// <param name="_RecordCount">每页总数</param>
        /// <param name="_PageIndex">一共页数</param>
        /// <returns></returns>
        public static Hashtable List4Page(String _RuZhuStartDate, String _TuiFangEndDate, bool _ShiFouShanChu, Int32 _BaoLiuZhuangTai, Int32 _XiTongSN, Int32 _BingGuanSN, Int32 _FangXingSN, String _sql, Int32 _RecordCount, Int32 _PageIndex)
        {
            return View_ChuangWeiKuCunData.List4Page( _RuZhuStartDate,  _TuiFangEndDate,  _ShiFouShanChu,  _BaoLiuZhuangTai,  _XiTongSN,  _BingGuanSN,  _FangXingSN,  _sql,  _RecordCount,  _PageIndex);
        }
        #endregion
    }

}
