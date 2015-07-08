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
public partial class BingGuanAdd : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
   
        if (!IsPostBack)
        {
            dropDingFangXiTongBind();
        }

    }

    protected void AddBingGuan(object sender, EventArgs e)
    {
        BingGuanInfo _BingGuanInfo = new BingGuanInfo();
        _BingGuanInfo.B_AddDate = DateTime.Now;
        _BingGuanInfo.B_Address = Texx_Address.Text;
        _BingGuanInfo.B_Name = Texx_Name.Text;
        _BingGuanInfo.B_Phone = Texx_Phone.Text;

        Int32 XiTongSN = Convert.ToInt32(Texx_DingFangXiTong.Text);
        DingFangXiTongInfo _DingFangXiTongInfo = MyDingFangXiTong.Get(XiTongSN);
        _BingGuanInfo.B_SuoShuDingFangXiTongSN = XiTongSN;
        _BingGuanInfo.B_SuoShuBuMenSN = _DingFangXiTongInfo.D_SuoShuBuMenSN;

        MyBingGuan.Add(_BingGuanInfo);

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

    

}