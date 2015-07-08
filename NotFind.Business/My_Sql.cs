using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using NotFind.Entity;
using System.Collections;
using NotFind.Data;
using System.Web;

namespace NotFind.Business
{
    /// <summary>
    /// 自定义Sql语句
    /// </summary>
    public class My_Sql
    {
        #region 执行指定SQL 2
        /// <summary>
        /// 执行指定SQL 2
        /// </summary>
        /// <param name="Sql">SQL语句</param>
        /// <returns></returns>
        public static DataTable Sql2(String Sql)
        {
            return SqlData.Sql2(Sql);
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
            return SqlData.Sql_FenYe2(TableName, SN, Field, Order, Sql, _RecordCount, _PageIndex);
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
            return SqlData.SqlCount2(Sql);
        }
        #endregion

        #region 执行指定SQL（返回计算后的结果） 2
        /// <summary>
        /// 执行指定SQL（返回计算后的结果） 2
        /// </summary>
        /// <param name="Sql">SQL语句</param>
        /// <returns></returns>
        public static Decimal SqlJiSuanJieGuo2(String Sql)
        {
            return SqlData.SqlJiSuanJieGuo2(Sql);
        }
        #endregion

        public static void runSQL(String SQL)
        {
            SqlData.runSQLCommand(SQL); 
        }

       
    }
}
