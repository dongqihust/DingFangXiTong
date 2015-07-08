//===============================================================================
// This file is based on the Microsoft Data Access Application Block for .NET
// For more information please go to 
// http://msdn.microsoft.com/library/en-us/dnbda/html/daab-rm.asp
//===============================================================================

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace NotFind.Data
{
    /// <summary>
    /// ��SqlHelper����Ϊ�˷�װ�ĸ����ܣ�����չ���������SqlClient�ĳ�����;��
    /// </summary>
    public static class SqlHelper
    {
        //���ݿ������ַ���5
        public static readonly string ConnectionString2 = "server=" + ConfigurationSettings.AppSettings["DBServer2"].ToString() + ";uid=" + ConfigurationSettings.AppSettings["DBUserName2"].ToString() + ";pwd=" + ConfigurationSettings.AppSettings["DBPassword2"].ToString() + ";database=" + ConfigurationSettings.AppSettings["DBName2"].ToString();




        // Hashtable���洢�������
        private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());


        /// <summary>
        /// ִ�д洢����
        /// </summary>
        /// <param name="connectionString">���ݿ������ַ���</param>
        /// <param name="cmdType">��������</param>
        /// <param name="cmdText">�洢��������</param>
        /// <param name="commandParameters">�洢�������еĲ���</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            int val = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Dispose();
                conn.Close();
            }
            return val;
        }


        /// <summary>
        /// ִ�д洢����
        /// </summary>
        /// <param name="connection">SqlConnection����</param>
        /// <param name="cmdType">��������</param>
        /// <param name="cmdText">�洢��������</param>
        /// <param name="commandParameters">�洢�������еĲ���</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(SqlConnection connection, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }


        /// <summary>
        /// ����DataSet���ݼ�
        /// </summary>
        /// <param name="connectionString">���ݿ������ַ���</param>
        /// <param name="cmdType">��������</param>
        /// <param name="cmdText">�洢��������</param>
        /// <param name="commandParameters">�洢�������еĲ���</param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
            
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
               
               
                cmd.Parameters.Clear();
                conn.Dispose();
                conn.Close();
            }
            return ds;
        }


        /// <summary>
        /// ����DataSet���ݼ�
        /// </summary>
        /// <param name="connection">SqlConnection����</param>
        /// <param name="cmdType">��������</param>
        /// <param name="cmdText">�洢��������</param>
        /// <param name="commandParameters">�洢�������еĲ���</param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(SqlConnection connection, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();

            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            cmd.Parameters.Clear();
            return ds;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="trans">SqlTransaction�������</param>
        /// <param name="cmdType">��������</param>
        /// <param name="cmdText">�洢��������</param>
        /// <param name="commandParameters">�洢�������еĲ���</param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(SqlTransaction trans, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.Fill(ds);
            cmd.Parameters.Clear();
            return ds;
        }


        /// <summary>
        /// ����DataSet���ݼ�
        /// </summary>
        /// <param name="connectionString">���ݿ������ַ���</param>
        /// <param name="cmdType">��������</param>
        /// <param name="cmdText">�洢��������</param>
        /// <param name="curPage">��ǰҳ</param>
        /// <param name="pageSize">ҳ�Ĵ�С</param>
        /// <param name="commandParameters">�洢�������еĲ���</param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string connectionString, CommandType cmdType, string cmdText, int curPage, int pageSize, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                if (curPage < 1)
                    curPage = 1;
                adp.Fill(ds, (curPage - 1) * pageSize, pageSize, "table0");
                cmd.Parameters.Clear();
                conn.Dispose();
                conn.Close();
            }
            return ds;
        }


        /// <summary>
        /// ����DataSet���ݼ�
        /// </summary>
        /// <param name="connection">SqlConnection����</param>
        /// <param name="cmdType">��������</param>
        /// <param name="cmdText">�洢��������</param>
        /// <param name="curPage">��ǰҳ</param>
        /// <param name="pageSize">ҳ�Ĵ�С</param>
        /// <param name="commandParameters">�洢�������еĲ���</param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(SqlConnection connection, CommandType cmdType, string cmdText, int curPage, int pageSize, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();

            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            if (curPage < 1)
                curPage = 1;
            adp.Fill(ds, (curPage - 1) * pageSize, pageSize, "table0");
            cmd.Parameters.Clear();
            return ds;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="trans">SqlTransaction�������</param>
        /// <param name="cmdType">��������</param>
        /// <param name="cmdText">�洢��������</param>
        /// <param name="curPage">��ǰҳ</param>
        /// <param name="pageSize">ҳ�Ĵ�С</param>
        /// <param name="commandParameters">�洢�������еĲ���</param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(SqlTransaction trans, CommandType cmdType, string cmdText, int curPage, int pageSize, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            if (curPage < 1)
                curPage = 1;
            adp.Fill(ds, (curPage - 1) * pageSize, pageSize, "table0");
            cmd.Parameters.Clear();
            return ds;
        }


        /// <summary>
        /// ִ��һ�䣨�����ؽ������ʹ�����е�SQL����
        /// </summary>
        /// <param name="trans">SqlTransaction�������</param>
        /// <param name="cmdType">��������</param>
        /// <param name="cmdText">�洢��������</param>
        /// <param name="commandParameters">�洢�������еĲ���</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(SqlTransaction trans, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }


        /// <summary>
        /// ��ȡ��ϸ��Ϣ
        /// </summary>
        /// <param name="connectionString">���ݿ������ַ���</param>
        /// <param name="cmdType">��������</param>
        /// <param name="cmdText">�洢��������</param>
        /// <param name="commandParameters">�洢�������еĲ���</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(connectionString);

            // we use a try/catch here because if the method throws an exception we want to 
            // close the connection throw code, because no datareader will exist, hence the 
            // commandBehaviour.CloseConnection will not work
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Dispose();
                conn.Close();
                throw;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString">���ݿ������ַ���</param>
        /// <param name="cmdType">��������</param>
        /// <param name="cmdText">�洢��������</param>
        /// <param name="commandParameters">�洢�������еĲ���</param>
        /// <returns>���ص�һ�С���һ��</returns>
        public static object ExecuteScalar(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            object val = new object();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
                val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                connection.Dispose();
                connection.Close();
            }
            return val;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection">SqlConnection����</param>
        /// <param name="cmdType">��������</param>
        /// <param name="cmdText">�洢��������</param>
        /// <param name="commandParameters">�洢�������еĲ���</param>
        /// <returns>���ص�һ�С���һ��</returns>
        public static object ExecuteScalar(SqlConnection connection, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();

            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            object val = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            return val;
        }


        /// <summary>
        /// ����������ӵ�������
        /// </summary>
        /// <param name="cacheKey">�ؼ���������</param>
        /// <param name="cmdParms">һ��SqlParamters���黺��</param>
        public static void CacheParameters(string cacheKey, params SqlParameter[] commandParameters)
        {
            parmCache[cacheKey] = commandParameters;
        }


        /// <summary>
        /// ��������Ĳ���
        /// </summary>
        /// <param name="cacheKey">��Ҫ���ڲ��Ҳ���</param>
        /// <returns>����SqlParamters����</returns>
        public static SqlParameter[] GetCachedParameters(string cacheKey)
        {
            SqlParameter[] cachedParms = (SqlParameter[])parmCache[cacheKey];

            if (cachedParms == null)
                return null;

            SqlParameter[] clonedParms = new SqlParameter[cachedParms.Length];

            for (int i = 0, j = cachedParms.Length; i < j; i++)
                clonedParms[i] = (SqlParameter)((ICloneable)cachedParms[i]).Clone();

            return clonedParms;
        }


        /// <summary>
        /// ׼��һ������ִ������
        /// </summary>
        /// <param name="cmd">SqlCommand ����</param>
        /// <param name="conn">SqlConnection ����</param>
        /// <param name="trans">SqlTransaction ����</param>
        /// <param name="cmdType">��������</param>
        /// <param name="cmdText">�洢��������</param>
        /// <param name="cmdParms">�洢�������еĲ���</param>
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;

            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

        public static void RunSQLCommand(string strSqlCommand)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString2))
            {
                SqlCommand objCommand = new SqlCommand(strSqlCommand, conn);
                conn.Open();
                objCommand.ExecuteNonQuery();
            }
        }
    }


        
       
        
}