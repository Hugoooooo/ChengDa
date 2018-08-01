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
    public partial class TradeEdit : Form
    {
        public mode mode;
        public string serno;
        public RosterInfo mRosterInfo = null;
        public TradeEdit(mode pmode, string pserno = "", RosterInfo pRosterInfo = null)
        {
            InitializeComponent();
            APConfig.loadPhrase(ddlDealer, PhraseCategory.案件負責人.ToString());
            APConfig.loadPhrase(ddlType, PhraseCategory.收入類別.ToString());
            serno = pserno;
            mode = pmode;
            mRosterInfo = pRosterInfo;
            initView();
        }
        private void initView()
        {
            if (mode == mode.Add)
            {
                btnOK.ButtonText = "新增";
                btnOK.IdleFillColor = Color.FromArgb(33, 166, 117);
                btnOK.IdleLineColor = Color.FromArgb(33, 166, 117);
                btnOK.ActiveFillColor = Color.FromArgb(33, 166, 117);
                btnOK.ActiveLineColor = Color.FromArgb(33, 166, 117);
                panelInfo.Visible = false;
                txtName.Text = mRosterInfo.RST_NAME;
                txtMobile.Text = mRosterInfo.RST_MAIN;
                txtAddr.Text = mRosterInfo.RST_ADDR;
                dpkDealDTTM.Value = DateTime.Today;
                ddlStatus.SelectedIndex = 3;
                ddlType.SelectedIndex = 0;
                ddlDealer.SelectedIndex = APConfig.getSelectIndex(ddlDealer, mRosterInfo.RST_PRINCIPAL) == -1 ? 0 : APConfig.getSelectIndex(ddlDealer, mRosterInfo.RST_PRINCIPAL);
                ddlY.SelectedIndex = 0;
                ddlM.SelectedIndex = 0;
            }
            else if (mode == mode.Edit)
            {
                btnOK.ButtonText = "修改";
                btnOK.IdleFillColor = Color.FromArgb(255, 161, 0);
                btnOK.IdleLineColor = Color.FromArgb(255, 161, 0);
                btnOK.ActiveFillColor = Color.FromArgb(255, 161, 0);
                btnOK.ActiveLineColor = Color.FromArgb(255, 161, 0);
                btnItemAdd.Visible = false;
                btnItemDel.Visible = false;
                btnItemPick.Visible = false;
                btnClear.Visible = false;
                btnDone.Visible = false;
                lblTotalAmt.Visible = false;
                panelInfo.Visible = true;
                RosterDial_RInfo view = new RosterDial_RInfo(APConfig.Conn);
                view.Conditions = " 1=1 ";
                view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.rsdserno.ToString(), serno);
                if (view.load())
                {
                    txtName.Text = view.RST_NAME;
                    txtMobile.Text = view.RST_MAIN;
                    txtAddr.Text = view.RST_ADDR;
                    ddlDealer.SelectedIndex = APConfig.getSelectIndex(ddlDealer, view.RSD_DEALER);
                    ddlStatus.SelectedIndex = APConfig.getSelectIndex(ddlStatus, view.RSD_STATUS);
                    ddlType.SelectedIndex = APConfig.getSelectIndex(ddlType, view.RSD_ITEMTYPE);
                    txtItemInfo.Text = view.RSD_ITEM;
                    txtAmount.Text = view.RSD_AMOUNT;
                    txtComment.Text = view.RSD_COMMENT;
                    lblInsertBy.Text = view.RSD_INSERTBY;
                    lblInsertDTTM.Text = view.RSD_INSERTDTTM.ToString();
                    lblModifyBy.Text = view.RSD_MODIFIEDBY;
                    lblModifyDTTM.Text = view.RSD_MODIFIEDDTTM.ToString();
                    dpkDealDTTM.Value = view.RSD_DEALDDTTM;
                }
            }
            else if (mode == mode.View)
            {
                DisableControls();
                btnOK.ButtonText = "確認";
                btnItemAdd.Visible = false;
                btnItemDel.Visible = false;
                btnClear.Visible = false;
                btnItemPick.Visible = false;
                btnDone.Visible = false;
                panelInfo.Visible = true;
                lblTotalAmt.Visible = false;
                RosterDial_RInfo view = new RosterDial_RInfo(APConfig.Conn);
                view.Conditions = " 1=1 ";
                view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.rsdserno.ToString(), serno);
                if (view.load())
                {
                    txtName.Text = view.RST_NAME;
                    txtMobile.Text = view.RST_MAIN;
                    txtAddr.Text = view.RST_ADDR;
                    ddlDealer.SelectedIndex = APConfig.getSelectIndex(ddlDealer, view.RSD_DEALER);
                    ddlStatus.SelectedIndex = APConfig.getSelectIndex(ddlStatus, view.RSD_STATUS);
                    ddlType.SelectedIndex = APConfig.getSelectIndex(ddlType, view.RSD_ITEMTYPE);
                    txtItemInfo.Text = view.RSD_ITEM;
                    txtAmount.Text = view.RSD_AMOUNT;
                    txtComment.Text = view.RSD_COMMENT;
                    lblInsertBy.Text = view.RSD_INSERTBY;
                    lblInsertDTTM.Text = view.RSD_INSERTDTTM.ToString();
                    lblModifyBy.Text = view.RSD_MODIFIEDBY;
                    lblModifyDTTM.Text = view.RSD_MODIFIEDDTTM.ToString();
                    dpkDealDTTM.Value = view.RSD_DEALDDTTM;
                }
            }
        }
        private bool checkAdd()
        {
            string msg = "";
            if (mode == mode.Add && dgvItem.RowCount<=0)
                msg = "商品資訊無法為空!";
            else if (mode == mode.Edit && string.IsNullOrEmpty(txtAmount.Text))
                msg = "實收無法為空!";
            else if (mode == mode.Edit && string.IsNullOrEmpty(txtItemInfo.Text))
                msg = "商品資訊無法為空!";

            if (!string.IsNullOrEmpty(msg))
            {
                APConfig.SweetAlert(ShowBoxType.alert, msg);
            }
            return string.IsNullOrEmpty(msg) ? true : false;
        }
        private void loadTotalAmount()
        {
            int total = 0;
            foreach (DataGridViewRow row in dgvItem.Rows)
            {
                total += int.Parse(row.Cells["dgvItem_Amount"].Value.ToString());
            }
            lblTotalAmt.Text = string.Format("總金額: {0:n0} 元", total);
        }
        private void itemInfoAdd()
        {
            #region 判斷
            string msg = "";
            int n;
            if (string.IsNullOrEmpty(txtAmount.Text))
                msg = "請輸入金額";
            else if (string.IsNullOrEmpty(txtItemInfo.Text))
                msg = "請輸入商品資訊";
            else if (!int.TryParse(txtAmount.Text,out n))
                msg = "金額欄位請輸入數字";
            if (!string.IsNullOrEmpty(msg))
            {
                APConfig.SweetAlert(ShowBoxType.alert, msg);
                return;
            }
            #endregion
            DataGridViewRowCollection rows = dgvItem.Rows;
            rows.Add(new Object[] { ddlType.SelectedItem.ToString(), txtItemInfo.Text, txtAmount.Text });
            loadTotalAmount();
        }
        private void DisableControls()
        {
            bool status = false;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is BunifuMetroTextbox)
                    ((BunifuMetroTextbox)ctrl).Enabled = status;
                else if (ctrl is BunifuCheckbox)
                    ((BunifuCheckbox)ctrl).Enabled = status;
                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).Enabled = status;
            }
        }


        private void dgvItem_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvItem.SelectedRows[0];
            ddlType.SelectedIndex = APConfig.getSelectIndex(ddlType, row.Cells["dgvItem_Type"].Value.ToString());
            txtItemInfo.Text = row.Cells["dgvItem_Item"].Value.ToString();
            txtAmount.Text = row.Cells["dgvItem_Amount"].Value.ToString();
        }
        private void ddlY_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlM.SelectedIndex>=0 && ddlY.SelectedIndex >= 0)
                dpkDealDTTM.Value = DateTime.Parse(string.Format("{0}/{1}/01", ddlY.SelectedItem.ToString(), ddlM.SelectedItem.ToString()));
        }
        private void ddlM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlM.SelectedIndex >= 0 && ddlY.SelectedIndex >= 0)
                dpkDealDTTM.Value = DateTime.Parse(string.Format("{0}/{1}/01", ddlY.SelectedItem.ToString(), ddlM.SelectedItem.ToString()));
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            txtComment.Text += lblTotalAmt.Text;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (mode == mode.Add && checkAdd())
            {
                foreach (DataGridViewRow row in dgvItem.Rows)
                {
                    RosterDial ent = new RosterDial(APConfig.Conn);
                    ent.RSD_SERNO = My.GenSerNo();
                    ent.RST_SERNO = mRosterInfo.RST_SERNO;
                    ent.RSD_STATUS = ddlStatus.SelectedItem.ToString();
                    ent.RSD_ITEMTYPE = row.Cells["dgvItem_Type"].Value.ToString();
                    ent.RSD_ITEM = row.Cells["dgvItem_Item"].Value.ToString();
                    ent.RSD_AMOUNT = row.Cells["dgvItem_Amount"].Value.ToString();
                    ent.RSD_COMMENT = txtComment.Text;
                    ent.RSD_DEALER = ddlDealer.SelectedItem.ToString();
                    ent.RSD_MODIFIEDBY = APConfig.AccountName;
                    ent.RSD_MODIFIEDDTTM = DateTime.Now;
                    ent.RSD_INSERTBY = APConfig.AccountName;
                    ent.RSD_INSERTDTTM = DateTime.Now;
                    ent.RSD_DEALDDTTM = DateTime.Parse(dpkDealDTTM.Value.ToString());
                    ent.insert();
                }
                APConfig.SweetAlert(ShowBoxType.alert, "新增完成");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (mode == mode.Edit && checkAdd())
            {
                RosterDial ent = new RosterDial(APConfig.Conn);
                ent.RSD_SERNO = serno;
                ent.ModifyFields = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8}"
                    , RosterDial.ncFields.RSD_DEALER.ToString()
                    , RosterDial.ncFields.RSD_STATUS.ToString()
                    , RosterDial.ncFields.RSD_ITEMTYPE.ToString()
                    , RosterDial.ncFields.RSD_ITEM.ToString()
                    , RosterDial.ncFields.RSD_AMOUNT.ToString()
                    , RosterDial.ncFields.RSD_COMMENT.ToString()
                    , RosterDial.ncFields.RSD_MODIFIEDBY.ToString()
                    , RosterDial.ncFields.RSD_MODIFIEDDTTM.ToString()
                    , RosterDial.ncFields.RSD_DEALDDTTM.ToString());
                ent.RSD_DEALER = ddlDealer.SelectedItem.ToString();
                ent.RSD_STATUS = ddlStatus.SelectedItem.ToString();
                ent.RSD_ITEMTYPE = ddlType.SelectedItem.ToString();
                ent.RSD_ITEM = txtItemInfo.Text;
                ent.RSD_AMOUNT = txtAmount.Text;
                ent.RSD_COMMENT = txtComment.Text;
                ent.RSD_MODIFIEDBY = APConfig.AccountName;
                ent.RSD_MODIFIEDDTTM = DateTime.Now;
                ent.RSD_DEALDDTTM = DateTime.Parse(dpkDealDTTM.Value.ToString());
                ent.update();
                APConfig.SweetAlert(ShowBoxType.alert, "修改完成");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (mode == mode.View)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                return;
        }
        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            itemInfoAdd();
        }
        private void btnItemDel_Click(object sender, EventArgs e)
        {
            if (APConfig.SweetAlert(ShowBoxType.confirm, "是否確定要刪除?"))
            {
                foreach (DataGridViewRow row in dgvItem.SelectedRows)
                {
                    dgvItem.Rows.RemoveAt(row.Index);
                }
            }
            loadTotalAmount();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemInfo.Text = "";
            txtAmount.Text = "";
            txtItemInfo.Focus();
        }
        private void btnItemPick_Click(object sender, EventArgs e)
        {
            using (var form = new PickItem(txtItemInfo.Text))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    txtItemInfo.Text = form.itemInfo;
            }
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #region 移動介面 (Border Style = none)
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panelBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panelBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        #endregion

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemInfoAdd();
            }
        }

        private void txtItemInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemInfoAdd();
            }
        }
    }
}
