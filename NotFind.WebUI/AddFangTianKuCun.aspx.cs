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

public partial class FangTianKuCunAdd : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
   
        if (!IsPostBack)
        {
            dropDingFangXiTongBind();

        }

    }

    protected void AddFangJianTianKuCun(object sender, EventArgs e)
    {
        FangJianTianKuCunInfo _FangJianTianKuCunInfo = new FangJianTianKuCunInfo();
        _FangJianTianKuCunInfo.F_AddDate = DateTime.Now;
        _FangJianTianKuCunInfo.F_BaoLiuZhuangTai = Convert.ToInt32(Texx_BaoLiuZhuangTai.Text);
        _FangJianTianKuCunInfo.F_BingGuanSN = Convert.ToInt32(Texx_BingGuan.Text);
        _FangJianTianKuCunInfo.F_FangJianSN = Convert.ToInt32(Texx_FangJian.Text);
        _FangJianTianKuCunInfo.F_FangXingSN = Convert.ToInt32(Texx_FangXing.Text);
      
        int DingFangXiTongSN = Convert.ToInt32(Texx_DingFangXiTong.Text);
        DingFangXiTongInfo _DingFangXiTongInfo = MyDingFangXiTong.Get(DingFangXiTongSN);
        _FangJianTianKuCunInfo.F_SuoShuXiTongSN = _DingFangXiTongInfo.D_SN;
        _FangJianTianKuCunInfo.F_SuoShuBuMenSN = _DingFangXiTongInfo.D_SuoShuBuMenSN;

        _FangJianTianKuCunInfo.F_ZhengJianJiaGe = Convert.ToDouble(Texx_FangJianJiaGe.Text);
        _FangJianTianKuCunInfo.F_TuiFangEndDate = DateTime.Parse(Texx_TuiFangEndDate.Text);
        _FangJianTianKuCunInfo.F_RuZhuStartDate = DateTime.Parse(Texx_RuZhuStartDate.Text);

        MyFangJianTianKuCun.Add(_FangJianTianKuCunInfo);

        RegisterClientScriptBlock("", "<script>alert('操作成功！'); </script>");
      

      
    }

    //情况所有TextBox
    public void CleartextBoxes(Control parent)
    {

        foreach (Control x in parent.Controls)
        {
            if ((x.GetType() == typeof(TextBox)))
            {
                ((TextBox)(x)).Text = "";
            }

            if (x.HasControls())
            {
                CleartextBoxes(x);
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
        this.Texx_DingFangXiTong.Items.Insert(0, new ListItem("请选择一个系统", "0"));//设置默认值
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
        this.Texx_BingGuan.Items.Insert(0, new ListItem("请选择一个宾馆", "0"));//设置默认值
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
        this.Texx_FangXing.Items.Insert(0, new ListItem("请选择一个房型", "0"));//设置默认值
    }


    public void FangJianDataBind(object sender, EventArgs e)
    {


        ///此方法是从一个datatable中select出一个新的datatable
        DataTable dtFangJian = MyFangJian.List();
        DataRow[] dtRows = dtFangJian.Select("F_SuoShuFangXingSN=" + Texx_FangXing.Text);

        DataTable NewDtFangJian = dtFangJian.Clone();
        NewDtFangJian.Clear();
        foreach (DataRow item in dtRows)
        {
            NewDtFangJian.Rows.Add(item.ItemArray);
        }

        this.Texx_FangJian.DataSource = NewDtFangJian;
        this.Texx_FangJian.DataTextField = "F_FangJianHao";
        this.Texx_FangJian.DataValueField = "F_SN";
        this.Texx_FangJian.DataBind();
    }







    //
    public static HashSet<string> DelSpiltChar(string input)
    {
        HashSet<string> retList = new HashSet<string>();
       
        string pattern = "(\\D+)|(\\W+)";
        foreach (string result in Regex.Split(input, pattern))
        {
            if (Regex.IsMatch(result, "^[0-9a-zA-Z]+$"))
            {
                retList.Add(result);
            }

        }

        return retList;
    }

}