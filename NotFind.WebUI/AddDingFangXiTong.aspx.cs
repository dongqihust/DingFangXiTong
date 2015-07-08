using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotFind.Business;
using NotFind.Entity;

public partial class AddXiTong : System.Web.UI.Page
{

    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void AddDingFangXiTong(object sender, EventArgs e)
    {
         DingFangXiTongInfo _DingFangXiTongInfo = new DingFangXiTongInfo();
        _DingFangXiTongInfo.D_AddDate = DateTime.Now;
        _DingFangXiTongInfo.D_BanJiSNs = Texx_BanJiSNs.Text;
        _DingFangXiTongInfo.D_Name = Texx_DingFangXiTongName.Text;
        _DingFangXiTongInfo.D_SuoShuBuMenSN = Convert.ToInt32(Texx_BuMenSN.Text);
        MyDingFangXiTong.Add(_DingFangXiTongInfo);
        RegisterClientScriptBlock("", "<script>alert('操作成功！');   window.location.href='AddDingFangXiTong.aspx'</script>");
        Texx_BuMenSN.Text = "";
        Texx_BanJiSNs.Text = "";
        
       
      
    }
}