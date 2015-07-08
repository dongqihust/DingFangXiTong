using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Collections;
using System.Web;
using System.Data;
using NotFind.Data;
using NotFind.Entity;
using System.Net.Mail;
using System.IO;
using System.Net;

using System.Xml;

using System.Net.Mime;

using System.Security.Cryptography;//加密\解密

namespace NotFind.Business
{
    public class MethodLibrary
    {

        #region 向Cookie中插入信息
        /// <summary>
        /// 向Cookie中插入信息
        /// </summary>
        /// <param name="_HttpCookie">Cookie对像</param>
        /// <returns></returns>
        public static Boolean CookieAdd(HttpCookie _HttpCookie)
        {
            System.Web.HttpContext.Current.Response.Cookies.Add(_HttpCookie);//写入Cookie
            return true;
        }
        #endregion

        #region 从Cookie中获得指定项的值
        /// <summary>
        /// 从Cookie中获得指定项的值
        /// </summary>
        /// <param name="_Key">Key</param>
        /// <param name="_Parameter">项</param>
        /// <returns></returns>
        public static String CookieGet(String _Key, String _Parameter)
        {
            string result = "";//初始化返回结果
            if (System.Web.HttpContext.Current.Request.Cookies[_Key] == null)
            {
            }
            else
            {
                string CookieString = System.Web.HttpContext.Current.Request.Cookies[_Key].Value;//获得Cookie内的用户信息

                string[] CookieParameter = CookieString.Split('&');//以&为标识,进行分割,并生成数组

                for (int i = 0; i < CookieParameter.Length; i++)
                {
                    string[] ParameterName = CookieParameter[i].Split('=');
                    if (ParameterName[0] == _Parameter)
                    {
                        result = ParameterName[1];
                    }
                }
            }
            return result;//返回结果
        }
        #endregion

        #region 执行指定SQL
        /// <summary>
        /// 执行指定SQL
        /// </summary>
        /// <param name="_DIYSql">SQL语句</param>
        /// <returns></returns>
        public static DataTable ExecuteDIYSql(String _DIYSql)
        {
            DataSet _TempSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.Text, _DIYSql, null);
            return _TempSet.Tables[0];
        }
        #endregion

        #region 网页进度条
        /// <summary>
        /// 网页进度条
        /// </summary>
        public class HProgressBar
        {
            /// <summary>
            /// 进度条的初始化
            /// </summary>
            public static void Start()
            {
                Start(0, "正在加载...");
            }

            /// <summary>
            /// 进度条
            /// </summary>
            /// <param name="GongCount">一共多少个进度</param>
            /// <param name="Count">当前进度</param>
            /// <param name="msg"></param>
            public static void Start(int GongCount, string msg)
            {
                StringBuilder s = new StringBuilder();
                s.Append("<span id=\"Msg1\" style=\"font-size:12px;\"></span>");
                s.Append("<script type=\"text/javascript\">");
                s.Append("function SetJD" + msg + "(pos)");
                s.Append("{");
                s.Append("document.getElementById(\"Msg1\").innerHTML = '共：<span style=\"color:Green;\">" + GongCount + "</span> 个，已完成 <span style=\"color:Green;\">' + pos + '</span> 个，在未全部完成前请不要关闭页面。';");
                s.Append("}");
                s.Append("</script><body>");
                s.Append("<script type=\"text/javascript\">SetJD" + msg + "(" + msg + ");</script>");
                s.Append("</body>");

                System.Web.HttpContext.Current.Response.Write(s);
                System.Web.HttpContext.Current.Response.Flush();
            }
            /// <summary>
            /// 滚动进度条
            /// </summary>
            /// <param name="Msg">在进度条上方显示的信息</param>
            /// <param name="Pos">显示进度的百分比数字</param>
        }
        #endregion

        #region 判断字符串中是否包含另一个字符串
        /// <summary>
        /// 判断字符串中是否包含另一个字符串
        /// </summary>
        /// <param name="CString">长字符串</param>
        /// <param name="DString">短字符串</param>
        /// <returns>true包含，false不包含</returns>
        public static bool IsBaoHanString(string CString, string DString)
        {
            if (CString.IndexOf(DString) > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
            ////CString = "," + CString + ",".ToLower();
            ////if (CString.Split(new string[] { DString.ToLower() }, StringSplitOptions.RemoveEmptyEntries).Length > 1)
            ////{
            ////    return true;
            ////}
            ////else
            ////{
            ////    return false;
            ////}
        }
        #endregion

        #region 清空指定的文件夹，但不删除文件夹
        /// <summary>
        /// 清空指定的文件夹，但不删除文件夹
        /// </summary>
        /// <param name="dir"></param>
        public static void DeleteFolderNeiRong(string dir)
        {
            foreach (string d in Directory.GetFileSystemEntries(dir))
            {
                if (File.Exists(d))
                {
                    FileInfo fi = new FileInfo(d);
                    if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                        fi.Attributes = FileAttributes.Normal;
                    File.Delete(d);//直接删除其中的文件  
                }
                else
                {
                    DirectoryInfo d1 = new DirectoryInfo(d);
                    if (d1.GetFiles().Length != 0)
                    {
                        DeleteFolder(d1.FullName);////递归删除子文件夹
                    }
                    Directory.Delete(d);
                }
            }
        }
        #endregion

        #region 删除文件夹及其内容
        /// <summary>
        /// 删除文件夹及其内容
        /// </summary>
        /// <param name="dir"></param>
        public static void DeleteFolder(string dir)
        {
            foreach (string d in Directory.GetFileSystemEntries(dir))
            {
                if (File.Exists(d))
                {
                    FileInfo fi = new FileInfo(d);
                    if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                        fi.Attributes = FileAttributes.Normal;
                    File.Delete(d);//直接删除其中的文件  
                }
                else
                    DeleteFolder(d);////递归删除子文件夹
                Directory.Delete(d);
            }
        }
        #endregion

        #region 根据身份证号获得性别、出生年、出生月、出生日、年龄
        /// <summary>
        /// 根据身份证号获得性别、出生年、出生月、出生日、年龄
        /// </summary>
        /// <param name="dir"></param>
        public static void GetShenFengZhengXinXi(string IDnumber, out string XingBie, out int Nian, out int Yue, out int Ri, out int NianLing)
        {
            XingBie = "不合法的身份证号码";
            Nian = 2000;
            Yue = 1;
            Ri = 1;
            NianLing = 1;

            string idcard = IDnumber;
            foreach (char x in idcard)
            {
                //Console.WriteLine("{0}", x);
                if (!(x >= '0' && x <= '9'))
                {
                    if (x != 'x' && x != 'X')
                    {
                        XingBie = "不合法的身份证号码";
                        Nian = 2000;
                        Yue = 1;
                        Ri = 1;
                        NianLing = 1;
                        return;
                    }
                }
            }

            if (idcard.Length < 15 || idcard.Length > 18)
            {
                XingBie = "不合法的身份证号码";
                Nian = 2000;
                Yue = 1;
                Ri = 1;
                NianLing = 1;
                return;
            }
            else if (idcard.Length == 18)
            {
                if (idcard.Substring(0, 17).ToLower().IndexOf("x") > -1)//如果前17未数字中存在x
                {
                    XingBie = "不合法的身份证号码";
                    Nian = 2000;
                    Yue = 1;
                    Ri = 1;
                    NianLing = 1;
                    return;
                }

                string year, month, day;
                int sex;
                year = idcard.Substring(6, 4);
                month = idcard.Substring(10, 2);
                day = idcard.Substring(12, 2);
                sex = int.Parse(idcard.Substring(16, 1));
                if (sex % 2 == 0)
                {
                    XingBie = "女";
                }
                else
                {
                    XingBie = "男";
                }
                Nian = Convert.ToInt32(year);
                Yue =Convert.ToInt32( month);
                Ri = Convert.ToInt32(day);
                NianLing = ((DateTime.Today.Year) - int.Parse(year));
                return;
            }
            else if (idcard.Length == 15)
            {
                foreach (char x in idcard)
                {
                    if (!(x >= '0' && x <= '9'))
                    {
                        XingBie = "不合法的身份证号码";
                        Nian = 2000;
                        Yue = 1;
                        Ri = 1;
                        NianLing = 1;
                        return;
                    }
                }

                string yyear, mmonth, dday;
                int Si = 0;

                //加权因子常数, 循环i=18~1,依次运算wi=2(2(i-1)次方%11)
                int[] Wi = new int[] { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
                //校验码常数 
                string LastCode = "10X98765432";
                //新身份证号 
                string NewIDcard;
                NewIDcard = idcard.Substring(0, 6);
                //填在第6位及第7位上填上‘1’，‘9’两个数字 
                NewIDcard += "19";

                //加上19后继续加上剩下的字符串
                NewIDcard += idcard.Substring(6, 9);

                //进行加权求和 
                for (int i = 0; i < 17; i++)
                {
                    Si += int.Parse(NewIDcard.Substring(i, 1)) * Wi[i];
                }

                //取模运算，得到模值 
                int iY = Si % 11;
                //从LastCode中取得以模为索引号的值，加到身份证的最后一位，即为新身份证号。 
                NewIDcard += LastCode.Substring(iY, 1);

                //return perIDNew;

                //Console.WriteLine("{0}", NewIDcard); //是把15位身份证号码转为18位身份证号码
                

                //NewIDcard = idcard.Insert(6, "19");               
                yyear = NewIDcard.Substring(6, 4);
                mmonth = NewIDcard.Substring(10, 2);
                dday = NewIDcard.Substring(12, 2);
                int sex = int.Parse(idcard.Substring(14, 1));
                if (sex % 2 == 0)
                {
                    XingBie = "女";
                }
                else
                {
                    XingBie = "男";
                }

                Nian = Convert.ToInt32(yyear);
                Yue = Convert.ToInt32(mmonth);
                Ri = Convert.ToInt32(dday);
                NianLing = ((DateTime.Today.Year) - int.Parse(yyear));
                return;
            }
        }
        #endregion

    }
}


