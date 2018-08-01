using System;
using System.Framework.DataLayer;

namespace System.DataLayer.Views
{
    /// <summary>
    /// Account ���K�n�y�z�C
    /// </summary>
    public class RosterInfo : BaseView
    {
        #region Name Config
        public enum ncConditions { serno, main,mobile, name, address, phoneLike, createSDTTM, createEDTTM, modifySDTTM, modifyEDTTM }
        public enum ncFields { RST_SERNO, RST_MAIN,RST_NAME, RST_SEX, RST_PHONE1, RST_PHONE2, RST_MOBILE, RST_FAX, RST_ADDR, RST_COMMENT, RST_MODIFIEDDTTM, RST_MODIFIEDBY, RST_INSERTBY, RST_INSERTDTTM, RST_PRINCIPAL }
        #endregion

        #region Fields

        /// <summary>�Ǹ�</summary>
        public string RST_SERNO = "";
        /// <summary>�D�n�p���q��</summary>
        public string RST_MAIN = "";
        /// <summary>�Ȥ�m�W</summary>
        public string RST_NAME = "";
        /// <summary>�Ȥ�ʧO</summary>
        public string RST_SEX = "";
        /// <summary>��a�q��1</summary>
        public string RST_PHONE1 = "";
        /// <summary>��a�q��2</summary>
        public string RST_PHONE2 = "";
        /// <summary>���</summary>
        public string RST_MOBILE = "";
        /// <summary>�ǯu</summary>
        public string RST_FAX = "";
        /// <summary>�a�}</summary>
        public string RST_ADDR = "";
        /// <summary>�Ƶ�</summary>
        public string RST_COMMENT = "";
        /// <summary>�t�d�H</summary>
        public string RST_PRINCIPAL = "";
        /// <summary>�ק���</summary>
        public DateTime RST_MODIFIEDDTTM;
        /// <summary>�ק�H��</summary>
        public string RST_MODIFIEDBY = "";
        /// <summary>�s�W���</summary>
        public DateTime RST_INSERTDTTM;
        /// <summary>�s�W�H��</summary>
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
