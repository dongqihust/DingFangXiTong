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
using System.Text;
using NotFind.Business;
using NotFind.Entity;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public partial class UserDingFang : System.Web.UI.Page
{
    protected StringBuilder _PageString = new StringBuilder();
    Int32 _PageIndex;//申请单分页中，请求第几页
   Int32 _XiTongSN  =0;     
   Int32 _BingGuanSN   =0;  
   Int32 _FangXingSN  =0;   
   String _RuZhuStartDate="";
   String _TuiFangEndDate = "";
   Int32 style = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            dropDingFangXiTongBind();
            
            if (Request["_XiTongSN"] != null)
            {
                Texx_DingFangXiTong.Text = Request["_XiTongSN"].ToString();
            }
          
            BinGuanDataBind(sender, e);

            if (Request["_BingGuanSN"] != null)
            {
                Texx_BingGuan.Text = Request["_BingGuanSN"].ToString();
            }


            FangXingDataBind(sender, e);
            if (Request["_FangXingSN"] != null)
            {
                Texx_FangXing.Text = Request["_FangXingSN"];
            }


            if (Request["style"] == "1")
            {
                ListChuangDataBind();
                Panel1.Visible = false;
                PageDiv1.Visible = false;
            }
            else
            {
                ListFangDataBind();
                Panel2.Visible = false;
                PageDiv2.Visible = false;
            }
           


          
        }
      
    }

    public void dropDingFangXiTongBind()
    {
        DataTable dtXiTong = MyDingFangXiTong.List();
        this.Texx_DingFangXiTong.DataSource = dtXiTong.DefaultView;
        this.Texx_DingFangXiTong.DataTextField = "D_Name";//设置option的text值
        this.Texx_DingFangXiTong.DataValueField = "D_SN";//设置option的value值
        this.Texx_DingFangXiTong.DataBind();
        this.Texx_DingFangXiTong.Items.Insert(0, new ListItem("不限系统", "0"));//设置默认值
    }

    public void BinGuanDataBind(object sender, EventArgs e)
    {


        ///此方法是从一个datatable中select出一个新的datatable
        DataTable dtBingGuans = MyBingGuan.List();
        DataRow[] dtRows = dtBingGuans.Select("B_SuoShuDingFangXiTongSN=" + Texx_DingFangXiTong.Text);

        DataTable NewDtBingGuans = dtBingGuans.Clone();
        NewDtBingGuans.Clear();
        foreach (DataRow item in dtRows)
        {

            NewDtBingGuans.Rows.Add(item.ItemArray);
        }

        this.Texx_BingGuan.DataSource = NewDtBingGuans;
        this.Texx_BingGuan.DataTextField = "B_Name";
        this.Texx_BingGuan.DataValueField = "B_SN";
        this.Texx_BingGuan.DataBind();
        this.Texx_BingGuan.Items.Insert(0, new ListItem("不限宾馆", "0"));//设置默认值

        FangXingDataBind(sender,e);
    }


    public void FangXingDataBind(object sender, EventArgs e)
    {


        ///此方法是从一个datatable中select出一个新的datatable
        DataTable dtFangXing = MyFangXing.List();
        DataRow[] dtRows = dtFangXing.Select("F_SuoShuBingGuanSN=" + Texx_BingGuan.Text);

        DataTable NewDtFangXing = dtFangXing.Clone();
        NewDtFangXing.Clear();
        foreach (DataRow item in dtRows)
        {

            NewDtFangXing.Rows.Add(item.ItemArray);
        }

        this.Texx_FangXing.DataSource = NewDtFangXing;
        this.Texx_FangXing.DataTextField = "F_Name";
        this.Texx_FangXing.DataValueField = "F_SN";
        this.Texx_FangXing.DataBind();
        this.Texx_FangXing.Items.Insert(0, new ListItem("不限房型", "0"));//设置默认值
    }

    protected void Search_Click(object sender, EventArgs e)
    {

        if(Texx_DingFangXiTong.Text!=""){
             _XiTongSN = Convert.ToInt32(Texx_DingFangXiTong.Text);
        }

        if (Texx_BingGuan.Text != "")
        {
            _BingGuanSN = Convert.ToInt32(Texx_BingGuan.Text);
        }
        if (Texx_FangXing.Text != "")
        {
            _FangXingSN = Convert.ToInt32(Texx_FangXing.Text);
        }


        if (Texx_Style.Text != "")
        {
            style = Convert.ToInt32(Texx_Style.Text);
        }

        _RuZhuStartDate = Texx_RuZhuStartDate.Text;
       _TuiFangEndDate = Texx_TuiFangEndDate.Text;

       Response.Redirect("UserDingFang.aspx?_RuZhuStartDate=" + _RuZhuStartDate + "&_TuiFangEndDate=" + _TuiFangEndDate + "&_XiTongSN=" + _XiTongSN + "&_BingGuanSN=" + _BingGuanSN + "&_FangXingSN=" + _FangXingSN+"&style="+style);    

    }


    protected void ListFangDataBind()
    {


        //如果前端请求了分页
        if (Request.QueryString["page"] != null)
        {
            //将当前的页数呈现在前端
            _PageIndex = Convert.ToInt32(Request.QueryString["page"].ToString());
        }
        if (Request["_XiTongSN"] != null)
        {
            _XiTongSN = Convert.ToInt32(Request["_XiTongSN"].ToString());
        }
        if (Request["_BingGuanSN"] != null)
        {
            _BingGuanSN = Convert.ToInt32(Request["_BingGuanSN"].ToString());
        }
        if (Request["_FangXingSN"] != null)
        {
            _FangXingSN = Convert.ToInt32(Request["_FangXingSN"].ToString());
        }
        if (Request["_RuZhuStartDate"] != null)
        {
            _RuZhuStartDate = Request["_RuZhuStartDate"].ToString();
        }
        if (Request["_TuiFangEndDate"] != null)
        {
            _TuiFangEndDate = Request["_TuiFangEndDate"].ToString();
        }
        if (Request["style"] != null)
        {
            style =  Convert.ToInt32(Request["style"].ToString());
        }
        Hashtable _HashTable = MyView_FangJianTianKuCun.List4Page(_RuZhuStartDate, _TuiFangEndDate, false, 0, _XiTongSN, _BingGuanSN, _FangXingSN, "", 10, _PageIndex);

        Int32 RecordCountOfPage = (int)_HashTable["RecordCountOfPage"];
        Int32 RecordCount = (int)_HashTable["RecordCount"];
        Int32 PageCount = (int)_HashTable["PageCount"];
        Int32 PageIndex = (int)_HashTable["PageIndex"];
        Int32 PrePageIndex = (int)_HashTable["PrePageIndex"];
        Int32 NextPageIndex = (int)_HashTable["NextPageIndex"];
        DataTable RecordList = (DataTable)_HashTable["RecordList"];

        #region 生成分页字串
        if (PageCount <= 20)
        {
            _PageString.Append("<a href='###'>共" + RecordCount + "条数据，每页" + RecordCountOfPage + "条</a> <a href='UserDingFang.aspx?page=1&_RuZhuStartDate=" + _RuZhuStartDate + "&_TuiFangEndDate=" + _TuiFangEndDate + "&_XiTongSN=" + _XiTongSN + "&_BingGuanSN=" + _BingGuanSN + "&_FangXingSN=" + _FangXingSN +"&style=0"+ "'>首页</a>");
            for (int pb = 0; pb < PageCount; pb++)
            {
                if ((pb + 1) != PageIndex)
                {
                    _PageString.Append("<a href='UserDingFang.aspx?page=" + (pb + 1) + "&_RuZhuStartDate=" + _RuZhuStartDate + "&_TuiFangEndDate=" + _TuiFangEndDate + "&_XiTongSN=" + _XiTongSN + "&_BingGuanSN=" + _BingGuanSN + "&_FangXingSN=" + _FangXingSN + "&style=0" + "'>" + (pb + 1) + "</a>");
                }
                else
                {
                    _PageString.Append("<a class=\"Items_Page_Seleted\">" + (pb + 1) + "</a>");
                }
            }
            _PageString.Append("<a href='UserDingFang.aspx?page=" + PageCount + "&_RuZhuStartDate=" + _RuZhuStartDate + "&_TuiFangEndDate=" + _TuiFangEndDate + "&_XiTongSN=" + _XiTongSN + "&_BingGuanSN=" + _BingGuanSN + "&_FangXingSN=" + _FangXingSN + "&style=0" + "'>尾页</a>");
        }
        else
        {
            Int32 _FristPage = PageIndex - 10;
            Int32 _LastPage = PageIndex + 9;

            if (_FristPage < 1)
            {
                _LastPage += (1 - _FristPage);
                _FristPage = 1;
            }
            else if (_LastPage > PageCount)
            {
                _FristPage -= (_LastPage - PageCount);
                _LastPage = PageCount;
            }

            _PageString.Append("<a href='###'>共" + RecordCount + "条数据，每页" + RecordCountOfPage + "条</a> <a href='UserDingFang.aspx?page=1&_RuZhuStartDate=" + _RuZhuStartDate + "&_TuiFangEndDate=" + _TuiFangEndDate + "&_XiTongSN=" + _XiTongSN + "&_BingGuanSN=" + _BingGuanSN + "&_FangXingSN=" + _FangXingSN + "&style=0" + "'>首页</a>");
            for (int pb = _FristPage; pb <= _LastPage; pb++)
            {
                if ((pb) != PageIndex)
                {
                    _PageString.Append("<a href='UserDingFang.aspx?page=" + (pb) + "&_RuZhuStartDate=" + _RuZhuStartDate + "&_TuiFangEndDate=" + _TuiFangEndDate + "&_XiTongSN=" + _XiTongSN + "&_BingGuanSN=" + _BingGuanSN + "&_FangXingSN=" + _FangXingSN + "&style=0" + "'>" + (pb) + "</a>");
                }
                else
                {
                    _PageString.Append("<a class=\"Items_Page_Seleted\">" + (pb) + "</a>");
                }
            }
            _PageString.Append("<a href='UserDingFang.aspx?page=" + PageCount + "&_RuZhuStartDate=" + _RuZhuStartDate + "&_TuiFangEndDate=" + _TuiFangEndDate + "&_XiTongSN=" + _XiTongSN + "&_BingGuanSN=" + _BingGuanSN + "&_FangXingSN=" + _FangXingSN + "&style=0" + "'>尾页</a>");
        }

        #endregion
        this.Lab_PageString1.Text = _PageString.ToString();

        this.Griw_List1.DataSource = RecordList;
        this.Griw_List1.DataBind();
  
        Texx_RuZhuStartDate.Text = _RuZhuStartDate;
        Texx_TuiFangEndDate.Text = _TuiFangEndDate;
        Texx_Style.Text = style.ToString() ;
    }


    protected void ListChuangDataBind()
    {


        //如果前端请求了分页
        if (Request.QueryString["page"] != null)
        {
            //将当前的页数呈现在前端
            _PageIndex = Convert.ToInt32(Request.QueryString["page"].ToString());
        }
        if (Request["_XiTongSN"] != null)
        {
            _XiTongSN = Convert.ToInt32(Request["_XiTongSN"].ToString());
        }
        if (Request["_BingGuanSN"] != null)
        {
            _BingGuanSN = Convert.ToInt32(Request["_BingGuanSN"].ToString());
        }
        if (Request["_FangXingSN"] != null)
        {
            _FangXingSN = Convert.ToInt32(Request["_FangXingSN"].ToString());
        }
        if (Request["_RuZhuStartDate"] != null)
        {
            _RuZhuStartDate = Request["_RuZhuStartDate"].ToString();
        }
        if (Request["_TuiFangEndDate"] != null)
        {
            _TuiFangEndDate = Request["_TuiFangEndDate"].ToString();
        }
        if (Request["style"] != null)
        {
            style = Convert.ToInt32(Request["style"].ToString());
        }
        Hashtable _HashTable = MyView_ChuangWeiKuCun.List4Page(_RuZhuStartDate, _TuiFangEndDate, false, 0, _XiTongSN, _BingGuanSN, _FangXingSN, "", 10, _PageIndex);

        Int32 RecordCountOfPage = (int)_HashTable["RecordCountOfPage"];
        Int32 RecordCount = (int)_HashTable["RecordCount"];
        Int32 PageCount = (int)_HashTable["PageCount"];
        Int32 PageIndex = (int)_HashTable["PageIndex"];
        Int32 PrePageIndex = (int)_HashTable["PrePageIndex"];
        Int32 NextPageIndex = (int)_HashTable["NextPageIndex"];
        DataTable RecordList = (DataTable)_HashTable["RecordList"];

        #region 生成分页字串
        if (PageCount <= 20)
        {
            _PageString.Append("<a href='###'>共" + RecordCount + "条数据，每页" + RecordCountOfPage + "条</a> <a href='UserDingFang.aspx?page=1&_RuZhuStartDate=" + _RuZhuStartDate + "&_TuiFangEndDate=" + _TuiFangEndDate + "&_XiTongSN=" + _XiTongSN + "&_BingGuanSN=" + _BingGuanSN + "&_FangXingSN=" + _FangXingSN + "&style=1" + "'>首页</a>");
            for (int pb = 0; pb < PageCount; pb++)
            {
                if ((pb + 1) != PageIndex)
                {
                    _PageString.Append("<a href='UserDingFang.aspx?page=" + (pb + 1) + "&_RuZhuStartDate=" + _RuZhuStartDate + "&_TuiFangEndDate=" + _TuiFangEndDate + "&_XiTongSN=" + _XiTongSN + "&_BingGuanSN=" + _BingGuanSN + "&_FangXingSN=" + _FangXingSN + "&style=1" + "'>" + (pb + 1) + "</a>");
                }
                else
                {
                    _PageString.Append("<a class=\"Items_Page_Seleted\">" + (pb + 1) + "</a>");
                }
            }
            _PageString.Append("<a href='UserDingFang.aspx?page=" + PageCount + "&_RuZhuStartDate=" + _RuZhuStartDate + "&_TuiFangEndDate=" + _TuiFangEndDate + "&_XiTongSN=" + _XiTongSN + "&_BingGuanSN=" + _BingGuanSN + "&_FangXingSN=" + _FangXingSN + "&style=1" + "'>尾页</a>");
        }
        else
        {
            Int32 _FristPage = PageIndex - 10;
            Int32 _LastPage = PageIndex + 9;

            if (_FristPage < 1)
            {
                _LastPage += (1 - _FristPage);
                _FristPage = 1;
            }
            else if (_LastPage > PageCount)
            {
                _FristPage -= (_LastPage - PageCount);
                _LastPage = PageCount;
            }

            _PageString.Append("<a href='###'>共" + RecordCount + "条数据，每页" + RecordCountOfPage + "条</a> <a href='UserDingFang.aspx?page=1&_RuZhuStartDate=" + _RuZhuStartDate + "&_TuiFangEndDate=" + _TuiFangEndDate + "&_XiTongSN=" + _XiTongSN + "&_BingGuanSN=" + _BingGuanSN + "&_FangXingSN=" + _FangXingSN + "&style=1" + "'>首页</a>");
            for (int pb = _FristPage; pb <= _LastPage; pb++)
            {
                if ((pb) != PageIndex)
                {
                    _PageString.Append("<a href='UserDingFang.aspx?page=" + (pb) + "&_RuZhuStartDate=" + _RuZhuStartDate + "&_TuiFangEndDate=" + _TuiFangEndDate + "&_XiTongSN=" + _XiTongSN + "&_BingGuanSN=" + _BingGuanSN + "&_FangXingSN=" + _FangXingSN + "&style=1" + "'>" + (pb) + "</a>");
                }
                else
                {
                    _PageString.Append("<a class=\"Items_Page_Seleted\">" + (pb) + "</a>");
                }
            }
            _PageString.Append("<a href='UserDingFang.aspx?page=" + PageCount + "&_RuZhuStartDate=" + _RuZhuStartDate + "&_TuiFangEndDate=" + _TuiFangEndDate + "&_XiTongSN=" + _XiTongSN + "&_BingGuanSN=" + _BingGuanSN + "&_FangXingSN=" + _FangXingSN + "&style=1" + "'>尾页</a>");
        }

        #endregion

        this.Lab_PageString2.Text = _PageString.ToString();

        this.Griw_List2.DataSource = RecordList;
        this.Griw_List2.DataBind();

        Texx_RuZhuStartDate.Text = _RuZhuStartDate;
        Texx_TuiFangEndDate.Text = _TuiFangEndDate;
        Texx_Style.Text = style.ToString();
    }
}