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
    /// �Զ���Sql���
    /// </summary>
    public class My_Sql
    {
        #region ִ��ָ��SQL 2
        /// <summary>
        /// ִ��ָ��SQL 2
        /// </summary>
        /// <param name="Sql">SQL���</param>
        /// <returns></returns>
        public static DataTable Sql2(String Sql)
        {
            return SqlData.Sql2(Sql);
        }
        #endregion

        #region ִ��ָ��SQL������Hashtable ����ҳ�� 2
        /// <summary>
        /// ִ��ָ��SQL������Hashtable ����ҳ�� 2
        /// </summary>
        /// <param name="TableName">����</param>
        /// <param name="SN">SN��</param>
        /// <param name="Field">Ҫ���ҵ��ֶΣ��ֶβ�����д *  ����һ�б��������ݿ��е�id���磺R_SN,R_Name</param>
        /// <param name="Order">����</param>
        /// <param name="Sql">Sql���</param>
        /// <param name="_RecordCount">��¼��</param>
        /// <param name="_PageIndex">ҳ��</param>
        /// <returns></returns>
        public static Hashtable Sql_FenYe2(String TableName, String SN, String Field, String Order, String Sql, Int32 _RecordCount, Int32 _PageIndex)
        {
            return SqlData.Sql_FenYe2(TableName, SN, Field, Order, Sql, _RecordCount, _PageIndex);
        }
        #endregion

        #region ִ��ָ��SQL������������ 2
        /// <summary>
        /// ִ��ָ��SQL������������ 2
        /// </summary>
        /// <param name="Sql">SQL���</param>
        /// <returns></returns>
        public static Int32 SqlCount2(String Sql)
        {
            return SqlData.SqlCount2(Sql);
        }
        #endregion

        #region ִ��ָ��SQL�����ؼ����Ľ���� 2
        /// <summary>
        /// ִ��ָ��SQL�����ؼ����Ľ���� 2
        /// </summary>
        /// <param name="Sql">SQL���</param>
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
