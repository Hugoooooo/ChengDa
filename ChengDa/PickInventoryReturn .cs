using System.Framework;
using System.DataLayer.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChengDa
{
    public partial class PickInventoryReturn : Form
    {
        public string itemserno;
        public string sernolist;
        public class SomeData
        {
            public string Value { get; set; }
            public string Text { get; set; }
        }

        public PickInventoryReturn(string pSernoList)
        {
            InitializeComponent();
            sernolist = string.IsNullOrEmpty(pSernoList) ? "" : APConfig.sqlArrayFormat(pSernoList);
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void loadData()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                lbxItem.DataSource = null;
                List<SomeData> data = new List<SomeData>();
                InventoryInfo view = new InventoryInfo(APConfig.Conn);
                view.Conditions = " 1=1 ";
                view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.status.ToString(), InventoryStatus.庫存中.ToString());
                if (!string.IsNullOrEmpty(txtCode.Text))
                    view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.LKcode.ToString(), txtCode.Text);
                if (!string.IsNullOrEmpty(txtName.Text))
                    view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.LKname.ToString(), txtName.Text);
                if (!string.IsNullOrEmpty(sernolist))
                    view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.NINsernolist.ToString(), sernolist);
                view.load();
                while (!view.IsEof)
                {
                    data.Add(new SomeData() { Value = view.INV_SERNO, Text = view.INV_CODE });
                    view.next();
                }
                lbxItem.DisplayMember = "Text";
                lbxItem.DataSource = data;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                string info = "";
                lbxPost.DataSource = null;
                List<SomeData> data = new List<SomeData>();
                InventoryInfo view = new InventoryInfo(APConfig.Conn);
                view.Conditions = " 1=1 ";
                view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.status.ToString(), InventoryStatus.寄庫品.ToString());
                if (!string.IsNullOrEmpty(txtCode.Text))
                    view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.LKcode.ToString(), txtCode.Text);
                if (!string.IsNullOrEmpty(txtName.Text))
                    view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.LKname.ToString(), txtName.Text);
                if (!string.IsNullOrEmpty(sernolist))
                    view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.NINsernolist.ToString(), sernolist);
                view.OrderBy = view.getOptionOrderBy(InventoryInfo.ncOrderBy.ODBname.ToString());
                view.load();
                while (!view.IsEof)
                {
                    info = string.Format("[{0}] ( 寄庫金額:{1:n0}元 / 寄庫時間:{2} )", view.INV_NAME, view.INV_POSTAMT, view.INV_POSTDTTM.ToShortDateString());
                    data.Add(new SomeData() { Value = view.INV_SERNO, Text = info });
                    view.next();
                }
                lbxPost.DisplayMember = "Text";
                lbxPost.DataSource = data;
            }
          
        }

        private void lbxItem_DoubleClick(object sender, EventArgs e)
        {
            itemserno = (lbxItem.SelectedItem as SomeData).Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lbxPost_DoubleClick(object sender, EventArgs e)
        {
            itemserno = (lbxPost.SelectedItem as SomeData).Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
