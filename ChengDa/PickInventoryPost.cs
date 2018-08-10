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
    public partial class PickInventoryPost : Form
    {
        public string itemserno;
        public string sernolist;

        public PickInventoryPost(string pSernoList)
        {
            InitializeComponent();
            sernolist = string.IsNullOrEmpty(pSernoList) ? "" : APConfig.sqlArrayFormat(pSernoList);
            ItemSearch();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ItemSearch();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ItemSearch()
        {
            dgvItem.Rows.Clear();
            DataGridViewRowCollection rows = dgvItem.Rows;
            InventoryInfo view = new InventoryInfo(APConfig.Conn);
            int totalamount = 0;
            view.Conditions = " 1=1 ";
            view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.status.ToString(), InventoryStatus.寄庫品.ToString());
            if(!string.IsNullOrEmpty(txtName.Text))
                view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.LKname.ToString(),txtName.Text);
            if (!string.IsNullOrEmpty(sernolist))
                view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.NINsernolist.ToString(), sernolist);
            view.OrderBy = view.getOptionOrderBy(InventoryInfo.ncOrderBy.ODBname.ToString());
            view.load();
            while (!view.IsEof)
            {
                rows.Add(new Object[] { view.INV_SERNO,view.INV_NAME,view.INV_POSTAMT,view.INV_POSTDTTM.ToShortDateString() });
                totalamount += view.INV_POSTAMT;
                view.next();
            }
            lblTotalCount.Text = string.Format("總件數:{0}", view.calculateCount());
            lblTotalAmt.Text = string.Format("總金額:{0}", totalamount);
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
