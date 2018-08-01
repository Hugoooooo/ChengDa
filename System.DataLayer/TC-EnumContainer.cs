using System;

namespace EASONTECH.Outbound.DataLayer
{
    //規則: 欄位名稱(不用資料表前置碼及底線) + "Type"


    /// <summary>
    /// 保費計算方式
    /// </summary>
    public class PlanComposeRateUseType
    {
        /// <summary>固定保費</summary>
        public static string Fix			= "0";
        /// <summary>非固定費率</summary>
        public static string NotFix			= "1";
        /// <summary>非定額組合</summary>
        public static string NotFixCompose	= "2";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "固定保費";	
                case "1":	return "非固定費率";	
                case "2":	return "非定額組合";	
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 費率指標因子使用類型
    /// </summary>
    public class PlanRateUseType
    {
        /// <summary>繳費年期</summary>
        public static string P		= "A";
        /// <summary>繳費年期 + 職業等級</summary>
        public static string PV		= "B";
        /// <summary>繳費年期 + 年齡 + 性別</summary>
        public static string PAS	= "C";
        /// <summary>繳費年期 + 職業等級 +  年齡 + 性別</summary>
        public static string PVAS	= "D";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "繳費年期";	
                case "B":	return "繳費年期 + 職業等級";	
                case "C":	return "繳費年期 + 年齡 + 性別";	
                case "D":	return "繳費年期 + 職業等級 +  年齡 + 性別";	
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 費率指標因子不使用
    /// </summary>
    public class PlanRateNoUseType
    {
        /// <summary>不使用</summary>
        public static string VocationLevelNoUse		= "0";
        /// <summary>不使用</summary>
        public static string AgeNoUse		= "0";
        /// <summary>不使用</summary>
        public static string SexNoUse		= "";
        /// <summary>不使用</summary>
        public static string PlanRateNoUse	= "";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "不使用";	
                case "":	return "不使用";	
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 職業等級
    /// </summary>
    public class VocationLevelType
    {
        /// <summary>拒保</summary>
        public static string Refuse		= "7";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "7":	return "拒保";	
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 電話名稱類型
    /// </summary>
    public class DefaultProductCategoryNameType
    {
        /// <summary>市調問卷</summary>
        public static string Inquire		= "A";
        /// <summary>商品組合</summary>
        public static string ProductCombo	= "B";
        /// <summary>險種組合</summary>
        public static string ProductPlan	= "C";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "市調問卷";	
                case "B":	return "商品組合";
                case "C":	return "險種組合";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 電話類型
    /// </summary>
    public class PhoneType
    {
        /// <summary>家庭</summary>
        public static string Home		= "A";
        /// <summary>公司</summary>
        public static string Company	= "B";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "家庭";	
                case "B":	return "公司";
                default:	return "";
            }
        }

        /// <summary>
        /// 依欄位值取得欄位說明簡稱
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldCommentSimple(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "(家)";	
                case "B":	return "(公)";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 電話名稱類型
    /// </summary>
    public class TelNameType
    {
        /// <summary>電話一(日) 工具頁</summary>
        public static string PHONE1		= "A";
        /// <summary>電話二(夜) 工具頁</summary>
        public static string PHONE2		= "B";
        /// <summary>電話三(其) 工具頁</summary>
        public static string PHONE3		= "C";
        /// <summary>手機一 工具頁</summary>
        public static string MOBILE1	= "D";
        /// <summary>手機二 工具頁</summary>
        public static string MOBILE2	= "E";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "電話一(日)";	
                case "B":	return "電話二(夜)";
                case "C":	return "電話三(其)";
                case "D":	return "手機一";
                case "E":	return "手機二";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 活動工具頁類型
    /// </summary>
    public class CampaignToolTypes
    {
        /// <summary>活動說明 工具頁</summary>
        public static string ToolDocument	= "A";
        /// <summary>行銷話術 工具頁</summary>
        public static string ToolWordFlow	= "B";
        /// <summary>Q&A 工具頁</summary>
        public static string ToolQNA		= "C";
        /// <summary>活動內容說明 工具頁</summary>
        public static string ToolContent	= "D";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "活動說明";	
                case "B":	return "行銷話術";
                case "C":	return "Q&A";
                case "D":	return "活動內容說明";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 險種主附約
    /// </summary>
    public class ProductPlanOptionType
    {
        /// <summary>主約 方式</summary>
        public static string Master		= "A";
        /// <summary>附約 方式</summary>
        public static string Detail		= "B";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "主險";	
                case "B":	return "附險";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 險種種類
    /// </summary>
    public class ProductPlanType
    {
        /// <summary>團險 方式</summary>
        public static string GroupPlan		= "A";
        /// <summary>壽險 方式</summary>
        public static string LifePlan		= "B";
        /// <summary>產險 方式</summary>
        public static string Immovable		= "C";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "團險";	
                case "B":	return "壽險";
                case "C":	return "產險";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 繳別
    /// </summary>
    public class PayModeType
    {
        /// <summary>年繳 方式</summary>
        public static string Year		= "A";
        /// <summary>半年繳 方式</summary>
        public static string HalfYear	= "B";
        /// <summary>季繳 方式</summary>
        public static string Quarter	= "C";
        /// <summary>月繳 方式</summary>
        public static string Month		= "D";
        public static string Whole		= "E";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "年繳";	
                case "B":	return "半年繳";
                case "C":	return "季繳";
                case "D":	return "月繳";
                case "E":	return "躉繳";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 付款方式
    /// </summary>
    public class PayType
    {
        /// <summary>信用卡 方式</summary>
        public static string CreditCard		= "A";
        /// <summary>ATM 轉帳 方式</summary>
        public static string ATM			= "B";
        /// <summary>郵政劃撥 方式</summary>
        public static string PostalTransfer	= "C";

        /// <summary>銀行轉帳 方式</summary>
        public static string Bank			= "1";
        /// <summary>信用卡扣款 方式</summary>
        public static string Card			= "2";
        /// <summary>郵局劃撥 方式</summary>
        public static string Allot			= "3";
        /// <summary>郵局轉帳 方式</summary>
        public static string PostOffice		= "4";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "信用卡";	
                case "B":	return "ATM 轉帳";
                case "C":	return "郵政劃撥";

                case "1":	return "銀行轉帳";
                case "2":	return "信用卡扣款";
                case "3":	return "郵局劃撥";
                case "4":	return "郵局轉帳";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 商品佣金方式
    /// </summary>
    public class CommType
    {
        /// <summary>訂價百分比 方式</summary>
        public static string Percentage		= "0";
        /// <summary>佣金金額 方式</summary>
        public static string Price			= "1";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "訂價百分比";	
                case "1":	return "佣金金額";
                default:	return "";
            }
        }
    }

    /// <summary>
    ///  名單狀態
    /// </summary>
    public class RosterStatusType
    {
        /// <summary>再聯絡 狀態</summary>
        public static string ContactAgain	= "0";
        /// <summary>考慮中 狀態</summary>
        public static string ThinkAbout		= "1";
        /// <summary>成功 狀態</summary>
        public static string Success		= "2";
        /// <summary>行銷失敗 狀態</summary>
        public static string Fail			= "3";
        /// <summary>無效名單 狀態</summary>
        public static string Useless		= "4";
        /// <summary>未撥打 狀態</summary>
        public static string NoDial			= "X";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "再聯絡";	
                case "1":	return "考慮中";
                case "2":	return "成功";
                case "3":	return "行銷失敗";
                case "4":	return "無效名單";
                case "X":	return "未撥打";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 撥打狀態動作
    /// </summary>
    public class CallTypeActionType
    {
        /// <summary>無動作 動作</summary>
        public static string None				= "0";
        /// <summary>選項資訊窗 動作</summary>
        public static string Option				= "1";
        /// <summary>開啟成交記錄視窗 動作</summary>
        public static string SuccessSale		= "2";
        /// <summary>開啟成交問卷視窗 動作</summary>
        public static string SuccessInquire		= "3";
        /// <summary>錯誤電話 動作</summary>
        public static string ErrorPhoneNumber	= "4";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "無動作";	
                case "1":	return "選項資訊窗";
                case "2":	return "開啟成交記錄視窗";
                case "3":	return "開啟成交問卷視窗";
                case "4":	return "錯誤電話";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 工作狀態
    /// </summary>
    public class JobStatus
    {
        public static string UnCompleted = "未完成";
        public static string Canceled       = "取消";
        public static string Completed     = "已完成";
    }

    /// <summary>
    /// 工作優先權
    /// </summary>
    public class JobPriority
    {
        public static string Highest   = "最高";
        public static string High       = "次高";
        public static string Normal   = "普通";
        public static string Low        = "次低";
        public static string Lowest    = "最低";
    }

    /// <summary>
    /// 問卷顯示方式
    /// </summary>
    public class InquireShowWay
    {
        /// <summary>單題顯示 方式</summary>
        public static string Single			= "0";
        /// <summary>整份顯示 方式</summary>
        public static string All			= "1";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "單題顯示";	
                case "1":	return "整份顯示";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 問卷題目類型
    /// </summary>
    public class InquireQuestionType
    {
        /// <summary>單選題 類型</summary>
        public static string SingleOption	= "1";
        /// <summary>複選題 方式</summary>
        public static string MultiOption	= "2";
        /// <summary>排序題 方式</summary>
        public static string SortOption		= "3";
        /// <summary>問答題 方式</summary>
        public static string Input			= "4";
        /// <summary>問卷答案 方式</summary>
        public static string InquireAnswer	= "X";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "1":	return "單選題";	
                case "2":	return "複選題";
                case "3":	return "排序題";
                case "4":	return "問答題";
                case "X":	return "問卷答案";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 問卷調查狀態
    /// </summary>
    public class DialInquireStatus
    {
        /// <summary>未填寫 狀態</summary>
        public static string None			= "0";
        /// <summary>已填寫 狀態</summary>
        public static string Complete		= "1";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "未填寫";	
                case "1":	return "已填寫";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 活動狀態
    /// </summary>
    public class CampaignStatus
    {
        /// <summary>未啟用 狀態</summary>
        public static string NotEnabled		= "0";
        /// <summary>啟用 狀態</summary>
        public static string Enable			= "1";
        /// <summary>中止 狀態</summary>
        public static string Stop			= "2";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "未啟用";	
                case "1":	return "啟用";
                case "2":	return "中止";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 活動參與者身份
    /// </summary>
    public class CampaignParticipantsTarget
    {
        /// <summary>組別 身份</summary>
        public static string Team		= "0";
        /// <summary>訪員 身份</summary>
        public static string TSR		= "1";
        /// <summary>分配員 身份</summary>
        public static string Dispatcher	= "2";
        /// <summary>管理者 身份</summary>
        public static string Manager	= "3";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "組別";	
                case "1":	return "訪員";
                case "2":	return "分派員";
                case "3":	return "管理者";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 名單姓別
    /// </summary>
    public class RosterSex
    {
        /// <summary>男</summary>
        public static string Man		= "M";
        /// <summary>女</summary>
        public static string Feminie	= "F";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "M":	return "男";	
                case "F":	return "女";
                default:	return "";
            }
        }
    }


    /// <summary>
    /// 名單電話狀態
    /// </summary>
    public class RosterPhoneStatus
    {
        /// <summary>錯誤電話</summary>
        public static string Error	= "0";
        /// <summary>限用電話</summary>
        public static string Only	= "1";

        /// <summary>
        /// 依欄位值取得欄位說明
        /// </summary>
        /// <param name="AFieldValue">欄位值</param>
        /// <returns>欄位說明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "錯誤電話";	
                case "1":	return "限用電話";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 布林值對應資料庫儲存的值
    /// </summary>
    public class DBBooleanType
    {
        /// <summary>偽</summary>
        public static string False = "0";
        /// <summary>真</summary>
        public static string True = "1";
    }

    // 系統參數XML
    public enum ProfileXMLName {SystemDialPhrase , SystemMonitor , SystemPresence , SystemDepartment , SystemTitle , SystemDialRule , Area , LeaveJob , PayingPeriod , PayingType , PaymentType , Vacation}

    public class FieldMapping
    {
        public static string getRosterFieldName(string aField)
        {
            switch (aField)
            {
                    /// <summary>身分證字號</summary>
                case "RST_ID":	return "身分證字號";
                    /// <summary>姓名</summary>
                case "RST_NAME": return "姓名";
                    /// <summary>性別</summary>
                case "RST_SEX": return  "性別";
                    /// <summary>出生日期</summary>
                case "RST_BIRDT": return  "出生日期";
                    /// <summary>電話一</summary>
                case "RST_PHONE1": return "電話一";
                    /// <summary>電話二</summary>
                case "RST_PHONE2": return "電話二";
                    /// <summary>電話三</summary>
                case "RST_PHONE3": return "電話三";
                    /// <summary>手機一</summary>
                case "RST_MOBILE1": return "手機一";
                    /// <summary>手機二</summary>
                case "RST_MOBILE2": return "手機二";
                    /// <summary>傳真號碼</summary>
                case "RST_FAX": return "傳真號碼";
                    /// <summary>公司</summary>
                case "RST_COMPANY": return "公司";
                    /// <summary>職稱</summary>
                case "RST_TITLE": return "職稱";
                    /// <summary>信用卡種類</summary>
                case "RST_CARDTYPE": return "信用卡種類";
                    /// <summary>信用卡卡號</summary>
                case "RST_CARDNO": return "信用卡卡號";
                    /// <summary>信用卡有效日期</summary>
                case "RST_CARDEFFDT": return "信用卡有效日期";
                    /// <summary>電子郵件信箱</summary>
                case "RST_EMAIL": return "電子郵件信箱";
                    /// <summary>通訊地址</summary>
                case "RST_ADDR1": return "通訊地址";
                    /// <summary>戶籍地址</summary>
                case "RST_ADDR2": return "戶籍地址";
                default:	return "";
            }
        }
    }

    public class DispatchStatus
    {
        /// <summary>分派</summary>
        public static int Dispatch = 0;
        /// <summary>回收</summary>
        public static int Recycle = 1;
    }
    
    /// <summary>
    /// 成交記錄狀態
    /// </summary>
    public class BargainFlowStatus
    {
        /// <summary>待訪員追蹤處理的退件</summary>
        public static string Reject = "Reject";
        /// <summary>待覆核</summary>
        public static string Recheck = "Recheck";
        /// <summary>待結案</summary>
        public static string Close = "Close";
        /// <summary>已結案</summary>
        public static string Closed = "Closed";
        public static string getStatusFieldName(string status)
        {
            switch(status)
            {
                case "Reject" :
                    return "退件";
                case "Recheck" :
                    return "待覆核";
                case "Close" :
                    return "待結案";
                case "Closed" :
                    return "已結案";
                default :
                    return "";
            }
        }
    }

    public class BargainFlowMethod
    {
        /// <summary>通過</summary>
        public static string Pass = "Pass";
        /// <summary>退件</summary>
        public static string Reject = "Reject";
        /// <summary>結案</summary>
        public static string Close = "Close";
        public static string getMethodFieldName(string method)
        {
            switch(method)
            {
                case "Reject" :
                    return "退件";
                case "Pass" :
                    return "通過";
                case "Close" :
                    return "結案";
                default :
                    return "";
            }
        }
    }

    /// <summary>
    /// 成交流程錯誤代碼
    /// </summary>
    public class BargainFlowErrorCode
    {
        public static string NotFoundUser = "接收者可能已離職,或該帳號已停用.";
        public static string NotNextNode  = "找不到下一個流程節點";
        public static string NotEnoughPolicy = "沒有分配的保單號碼.";
        public static string NotFoundCloseNode = "沒有任何結束點.";
        public static string RecheckMustTwoLine = "覆核節點必須要各有一條通過線和退件線.";
    }
}
