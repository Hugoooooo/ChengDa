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
    public partial class PickMember : Form
    {
        public RosterInfo pRosterInfo { get; set; }
        public PickMember()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            submit();
        }

        private void submit()
        {
            RosterInfo vRoster = new RosterInfo(APConfig.Conn);
            vRoster.Conditions = vRoster.getCondition(RosterInfo.ncConditions.main.ToString(), txtMain.Text);
            if (!vRoster.load())
            {
                APConfig.SweetAlert(ShowBoxType.alert, "查無此主要號碼");
            }
            else
            {
                this.Hide();
                TradeEdit form = new TradeEdit(mode.Add, "", vRoster);
                form.ShowDialog();
                this.Close();
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void txtMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submit();
            }
        }
    }
}
