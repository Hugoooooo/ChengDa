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
    public partial class PickItem : Form
    {
        public string itemInfo;

        public PickItem(string pItem="")
        {
            InitializeComponent();
            txtItem.Text = pItem;
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            itemInfo = txtItem.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ItemSearch()
        {
            lbxItem.Items.Clear();
            PhraseInfo view = new PhraseInfo(APConfig.Conn);
            view.Conditions = " 1=1 ";
            view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.category.ToString(), PhraseCategory.銷售商品資訊.ToString());
            if (!string.IsNullOrEmpty(txtName.Text))
                view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.name.ToString(), txtName.Text);
            view.load();
            while (!view.IsEof)
            {
                lbxItem.Items.Add(view.PHS_TYPE + view.PHS_NAME);
                view.next();
            }
        }

        private void lbxItem_DoubleClick(object sender, EventArgs e)
        {
            txtItem.Text += lbxItem.GetItemText(lbxItem.SelectedItem);
        }
    }
}
