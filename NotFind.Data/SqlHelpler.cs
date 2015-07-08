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
    /// 在SqlHelper类是为了封装的高性能，可扩展的最佳做法SqlClient的常见用途。
    /// </summary>
    public static class SqlHelper
    {
        //数据库连接字符串5
        public static readonly string ConnectionString2 = "server=" + ConfigurationSettings.AppSettings["DBServer2"].ToString() + ";uid=" + ConfigurationSettings.AppSettings["DBUserName2"].ToString() + ";pwd=" + ConfigurationSettings.AppSettings["DBPassword2"].ToString() + ";database=" + ConfigurationSettings.AppSettings["DBName2"].ToString();




        // Hashtable来存储缓存参数
        private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());


        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="commandParameters">存储过程所有的参数</param>
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
        /// 执行存储过程
        /// </summary>
        /// <param name="connection">SqlConnection对像</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="commandParameters">存储过程所有的参数</param>
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
        /// 返回DataSet数据集
        /// </summary>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="commandParameters">存储过程所有的参数</param>
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
        /// 返回DataSet数据集
        /// </summary>
        /// <param name="connection">SqlConnection对像</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="commandParameters">存储过程所有的参数</param>
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
        /// <param name="trans">SqlTransaction事务对像</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="commandParameters">存储过程所有的参数</param>
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
        /// 返回DataSet数据集
        /// </summary>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="curPage">当前页</param>
        /// <param name="pageSize">页的大小</param>
        /// <param name="commandParameters">存储过程所有的参数</param>
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
        /// 返回DataSet数据集
        /// </summary>
        /// <param name="connection">SqlConnection对像</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="curPage">当前页</param>
        /// <param name="pageSize">页的大小</param>
        /// <param name="commandParameters">存储过程所有的参数</param>
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
        /// <param name="trans">SqlTransaction事务对像</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="curPage">当前页</param>
        /// <param name="pageSize">页的大小</param>
        /// <param name="commandParameters">存储过程所有的参数</param>
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
        /// 执行一句（不返回结果集）使用现有的SQL事务
        /// </summary>
        /// <param name="trans">SqlTransaction事务对像</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="commandParameters">存储过程所有的参数</param>
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
        /// 获取详细信息
        /// </summary>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="commandParameters">存储过程所有的参数</param>
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
        /// <param name="connectionString">数据库连接字符串</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="commandParameters">存储过程所有的参数</param>
        /// <returns>返回第一行、第一列</returns>
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
        /// <param name="connection">SqlConnection对像</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="commandParameters">存储过程所有的参数</param>
        /// <returns>返回第一行、第一列</returns>
        public static object ExecuteScalar(SqlConnection connection, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();

            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            object val = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            return val;
        }


        /// <summary>
        /// 参数数组添加到缓存中
        /// </summary>
        /// <param name="cacheKey">关键参数缓存</param>
        /// <param name="cmdParms">一个SqlParamters数组缓存</param>
        public static void CacheParameters(string cacheKey, params SqlParameter[] commandParameters)
        {
            parmCache[cacheKey] = commandParameters;
        }


        /// <summary>
        /// 检索缓存的参数
        /// </summary>
        /// <param name="cacheKey">主要用于查找参数</param>
        /// <returns>缓存SqlParamters阵列</returns>
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
        /// 准备一个用于执行命令
        /// </summary>
        /// <param name="cmd">SqlCommand 对象</param>
        /// <param name="conn">SqlConnection 对象</param>
        /// <param name="trans">SqlTransaction 对象</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="cmdParms">存储过程所有的参数</param>
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