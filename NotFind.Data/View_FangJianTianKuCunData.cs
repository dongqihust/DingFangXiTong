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
    public class View_FangJianTianKuCunData
    {
        
        #region 列表
        /// <summary>
        /// 
        /// </summary>
        public static DataTable List()
        {
            DataSet _DataSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "View_FangJianTianKuCun_List", null);
            return _DataSet.Tables[0];
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
        public static Hashtable List4Page(String _RuZhuStartDate, String _TuiFangEndDate, bool _ShiFouShanChu,Int32 _BaoLiuZhuangTai, Int32 _XiTongSN, Int32 _BingGuanSN, Int32 _FangXingSN, String _sql, Int32 _RecordCount, Int32 _PageIndex)
        {
            String Sql = "";
            //拼接系统SN
            if (_XiTongSN !=0)
            {
                Sql += " and F_SuoShuXiTongSN = " + _XiTongSN;
            }

            //拼接宾馆SN
            if (_BingGuanSN != 0)
            {
                Sql += " and F_BingGuanSN = " + _BingGuanSN;
            }
            //拼接房型SN
            if (_FangXingSN != 0)
            {
                Sql += " and F_FangXingSN = " + _FangXingSN;
            }

            //凭借是否删除
            if (_ShiFouShanChu)
            {
                Sql += " and F_ShiFouShanChu =" + 1;
            }
            else
            {
                Sql += " and F_ShiFouShanChu =" + 0;
            }


            //最早入住时间
            if (_RuZhuStartDate != "")
            {
                Sql += " and F_RuZhuStartDate <='" + _RuZhuStartDate + " 12:00:00'";
            }
            //最晚退房时间
            if (_TuiFangEndDate != "")
            {
                Sql += " and F_TuiFangEndDate >='" + _TuiFangEndDate+"'";
            }

             if (_BaoLiuZhuangTai != 0)
            {
                Sql += " and F_BaoLiuZhuangTai =" + _BaoLiuZhuangTai;
            }


            Sql += _sql;

            if (Sql.Length > 3)
            {
                Sql = Sql.Substring(4);//章节名称，去掉前面4个字符： and 
            }
            else
            {
                Sql = " F_SN >=1";
            }

            Hashtable resultmsg = new Hashtable();//创建返回的变量

            resultmsg.Add("RecordCountOfPage", _RecordCount);//向hashtable中插入每页显示的文章数

            int RecordCount = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.ConnectionString2, CommandType.Text, "select count(F_SN) from View_FangJianTianKuCun where " + Sql, null).ToString());//记录总数

            resultmsg.Add("RecordCount", RecordCount);//向hashtable中插入记录总数

            DataTable _DataTable = new DataTable();

            int m = RecordCount % _RecordCount;//计算出数据页数的余数

            int MyRecordCount = RecordCount / _RecordCount;//计算出数据所能要显示的页数

            if (m > 0)
            {
                MyRecordCount++;
            }

            resultmsg.Add("PageCount", MyRecordCount);//向hashtable中插入总页数

            if (_PageIndex == 0)
            {
                _PageIndex = 1;
            }
            int MyPageIndex = _PageIndex;

            if (MyPageIndex > MyRecordCount)
            {
                MyPageIndex = MyRecordCount;
                if (MyPageIndex < 1)
                {
                    MyPageIndex = 1;
                }
            }

            resultmsg.Add("PageIndex", MyPageIndex);//向hashtable中插入当前页数

            if (MyRecordCount == 0)
            {
                resultmsg.Add("PrePageIndex", 0);//向hashtable中插入上一页
                resultmsg.Add("NextPageIndex", 0);//向hashtable中插入下一页
            }
            else
            {
                if (MyPageIndex == 1)
                {
                    resultmsg.Add("PrePageIndex", 0);//向hashtable中插入上一页
                }
                else
                {
                    resultmsg.Add("PrePageIndex", MyPageIndex - 1);//向hashtable中插入上一页
                }

                if (MyPageIndex == MyRecordCount)
                {
                    resultmsg.Add("NextPageIndex", 0);//向hashtable中插入下一页
                }
                else
                {
                    resultmsg.Add("NextPageIndex", MyPageIndex + 1);//向hashtable中插入下一页
                }
            }


            SqlParameter[] parm = {
                                      new SqlParameter("TableName", "View_FangJianTianKuCun"), //表名、视图名
                                      new SqlParameter("FdShow", "F_BingGuanSN,B_Name,F_SuoShuXiTongSN,D_Name,F_FangXingSN,F_FangJianHao,F_Name,F_SN,F_SuoShuBuMenSN,F_FangJianSN,F_RuZhuStartDate,F_TuiFangEndDate,F_ZhengJianJiaGe,F_BaoLiuZhuangTai,F_ShiFouShanChu,F_AddDate"), //要显示的字段列表
                                      new SqlParameter("Critical", Sql), //条件语句
                                      new SqlParameter("FdOrder", "F_SN desc"), //排序字段列表
                                      new SqlParameter("PageSize", _RecordCount), //每页的大小(行数)
                                      new SqlParameter("PageCurrent", _PageIndex), //要显示的页
                                      new SqlParameter("SN", "F_SN"), //ID键名称，如R_SN
                                  };
            DataSet _DataSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "CutPage_Show", parm);

            resultmsg.Add("RecordList", _DataSet.Tables[0]);//向hashtable中插入记录列表

            return resultmsg;
        }
        #endregion

    }

}
