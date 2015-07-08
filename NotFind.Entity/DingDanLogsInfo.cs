using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotFind.Entity
{
    public class DingDanLogsInfo
    {
        private Int32 _D_SN = 0;//
        private Int32 _D_DingDanSN = 0;//
        private String _D_DingDanShuoMing = "";//
        private String _D_AddIP = "";//
        private DateTime _D_AddDate = DateTime.Now;//

        public DingDanLogsInfo()
        {
            this._D_SN = D_SN;
            this._D_DingDanSN = D_DingDanSN;
            this._D_DingDanShuoMing = D_DingDanShuoMing;
            this._D_AddIP = D_AddIP;
            this._D_AddDate = D_AddDate;
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
        public Int32 D_DingDanSN
        {
            get { return this._D_DingDanSN; }
            set { this._D_DingDanSN = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String D_DingDanShuoMing
        {
            get { return this._D_DingDanShuoMing; }
            set { this._D_DingDanShuoMing = value; }
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
        public DateTime D_AddDate
        {
            get { return this._D_AddDate; }
            set { this._D_AddDate = value; }
        }
    }

}
