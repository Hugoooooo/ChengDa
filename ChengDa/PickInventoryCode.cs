using Bunifu.Framework.UI;
using System.Application.Common;
using System.Framework;
using System.DataLayer.Entities;
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
    public partial class PickInventoryCode : Form
    {
        public mode mode;
        public string sernolist = "";
        public PickInventoryCode(mode pmode, string pSernoList)
        {
            InitializeComponent();
            mode = pmode;
            sernolist = APConfig.sqlArrayFormat(pSernoList);
            loadData();
        }

        private void loadData()
        {
            dgvInventory.Rows.Clear();
            string info = "";
            DataGridViewRowCollection rows = dgvInventory.Rows;

            InventoryInfo view = new InventoryInfo(APConfig.Conn);
            view.Conditions = " 1=1 ";
            view.Conditions += " AND "+view.getCondition(InventoryInfo.ncConditions.sernolist.ToString(), sernolist);
            view.OrderBy = view.getOptionOrderBy(InventoryInfo.ncOrderBy.ODBcode.ToString());
            view.load();
            while(!view.IsEof)
            {
                if(string.IsNullOrEmpty(view.INV_CODE))
                {
                    info = string.Format("寄庫品( 寄庫金額:{0:n0}元 / 寄庫時間:{1} )", view.INV_POSTAMT, view.INV_POSTDTTM.ToShortDateString());
                    rows.Add(new Object[] { view.INV_SERNO, view.INV_STATUS, info });
                }
                else
                {
                    rows.Add(new Object[] { view.INV_SERNO, view.INV_STATUS, view.INV_CODE });
                }
                view.next();
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dgvInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvInventory.SelectedRows[0];
            string status = row.Cells["dgvInventory_Status"].Value.ToString();
            if(status==InventoryStatus.已出貨.ToString())
            {
                this.Hide();
                InventoryExportEdit form = new InventoryExportEdit(mode, row.Cells["dgvInventory_Serno"].Value.ToString());
                form.ShowDialog();
                this.Close();
            }
            else if(status == InventoryStatus.庫存中.ToString())
            {
                this.Hide();
                InventoryImportEdit form = new InventoryImportEdit(mode, row.Cells["dgvInventory_Serno"].Value.ToString());
                form.ShowDialog();
                this.Close();
            }
            else if (status == InventoryStatus.寄庫品.ToString())
            {
                this.Hide();
                InventoryPostEdit form = new InventoryPostEdit(mode, row.Cells["dgvInventory_Serno"].Value.ToString());
                form.ShowDialog();
                this.Close();
            }
            else if (status == InventoryStatus.進貨退出.ToString())
            {
                this.Hide();
                InventoryReturnEdit form = new InventoryReturnEdit(mode, row.Cells["dgvInventory_Serno"].Value.ToString());
                form.ShowDialog();
                this.Close();
            }
            else
            {
                APConfig.SweetAlert(ShowBoxType.alert, "請聯繫Hugo!");
                this.Close();
            }
        }
    }
}
