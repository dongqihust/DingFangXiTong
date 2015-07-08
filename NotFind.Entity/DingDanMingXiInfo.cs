using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotFind.Entity
{
    public class DingDanMingXiInfo
    {
        private Int32 _D_SN = 0;//
        private Int32 _D_SuoShuDingDanSN = 0;//
        private Int32 _D_SuoShuBuMenSN = 0;//
        private Int32 _D_SuoShuXiTongSN = 0;//
        private Int32 _D_SuoShuFangJianTian = 0;//
        private Int32 _D_SuoShuChuangWeiTian = 0;//
        private DateTime _D_AddDate = DateTime.Now;//
        private Boolean _D_ShiFouShanChu = false;//

        public DingDanMingXiInfo()
        {
            this._D_SN = D_SN;
            this._D_SuoShuDingDanSN = D_SuoShuDingDanSN;
            this._D_SuoShuBuMenSN = D_SuoShuBuMenSN;
            this._D_SuoShuXiTongSN = D_SuoShuXiTongSN;
            this._D_SuoShuFangJianTian = D_SuoShuFangJianTian;
            this._D_SuoShuChuangWeiTian = D_SuoShuChuangWeiTian;
            this._D_AddDate = D_AddDate;
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
        public Int32 D_SuoShuDingDanSN
        {
            get { return this._D_SuoShuDingDanSN; }
            set { this._D_SuoShuDingDanSN = value; }
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
        public Int32 D_SuoShuFangJianTian
        {
            get { return this._D_SuoShuFangJianTian; }
            set { this._D_SuoShuFangJianTian = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 D_SuoShuChuangWeiTian
        {
            get { return this._D_SuoShuChuangWeiTian; }
            set { this._D_SuoShuChuangWeiTian = value; }
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
        public Boolean D_ShiFouShanChu
        {
            get { return this._D_ShiFouShanChu; }
            set { this._D_ShiFouShanChu = value; }
        }
    }

}
