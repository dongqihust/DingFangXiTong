using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using NotFind.Business;
using System.Text;

public partial class _Temp_var : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DB_Submit_Click(object sender, EventArgs e)
    {
        StringBuilder result = new StringBuilder();
        String TableName = this.DB_TableName.Text;
        DataTable TableList = MethodLibrary.ExecuteDIYSql("select top 0 * from " + TableName);
        String title = this.Entity_Title.Text + "Info";
        result.Append("public class " + title + "\n");
        result.Append("{\n");
        for (int k = 0; k < TableList.Columns.Count; k++)
        {
            result.Append("private " + TableList.Columns[k].DataType.ToString().Replace("System.", "") + " _" + TableList.Columns[k].ColumnName + " " + TableList.Columns[k].DataType.ToString().Replace("System.", "").Replace("Int32", "= 0").Replace("Decimal", "= 0").Replace("Boolean", "= false").Replace("String", "= \"\"").Replace("DateTime", "= DateTime.Now") + ";//\n");
        }
        result.Append("\npublic " + title + "()\n");
        result.Append("{\n");
        for (int k = 0; k < TableList.Columns.Count; k++)
        {
            result.Append("this._" + TableList.Columns[k].ColumnName + " = " + TableList.Columns[k].ColumnName + ";\n");
        }
        result.Append("}\n");
        for (int k = 0; k < TableList.Columns.Count; k++)
        {
            result.Append("/// <summary>\n");
            result.Append("/// \n");
            result.Append("/// </summary>\n");
            result.Append("public " + TableList.Columns[k].DataType.ToString().Replace("System.", "") + " " + TableList.Columns[k].ColumnName + "\n");
            result.Append("{\n");
            result.Append("get { return this._" + TableList.Columns[k].ColumnName + "; }\n");
            result.Append("set { this._" + TableList.Columns[k].ColumnName + " = value; }\n");
            result.Append("}\n");
        }
        result.Append("}\n");

        this.Entity_Result.Text = result.ToString();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        StringBuilder result = new StringBuilder();
        String TableName = this.DB_TableName.Text;
        DataTable TableList = MethodLibrary.ExecuteDIYSql("select column_name,data_type,character_maximum_length from information_schema.columns where table_name = '" + TableName + "'");

        #region 添加
        result.Append("/*\n");
        result.Append("*Name: [" + TableName + "_Add]\n");
        result.Append("*Description: 添加\n");
        result.Append("*Author: C#\n");
        result.Append("*/\n");
        result.Append("IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[" + TableName + "_Add]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)\n");
        result.Append("DROP PROCEDURE [" + TableName + "_Add]\n");
        result.Append("GO\n");
        result.Append("CREATE procedure [" + TableName + "_Add]\n");
        for (int k = 1; k < TableList.Rows.Count; k++)
        {
            if (k + 1 == TableList.Rows.Count)
            {
                if (TableList.Rows[k]["character_maximum_length"].ToString() == "")
                {
                    result.Append("@" + TableList.Rows[k]["column_name"].ToString() + " " + TableList.Rows[k]["data_type"].ToString() + "\n");
                }
                else if (TableList.Rows[k]["character_maximum_length"].ToString() == "1073741823")
                {
                    result.Append("@" + TableList.Rows[k]["column_name"].ToString() + " " + TableList.Rows[k]["data_type"].ToString() + "\n");
                }
                else
                {
                    result.Append("@" + TableList.Rows[k]["column_name"].ToString() + " " + TableList.Rows[k]["data_type"].ToString() + "(" + TableList.Rows[k]["character_maximum_length"].ToString() + ")\n");
                }
            }
            else
            {
                if (TableList.Rows[k]["character_maximum_length"].ToString() == "")
                {
                    result.Append("@" + TableList.Rows[k]["column_name"].ToString() + " " + TableList.Rows[k]["data_type"].ToString() + ",\n");
                }
                else if (TableList.Rows[k]["character_maximum_length"].ToString() == "1073741823")
                {
                    result.Append("@" + TableList.Rows[k]["column_name"].ToString() + " " + TableList.Rows[k]["data_type"].ToString() + ",\n");
                }
                else
                {
                    result.Append("@" + TableList.Rows[k]["column_name"].ToString() + " " + TableList.Rows[k]["data_type"].ToString() + "(" + TableList.Rows[k]["character_maximum_length"].ToString() + "),\n");
                }
            }
        }
        result.Append("AS\n");
        result.Append("Insert into " + TableName + "\n");
        result.Append("(\n");
        for (int k = 1; k < TableList.Rows.Count; k++)
        {
            if (k + 1 == TableList.Rows.Count)
            {
                result.Append(TableList.Rows[k]["column_name"].ToString() + "\n");
            }
            else
            {
                result.Append(TableList.Rows[k]["Column_Name"].ToString() + ",\n");
            }
        }
        result.Append(")\n");
        result.Append("Values\n");
        result.Append("(\n");
        for (int k = 1; k < TableList.Rows.Count; k++)
        {
            if (k + 1 == TableList.Rows.Count)
            {
                result.Append("@" + TableList.Rows[k]["Column_Name"].ToString() + "\n");
            }
            else
            {
                result.Append("@" + TableList.Rows[k]["Column_Name"].ToString() + ",\n");
            }
        }
        result.Append(")\n");
        result.Append("\n");
        result.Append("\n");
        result.Append("\n");
        result.Append("\n");
        #endregion

        #region 删除
        result.Append("/*\n");
        result.Append("*Name: [" + TableName + "_Delete]\n");
        result.Append("*Description: 删除\n");
        result.Append("*Author: C#\n");
        result.Append("*/\n");
        result.Append("IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[" + TableName + "_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)\n");
        result.Append("DROP PROCEDURE [" + TableName + "_Delete]\n");
        result.Append("GO\n");
        result.Append("CREATE procedure [" + TableName + "_Delete]\n");
        result.Append("@" + TableList.Rows[0]["Column_Name"].ToString() + " " + TableList.Rows[0]["data_type"].ToString() + "\n");
        result.Append("AS\n");
        result.Append("Delete from " + TableName + " where " + TableList.Rows[0]["Column_Name"].ToString() + "=@" + TableList.Rows[0]["Column_Name"].ToString() + "\n");
        result.Append("\n");
        result.Append("\n");
        result.Append("\n");
        result.Append("\n");
        #endregion

        #region 获取
        result.Append("/*\n");
        result.Append("*Name: [" + TableName + "_Get]\n");
        result.Append("*Description: 获取\n");
        result.Append("*Author: C#\n");
        result.Append("*/\n");
        result.Append("IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[" + TableName + "_Get]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)\n");
        result.Append("DROP PROCEDURE [" + TableName + "_Get]\n");
        result.Append("GO\n");
        result.Append("CREATE procedure [" + TableName + "_Get]\n");
        result.Append("@" + TableList.Rows[0]["Column_Name"].ToString() + " " + TableList.Rows[0]["data_type"].ToString() + "\n");
        result.Append("AS\n");
        result.Append("select top 1 * from " + TableName + " where " + TableList.Rows[0]["Column_Name"].ToString() + "=@" + TableList.Rows[0]["Column_Name"].ToString() + "\n");
        result.Append("\n");
        result.Append("\n");
        result.Append("\n");
        result.Append("\n");
        #endregion

        #region 列表
        result.Append("/*\n");
        result.Append("*Name: [" + TableName + "_List]\n");
        result.Append("*Description: 列表\n");
        result.Append("*Author: C#\n");
        result.Append("*/\n");
        result.Append("IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[" + TableName + "_List]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)\n");
        result.Append("DROP PROCEDURE [" + TableName + "_List]\n");
        result.Append("GO\n");
        result.Append("CREATE procedure [" + TableName + "_List]\n");
        result.Append("AS\n");
        result.Append("select * from " + TableName + "\n");
        result.Append("\n");
        result.Append("\n");
        result.Append("\n");
        result.Append("\n");
        #endregion

        #region 设置
        result.Append("/*\n");
        result.Append("*Name: [" + TableName + "_Set]\n");
        result.Append("*Description: 设置\n");
        result.Append("*Author: C#\n");
        result.Append("*/\n");
        result.Append("IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[" + TableName + "_Set]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)\n");
        result.Append("DROP PROCEDURE [" + TableName + "_Set]\n");
        result.Append("GO\n");
        result.Append("CREATE procedure [" + TableName + "_Set]\n");
        for (int k = 0; k < TableList.Rows.Count; k++)
        {
            if (k + 1 == TableList.Rows.Count)
            {
                if (TableList.Rows[k]["character_maximum_length"].ToString() == "")
                {
                    result.Append("@" + TableList.Rows[k]["column_name"].ToString() + " " + TableList.Rows[k]["data_type"].ToString() + "\n");
                }
                else if (TableList.Rows[k]["character_maximum_length"].ToString() == "1073741823")
                {
                    result.Append("@" + TableList.Rows[k]["column_name"].ToString() + " " + TableList.Rows[k]["data_type"].ToString() + "\n");
                }
                else
                {
                    result.Append("@" + TableList.Rows[k]["column_name"].ToString() + " " + TableList.Rows[k]["data_type"].ToString() + "(" + TableList.Rows[k]["character_maximum_length"].ToString() + ")\n");
                }
            }
            else
            {
                if (TableList.Rows[k]["character_maximum_length"].ToString() == "")
                {
                    result.Append("@" + TableList.Rows[k]["column_name"].ToString() + " " + TableList.Rows[k]["data_type"].ToString() + ",\n");
                }
                else if (TableList.Rows[k]["character_maximum_length"].ToString() == "1073741823")
                {
                    result.Append("@" + TableList.Rows[k]["column_name"].ToString() + " " + TableList.Rows[k]["data_type"].ToString() + ",\n");
                }
                else
                {
                    result.Append("@" + TableList.Rows[k]["column_name"].ToString() + " " + TableList.Rows[k]["data_type"].ToString() + "(" + TableList.Rows[k]["character_maximum_length"].ToString() + "),\n");
                }
            }
        }
        result.Append("AS\n");
        result.Append("update " + TableName + " Set\n");
        for (int k = 1; k < TableList.Rows.Count; k++)
        {
            if (k + 1 == TableList.Rows.Count)
            {
                result.Append(TableList.Rows[k]["column_name"].ToString() + "=@" + TableList.Rows[k]["column_name"].ToString() + "\n");
            }
            else
            {
                result.Append(TableList.Rows[k]["column_name"].ToString() + "=@" + TableList.Rows[k]["column_name"].ToString() + ",\n");
            }
        }
        result.Append("where " + TableList.Rows[0]["column_name"].ToString() + "=@" + TableList.Rows[0]["column_name"].ToString() + "\n");
        #endregion

        this.Entity_Result.Text = result.ToString();
    }

    protected void Entity_Data_Click(object sender, EventArgs e)
    {
        StringBuilder result = new StringBuilder();
        String TableName = this.DB_TableName.Text;
        DataTable TableList = MethodLibrary.ExecuteDIYSql("select top 0 * from " + TableName);
        String title = this.Entity_Title.Text + "Data";
        result.Append("public class " + title + "\n");
        result.Append("{\n");
        result.Append("#region 添加\n");
        result.Append("/// <summary>\n");
        result.Append("/// 添加\n");
        result.Append("/// </summary>\n");
        result.Append("/// <param name=\"_UserInfo\">实体类</param>\n");
        result.Append("/// <returns></returns>\n");
        result.Append("public static Boolean Add(" + this.Entity_Title.Text + "Info _" + this.Entity_Title.Text + "Info)\n");
        result.Append("{\n");
        result.Append("SqlParameter[] parm ={\n");
        for (int t = 1; t < TableList.Columns.Count; t++)
        {
            result.Append("                                     new SqlParameter(\"" + TableList.Columns[t].ColumnName + "\",_" + this.Entity_Title.Text + "Info." + TableList.Columns[t].ColumnName + "),\n");
        }
        result.Append("                                  };\n");
        result.Append("SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, \"" + TableName + "_Add\", parm);\n");
        result.Append("return true;\n");
        result.Append("}\n");
        result.Append("#endregion\n\n");


        result.Append("#region 删除\n");
        result.Append("/// <summary>\n");
        result.Append("/// 删除\n");
        result.Append("/// </summary>\n");
        result.Append("/// <param name=\"_" + TableList.Columns[0].ColumnName + "\">SN</param>\n");
        result.Append("/// <returns></returns>\n");
        result.Append("public static Boolean Delete(" + TableList.Columns[0].DataType.ToString().Replace("System.", "") + " _" + TableList.Columns[0].ColumnName + ")\n");
        result.Append("{\n");
        result.Append("SqlParameter[] parm ={");
        result.Append("new SqlParameter(\"" + TableList.Columns[0].ColumnName + "\",_" + TableList.Columns[0].ColumnName + "),");
        result.Append("};\n");
        result.Append("SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, \"" + TableName + "_Delete\", parm);\n");
        result.Append("return true;\n");
        result.Append("}\n");
        result.Append("#endregion\n\n");


        result.Append("#region 获取\n");
        result.Append("/// <summary>\n");
        result.Append("/// 获取\n");
        result.Append("/// </summary>\n");
        result.Append("/// <param name=\"_" + TableList.Columns[0].ColumnName + "\">SN</param>\n");
        result.Append("/// <returns></returns>\n");
        result.Append("public static " + this.Entity_Title.Text + "Info Get(" + TableList.Columns[0].DataType.ToString().Replace("System.", "") + " _" + TableList.Columns[0].ColumnName + ")\n");
        result.Append("{\n");
        result.Append(this.Entity_Title.Text + "Info _" + this.Entity_Title.Text + "Info = new " + this.Entity_Title.Text + "Info();\n");
        result.Append("SqlParameter[] parm ={");
        result.Append("new SqlParameter(\"" + TableList.Columns[0].ColumnName + "\",_" + TableList.Columns[0].ColumnName + "),");
        result.Append("};\n");
        result.Append("using (SqlDataReader _SDR = SqlHelper.ExecuteReader(SqlHelper.ConnectionString2, CommandType.StoredProcedure, \"" + TableName + "_Get\", parm))\n");
        result.Append("{\n");
        result.Append("if (_SDR.Read())\n");
        result.Append("{\n");
        for (int t = 0; t < TableList.Columns.Count; t++)
        {
            result.Append("_" + this.Entity_Title.Text + "Info." + TableList.Columns[t].ColumnName + " = Convert.To" + TableList.Columns[t].DataType.ToString().Replace("System.", "") + "(_SDR[\"" + TableList.Columns[t].ColumnName + "\"]);\n");
        }
        result.Append("}\n");
        result.Append("_SDR.Close();\n");
        result.Append("_SDR.Dispose();\n");
        result.Append("}\n");
        result.Append("return _" + this.Entity_Title.Text + "Info;\n");
        result.Append("}\n");
        result.Append("#endregion\n\n");


        result.Append("#region 列表\n");
        result.Append("/// <summary>\n");
        result.Append("/// \n");
        result.Append("/// </summary>\n");
        result.Append("public static DataTable List()\n");
        result.Append("{\n");
        result.Append("DataSet _DataSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.StoredProcedure, \"" + TableName + "_List\", null);\n");
        result.Append("return _DataSet.Tables[0];\n");
        result.Append("}\n");
        result.Append("#endregion\n\n");


        result.Append("#region 设置\n");
        result.Append("/// <summary>\n");
        result.Append("/// 设置\n");
        result.Append("/// </summary>\n");
        result.Append("/// <param name=\"_UserInfo\">实体类</param>\n");
        result.Append("/// <returns></returns>\n");
        result.Append("public static Boolean Set(" + this.Entity_Title.Text + "Info _" + this.Entity_Title.Text + "Info)\n");
        result.Append("{\n");
        result.Append("SqlParameter[] parm ={\n");
        for (int t = 0; t < TableList.Columns.Count; t++)
        {
            result.Append("                                     new SqlParameter(\"" + TableList.Columns[t].ColumnName + "\",_" + this.Entity_Title.Text + "Info." + TableList.Columns[t].ColumnName + "),\n");
        }
        result.Append("                                  };\n");
        result.Append("SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString2, CommandType.StoredProcedure, \"" + TableName + "_Set\", parm);\n");
        result.Append("return true;\n");
        result.Append("}\n");
        result.Append("#endregion\n");

        result.Append("}\n");

        this.Entity_Result.Text = result.ToString();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        StringBuilder result = new StringBuilder();
        String TableName = this.DB_TableName.Text;
        DataTable TableList = MethodLibrary.ExecuteDIYSql("select top 0 * from " + TableName);
        String title = "My" + this.Entity_Title.Text;
        result.Append("public class " + title + "\n");
        result.Append("{\n");
        result.Append("#region 添加\n");
        result.Append("/// <summary>\n");
        result.Append("/// 添加\n");
        result.Append("/// </summary>\n");
        result.Append("/// <param name=\"_UserInfo\">实体类</param>\n");
        result.Append("/// <returns></returns>\n");
        result.Append("public static Boolean Add(" + this.Entity_Title.Text + "Info _" + this.Entity_Title.Text + "Info)\n");
        result.Append("{\n");
        result.Append("return " + this.Entity_Title.Text + "Data.Add(_" + this.Entity_Title.Text + "Info);\n");
        result.Append("}\n");
        result.Append("#endregion\n\n");


        result.Append("#region 删除\n");
        result.Append("/// <summary>\n");
        result.Append("/// 删除\n");
        result.Append("/// </summary>\n");
        result.Append("/// <param name=\"_" + TableList.Columns[0].ColumnName + "\">SN</param>\n");
        result.Append("/// <returns></returns>\n");
        result.Append("public static Boolean Delete(" + TableList.Columns[0].DataType.ToString().Replace("System.", "") + " _" + TableList.Columns[0].ColumnName + ")\n");
        result.Append("{\n");
        result.Append("return " + this.Entity_Title.Text + "Data.Delete(_" + TableList.Columns[0].ColumnName + ");\n");
        result.Append("}\n");
        result.Append("#endregion\n\n");


        result.Append("#region 获取\n");
        result.Append("/// <summary>\n");
        result.Append("/// 获取\n");
        result.Append("/// </summary>\n");
        result.Append("/// <param name=\"_" + TableList.Columns[0].ColumnName + "\">SN</param>\n");
        result.Append("/// <returns></returns>\n");
        result.Append("public static " + this.Entity_Title.Text + "Info Get(" + TableList.Columns[0].DataType.ToString().Replace("System.", "") + " _" + TableList.Columns[0].ColumnName + ")\n");
        result.Append("{\n");
        result.Append("return " + this.Entity_Title.Text + "Data.Get(_" + TableList.Columns[0].ColumnName + ");\n");
        result.Append("}\n");
        result.Append("#endregion\n\n");


        result.Append("#region 列表\n");
        result.Append("/// <summary>\n");
        result.Append("/// \n");
        result.Append("/// </summary>\n");
        result.Append("public static DataTable List()\n");
        result.Append("{\n");
        result.Append("return " + this.Entity_Title.Text + "Data.List();\n");
        result.Append("}\n");
        result.Append("#endregion\n\n");


        result.Append("#region 设置\n");
        result.Append("/// <summary>\n");
        result.Append("/// 设置\n");
        result.Append("/// </summary>\n");
        result.Append("/// <param name=\"_UserInfo\">实体类</param>\n");
        result.Append("/// <returns></returns>\n");
        result.Append("public static Boolean Set(" + this.Entity_Title.Text + "Info _" + this.Entity_Title.Text + "Info)\n");
        result.Append("{\n");
        result.Append("return " + this.Entity_Title.Text + "Data.Set(_" + this.Entity_Title.Text + "Info);\n");
        result.Append("}\n");
        result.Append("#endregion\n");

        result.Append("}\n");

        this.Entity_Result.Text = result.ToString();
    }

    protected void Button21_Click(object sender, EventArgs e)
    {
        StringBuilder result = new StringBuilder();
        String TableName = this.DB_TableName.Text;
        DataTable TableList = MethodLibrary.ExecuteDIYSql("select column_name,data_type,character_maximum_length from information_schema.columns where table_name = '" + TableName + "'");

        #region 添加
        for (int k = 0; k < TableList.Rows.Count; k++)
        {
            if (k + 1 == TableList.Rows.Count)
            {
                result.Append(TableList.Rows[k]["column_name"].ToString() + "\n\n");
            }
            else
            {
                result.Append(TableList.Rows[k]["Column_Name"].ToString() + ",");
            }
        }
        #endregion

        this.Entity_Result.Text = result.ToString();
    }

    protected void DB_Submit5_Click(object sender, EventArgs e)
    {
        StringBuilder result = new StringBuilder();
        String TableName = this.DB_TableName.Text;
        DataTable TableList = MethodLibrary.ExecuteDIYSql("select top 0 * from " + TableName);
        String title = this.Entity_Title.Text + "Info";

        result.Append("<table>\n");
        for (int k = 0; k < TableList.Columns.Count; k++)
        {
            string _ColumnName = TableList.Columns[k].ColumnName.Split('_')[1];
            if (TableList.Columns[k].ColumnName.Split('_').Length > 2)
            {
                _ColumnName = TableList.Columns[k].ColumnName.Split('_')[1] + TableList.Columns[k].ColumnName.Split('_')[2];
            }
            result.Append("    <tr>\n");
            result.Append("        <td class=\"infozuo\">" + TableList.Columns[k].ColumnName + "：</td>\n");
            result.Append("        <td class=\"infoyou\"><asp:TextBox ID=\"Texx_" + _ColumnName + "\" MaxLength=\"50\" runat=\"server\" CssClass=\"class\"></asp:TextBox></td>\n");
            result.Append("    </tr>\n\n");
        }
        result.Append("</table>");
        result.Append("\n\n\n\n\n");


        result.Append(title + " _" + title + " = new " + title + "();\n\n");
        for (int k = 0; k < TableList.Columns.Count; k++)
        {
            string _ColumnName = TableList.Columns[k].ColumnName.Split('_')[1];
            if (TableList.Columns[k].ColumnName.Split('_').Length > 2)
            {
                _ColumnName = TableList.Columns[k].ColumnName.Split('_')[1] + TableList.Columns[k].ColumnName.Split('_')[2];
            }
            result.Append("this.Texx_" + _ColumnName + ".Text = _" + title + "." + TableList.Columns[k].ColumnName + ";\n");
        }

        result.Append("\n\n\n\n\n");


        result.Append(title + " _" + title + " = new " + title + "();\n\n");
        for (int k = 0; k < TableList.Columns.Count; k++)
        {
            string _ColumnName = TableList.Columns[k].ColumnName.Split('_')[1];
            if (TableList.Columns[k].ColumnName.Split('_').Length > 2)
            {
                _ColumnName = _ColumnName + TableList.Columns[k].ColumnName.Split('_')[2];
            }
            result.Append("_" + title + "." + TableList.Columns[k].ColumnName + " = this.Texx_" + _ColumnName + ".Text;\n");
        }

        this.Entity_Result.Text = result.ToString();

    }
}
