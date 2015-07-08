using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotFind.Business;
using NotFind.Entity;


public partial class KuCunTianList : System.Web.UI.Page
{
  

    protected void Page_Load(object sender, EventArgs e)
    {
        
           if(!IsPostBack)
           {
               KuCunTianDataBind();
               
           }
       
        
    }


    protected void KuCunTianDataBind()
    {
        this.Griw_List.DataSource = MyView_FangJianTianKuCun.List();
        this.Griw_List.DataBind();
       
    }

    //点击拆房时候执行的操作
    protected void Butn_ChaiFang_Click(object sender, EventArgs e)
    {
       
        for (int g = 0; g < this.Griw_List.Rows.Count; g++)
        {
            CheckBox _CheckBox = (CheckBox)this.Griw_List.Rows[g].FindControl("Chex_Selete");
            if (_CheckBox.Checked)
            {
                //获取要删除的SN，并将其是否删除状态置为1
                Label SN = (Label)this.Griw_List.Rows[g].FindControl("Labl_CSN");
                FangJianTianKuCunInfo _FangJianTianKuCunInfo = MyFangJianTianKuCun.Get(Convert.ToInt32(SN.Text));
                int FangJianNum = Convert.ToInt32(Texx_FangJianNum.Text);
                for (int i = 1; i <= FangJianNum;i++ )
                {
                    ChuangWeiKuCunInfo _ChuangWeiKuCunInfo = new ChuangWeiKuCunInfo();
                    _ChuangWeiKuCunInfo.C_AddDate = DateTime.Now;
                    _ChuangWeiKuCunInfo.C_BaoLiuZhuangTai = _FangJianTianKuCunInfo.F_BaoLiuZhuangTai;
                    _ChuangWeiKuCunInfo.C_ChuangWei1JiaGe = Convert.ToDouble(Texx_MeiJianJianGe.Text);
                    _ChuangWeiKuCunInfo.C_BingGuanSN = _FangJianTianKuCunInfo.F_BingGuanSN;
                    _ChuangWeiKuCunInfo.C_FangJianSN = _FangJianTianKuCunInfo.F_FangJianSN;
                    _ChuangWeiKuCunInfo.C_RuZhuStartDate = _FangJianTianKuCunInfo.F_RuZhuStartDate;
                    _ChuangWeiKuCunInfo.C_TuiFangEndDate = _FangJianTianKuCunInfo.F_TuiFangEndDate;
                    _ChuangWeiKuCunInfo.C_SuoShuXiTongSN = _FangJianTianKuCunInfo.F_SuoShuXiTongSN;
                    _ChuangWeiKuCunInfo.C_SuoShuBuMenSN = _FangJianTianKuCunInfo.F_SuoShuBuMenSN;
                    _ChuangWeiKuCunInfo.C_FangXingSN = _FangJianTianKuCunInfo.F_FangXingSN;
                    _ChuangWeiKuCunInfo.C_ChuangWeiHao = i;
                    MyChuangWeiKuCun.Add(_ChuangWeiKuCunInfo);
                }
                _FangJianTianKuCunInfo.F_ShiFouShanChu = true;
                MyFangJianTianKuCun.Set(_FangJianTianKuCunInfo);

            }
        }
        KuCunTianDataBind();
       
    }


}