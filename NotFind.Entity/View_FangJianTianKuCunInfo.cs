using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotFind.Entity
{
    public class View_FangJianTianKuCunInfo
    {
        private Int32 _F_BingGuanSN = 0;//
        private String _B_Name = "";//
        private Int32 _F_SuoShuXiTongSN = 0;//
        private String _D_Name = "";//
        private Int32 _F_FangXingSN = 0;//
        private String _F_FangJianHao = "";//
        private String _F_Name = "";//
        private Int32 _F_SN = 0;//
        private Int32 _F_SuoShuBuMenSN = 0;//
        private Int32 _F_FangJianSN = 0;//
        private DateTime _F_RuZhuStartDate = DateTime.Now;//
        private DateTime _F_TuiFangEndDate = DateTime.Now;//
        private Double _F_ZhengJianJiaGe = 0.0;//
        private Int32 _F_BaoLiuZhuangTai = 0;//
        private Boolean _F_ShiFouShanChu = false;//
        private DateTime _F_AddDate = DateTime.Now;//

        public View_FangJianTianKuCunInfo()
        {
            this._F_BingGuanSN = F_BingGuanSN;
            this._B_Name = B_Name;
            this._F_SuoShuXiTongSN = F_SuoShuXiTongSN;
            this._D_Name = D_Name;
            this._F_FangXingSN = F_FangXingSN;
            this._F_FangJianHao = F_FangJianHao;
            this._F_Name = F_Name;
            this._F_SN = F_SN;
            this._F_SuoShuBuMenSN = F_SuoShuBuMenSN;
            this._F_FangJianSN = F_FangJianSN;
            this._F_RuZhuStartDate = F_RuZhuStartDate;
            this._F_TuiFangEndDate = F_TuiFangEndDate;
            this._F_ZhengJianJiaGe = F_ZhengJianJiaGe;
            this._F_BaoLiuZhuangTai = F_BaoLiuZhuangTai;
            this._F_ShiFouShanChu = F_ShiFouShanChu;
            this._F_AddDate = F_AddDate;
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 F_BingGuanSN
        {
            get { return this._F_BingGuanSN; }
            set { this._F_BingGuanSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String B_Name
        {
            get { return this._B_Name; }
            set { this._B_Name = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 F_SuoShuXiTongSN
        {
            get { return this._F_SuoShuXiTongSN; }
            set { this._F_SuoShuXiTongSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String D_Name
        {
            get { return this._D_Name; }
            set { this._D_Name = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 F_FangXingSN
        {
            get { return this._F_FangXingSN; }
            set { this._F_FangXingSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String F_FangJianHao
        {
            get { return this._F_FangJianHao; }
            set { this._F_FangJianHao = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String F_Name
        {
            get { return this._F_Name; }
            set { this._F_Name = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 F_SN
        {
            get { return this._F_SN; }
            set { this._F_SN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 F_SuoShuBuMenSN
        {
            get { return this._F_SuoShuBuMenSN; }
            set { this._F_SuoShuBuMenSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 F_FangJianSN
        {
            get { return this._F_FangJianSN; }
            set { this._F_FangJianSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime F_RuZhuStartDate
        {
            get { return this._F_RuZhuStartDate; }
            set { this._F_RuZhuStartDate = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime F_TuiFangEndDate
        {
            get { return this._F_TuiFangEndDate; }
            set { this._F_TuiFangEndDate = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Double F_ZhengJianJiaGe
        {
            get { return this._F_ZhengJianJiaGe; }
            set { this._F_ZhengJianJiaGe = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 F_BaoLiuZhuangTai
        {
            get { return this._F_BaoLiuZhuangTai; }
            set { this._F_BaoLiuZhuangTai = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Boolean F_ShiFouShanChu
        {
            get { return this._F_ShiFouShanChu; }
            set { this._F_ShiFouShanChu = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime F_AddDate
        {
            get { return this._F_AddDate; }
            set { this._F_AddDate = value; }
        }
    }

}
