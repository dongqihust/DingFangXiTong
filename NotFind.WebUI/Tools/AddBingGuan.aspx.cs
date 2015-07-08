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
        if(!IsPostBack){
            dropDingFangXiTongBind();
        }

    }

    protected void AddBinGuan(object sender, EventArgs e)
    {
        BingGuanInfo _BingGuanInfo = new BingGuanInfo();
        int DingFangXiTongSN = Convert.ToInt32(Texx_DingFangXiTong.Text);
        DingFangXiTongInfo _DingFangXiTongInfo = MyDingFangXiTong.Get(DingFangXiTongSN);
        _BingGuanInfo.B_SuoShuDingFangXiTongSN = _DingFangXiTongInfo.D_SN;
        _BingGuanInfo.B_SuoShuBuMenSN = _DingFangXiTongInfo.D_SuoShuBuMenSN;
        _BingGuanInfo.B_Name = Texx_BingGuanName.Text;
        _BingGuanInfo.B_AddDate = DateTime.Now;
        _BingGuanInfo.B_Address = Texx_Address.Text;
        _BingGuanInfo.B_Phone = Texx_Phone.Text;
        MyBingGuan.Add(_BingGuanInfo);
        RegisterClientScriptBlock("", "<script>alert('操作成功！');   window.location.href='AddBingGuan.aspx'</script>");
       
    }

    public void dropDingFangXiTongBind()
    {
        DataTable dtXiTong = MyDingFangXiTong.List();
        this.Texx_DingFangXiTong.DataSource = dtXiTong.DefaultView;
        this.Texx_DingFangXiTong.DataTextField = "D_Name";//设置option的text值
        this.Texx_DingFangXiTong.DataValueField = "D_SN";//设置option的value值
        this.Texx_DingFangXiTong.DataBind();
        //  this.Texx_DingFangXiTong.Items.Insert(0, new ListItem("请选择一个系统", "0"));//设置默认值
      
    }
}