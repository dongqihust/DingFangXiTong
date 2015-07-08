using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotFind.Entity
{
    public class DingFangXiTongInfo
    {
        private Int32 _D_SN = 0;//
        private Int32 _D_SuoShuBuMenSN = 0;//
        private String _D_Name = "";//
        private String _D_BanJiSNs = "";//
        private DateTime _D_AddDate = DateTime.Now;//
        private Boolean _D_ShiFouShanChu = false;//

        public DingFangXiTongInfo()
        {
            this._D_SN = D_SN;
            this._D_SuoShuBuMenSN = D_SuoShuBuMenSN;
            this._D_Name = D_Name;
            this._D_BanJiSNs = D_BanJiSNs;
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
        public Int32 D_SuoShuBuMenSN
        {
            get { return this._D_SuoShuBuMenSN; }
            set { this._D_SuoShuBuMenSN = value; }
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
        public String D_BanJiSNs
        {
            get { return this._D_BanJiSNs; }
            set { this._D_BanJiSNs = value; }
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
