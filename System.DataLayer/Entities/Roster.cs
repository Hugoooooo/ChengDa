using System.Framework.DataLayer;
using System.DataLayer.Base;
using System;

namespace System.DataLayer.Entities
{
    /// <summary>
    /// Account
    /// </summary>
    public class Roster : BaseEntity
    {
        #region Name Config
        public enum ncConditions { mobile,serno , sernolist }
        public enum ncFields { RST_SERNO, RST_MAIN,RST_NAME, RST_SEX, RST_PHONE1, RST_PHONE2, RST_MOBILE, RST_FAX, RST_ADDR, RST_COMMENT, RST_MODIFIEDDTTM, RST_MODIFIEDBY, RST_INSERTBY, RST_INSERTDTTM, RST_PRINCIPAL }
        #endregion
        #region Fields

        /// <summary>序號</summary>
        public string RST_SERNO = "";
        /// <summary>主要聯絡電話</summary>
        public string RST_MAIN = "";
        /// <summary>客戶姓名</summary>
        public string RST_NAME = "";
        /// <summary>客戶性別</summary>
        public string RST_SEX = "";
        /// <summary>住家電話1</summary>
        public string RST_PHONE1 = "";
        /// <summary>住家電話2</summary>
        public string RST_PHONE2 = "";
        /// <summary>手機</summary>
        public string RST_MOBILE = "";
        /// <summary>傳真</summary>
        public string RST_FAX = "";
        /// <summary>地址</summary>
        public string RST_ADDR = "";
        /// <summary>備註</summary>
        public string RST_COMMENT = "";
        /// <summary>負責人</summary>
        public string RST_PRINCIPAL = "";
        /// <summary>修改日期</summary>
        public DateTime RST_MODIFIEDDTTM;
        /// <summary>修改人員</summary>
        public string RST_MODIFIEDBY = "";
        /// <summary>新增日期</summary>
        public DateTime RST_INSERTDTTM;
        /// <summary>新增人員</summary>
        public string RST_INSERTBY = "";


        #endregion
        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="AConn">資料庫連接物件介面</param>
        public Roster(IConnection AConn)
            : base(AConn)
        {
            this.TableName = "ROSTER";
            base.addKey("RST_SERNO");
            this.ConditionDictionary["serno"] = " RST_SERNO = N'?' ";
            this.ConditionDictionary["sernolist"] = " RST_SERNO IN (?) ";
        }
    }
}
