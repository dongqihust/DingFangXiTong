using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotFind.Entity
{
    public class DingDanInfo
    {
        private Int32 _D_SN = 0;//
        private Int32 _D_SuoShuBuMenSN = 0;//
        private Int32 _D_SuoShuXiTongSN = 0;//
        private String _D_TiJiaoRenName = "";//
        private Int32 _D_TiJiaoRenSN = 0;//
        private Int32 _D_TiJiaoSuoShuBanJiSN = 0;//
        private String _D_TiJiaoRenKaoShiHao = "";//
        private DateTime _D_AddDate = DateTime.Now;//
        private String _D_AddIP = "";//
        private String _D_LianXiRen = "";//
        private String _D_LianXiPhone = "";//
        private String _D_LianXiMail = "";//
        private Int32 _D_Style = 0;//
        private Double _D_JiaGe = 0.0;//
        private Int32 _D_ZhuangTai = 0;//
        private Boolean _D_ShiFouShanChu = false;//

        public DingDanInfo()
        {
            this._D_SN = D_SN;
            this._D_SuoShuBuMenSN = D_SuoShuBuMenSN;
            this._D_SuoShuXiTongSN = D_SuoShuXiTongSN;
            this._D_TiJiaoRenName = D_TiJiaoRenName;
            this._D_TiJiaoRenSN = D_TiJiaoRenSN;
            this._D_TiJiaoSuoShuBanJiSN = D_TiJiaoSuoShuBanJiSN;
            this._D_TiJiaoRenKaoShiHao = D_TiJiaoRenKaoShiHao;
            this._D_AddDate = D_AddDate;
            this._D_AddIP = D_AddIP;
            this._D_LianXiRen = D_LianXiRen;
            this._D_LianXiPhone = D_LianXiPhone;
            this._D_LianXiMail = D_LianXiMail;
            this._D_Style = D_Style;
            this._D_JiaGe = D_JiaGe;
            this._D_ZhuangTai = D_ZhuangTai;
            this._D_ShiFouShanChu = D_ShiFouShanChu;
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 D_SN
        {
            get { return this._D_SN; }
            set { this._D_SN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 D_SuoShuBuMenSN
        {
            get { return this._D_SuoShuBuMenSN; }
            set { this._D_SuoShuBuMenSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 D_SuoShuXiTongSN
        {
            get { return this._D_SuoShuXiTongSN; }
            set { this._D_SuoShuXiTongSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String D_TiJiaoRenName
        {
            get { return this._D_TiJiaoRenName; }
            set { this._D_TiJiaoRenName = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 D_TiJiaoRenSN
        {
            get { return this._D_TiJiaoRenSN; }
            set { this._D_TiJiaoRenSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 D_TiJiaoSuoShuBanJiSN
        {
            get { return this._D_TiJiaoSuoShuBanJiSN; }
            set { this._D_TiJiaoSuoShuBanJiSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String D_TiJiaoRenKaoShiHao
        {
            get { return this._D_TiJiaoRenKaoShiHao; }
            set { this._D_TiJiaoRenKaoShiHao = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime D_AddDate
        {
            get { return this._D_AddDate; }
            set { this._D_AddDate = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String D_AddIP
        {
            get { return this._D_AddIP; }
            set { this._D_AddIP = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String D_LianXiRen
        {
            get { return this._D_LianXiRen; }
            set { this._D_LianXiRen = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String D_LianXiPhone
        {
            get { return this._D_LianXiPhone; }
            set { this._D_LianXiPhone = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String D_LianXiMail
        {
            get { return this._D_LianXiMail; }
            set { this._D_LianXiMail = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 D_Style
        {
            get { return this._D_Style; }
            set { this._D_Style = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Double D_JiaGe
        {
            get { return this._D_JiaGe; }
            set { this._D_JiaGe = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 D_ZhuangTai
        {
            get { return this._D_ZhuangTai; }
            set { this._D_ZhuangTai = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Boolean D_ShiFouShanChu
        {
            get { return this._D_ShiFouShanChu; }
            set { this._D_ShiFouShanChu = value; }
        }
    }

}
