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
    public partial class PickInventoryDelete : Form
    {
        public mode mode;
        public string sernolist = "";
        public PickInventoryDelete(mode pmode, string pSernoList)
        {
            InitializeComponent();
            mode = pmode;
            sernolist = pSernoList;
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
                    rows.Add(new Object[] { view.INV_SERNO, view.INV_STATUS,true, info });
                }
                else
                {
                    rows.Add(new Object[] { view.INV_SERNO, view.INV_STATUS, true, view.INV_CODE });
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
            if (e.ColumnIndex != 2)
                return;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dgvInventory.EndEdit();
                List<string> sernolist = new List<string>();
                string delSernoList = "";
                foreach (DataGridViewRow row in dgvInventory.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[2];
                    if ((bool)chk.Value)
                        sernolist.Add(row.Cells["dgvInventory_Serno"].Value.ToString());
                }
                delSernoList = APConfig.sqlArrayFormat(string.Join(",", sernolist));
                Inventory ent = new Inventory(APConfig.Conn);
                string sConditions = ent.getCondition(Inventory.ncConditions.sernolist.ToString(), delSernoList);
                ent.deleteAll(sConditions);
                APConfig.SweetAlert(ShowBoxType.alert, "刪除完成");
                this.Close();
            }
            catch (Exception ex)
            {
                APConfig.SweetAlert(ShowBoxType.alert, string.Format("刪除失敗 {0}", ex.Message));
            }
        }
    }
}
