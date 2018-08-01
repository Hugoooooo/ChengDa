using System;

namespace EASONTECH.Outbound.DataLayer
{
    //�W�h: ���W��(���θ�ƪ�e�m�X�Ω��u) + "Type"


    /// <summary>
    /// �O�O�p��覡
    /// </summary>
    public class PlanComposeRateUseType
    {
        /// <summary>�T�w�O�O</summary>
        public static string Fix			= "0";
        /// <summary>�D�T�w�O�v</summary>
        public static string NotFix			= "1";
        /// <summary>�D�w�B�զX</summary>
        public static string NotFixCompose	= "2";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "�T�w�O�O";	
                case "1":	return "�D�T�w�O�v";	
                case "2":	return "�D�w�B�զX";	
                default:	return "";
            }
        }
    }

    /// <summary>
    /// �O�v���Ц]�l�ϥ�����
    /// </summary>
    public class PlanRateUseType
    {
        /// <summary>ú�O�~��</summary>
        public static string P		= "A";
        /// <summary>ú�O�~�� + ¾�~����</summary>
        public static string PV		= "B";
        /// <summary>ú�O�~�� + �~�� + �ʧO</summary>
        public static string PAS	= "C";
        /// <summary>ú�O�~�� + ¾�~���� +  �~�� + �ʧO</summary>
        public static string PVAS	= "D";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "ú�O�~��";	
                case "B":	return "ú�O�~�� + ¾�~����";	
                case "C":	return "ú�O�~�� + �~�� + �ʧO";	
                case "D":	return "ú�O�~�� + ¾�~���� +  �~�� + �ʧO";	
                default:	return "";
            }
        }
    }

    /// <summary>
    /// �O�v���Ц]�l���ϥ�
    /// </summary>
    public class PlanRateNoUseType
    {
        /// <summary>���ϥ�</summary>
        public static string VocationLevelNoUse		= "0";
        /// <summary>���ϥ�</summary>
        public static string AgeNoUse		= "0";
        /// <summary>���ϥ�</summary>
        public static string SexNoUse		= "";
        /// <summary>���ϥ�</summary>
        public static string PlanRateNoUse	= "";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "���ϥ�";	
                case "":	return "���ϥ�";	
                default:	return "";
            }
        }
    }

    /// <summary>
    /// ¾�~����
    /// </summary>
    public class VocationLevelType
    {
        /// <summary>�ګO</summary>
        public static string Refuse		= "7";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "7":	return "�ګO";	
                default:	return "";
            }
        }
    }

    /// <summary>
    /// �q�ܦW������
    /// </summary>
    public class DefaultProductCategoryNameType
    {
        /// <summary>���հݨ�</summary>
        public static string Inquire		= "A";
        /// <summary>�ӫ~�զX</summary>
        public static string ProductCombo	= "B";
        /// <summary>�I�زզX</summary>
        public static string ProductPlan	= "C";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "���հݨ�";	
                case "B":	return "�ӫ~�զX";
                case "C":	return "�I�زզX";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// �q������
    /// </summary>
    public class PhoneType
    {
        /// <summary>�a�x</summary>
        public static string Home		= "A";
        /// <summary>���q</summary>
        public static string Company	= "B";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "�a�x";	
                case "B":	return "���q";
                default:	return "";
            }
        }

        /// <summary>
        /// �����Ȩ��o��컡��²��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldCommentSimple(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "(�a)";	
                case "B":	return "(��)";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// �q�ܦW������
    /// </summary>
    public class TelNameType
    {
        /// <summary>�q�ܤ@(��) �u�㭶</summary>
        public static string PHONE1		= "A";
        /// <summary>�q�ܤG(�]) �u�㭶</summary>
        public static string PHONE2		= "B";
        /// <summary>�q�ܤT(��) �u�㭶</summary>
        public static string PHONE3		= "C";
        /// <summary>����@ �u�㭶</summary>
        public static string MOBILE1	= "D";
        /// <summary>����G �u�㭶</summary>
        public static string MOBILE2	= "E";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "�q�ܤ@(��)";	
                case "B":	return "�q�ܤG(�])";
                case "C":	return "�q�ܤT(��)";
                case "D":	return "����@";
                case "E":	return "����G";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// ���ʤu�㭶����
    /// </summary>
    public class CampaignToolTypes
    {
        /// <summary>���ʻ��� �u�㭶</summary>
        public static string ToolDocument	= "A";
        /// <summary>��P�ܳN �u�㭶</summary>
        public static string ToolWordFlow	= "B";
        /// <summary>Q&A �u�㭶</summary>
        public static string ToolQNA		= "C";
        /// <summary>���ʤ��e���� �u�㭶</summary>
        public static string ToolContent	= "D";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "���ʻ���";	
                case "B":	return "��P�ܳN";
                case "C":	return "Q&A";
                case "D":	return "���ʤ��e����";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// �I�إD����
    /// </summary>
    public class ProductPlanOptionType
    {
        /// <summary>�D�� �覡</summary>
        public static string Master		= "A";
        /// <summary>���� �覡</summary>
        public static string Detail		= "B";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "�D�I";	
                case "B":	return "���I";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// �I�غ���
    /// </summary>
    public class ProductPlanType
    {
        /// <summary>���I �覡</summary>
        public static string GroupPlan		= "A";
        /// <summary>���I �覡</summary>
        public static string LifePlan		= "B";
        /// <summary>���I �覡</summary>
        public static string Immovable		= "C";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "���I";	
                case "B":	return "���I";
                case "C":	return "���I";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// ú�O
    /// </summary>
    public class PayModeType
    {
        /// <summary>�~ú �覡</summary>
        public static string Year		= "A";
        /// <summary>�b�~ú �覡</summary>
        public static string HalfYear	= "B";
        /// <summary>�uú �覡</summary>
        public static string Quarter	= "C";
        /// <summary>��ú �覡</summary>
        public static string Month		= "D";
        public static string Whole		= "E";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "�~ú";	
                case "B":	return "�b�~ú";
                case "C":	return "�uú";
                case "D":	return "��ú";
                case "E":	return "Ļú";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// �I�ڤ覡
    /// </summary>
    public class PayType
    {
        /// <summary>�H�Υd �覡</summary>
        public static string CreditCard		= "A";
        /// <summary>ATM ��b �覡</summary>
        public static string ATM			= "B";
        /// <summary>�l�F���� �覡</summary>
        public static string PostalTransfer	= "C";

        /// <summary>�Ȧ���b �覡</summary>
        public static string Bank			= "1";
        /// <summary>�H�Υd���� �覡</summary>
        public static string Card			= "2";
        /// <summary>�l������ �覡</summary>
        public static string Allot			= "3";
        /// <summary>�l����b �覡</summary>
        public static string PostOffice		= "4";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "A":	return "�H�Υd";	
                case "B":	return "ATM ��b";
                case "C":	return "�l�F����";

                case "1":	return "�Ȧ���b";
                case "2":	return "�H�Υd����";
                case "3":	return "�l������";
                case "4":	return "�l����b";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// �ӫ~�����覡
    /// </summary>
    public class CommType
    {
        /// <summary>�q���ʤ��� �覡</summary>
        public static string Percentage		= "0";
        /// <summary>�������B �覡</summary>
        public static string Price			= "1";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "�q���ʤ���";	
                case "1":	return "�������B";
                default:	return "";
            }
        }
    }

    /// <summary>
    ///  �W�檬�A
    /// </summary>
    public class RosterStatusType
    {
        /// <summary>�A�p�� ���A</summary>
        public static string ContactAgain	= "0";
        /// <summary>�Ҽ{�� ���A</summary>
        public static string ThinkAbout		= "1";
        /// <summary>���\ ���A</summary>
        public static string Success		= "2";
        /// <summary>��P���� ���A</summary>
        public static string Fail			= "3";
        /// <summary>�L�ĦW�� ���A</summary>
        public static string Useless		= "4";
        /// <summary>������ ���A</summary>
        public static string NoDial			= "X";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "�A�p��";	
                case "1":	return "�Ҽ{��";
                case "2":	return "���\";
                case "3":	return "��P����";
                case "4":	return "�L�ĦW��";
                case "X":	return "������";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// �������A�ʧ@
    /// </summary>
    public class CallTypeActionType
    {
        /// <summary>�L�ʧ@ �ʧ@</summary>
        public static string None				= "0";
        /// <summary>�ﶵ��T�� �ʧ@</summary>
        public static string Option				= "1";
        /// <summary>�}�Ҧ���O������ �ʧ@</summary>
        public static string SuccessSale		= "2";
        /// <summary>�}�Ҧ���ݨ����� �ʧ@</summary>
        public static string SuccessInquire		= "3";
        /// <summary>���~�q�� �ʧ@</summary>
        public static string ErrorPhoneNumber	= "4";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "�L�ʧ@";	
                case "1":	return "�ﶵ��T��";
                case "2":	return "�}�Ҧ���O������";
                case "3":	return "�}�Ҧ���ݨ�����";
                case "4":	return "���~�q��";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// �u�@���A
    /// </summary>
    public class JobStatus
    {
        public static string UnCompleted = "������";
        public static string Canceled       = "����";
        public static string Completed     = "�w����";
    }

    /// <summary>
    /// �u�@�u���v
    /// </summary>
    public class JobPriority
    {
        public static string Highest   = "�̰�";
        public static string High       = "����";
        public static string Normal   = "���q";
        public static string Low        = "���C";
        public static string Lowest    = "�̧C";
    }

    /// <summary>
    /// �ݨ���ܤ覡
    /// </summary>
    public class InquireShowWay
    {
        /// <summary>���D��� �覡</summary>
        public static string Single			= "0";
        /// <summary>������ �覡</summary>
        public static string All			= "1";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "���D���";	
                case "1":	return "������";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// �ݨ��D������
    /// </summary>
    public class InquireQuestionType
    {
        /// <summary>����D ����</summary>
        public static string SingleOption	= "1";
        /// <summary>�ƿ��D �覡</summary>
        public static string MultiOption	= "2";
        /// <summary>�Ƨ��D �覡</summary>
        public static string SortOption		= "3";
        /// <summary>�ݵ��D �覡</summary>
        public static string Input			= "4";
        /// <summary>�ݨ����� �覡</summary>
        public static string InquireAnswer	= "X";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "1":	return "����D";	
                case "2":	return "�ƿ��D";
                case "3":	return "�Ƨ��D";
                case "4":	return "�ݵ��D";
                case "X":	return "�ݨ�����";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// �ݨ��լd���A
    /// </summary>
    public class DialInquireStatus
    {
        /// <summary>����g ���A</summary>
        public static string None			= "0";
        /// <summary>�w��g ���A</summary>
        public static string Complete		= "1";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "����g";	
                case "1":	return "�w��g";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// ���ʪ��A
    /// </summary>
    public class CampaignStatus
    {
        /// <summary>���ҥ� ���A</summary>
        public static string NotEnabled		= "0";
        /// <summary>�ҥ� ���A</summary>
        public static string Enable			= "1";
        /// <summary>���� ���A</summary>
        public static string Stop			= "2";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "���ҥ�";	
                case "1":	return "�ҥ�";
                case "2":	return "����";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// ���ʰѻP�̨���
    /// </summary>
    public class CampaignParticipantsTarget
    {
        /// <summary>�էO ����</summary>
        public static string Team		= "0";
        /// <summary>�X�� ����</summary>
        public static string TSR		= "1";
        /// <summary>���t�� ����</summary>
        public static string Dispatcher	= "2";
        /// <summary>�޲z�� ����</summary>
        public static string Manager	= "3";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "�էO";	
                case "1":	return "�X��";
                case "2":	return "������";
                case "3":	return "�޲z��";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// �W��m�O
    /// </summary>
    public class RosterSex
    {
        /// <summary>�k</summary>
        public static string Man		= "M";
        /// <summary>�k</summary>
        public static string Feminie	= "F";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "M":	return "�k";	
                case "F":	return "�k";
                default:	return "";
            }
        }
    }


    /// <summary>
    /// �W��q�ܪ��A
    /// </summary>
    public class RosterPhoneStatus
    {
        /// <summary>���~�q��</summary>
        public static string Error	= "0";
        /// <summary>���ιq��</summary>
        public static string Only	= "1";

        /// <summary>
        /// �����Ȩ��o��컡��
        /// </summary>
        /// <param name="AFieldValue">����</param>
        /// <returns>��컡��</returns>
        public static string getFieldComment(string AFieldValue)
        {
            switch (AFieldValue)
            {
                case "0":	return "���~�q��";	
                case "1":	return "���ιq��";
                default:	return "";
            }
        }
    }

    /// <summary>
    /// ���L�ȹ�����Ʈw�x�s����
    /// </summary>
    public class DBBooleanType
    {
        /// <summary>��</summary>
        public static string False = "0";
        /// <summary>�u</summary>
        public static string True = "1";
    }

    // �t�ΰѼ�XML
    public enum ProfileXMLName {SystemDialPhrase , SystemMonitor , SystemPresence , SystemDepartment , SystemTitle , SystemDialRule , Area , LeaveJob , PayingPeriod , PayingType , PaymentType , Vacation}

    public class FieldMapping
    {
        public static string getRosterFieldName(string aField)
        {
            switch (aField)
            {
                    /// <summary>�����Ҧr��</summary>
                case "RST_ID":	return "�����Ҧr��";
                    /// <summary>�m�W</summary>
                case "RST_NAME": return "�m�W";
                    /// <summary>�ʧO</summary>
                case "RST_SEX": return  "�ʧO";
                    /// <summary>�X�ͤ��</summary>
                case "RST_BIRDT": return  "�X�ͤ��";
                    /// <summary>�q�ܤ@</summary>
                case "RST_PHONE1": return "�q�ܤ@";
                    /// <summary>�q�ܤG</summary>
                case "RST_PHONE2": return "�q�ܤG";
                    /// <summary>�q�ܤT</summary>
                case "RST_PHONE3": return "�q�ܤT";
                    /// <summary>����@</summary>
                case "RST_MOBILE1": return "����@";
                    /// <summary>����G</summary>
                case "RST_MOBILE2": return "����G";
                    /// <summary>�ǯu���X</summary>
                case "RST_FAX": return "�ǯu���X";
                    /// <summary>���q</summary>
                case "RST_COMPANY": return "���q";
                    /// <summary>¾��</summary>
                case "RST_TITLE": return "¾��";
                    /// <summary>�H�Υd����</summary>
                case "RST_CARDTYPE": return "�H�Υd����";
                    /// <summary>�H�Υd�d��</summary>
                case "RST_CARDNO": return "�H�Υd�d��";
                    /// <summary>�H�Υd���Ĥ��</summary>
                case "RST_CARDEFFDT": return "�H�Υd���Ĥ��";
                    /// <summary>�q�l�l��H�c</summary>
                case "RST_EMAIL": return "�q�l�l��H�c";
                    /// <summary>�q�T�a�}</summary>
                case "RST_ADDR1": return "�q�T�a�}";
                    /// <summary>���y�a�}</summary>
                case "RST_ADDR2": return "���y�a�}";
                default:	return "";
            }
        }
    }

    public class DispatchStatus
    {
        /// <summary>����</summary>
        public static int Dispatch = 0;
        /// <summary>�^��</summary>
        public static int Recycle = 1;
    }
    
    /// <summary>
    /// ����O�����A
    /// </summary>
    public class BargainFlowStatus
    {
        /// <summary>�ݳX���l�ܳB�z���h��</summary>
        public static string Reject = "Reject";
        /// <summary>���Ю�</summary>
        public static string Recheck = "Recheck";
        /// <summary>�ݵ���</summary>
        public static string Close = "Close";
        /// <summary>�w����</summary>
        public static string Closed = "Closed";
        public static string getStatusFieldName(string status)
        {
            switch(status)
            {
                case "Reject" :
                    return "�h��";
                case "Recheck" :
                    return "���Ю�";
                case "Close" :
                    return "�ݵ���";
                case "Closed" :
                    return "�w����";
                default :
                    return "";
            }
        }
    }

    public class BargainFlowMethod
    {
        /// <summary>�q�L</summary>
        public static string Pass = "Pass";
        /// <summary>�h��</summary>
        public static string Reject = "Reject";
        /// <summary>����</summary>
        public static string Close = "Close";
        public static string getMethodFieldName(string method)
        {
            switch(method)
            {
                case "Reject" :
                    return "�h��";
                case "Pass" :
                    return "�q�L";
                case "Close" :
                    return "����";
                default :
                    return "";
            }
        }
    }

    /// <summary>
    /// ����y�{���~�N�X
    /// </summary>
    public class BargainFlowErrorCode
    {
        public static string NotFoundUser = "�����̥i��w��¾,�θӱb���w����.";
        public static string NotNextNode  = "�䤣��U�@�Ӭy�{�`�I";
        public static string NotEnoughPolicy = "�S�����t���O�渹�X.";
        public static string NotFoundCloseNode = "�S�����󵲧��I.";
        public static string RecheckMustTwoLine = "�Юָ`�I�����n�U���@���q�L�u�M�h��u.";
    }
}
