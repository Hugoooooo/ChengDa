using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using Microsoft.Office.Interop.Excel;
using System.Framework.DataLayer;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Framework.Common;
using System.DataLayer;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.DataLayer.Views;
using System.Framework;

namespace ChengDa
{
    public class APConfig
    {
        private static readonly ILog TxtLog = LogManager.GetLogger(typeof(SQLConnection));

        public static string MSSQLConnStringFormat = @"packet size=4096;Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3};connect timeout=240;Min Pool Size=5;Max Pool Size=200";

        public static IConnection Conn = null;

        public static Exception LastException = null;

        public static bool LoginCheck = false;

        public static string AccountName = "";

        public static bool Debug = false;

        public static void LoadConfig()
        {
            string DBHost = ConfigurationManager.AppSettings["DBHost"].ToString();
            string DBDatabase = ConfigurationManager.AppSettings["DBDatabase"].ToString();
            string DBUser = ConfigurationManager.AppSettings["DBUser"].ToString();
            string DBPassword = ConfigurationManager.AppSettings["DBPassword"].ToString();
            string DBCollate = ConfigurationManager.AppSettings["DBCollate"].ToString();

            Conn = new SQLConnection(string.Format(MSSQLConnStringFormat, DBHost, DBDatabase, DBUser, DBPassword), Debug);
        }

        public static bool SweetAlert(ShowBoxType type,string msg)
        {
            using (var form = new ShowBox(type,msg))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    return true;
                else
                    return false;
            }
        }

        public static int getSelectIndex(ComboBox ddl, string selectTxt)
        {
            int index = 0;
            foreach (string item in ddl.Items)
            {
                if (item == selectTxt)
                    return index;
                else
                    index++;
            }
            return -1;
        }

        private static List<T> GetEnumList<T>()
        {
            T[] array = (T[])Enum.GetValues(typeof(T));
            List<T> list = new List<T>(array);
            return list;
        }

        public static ComboBox loadEnum<T>(ComboBox c,string selected="", bool isALL = false)
        {
            List<T> list = GetEnumList<T>();
            c.Items.Clear();
            if (isALL)
                c.Items.Add("全部");
            foreach (T item in list)
            {
                c.Items.Add(item.ToString());
            }
            if (string.IsNullOrEmpty(selected))
                c.SelectedIndex = 0;
            else
                c.SelectedIndex = getSelectIndex(c, selected);

            return c;
        }

        public static ComboBox loadPhrase(ComboBox c, string category,bool isALL=false)
        {
            c.Items.Clear();
            if (isALL)
                c.Items.Add("全部");
            PhraseInfo view = new PhraseInfo(APConfig.Conn);
            view.Conditions = " 1=1 ";
            view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.category.ToString(), category);
            view.load();
            while(!view.IsEof)
            {
                c.Items.Add(view.PHS_NAME);
                view.next();
            }
            return c;
        }

        public static string sqlArrayFormat(string param)
        {
            string[] items = param.Split(',');
            for (int index = 0; index < items.Length; index++)
            {
                items[index] = string.Format("'{0}'", items[index]);
            }
            return string.Join(",", items);
        }
    }
}
