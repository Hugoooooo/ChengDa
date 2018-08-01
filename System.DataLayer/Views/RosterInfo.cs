using System;
using System.Framework.DataLayer;

namespace System.DataLayer.Views
{
    /// <summary>
    /// Account 的摘要描述。
    /// </summary>
    public class RosterInfo : BaseView
    {
        #region Name Config
        public enum ncConditions { serno, main,mobile, name, address, phoneLike, createSDTTM, createEDTTM, modifySDTTM, modifyEDTTM }
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

        public RosterInfo(IConnection AConn)
            : base(AConn)
        {
            base.Fields = @"RST_SERNO,RST_NAME,RST_MAIN,RST_SEX,RST_PHONE1,RST_PHONE2,RST_MOBILE,RST_FAX,RST_ADDR,RST_COMMENT,RST_MODIFIEDDTTM,RST_MODIFIEDBY,RST_INSERTBY,RST_INSERTDTTM,RST_PRINCIPAL";
            base.From = "ROSTER";
            base.OrderBy = "RST_MODIFIEDDTTM desc";
            base.ConditionDictionary.Add("serno", " RST_SERNO = N'?' ");
            base.ConditionDictionary.Add("main", " RST_MAIN = N'?' ");
            base.ConditionDictionary.Add("mobile", " RST_MOBILE like N'%?%' ");
            base.ConditionDictionary.Add("name", " RST_NAME like N'%?%' ");
            base.ConditionDictionary.Add("address", " RST_ADDR like N'%?%' ");
            base.ConditionDictionary.Add("phoneLike", " (RST_PHONE1 LIKE N'%?%' OR RST_PHONE2 LIKE N'%?%' OR RST_MOBILE LIKE N'%?%') ");
            base.ConditionDictionary.Add("createSDTTM", " left(RST_INSERTDTTM,10) >= N'?'");
            base.ConditionDictionary.Add("createEDTTM", " left(RST_INSERTDTTM,10) <= N'?'");
            base.ConditionDictionary.Add("modifySDTTM", " left(RST_MODIFIEDDTTM,10) >= N'?'");
            base.ConditionDictionary.Add("modifyEDTTM", " left(RST_MODIFIEDDTTM,10) <= N'?'");
        }
       

    }

}
