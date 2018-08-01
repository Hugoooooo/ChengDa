using System;

namespace EASONTECH.Outbound.DataLayer
{
    //规则: 栏位名称(不用资料表前置码及底线) + "Type"


    /// <summary>
    /// 保费计算方式
    /// </summary>
    public class PlanComposeRateUseType
    {
        /// <summary>固定保费</summary>
        public static string Fix			= "0";
        /// <summary>非固定费率</summary>
        public static string NotFix			= "1";
        /// <summary>非定额组合</summary>
        public static string NotFixCompose	= "2";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "固定保费";	
                case "1":	return "非固定费率";	
                case "2":	return "非定额组合";	
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 费率指标因子使用类型
    /// </summary>
    public class PlanRateUseType
    {
        /// <summary>缴费年期</summary>
        public static string P		= "A";
        /// <summary>缴费年期 + 职业等级</summary>
        public static string PV		= "B";
        /// <summary>缴费年期 + 年龄 + 性别</summary>
        public static string PAS	= "C";
        /// <summary>缴费年期 + 职业等级 +  年龄 + 性别</summary>
        public static string PVAS	= "D";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "缴费年期";	
                case "B":	return "缴费年期 + 职业等级";	
                case "C":	return "缴费年期 + 年龄 + 性别";	
                case "D":	return "缴费年期 + 职业等级 +  年龄 + 性别";	
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 费率指标因子不使用
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
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
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
    /// 职业等级
    /// </summary>
    public class VocationLevelType
    {
        /// <summary>拒保</summary>
        public static string Refuse		= "7";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
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
    /// 电话名称类型
    /// </summary>
    public class DefaultProductCategoryNameType
    {
        /// <summary>市调问卷</summary>
        public static string Inquire		= "A";
        /// <summary>商品组合</summary>
        public static string ProductCombo	= "B";
        /// <summary>险种组合</summary>
        public static string ProductPlan	= "C";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "市调问卷";	
                case "B":	return "商品组合";
                case "C":	return "险种组合";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 电话类型
    /// </summary>
    public class PhoneType
    {
        /// <summary>家庭</summary>
        public static string Home		= "家庭";
        /// <summary>公司</summary>
        public static string Company	= "公司";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "家庭":	return "家庭";	
                case "公司":	return "公司";
                default:	return "";
            }
        }

        /// <summary>
        /// 依栏位值取得栏位说明简称
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldCommentSimple(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "家庭":	return "(家)";	
                case "公司":	return "(公)";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 电话名称类型
    /// </summary>
    public class TelNameType
    {
        /// <summary>电话一(日) 工具页</summary>
        public static string PHONE1		= "A";
        /// <summary>电话二(夜) 工具页</summary>
        public static string PHONE2		= "B";
        /// <summary>电话三(其) 工具页</summary>
        public static string PHONE3		= "C";
        /// <summary>手机一 工具页</summary>
        public static string MOBILE1	= "D";
        /// <summary>手机二 工具页</summary>
        public static string MOBILE2	= "E";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "电话一(日)";	
                case "B":	return "电话二(夜)";
                case "C":	return "电话三(其)";
                case "D":	return "手机一";
                case "E":	return "手机二";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 活动工具页类型
    /// </summary>
    public class CampaignToolTypes
    {
        /// <summary>活动说明 工具页</summary>
        public static string ToolDocument	= "A";
        /// <summary>行销话术 工具页</summary>
        public static string ToolWordFlow	= "B";
        /// <summary>Q&A 工具页</summary>
        public static string ToolQNA		= "C";
        /// <summary>活动内容说明 工具页</summary>
        public static string ToolContent	= "D";
        /// <summary>我的最爱 工具页</summary>
        public static string ToolFavorite = "E";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "活动说明";	
                case "B":	return "行销话术";
                case "C":	return "Q&A";
                case "D":	return "保費試算";
                case "E": return "我的最爱";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 险种主附约
    /// </summary>
    public class ProductPlanOptionType
    {
        /// <summary>主约 方式</summary>
        public static string Master		= "A";
        /// <summary>附约 方式</summary>
        public static string Detail		= "B";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "主险";	
                case "B":	return "附险";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 险种种类
    /// </summary>
    public class ProductPlanType
    {
        /// <summary>团险 方式</summary>
        public static string GroupPlan		= "A";
        /// <summary>寿险 方式</summary>
        public static string LifePlan		= "B";
        /// <summary>产险 方式</summary>
        public static string Immovable		= "C";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "团险";	
                case "B":	return "寿险";
                case "C":	return "产险";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 缴别
    /// </summary>
    public class PayModeType
    {
        /// <summary>年缴 方式</summary>
        public static string Year		= "A";
        /// <summary>半年缴 方式</summary>
        public static string HalfYear	= "B";
        /// <summary>季缴 方式</summary>
        public static string Quarter	= "C";
        /// <summary>月缴 方式</summary>
        public static string Month		= "D";
        public static string Whole		= "E";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "年缴";	
                case "B":	return "半年缴";
                case "C":	return "季缴";
                case "D":	return "月缴";
                case "E":	return "趸缴";
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
        /// <summary>ATM 转帐 方式</summary>
        public static string ATM			= "B";
        /// <summary>邮政划拨 方式</summary>
        public static string PostalTransfer	= "C";

        /// <summary>银行转帐 方式</summary>
        public static string Bank			= "1";
        /// <summary>信用卡扣款 方式</summary>
        public static string Card			= "2";
        /// <summary>邮局划拨 方式</summary>
        public static string Allot			= "3";
        /// <summary>邮局转帐 方式</summary>
        public static string PostOffice		= "4";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "信用卡";	
                case "B":	return "ATM 转帐";
                case "C":	return "邮政划拨";

                case "1":	return "银行转帐";
                case "2":	return "信用卡扣款";
                case "3":	return "邮局划拨";
                case "4":	return "邮局转帐";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 商品佣金方式
    /// </summary>
    public class CommType
    {
        /// <summary>订价百分比 方式</summary>
        public static string Percentage		= "0";
        /// <summary>佣金金额 方式</summary>
        public static string Price			= "1";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "订价百分比";	
                case "1":	return "佣金金额";
                default:	return "";
            }
        }
    }

    /// <summary>
    ///  名单状态
    /// </summary>
    public class RosterStatusType
    {
        /// <summary>再联络 状态</summary>
        public static string ContactAgain	= "0";
        /// <summary>考虑中 状态</summary>
        public static string ThinkAbout		= "1";
        /// <summary>成功 状态</summary>
        public static string Success		= "2";
        /// <summary>行销失败 状态</summary>
        public static string Fail			= "3";
        /// <summary>无效名单 状态</summary>
        public static string Useless		= "4";
        /// <summary>未拨打 状态</summary>
        public static string NoDial			= "X";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "再联络";	
                case "1":	return "考虑中";
                case "2":	return "成功";
                case "3":	return "行销失败";
                case "4":	return "无效名单";
                case "X":	return "未拨打";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 拨打状态动作
    /// </summary>
    public class CallTypeActionType
    {
        /// <summary>无动作 动作</summary>
        public static string None				= "0";
        /// <summary>选项信息窗 动作</summary>
        public static string Option				= "1";
        /// <summary>开启成交记录视窗 动作</summary>
        public static string SuccessSale		= "2";
        /// <summary>开启成交问卷视窗 动作</summary>
        public static string SuccessInquire		= "3";
        /// <summary>错误电话 动作</summary>
        public static string ErrorPhoneNumber	= "4";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "无动作";	
                case "1":	return "选项信息窗";
                case "2":	return "开启成交记录视窗";
                case "3":	return "开启成交问卷视窗";
                case "4":	return "错误电话";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 工作状态
    /// </summary>
    public class JobStatus
    {
        public static string UnCompleted = "未完成";
        public static string Canceled       = "取消";
        public static string Completed     = "已完成";
    }

    /// <summary>
    /// 工作优先权
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
    /// 问卷显示方式
    /// </summary>
    public class InquireShowWay
    {
        /// <summary>单题显示 方式</summary>
        public static string Single			= "0";
        /// <summary>整份显示 方式</summary>
        public static string All			= "1";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "单题显示";	
                case "1":	return "整份显示";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 问卷题目类型
    /// </summary>
    public class InquireQuestionType
    {
        /// <summary>单选题 类型</summary>
        public static string SingleOption	= "1";
        /// <summary>复选题 方式</summary>
        public static string MultiOption	= "2";
        /// <summary>排序题 方式</summary>
        public static string SortOption		= "3";
        /// <summary>问答题 方式</summary>
        public static string Input			= "4";
        /// <summary>问卷答案 方式</summary>
        public static string InquireAnswer	= "X";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0": return "问卷调查开始";
                case "1":	return "单选题";	
                case "2":	return "复选题";
                case "3":	return "排序题";
                case "4":	return "问答题";
                case "X":	return "问卷答案";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 问卷调查状态
    /// </summary>
    public class DialInquireStatus
    {
        /// <summary>未填写 状态</summary>
        public static string None			= "0";
        /// <summary>已填写 状态</summary>
        public static string Complete		= "1";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "未填写";	
                case "1":	return "已填写";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 活动状态
    /// </summary>
    public class CampaignStatus
    {
        /// <summary>未启用 状态</summary>
        public static string NotEnabled		= "0";
        /// <summary>启用 状态</summary>
        public static string Enable			= "1";
        /// <summary>中止 状态</summary>
        public static string Stop			= "2";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "未启用";	
                case "1":	return "启用";
                case "2":	return "中止";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 活动参与者身份
    /// </summary>
    public class CampaignParticipantsTarget
    {
        /// <summary>组别 身份</summary>
        public static string Team		= "0";
        /// <summary>访员 身份</summary>
        public static string TSR		= "1";
        /// <summary>分配员 身份</summary>
        public static string Dispatcher	= "2";
        /// <summary>管理者 身份</summary>
        public static string Manager	= "3";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "组别";	
                case "1":	return "访员";
                case "2":	return "分派员";
                case "3":	return "管理者";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 名单姓别
    /// </summary>
    public class RosterSex
    {
        /// <summary>男</summary>
        public static string Man		= "M";
        /// <summary>女</summary>
        public static string Feminie	= "F";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "M":	return "男";	
                case "F":	return "女";
                default:	return "";
            }
        }

        public static string getFieldTitle(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "M":	return "先生";	
                case "F":	return "小姐";
                default:	return "";
            }
        }
    }


    /// <summary>
    /// 名单电话状态
    /// </summary>
    public class RosterPhoneStatus
    {
        /// <summary>错误电话</summary>
        public static string Error	= "0";
        /// <summary>限用电话</summary>
        public static string Only	= "1";

        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "错误电话";	
                case "1":	return "限用电话";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 布林值对应资料库存贮的值
    /// </summary>
    public class DBBooleanType
    {
        /// <summary>伪</summary>
        public static string False = "0";
        /// <summary>真</summary>
        public static string True = "1";
    }

    // 系统参数XML
    public enum ProfileXMLName {SystemDialPhrase , SystemMonitor , SystemPresence , SystemDepartment , SystemTitle , SystemDialRule , Area , LeaveJob , PayingPeriod , PayingType , PaymentType , Vacation}

    public class FieldMapping
    {
        public static string getRosterFieldName(string aField)
        {
            switch (aField)
            {
                    /// <summary>身份证字号</summary>
                case "RST_ID":	return "身份证号";
                    /// <summary>姓名</summary>
                case "RST_NAME": return "姓名";
                    /// <summary>性别</summary>
                case "RST_SEX": return  "性别";
                    /// <summary>出生日期</summary>
                case "RST_BIRDT": return  "出生日期";
                    /// <summary>电话一</summary>
                case "RST_PHONE1": return "电话一";
                    /// <summary>电话二</summary>
                case "RST_PHONE2": return "电话二";
                    /// <summary>电话三</summary>
                case "RST_PHONE3": return "电话三";
                    /// <summary>手机一</summary>
                case "RST_MOBILE1": return "手机一";
                    /// <summary>手机二</summary>
                case "RST_MOBILE2": return "手机二";
                    /// <summary>传真号码</summary>
                case "RST_FAX": return "传真号码";
                    /// <summary>电子邮件信箱</summary>
                case "RST_EMAIL": return "电子邮件信箱";
                    /// <summary>工作单位</summary>
                case "RST_COMPANY": return "工作单位";
                    /// <summary>职业</summary>
                case "RST_TITLE": return "职业";
                    /// <summary>银行名称</summary>
                case "RST_BANKNAME": return "银行名称";
                    /// <summary>帐号类型</summary>
                case "RST_ACCOUNTTYPE": return "帐号类型";
                    /// <summary>邮政编码</summary>
                case "RST_POSTCODE1": return "邮政编码";
                    /// <summary>通讯地址</summary>
                case "RST_ADDR1": return "通讯地址";
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
    /// 成交记录状态
    /// </summary>
    public class BargainFlowStatus
    {
        /// <summary>待访员追踪处理的退件</summary>
        public static string Reject = "Reject";
        /// <summary>待复核</summary>
        public static string Recheck = "Recheck";
        /// <summary>待结案</summary>
        public static string Close = "Close";
        /// <summary>已结案</summary>
        public static string Closed = "Closed";
        public static string getStatusFieldName(string status)
        {
            switch(status)
            {
                case "Reject" :
                    return "退件";
                case "Recheck" :
                    return "待复核";
                case "Close" :
                    return "待结案";
                case "Closed" :
                    return "已结案";
                default :
                    return "";
            }
        }
    }

    public class BargainFlowMethod
    {
        /// <summary>通过</summary>
        public static string Pass = "Pass";
        /// <summary>退件</summary>
        public static string Reject = "Reject";
        /// <summary>结案</summary>
        public static string Close = "Close";
        public static string getMethodFieldName(string method)
        {
            switch(method)
            {
                case "Reject" :
                    return "退件";
                case "Pass" :
                    return "通过";
                case "Close" :
                    return "结案";
                default :
                    return "";
            }
        }
    }

    /// <summary>
    /// View中所使用到的一般讯息
    /// </summary>
    public class ViewMessage
    {
        public static string Hour = "小时";
    }

    /// <summary>
    /// 成交流程错误代码
    /// </summary>
    public class BargainFlowErrorCode
    {
        public static string NotFoundUser = "接收者可能已离职,或该帐号已停用.";
        public static string NotNextNode  = "找不到下一个流程节点";
        public static string NotEnoughPolicy = "没有分配的保单号码.";
        public static string NotFoundCloseNode = "没有任何结束点.";
        public static string RecheckMustTwoLine = "复核节点必须要各有一条通过线和退件线.";
    }

    public class ReportMessage
    {
        public static string RejectReason = "退件原因";
    }

    public class WordFlowMessage
    {
        public static string CodeOrNameExist = "行销话术流程代码或名称已存在";
        public static string CodeExist = "行销话术流程代码已存在";
        public static string NameExist = "行销话术流程名称已存在";
    }

    public class DialFlowMessage
    {
        public static string CodeOrNameExist = "拨打状态流程代码或名称已存在";
        public static string CodeExist = "拨打状态流程代码已存在";
        public static string NameExist = "拨打状态流程名称已存在";
    }

    public class QuestionMessage
    {
        public static string Yes = "是";
        public static string No = "否";
    }

    public class WeeklyName
    {
        public static string Sunday = "星期日";
        public static string Monday = "星期一";
        public static string Tuesday = "星期二";
        public static string Wednesday = "星期三";
        public static string Thursday = "星期四";
        public static string Friday = "星期五";
        public static string Saturday = "星期六";
    }

    public class ProductPlanPayType
    {
        public static string getPayTypeName(string code)
        {
            switch (code)
            {
                case "1" : return "按基本保额";
                case "2" : return "退还保费";
                default	 : return "无还本给付";
            }
        }
    }

    /// <summary>
    /// 问卷调查汇出栏位
    /// </summary>
    public class InquireExportField
    {
        public enum FieldName {IRT_CAPNAME , IRT_RTANAME , IRT_EMPNAME , IRT_RSTNAME , IRT_IQQCODE , IRT_IQQNAME , IRT_LPDTTM, IRD_TYPE , IRD_SEQUENCE , IRD_CONTENT , IRD_ANSWER}
        public static string getInquireField(string code)
        {
            switch(code)
            {
                case "IRT_CAPNAME" : return "活动名称";
                case "IRT_RTANAME" : return "名单别名";
                case "IRT_EMPNAME" : return "访员姓名";
                case "IRT_RSTNAME" : return "客户姓名";
                case "IRT_IQQCODE" : return "问卷代码";
                case "IRT_IQQNAME" : return "问卷名称";
                case "IRT_LPDTTM"  : return "问卷调查日期";
                case "IRD_TYPE"    : return "题目类型";
                case "IRD_SEQUENCE": return "题目顺序";
                case "IRD_CONTENT" : return "题目内容";
                case "IRD_ANSWER"  : return "答案";
                default : return "";
            }
        }
    }

    /// <summary>
    /// 婚姻状况
    /// </summary>
    public class Married
    {
        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "Y":	return "已婚";	
                case "N":	return "未婚";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 子女状况
    /// </summary>
    public class HaveChild
    {
        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "Y":	return "有";	
                case "N":	return "無";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// 来电服务项目处理作业
    /// </summary>
    public class ServiceItemProcess
    {
        /// <summary>
        /// 依栏位值取得栏位说明
        /// </summary>
        /// <param name="AFieldValue">栏位值</param>
        /// <returns>栏位说明</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "online":	return "联机回覆处理";	
                case "none":	return "无";
                default:	return "";
            }
        }
    }
}
