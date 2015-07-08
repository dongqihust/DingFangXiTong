using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotFind.Entity
{
    public class BingGuanInfo
    {
        private Int32 _B_SN = 0;//
        private Int32 _B_SuoShuBuMenSN = 0;//
        private Int32 _B_SuoShuDingFangXiTongSN = 0;//
        private String _B_Name = "";//
        private String _B_Address = "";//
        private String _B_Phone = "";//
        private Boolean _B_ShiFouShanChu = false;//
        private DateTime _B_AddDate = DateTime.Now;//

        public BingGuanInfo()
        {
            this._B_SN = B_SN;
            this._B_SuoShuBuMenSN = B_SuoShuBuMenSN;
            this._B_SuoShuDingFangXiTongSN = B_SuoShuDingFangXiTongSN;
            this._B_Name = B_Name;
            this._B_Address = B_Address;
            this._B_Phone = B_Phone;
            this._B_ShiFouShanChu = B_ShiFouShanChu;
            this._B_AddDate = B_AddDate;
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 B_SN
        {
            get { return this._B_SN; }
            set { this._B_SN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 B_SuoShuBuMenSN
        {
            get { return this._B_SuoShuBuMenSN; }
            set { this._B_SuoShuBuMenSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Int32 B_SuoShuDingFangXiTongSN
        {
            get { return this._B_SuoShuDingFangXiTongSN; }
            set { this._B_SuoShuDingFangXiTongSN = value; }
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
        public String B_Address
        {
            get { return this._B_Address; }
            set { this._B_Address = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String B_Phone
        {
            get { return this._B_Phone; }
            set { this._B_Phone = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Boolean B_ShiFouShanChu
        {
            get { return this._B_ShiFouShanChu; }
            set { this._B_ShiFouShanChu = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime B_AddDate
        {
            get { return this._B_AddDate; }
            set { this._B_AddDate = value; }
        }
    }

}
