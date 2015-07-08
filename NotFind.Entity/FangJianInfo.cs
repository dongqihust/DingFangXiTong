using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotFind.Entity
{
    public class FangJianInfo
    {
        private Int32 _F_SN = 0;//
        private Int32 _F_SuoShuFangXingSN = 0;//
        private String _F_FangJianHao = "";//
        private Double _F_ZhengJianJiaGe; //
        private Double _F_ChuangWei1JiaGe;//
        private Double _F_ChuangWei2JiaGe;//
        private Double _F_ChuangWei3JiaGe;//
        private Double _F_ChuangWei4JiaGe;//
        private Double _F_ChuangWei5JiaGe;//
        private String _F_Detail = "";//
        private DateTime _F_AddDate = DateTime.Now;//
        private Boolean _F_ShiFouShanChu = false;//

        public FangJianInfo()
        {
            this._F_SN = F_SN;
            this._F_SuoShuFangXingSN = F_SuoShuFangXingSN;
            this._F_FangJianHao = F_FangJianHao;
            this._F_ZhengJianJiaGe = F_ZhengJianJiaGe;
            this._F_ChuangWei1JiaGe = F_ChuangWei1JiaGe;
            this._F_ChuangWei2JiaGe = F_ChuangWei2JiaGe;
            this._F_ChuangWei3JiaGe = F_ChuangWei3JiaGe;
            this._F_ChuangWei4JiaGe = F_ChuangWei4JiaGe;
            this._F_ChuangWei5JiaGe = F_ChuangWei5JiaGe;
            this._F_Detail = F_Detail;
            this._F_AddDate = F_AddDate;
            this._F_ShiFouShanChu = F_ShiFouShanChu;
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
        public Int32 F_SuoShuFangXingSN
        {
            get { return this._F_SuoShuFangXingSN; }
            set { this._F_SuoShuFangXingSN = value; }
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
        public String F_Detail
        {
            get { return this._F_Detail; }
            set { this._F_Detail = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime F_AddDate
        {
            get { return this._F_AddDate; }
            set { this._F_AddDate = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Boolean F_ShiFouShanChu
        {
            get { return this._F_ShiFouShanChu; }
            set { this._F_ShiFouShanChu = value; }
        }
    }

}
