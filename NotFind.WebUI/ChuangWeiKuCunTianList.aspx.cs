using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotFind.Business;
using NotFind.Entity;


public partial class ChuangWeiKuCunTianList : System.Web.UI.Page
{
  

    protected void Page_Load(object sender, EventArgs e)
    {
        
           if(!IsPostBack)
           {
               ChuangWeiKuCunTianDataBind();
               
           }
       
        
    }


    protected void ChuangWeiKuCunTianDataBind()
    {
        this.Griw_List.DataSource = MyView_ChuangWeiKuCun.List();
        this.Griw_List.DataBind();
       
    }

  


}