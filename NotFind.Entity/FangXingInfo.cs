using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotFind.Entity
{
    public class FangXingInfo
    {
        private Int32 _F_SN = 0;//
        private Int32 _F_SuoShuBuMenSN = 0;//
        private Int32 _F_SuoShuXiTongSN = 0;//
        private Int32 _F_SuoShuBingGuanSN = 0;//
        private String _F_Name = "";//
        private String _F_Detail = "";//
        private Double _F_ZhengJianJiaGe = 0.0;//
        private Double _F_ChuangWei1JiaGe = 0.0;//
        private Double _F_ChuangWei2JiaGe = 0.0;//
        private Double _F_ChuangWei3JiaGe = 0.0;//
        private Double _F_ChuangWei4JiaGe = 0.0;//
        private Double _F_ChuangWei5JiaGe = 0.0;//
        private Boolean _F_ShiFouShanChu = false;//
        private DateTime _F_AddDate = DateTime.Now;//

        public FangXingInfo()
        {
            this._F_SN = F_SN;
            this._F_SuoShuBuMenSN = F_SuoShuBuMenSN;
            this._F_SuoShuXiTongSN = F_SuoShuXiTongSN;
            this._F_SuoShuBingGuanSN = F_SuoShuBingGuanSN;
            this._F_Name = F_Name;
            this._F_Detail = F_Detail;
            this._F_ZhengJianJiaGe = F_ZhengJianJiaGe;
            this._F_ChuangWei1JiaGe = F_ChuangWei1JiaGe;
            this._F_ChuangWei2JiaGe = F_ChuangWei2JiaGe;
            this._F_ChuangWei3JiaGe = F_ChuangWei3JiaGe;
            this._F_ChuangWei4JiaGe = F_ChuangWei4JiaGe;
            this._F_ChuangWei5JiaGe = F_ChuangWei5JiaGe;
            this._F_ShiFouShanChu = F_ShiFouShanChu;
            this._F_AddDate = F_AddDate;
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
        public Int32 F_SuoShuXiTongSN
        {
            get { return this._F_SuoShuXiTongSN; }
            set { this._F_SuoShuXiTongSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 F_SuoShuBingGuanSN
        {
            get { return this._F_SuoShuBingGuanSN; }
            set { this._F_SuoShuBingGuanSN = value; }
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
        public String F_Detail
        {
            get { return this._F_Detail; }
            set { this._F_Detail = value; }
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
        public Double F_ChuangWei1JiaGe
        {
            get { return this._F_ChuangWei1JiaGe; }
            set { this._F_ChuangWei1JiaGe = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Double F_ChuangWei2JiaGe
        {
            get { return this._F_ChuangWei2JiaGe; }
            set { this._F_ChuangWei2JiaGe = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Double F_ChuangWei3JiaGe
        {
            get { return this._F_ChuangWei3JiaGe; }
            set { this._F_ChuangWei3JiaGe = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Double F_ChuangWei4JiaGe
        {
            get { return this._F_ChuangWei4JiaGe; }
            set { this._F_ChuangWei4JiaGe = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Double F_ChuangWei5JiaGe
        {
            get { return this._F_ChuangWei5JiaGe; }
            set { this._F_ChuangWei5JiaGe = value; }
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
