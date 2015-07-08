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

public partial class AddFangJianS : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
   
        if (!IsPostBack)
        {
            dropDingFangXiTongBind();

        }

    }

    protected void AddFangJian(object sender, EventArgs e)
    {
        //首先获取每一个房间号

        HashSet<string> FangJianHaos = DelSpiltChar(Texx_FangJianHao.Text);
        foreach(string FangJianHao in FangJianHaos){
            FangJianInfo _FangJianInfo = new FangJianInfo();
            _FangJianInfo.F_AddDate = DateTime.Now;

            _FangJianInfo.F_ZhengJianJiaGe = Convert.ToDouble(Texx_FangJianJiaGe.Text);
            _FangJianInfo.F_ChuangWei1JiaGe = Convert.ToDouble(Texx_ChuangWei1JiaGe.Text);
            _FangJianInfo.F_ChuangWei2JiaGe = Convert.ToDouble(Texx_ChuangWei2JiaGe.Text);
            _FangJianInfo.F_ChuangWei3JiaGe = Convert.ToDouble(Texx_ChuangWei3JiaGe.Text);
            _FangJianInfo.F_ChuangWei4JiaGe = Convert.ToDouble(Texx_ChuangWei4JiaGe.Text);
            _FangJianInfo.F_ChuangWei5JiaGe = Convert.ToDouble(Texx_ChuangWei5JiaGe.Text);

            _FangJianInfo.F_Detail = Texx_FangJianBeiZhu.Text;
            _FangJianInfo.F_FangJianHao = FangJianHao;
            _FangJianInfo.F_SuoShuFangXingSN = Convert.ToInt32(Texx_FangXing.Text);
            MyFangJian.Add(_FangJianInfo);
        }
        RegisterClientScriptBlock("", "<script>alert('操作成功！'); </script>");
        CleartextBoxes(this);

      
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