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
    public class MyView_FangJianTianKuCun
    {
     

        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            return View_FangJianTianKuCunData.List();
        }
        #endregion


           #region 列表
     /// <summary>
     /// 分页获取房间天数据
     /// </summary>
     /// <param name="_RuZhuStartDate"></param>
     /// <param name="_TuiFangEndDate"></param>
     /// <param name="_ShiFouShanChu"></param>
     /// <param name="_BaoLiuZhuangTai"></param>
     /// <param name="_XiTongSN"></param>
     /// <param name="_BingGuanSN"></param>
     /// <param name="_FangXingSN"></param>
     /// <param name="_sql"></param>
     /// <param name="_RecordCount"></param>
     /// <param name="_PageIndex"></param>
     /// <returns></returns>
        public static Hashtable List4Page(String _RuZhuStartDate, String _TuiFangEndDate, bool _ShiFouShanChu, Int32 _BaoLiuZhuangTai, Int32 _XiTongSN, Int32 _BingGuanSN, Int32 _FangXingSN, String _sql, Int32 _RecordCount, Int32 _PageIndex)
        {
            return View_FangJianTianKuCunData.List4Page(_RuZhuStartDate, _TuiFangEndDate, _ShiFouShanChu, _BaoLiuZhuangTai, _XiTongSN, _BingGuanSN, _FangXingSN, _sql, _RecordCount, _PageIndex);
        }
           #endregion

        public static Hashtable List4Page()
        {
            throw new NotImplementedException();
        }
    }

}
