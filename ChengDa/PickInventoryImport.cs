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
    public partial class PickInventoryImport : Form
    {
        public string itemserno;
        public string sernolist;
        public class SomeData
        {
            public string Value { get; set; }
            public string Text { get; set; }
        }

        public PickInventoryImport(string pSernoList)
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
            lbxItem.DataSource=null;
            List<SomeData> data = new List<SomeData>();
            InventoryInfo view = new InventoryInfo(APConfig.Conn);
            view.Conditions = " 1=1 ";
            view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.status.ToString(), InventoryStatus.庫存中.ToString());
            if(!string.IsNullOrEmpty(txtName.Text))
                view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.LKcode.ToString(),txtName.Text);
            if (!string.IsNullOrEmpty(sernolist))
                view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.NINsernolist.ToString(), sernolist);
            view.OrderBy = view.getOptionOrderBy(InventoryInfo.ncOrderBy.ODBcode.ToString());
            view.load();
            while (!view.IsEof)
            {
                data.Add(new SomeData() { Value = view.INV_SERNO, Text = view.INV_CODE });
                view.next();
            }
            lbxItem.DisplayMember = "Text";
            lbxItem.DataSource = data;
        }

        private void lbxItem_DoubleClick(object sender, EventArgs e)
        {
            itemserno = (lbxItem.SelectedItem as SomeData).Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
