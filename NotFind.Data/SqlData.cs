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
    public class SqlData
    {
        #region 执行指定SQL 2
        /// <summary>
        /// 执行指定SQL 2
        /// </summary>
        /// <param name="Sql">SQL语句</param>
        /// <returns></returns>
        public static DataTable Sql2(String Sql)
        {
            DataSet _TempSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.Text, Sql, null);
            return _TempSet.Tables[0];
        }
        #endregion

        #region 执行指定SQL（返回Hashtable 、分页） 2
        /// <summary>
        /// 执行指定SQL（返回Hashtable 、分页） 2
        /// </summary>
        /// <param name="TableName">表名</param>
        /// <param name="SN">SN名</param>
        /// <param name="Field">要查找的字段，字段不可以写 *  ，第一列必须是数据库中的id，如：R_SN,R_Name</param>
        /// <param name="Order">排序</param>
        /// <param name="Sql">Sql语句</param>
        /// <param name="_RecordCount">记录数</param>
        /// <param name="_PageIndex">页码</param>
        /// <returns></returns>
        public static Hashtable Sql_FenYe2(String TableName, String SN, String Field, String Order, String Sql, Int32 _RecordCount, Int32 _PageIndex)
        {
            Hashtable resultmsg = new Hashtable();//创建返回的变量

            resultmsg.Add("RecordCountOfPage", _RecordCount);//向hashtable中插入每页显示的文章数

            int RecordCount = 0;
            if (Sql == "")
            {
                RecordCount = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.ConnectionString2, CommandType.Text, "select count(" + SN + ") from " + TableName, null).ToString());//记录总数
            }
            else
            {
                RecordCount = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.ConnectionString2, CommandType.Text, "select count(" + SN + ") from " + TableName + " where " + Sql, null).ToString());//记录总数
            }


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
                                      new SqlParameter("TableName", TableName), //表名、视图名
                                      new SqlParameter("FdShow", Field), //要显示的字段列表
                                      new SqlParameter("Critical", Sql), //条件语句
                                      new SqlParameter("FdOrder", Order.Replace("order by","")), //排序字段列表
                                      new SqlParameter("PageSize", _RecordCount), //每页的大小(行数)
                                      new SqlParameter("PageCurrent", _PageIndex), //要显示的页
                                      new SqlParameter("SN", SN), //ID键名称，如R_SN
                                  };
            DataSet _DataSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "CutPage_Show", parm);

            resultmsg.Add("RecordList", _DataSet.Tables[0]);//向hashtable中插入记录列表

            return resultmsg;
        }
        #endregion

        #region 执行指定SQL（返回数量） 2
        /// <summary>
        /// 执行指定SQL（返回数量） 2
        /// </summary>
        /// <param name="Sql">SQL语句</param>
        /// <returns></returns>
        public static Int32 SqlCount2(String Sql)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.ConnectionString2, CommandType.Text, Sql, null).ToString());//记录总数
        }
        #endregion

        #region 执行指定SQL（返回计算后的结果）2
        /// <summary>
        /// 执行指定SQL（返回计算后的结果） 2
        /// </summary>
        /// <param name="Sql">SQL语句</param>
        /// <returns></returns>
        public static Decimal SqlJiSuanJieGuo2(String Sql)
        {
            return Convert.ToDecimal(SqlHelper.ExecuteScalar(SqlHelper.ConnectionString2, CommandType.Text, Sql, null).ToString());//记录总数
        }
        #endregion



        public static void runSQLCommand(String SQL)
        {
            SqlHelper.RunSQLCommand(SQL);
        }
    }
}