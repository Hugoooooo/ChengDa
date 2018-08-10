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
                dgvItem.Rows.Clear();
                DataGridViewRowCollection rows = dgvItem.Rows;
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
                    rows.Add(new Object[] { view.INV_SERNO, view.INV_CODE });
                    view.next();
                }
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                dgvPost.Rows.Clear();
                DataGridViewRowCollection rows = dgvPost.Rows;
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
                    rows.Add(new Object[] { view.INV_SERNO, view.INV_NAME, view.INV_POSTAMT, view.INV_POSTDTTM.ToShortDateString() });
                    view.next();
                }
            }
          
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvPost_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.dgvPost.SelectedRows[0];
            itemserno = row.Cells["dgvPost_Serno"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgvItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.dgvItem.SelectedRows[0];
            itemserno = row.Cells["dgvItem_Serno"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
