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
        #region ִ��ָ��SQL 2
        /// <summary>
        /// ִ��ָ��SQL 2
        /// </summary>
        /// <param name="Sql">SQL���</param>
        /// <returns></returns>
        public static DataTable Sql2(String Sql)
        {
            DataSet _TempSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.Text, Sql, null);
            return _TempSet.Tables[0];
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
            Hashtable resultmsg = new Hashtable();//�������صı���

            resultmsg.Add("RecordCountOfPage", _RecordCount);//��hashtable�в���ÿҳ��ʾ��������

            int RecordCount = 0;
            if (Sql == "")
            {
                RecordCount = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.ConnectionString2, CommandType.Text, "select count(" + SN + ") from " + TableName, null).ToString());//��¼����
            }
            else
            {
                RecordCount = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.ConnectionString2, CommandType.Text, "select count(" + SN + ") from " + TableName + " where " + Sql, null).ToString());//��¼����
            }


            resultmsg.Add("RecordCount", RecordCount);//��hashtable�в����¼����

            DataTable _DataTable = new DataTable();

            int m = RecordCount % _RecordCount;//���������ҳ��������

            int MyRecordCount = RecordCount / _RecordCount;//�������������Ҫ��ʾ��ҳ��

            if (m > 0)
            {
                MyRecordCount++;
            }

            resultmsg.Add("PageCount", MyRecordCount);//��hashtable�в�����ҳ��

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

            resultmsg.Add("PageIndex", MyPageIndex);//��hashtable�в��뵱ǰҳ��

            if (MyRecordCount == 0)
            {
                resultmsg.Add("PrePageIndex", 0);//��hashtable�в�����һҳ
                resultmsg.Add("NextPageIndex", 0);//��hashtable�в�����һҳ
            }
            else
            {
                if (MyPageIndex == 1)
                {
                    resultmsg.Add("PrePageIndex", 0);//��hashtable�в�����һҳ
                }
                else
                {
                    resultmsg.Add("PrePageIndex", MyPageIndex - 1);//��hashtable�в�����һҳ
                }

                if (MyPageIndex == MyRecordCount)
                {
                    resultmsg.Add("NextPageIndex", 0);//��hashtable�в�����һҳ
                }
                else
                {
                    resultmsg.Add("NextPageIndex", MyPageIndex + 1);//��hashtable�в�����һҳ
                }
            }


            SqlParameter[] parm = {
                                      new SqlParameter("TableName", TableName), //��������ͼ��
                                      new SqlParameter("FdShow", Field), //Ҫ��ʾ���ֶ��б�
                                      new SqlParameter("Critical", Sql), //�������
                                      new SqlParameter("FdOrder", Order.Replace("order by","")), //�����ֶ��б�
                                      new SqlParameter("PageSize", _RecordCount), //ÿҳ�Ĵ�С(����)
                                      new SqlParameter("PageCurrent", _PageIndex), //Ҫ��ʾ��ҳ
                                      new SqlParameter("SN", SN), //ID�����ƣ���R_SN
                                  };
            DataSet _DataSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.StoredProcedure, "CutPage_Show", parm);

            resultmsg.Add("RecordList", _DataSet.Tables[0]);//��hashtable�в����¼�б�

            return resultmsg;
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
            return Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.ConnectionString2, CommandType.Text, Sql, null).ToString());//��¼����
        }
        #endregion

        #region ִ��ָ��SQL�����ؼ����Ľ����2
        /// <summary>
        /// ִ��ָ��SQL�����ؼ����Ľ���� 2
        /// </summary>
        /// <param name="Sql">SQL���</param>
        /// <returns></returns>
        public static Decimal SqlJiSuanJieGuo2(String Sql)
        {
            return Convert.ToDecimal(SqlHelper.ExecuteScalar(SqlHelper.ConnectionString2, CommandType.Text, Sql, null).ToString());//��¼����
        }
        #endregion



        public static void runSQLCommand(String SQL)
        {
            SqlHelper.RunSQLCommand(SQL);
        }
    }
}