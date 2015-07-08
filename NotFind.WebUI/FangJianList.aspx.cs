using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotFind.Business;
using NotFind.Entity;


public partial class FangJianList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Griw_List.DataSource = MyFangJian.List();
        this.Griw_List.DataBind();
    }
}