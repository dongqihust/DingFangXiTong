using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotFind.Entity
{
    public class ChuangWeiKuCunInfo
    {
        private Int32 _C_SN = 0;//
        private Int32 _C_SuoShuBuMenSN = 0;//
        private Int32 _C_SuoShuXiTongSN = 0;//
        private Int32 _C_BingGuanSN = 0;//
        private Int32 _C_FangXingSN = 0;//
        private Int32 _C_FangJianSN = 0;//
        private Int32 _C_ChuangWeiHao = 0;//
        private DateTime _C_RuZhuStartDate = DateTime.Now;//
        private DateTime _C_TuiFangEndDate = DateTime.Now;//
        private Double _C_ChuangWei1JiaGe = 0.0;//
        private Double _C_ChuangWei2JiaGe = 0.0;//
        private Double _C_ChuangWei3JiaGe = 0.0;//
        private Double _C_ChuangWei4JiaGe = 0.0;//
        private Double _C_ChuangWei5JiaGe = 0.0;//
        private Int32 _C_BaoLiuZhuangTai = 0;//
        private Boolean _C_ShiFouShanChu = false;//
        private DateTime _C_AddDate = DateTime.Now;//

        public ChuangWeiKuCunInfo()
        {
            this._C_SN = C_SN;
            this._C_SuoShuBuMenSN = C_SuoShuBuMenSN;
            this._C_SuoShuXiTongSN = C_SuoShuXiTongSN;
            this._C_BingGuanSN = C_BingGuanSN;
            this._C_FangXingSN = C_FangXingSN;
            this._C_FangJianSN = C_FangJianSN;
            this._C_ChuangWeiHao = C_ChuangWeiHao;
            this._C_RuZhuStartDate = C_RuZhuStartDate;
            this._C_TuiFangEndDate = C_TuiFangEndDate;
            this._C_ChuangWei1JiaGe = C_ChuangWei1JiaGe;
            this._C_ChuangWei2JiaGe = C_ChuangWei2JiaGe;
            this._C_ChuangWei3JiaGe = C_ChuangWei3JiaGe;
            this._C_ChuangWei4JiaGe = C_ChuangWei4JiaGe;
            this._C_ChuangWei5JiaGe = C_ChuangWei5JiaGe;
            this._C_BaoLiuZhuangTai = C_BaoLiuZhuangTai;
            this._C_ShiFouShanChu = C_ShiFouShanChu;
            this._C_AddDate = C_AddDate;
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 C_SN
        {
            get { return this._C_SN; }
            set { this._C_SN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 C_SuoShuBuMenSN
        {
            get { return this._C_SuoShuBuMenSN; }
            set { this._C_SuoShuBuMenSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 C_SuoShuXiTongSN
        {
            get { return this._C_SuoShuXiTongSN; }
            set { this._C_SuoShuXiTongSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 C_BingGuanSN
        {
            get { return this._C_BingGuanSN; }
            set { this._C_BingGuanSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 C_FangXingSN
        {
            get { return this._C_FangXingSN; }
            set { this._C_FangXingSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 C_FangJianSN
        {
            get { return this._C_FangJianSN; }
            set { this._C_FangJianSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 C_ChuangWeiHao
        {
            get { return this._C_ChuangWeiHao; }
            set { this._C_ChuangWeiHao = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime C_RuZhuStartDate
        {
            get { return this._C_RuZhuStartDate; }
            set { this._C_RuZhuStartDate = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime C_TuiFangEndDate
        {
            get { return this._C_TuiFangEndDate; }
            set { this._C_TuiFangEndDate = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Double C_ChuangWei1JiaGe
        {
            get { return this._C_ChuangWei1JiaGe; }
            set { this._C_ChuangWei1JiaGe = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Double C_ChuangWei2JiaGe
        {
            get { return this._C_ChuangWei2JiaGe; }
            set { this._C_ChuangWei2JiaGe = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Double C_ChuangWei3JiaGe
        {
            get { return this._C_ChuangWei3JiaGe; }
            set { this._C_ChuangWei3JiaGe = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Double C_ChuangWei4JiaGe
        {
            get { return this._C_ChuangWei4JiaGe; }
            set { this._C_ChuangWei4JiaGe = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Double C_ChuangWei5JiaGe
        {
            get { return this._C_ChuangWei5JiaGe; }
            set { this._C_ChuangWei5JiaGe = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 C_BaoLiuZhuangTai
        {
            get { return this._C_BaoLiuZhuangTai; }
            set { this._C_BaoLiuZhuangTai = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Boolean C_ShiFouShanChu
        {
            get { return this._C_ShiFouShanChu; }
            set { this._C_ShiFouShanChu = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime C_AddDate
        {
            get { return this._C_AddDate; }
            set { this._C_AddDate = value; }
        }
    }

}
