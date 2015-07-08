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

using System.Security.Cryptography;//����\����

namespace NotFind.Business
{
    public class MethodLibrary
    {

        #region ��Cookie�в�����Ϣ
        /// <summary>
        /// ��Cookie�в�����Ϣ
        /// </summary>
        /// <param name="_HttpCookie">Cookie����</param>
        /// <returns></returns>
        public static Boolean CookieAdd(HttpCookie _HttpCookie)
        {
            System.Web.HttpContext.Current.Response.Cookies.Add(_HttpCookie);//д��Cookie
            return true;
        }
        #endregion

        #region ��Cookie�л��ָ�����ֵ
        /// <summary>
        /// ��Cookie�л��ָ�����ֵ
        /// </summary>
        /// <param name="_Key">Key</param>
        /// <param name="_Parameter">��</param>
        /// <returns></returns>
        public static String CookieGet(String _Key, String _Parameter)
        {
            string result = "";//��ʼ�����ؽ��
            if (System.Web.HttpContext.Current.Request.Cookies[_Key] == null)
            {
            }
            else
            {
                string CookieString = System.Web.HttpContext.Current.Request.Cookies[_Key].Value;//���Cookie�ڵ��û���Ϣ

                string[] CookieParameter = CookieString.Split('&');//��&Ϊ��ʶ,���зָ�,����������

                for (int i = 0; i < CookieParameter.Length; i++)
                {
                    string[] ParameterName = CookieParameter[i].Split('=');
                    if (ParameterName[0] == _Parameter)
                    {
                        result = ParameterName[1];
                    }
                }
            }
            return result;//���ؽ��
        }
        #endregion

        #region ִ��ָ��SQL
        /// <summary>
        /// ִ��ָ��SQL
        /// </summary>
        /// <param name="_DIYSql">SQL���</param>
        /// <returns></returns>
        public static DataTable ExecuteDIYSql(String _DIYSql)
        {
            DataSet _TempSet = SqlHelper.ExecuteDataSet(SqlHelper.ConnectionString2, CommandType.Text, _DIYSql, null);
            return _TempSet.Tables[0];
        }
        #endregion

        #region ��ҳ������
        /// <summary>
        /// ��ҳ������
        /// </summary>
        public class HProgressBar
        {
            /// <summary>
            /// �������ĳ�ʼ��
            /// </summary>
            public static void Start()
            {
                Start(0, "���ڼ���...");
            }

            /// <summary>
            /// ������
            /// </summary>
            /// <param name="GongCount">һ�����ٸ�����</param>
            /// <param name="Count">��ǰ����</param>
            /// <param name="msg"></param>
            public static void Start(int GongCount, string msg)
            {
                StringBuilder s = new StringBuilder();
                s.Append("<span id=\"Msg1\" style=\"font-size:12px;\"></span>");
                s.Append("<script type=\"text/javascript\">");
                s.Append("function SetJD" + msg + "(pos)");
                s.Append("{");
                s.Append("document.getElementById(\"Msg1\").innerHTML = '����<span style=\"color:Green;\">" + GongCount + "</span> ��������� <span style=\"color:Green;\">' + pos + '</span> ������δȫ�����ǰ�벻Ҫ�ر�ҳ�档';");
                s.Append("}");
                s.Append("</script><body>");
                s.Append("<script type=\"text/javascript\">SetJD" + msg + "(" + msg + ");</script>");
                s.Append("</body>");

                System.Web.HttpContext.Current.Response.Write(s);
                System.Web.HttpContext.Current.Response.Flush();
            }
            /// <summary>
            /// ����������
            /// </summary>
            /// <param name="Msg">�ڽ������Ϸ���ʾ����Ϣ</param>
            /// <param name="Pos">��ʾ���ȵİٷֱ�����</param>
        }
        #endregion

        #region �ж��ַ������Ƿ������һ���ַ���
        /// <summary>
        /// �ж��ַ������Ƿ������һ���ַ���
        /// </summary>
        /// <param name="CString">���ַ���</param>
        /// <param name="DString">���ַ���</param>
        /// <returns>true������false������</returns>
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

        #region ���ָ�����ļ��У�����ɾ���ļ���
        /// <summary>
        /// ���ָ�����ļ��У�����ɾ���ļ���
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
                    File.Delete(d);//ֱ��ɾ�����е��ļ�  
                }
                else
                {
                    DirectoryInfo d1 = new DirectoryInfo(d);
                    if (d1.GetFiles().Length != 0)
                    {
                        DeleteFolder(d1.FullName);////�ݹ�ɾ�����ļ���
                    }
                    Directory.Delete(d);
                }
            }
        }
        #endregion

        #region ɾ���ļ��м�������
        /// <summary>
        /// ɾ���ļ��м�������
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
                    File.Delete(d);//ֱ��ɾ�����е��ļ�  
                }
                else
                    DeleteFolder(d);////�ݹ�ɾ�����ļ���
                Directory.Delete(d);
            }
        }
        #endregion

        #region �������֤�Ż���Ա𡢳����ꡢ�����¡������ա�����
        /// <summary>
        /// �������֤�Ż���Ա𡢳����ꡢ�����¡������ա�����
        /// </summary>
        /// <param name="dir"></param>
        public static void GetShenFengZhengXinXi(string IDnumber, out string XingBie, out int Nian, out int Yue, out int Ri, out int NianLing)
        {
            XingBie = "���Ϸ������֤����";
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
                        XingBie = "���Ϸ������֤����";
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
                XingBie = "���Ϸ������֤����";
                Nian = 2000;
                Yue = 1;
                Ri = 1;
                NianLing = 1;
                return;
            }
            else if (idcard.Length == 18)
            {
                if (idcard.Substring(0, 17).ToLower().IndexOf("x") > -1)//���ǰ17δ�����д���x
                {
                    XingBie = "���Ϸ������֤����";
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
                    XingBie = "Ů";
                }
                else
                {
                    XingBie = "��";
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
                        XingBie = "���Ϸ������֤����";
                        Nian = 2000;
                        Yue = 1;
                        Ri = 1;
                        NianLing = 1;
                        return;
                    }
                }

                string yyear, mmonth, dday;
                int Si = 0;

                //��Ȩ���ӳ���, ѭ��i=18~1,��������wi=2(2(i-1)�η�%11)
                int[] Wi = new int[] { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
                //У���볣�� 
                string LastCode = "10X98765432";
                //�����֤�� 
                string NewIDcard;
                NewIDcard = idcard.Substring(0, 6);
                //���ڵ�6λ����7λ�����ϡ�1������9���������� 
                NewIDcard += "19";

                //����19���������ʣ�µ��ַ���
                NewIDcard += idcard.Substring(6, 9);

                //���м�Ȩ��� 
                for (int i = 0; i < 17; i++)
                {
                    Si += int.Parse(NewIDcard.Substring(i, 1)) * Wi[i];
                }

                //ȡģ���㣬�õ�ģֵ 
                int iY = Si % 11;
                //��LastCode��ȡ����ģΪ�����ŵ�ֵ���ӵ����֤�����һλ����Ϊ�����֤�š� 
                NewIDcard += LastCode.Substring(iY, 1);

                //return perIDNew;

                //Console.WriteLine("{0}", NewIDcard); //�ǰ�15λ���֤����תΪ18λ���֤����
                

                //NewIDcard = idcard.Insert(6, "19");               
                yyear = NewIDcard.Substring(6, 4);
                mmonth = NewIDcard.Substring(10, 2);
                dday = NewIDcard.Substring(12, 2);
                int sex = int.Parse(idcard.Substring(14, 1));
                if (sex % 2 == 0)
                {
                    XingBie = "Ů";
                }
                else
                {
                    XingBie = "��";
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


