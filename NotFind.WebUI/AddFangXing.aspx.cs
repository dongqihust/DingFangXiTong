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
public partial class FangXingAdd : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
   
        if (!IsPostBack)
        {
            dropDingFangXiTongBind();

        }

    }

    protected void AddFangXing(object sender, EventArgs e)
    {
        FangXingInfo _FangXingInfo = new FangXingInfo();
        _FangXingInfo.F_AddDate = DateTime.Now;


        _FangXingInfo.F_ZhengJianJiaGe = Convert.ToDouble(Texx_FangXingJiaGe.Text);
        _FangXingInfo.F_ChuangWei1JiaGe = Convert.ToDouble(Texx_ChuangWei1JiaGe.Text);
        _FangXingInfo.F_ChuangWei2JiaGe = Convert.ToDouble(Texx_ChuangWei2JiaGe.Text);
        _FangXingInfo.F_ChuangWei3JiaGe = Convert.ToDouble(Texx_ChuangWei3JiaGe.Text);
        _FangXingInfo.F_ChuangWei4JiaGe = Convert.ToDouble(Texx_ChuangWei4JiaGe.Text);
        _FangXingInfo.F_ChuangWei5JiaGe = Convert.ToDouble(Texx_ChuangWei5JiaGe.Text);



        _FangXingInfo.F_Detail = Texx_FangXingDetail.Text;
        _FangXingInfo.F_Name = Texx_FangXingName.Text;
        _FangXingInfo.F_SuoShuBingGuanSN = Convert.ToInt32(Texx_BingGuan.Text);

        int DingFangXiTongSN = Convert.ToInt32(Texx_DingFangXiTong.Text);
        DingFangXiTongInfo _DingFangXiTongInfo = MyDingFangXiTong.Get(DingFangXiTongSN);
        _FangXingInfo.F_SuoShuXiTongSN = _DingFangXiTongInfo.D_SN;
        _FangXingInfo.F_SuoShuBuMenSN = _DingFangXiTongInfo.D_SuoShuBuMenSN;
        MyFangXing.Add(_FangXingInfo);

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
    }

}