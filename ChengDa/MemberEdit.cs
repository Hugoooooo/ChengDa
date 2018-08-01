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
    public partial class MemberEdit : Form
    {
        public mode mode;
        public string serno;
        public MemberEdit(mode pmode,string pserno="")
        {
            InitializeComponent();
            APConfig.loadPhrase(ddlPrinciple, PhraseCategory.案件負責人.ToString());
            serno = pserno;
            mode = pmode;
            initView();
            txtMain.Focus();
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
                ddlPrinciple.SelectedIndex = 0;
                ddlSex.SelectedIndex = 0;
            }
            else if (mode == mode.Edit)
            {
                btnOK.ButtonText = "修改";
                btnOK.IdleFillColor = Color.FromArgb(255, 161, 0);
                btnOK.IdleLineColor = Color.FromArgb(255, 161, 0);
                btnOK.ActiveFillColor = Color.FromArgb(255, 161, 0);
                btnOK.ActiveLineColor = Color.FromArgb(255, 161, 0);
                txtMain.Enabled = false;
                panelInfo.Visible = true;
                RosterInfo vRoster = new RosterInfo(APConfig.Conn);
                vRoster.Conditions = " 1=1 ";
                vRoster.Conditions += " AND " + vRoster.getCondition(RosterInfo.ncConditions.serno.ToString(), serno);
                if (vRoster.load())
                {
                    txtName.Text = vRoster.RST_NAME;
                    txtMain.Text = vRoster.RST_MAIN;
                    txtPhone1.Text = vRoster.RST_PHONE1;
                    txtPhone2.Text = vRoster.RST_PHONE2;
                    txtMobile.Text = vRoster.RST_MOBILE;
                    txtFax.Text = vRoster.RST_FAX;
                    txtAddr.Text = vRoster.RST_ADDR;
                    txtComment.Text = vRoster.RST_COMMENT;
                    ddlSex.SelectedIndex = APConfig.getSelectIndex(ddlSex, vRoster.RST_SEX);
                    ddlPrinciple.SelectedIndex = APConfig.getSelectIndex(ddlPrinciple, vRoster.RST_PRINCIPAL);
                    lblInsertBy.Text = vRoster.RST_INSERTBY;
                    lblInsertDTTM.Text = vRoster.RST_INSERTDTTM.ToString();
                    lblModifyBy.Text = vRoster.RST_MODIFIEDBY;
                    lblModifyDTTM.Text = vRoster.RST_MODIFIEDDTTM.ToString();
                }
            }
            else if (mode == mode.View)
            {
                DisableControls();
                btnOK.ButtonText = "確認";
                txtMobile.Enabled = false;
                btnGetAddress.Visible = false;
                panelInfo.Visible = true;
                RosterInfo vRoster = new RosterInfo(APConfig.Conn);
                vRoster.Conditions = " 1=1 ";
                vRoster.Conditions += " AND " + vRoster.getCondition(RosterInfo.ncConditions.serno.ToString(), serno);
                vRoster.load();
                txtName.Text = vRoster.RST_NAME;
                txtMain.Text = vRoster.RST_MAIN;
                txtPhone1.Text = vRoster.RST_PHONE1;
                txtPhone2.Text = vRoster.RST_PHONE2;
                txtMobile.Text = vRoster.RST_MOBILE;
                txtFax.Text = vRoster.RST_FAX;
                txtAddr.Text = vRoster.RST_ADDR;
                txtComment.Text = vRoster.RST_COMMENT;
                ddlSex.SelectedIndex = APConfig.getSelectIndex(ddlSex, vRoster.RST_SEX);
                ddlPrinciple.SelectedIndex = APConfig.getSelectIndex(ddlPrinciple, vRoster.RST_PRINCIPAL);
                lblInsertBy.Text = vRoster.RST_INSERTBY;
                lblInsertDTTM.Text = vRoster.RST_INSERTDTTM.ToString();
                lblModifyBy.Text = vRoster.RST_MODIFIEDBY;
                lblModifyDTTM.Text = vRoster.RST_MODIFIEDDTTM.ToString();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (mode == mode.Add && checkAdd())
            {
                RosterInfo vRoster = new RosterInfo(APConfig.Conn);
                vRoster.Conditions = vRoster.getCondition(RosterInfo.ncConditions.main.ToString(), txtMain.Text);
                if (vRoster.calculateCount() == 0)
                {
                    Roster entRoster = new Roster(APConfig.Conn);
                    entRoster.RST_SERNO = My.GenSerNo();
                    entRoster.RST_NAME = txtName.Text;
                    entRoster.RST_MAIN = txtMain.Text;
                    entRoster.RST_SEX = ddlSex.SelectedItem.ToString();
                    entRoster.RST_PHONE1 = txtPhone1.Text;
                    entRoster.RST_PHONE2 = txtPhone2.Text;
                    entRoster.RST_MOBILE = txtMobile.Text;
                    entRoster.RST_FAX = txtFax.Text;
                    entRoster.RST_ADDR = txtAddr.Text;
                    entRoster.RST_PRINCIPAL = ddlPrinciple.SelectedItem.ToString();
                    entRoster.RST_COMMENT = txtComment.Text;
                    entRoster.RST_MODIFIEDBY = APConfig.AccountName;
                    entRoster.RST_MODIFIEDDTTM = DateTime.Now;
                    entRoster.RST_INSERTBY = APConfig.AccountName;
                    entRoster.RST_INSERTDTTM = DateTime.Now;
                    entRoster.insert();
                    APConfig.SweetAlert(ShowBoxType.alert, "新增完成");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    APConfig.SweetAlert(ShowBoxType.alert, "主要號碼已經存在");
                    txtMain.Focus();
                }
            }
            else if (mode == mode.Edit && checkAdd())
            {
                Roster entRoster = new Roster(APConfig.Conn);
                entRoster.RST_SERNO = serno;
                entRoster.ModifyFields = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10}"
                    , Roster.ncFields.RST_NAME.ToString()
                    , Roster.ncFields.RST_MAIN.ToString()
                    , Roster.ncFields.RST_SEX.ToString()
                    , Roster.ncFields.RST_PHONE1.ToString()
                    , Roster.ncFields.RST_PHONE2.ToString()
                    , Roster.ncFields.RST_FAX.ToString()
                    , Roster.ncFields.RST_ADDR.ToString()
                    , Roster.ncFields.RST_PRINCIPAL.ToString()
                    , Roster.ncFields.RST_COMMENT.ToString()
                    , Roster.ncFields.RST_MODIFIEDBY.ToString()
                    , Roster.ncFields.RST_MODIFIEDDTTM.ToString());
                entRoster.RST_NAME = txtName.Text;
                entRoster.RST_MAIN = txtMain.Text;
                entRoster.RST_SEX = ddlSex.SelectedItem.ToString();
                entRoster.RST_PHONE1 = txtPhone1.Text;
                entRoster.RST_PHONE2 = txtPhone2.Text;
                entRoster.RST_FAX = txtFax.Text;
                entRoster.RST_ADDR = txtAddr.Text;
                entRoster.RST_PRINCIPAL = ddlPrinciple.SelectedItem.ToString();
                entRoster.RST_COMMENT = txtComment.Text;
                entRoster.RST_MODIFIEDBY = APConfig.AccountName;
                entRoster.RST_MODIFIEDDTTM = DateTime.Now;
                entRoster.update();
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
        private bool checkAdd()
        {
            string msg = "";
            bool isEmpty = false;
            int count = 0;
            string[] condReqName = { "txtMobile", "txtPhone1", "txtPhone2" }; //判斷欄位三個至少填一個
            string[] condName = { "txtName", "txtAddr", "txtMain" };   //必填欄位
            
            foreach (Control c in this.Controls)
            {
                if (c is BunifuMetroTextbox)
                {
                    BunifuMetroTextbox textBox = c as BunifuMetroTextbox;
                    if (condName.Contains(textBox.Name) && textBox.Text == string.Empty)
                    {
                        msg = "欄位不能為空值!";
                        isEmpty = true;
                    }
                    else if (condReqName.Contains(textBox.Name) && textBox.Text == string.Empty) 
                    {
                        count++;
                    }
                }
                else if (c is BunifuDropdown)
                {
                    BunifuDropdown dropdown = c as BunifuDropdown;
                    if(dropdown.selectedIndex == -1)
                    {
                        msg = "欄位不能為空值!";
                        isEmpty = true;
                    }
                }
            }
            
            if(count ==condReqName.Length)  
            {
                msg = "電話欄位至少輸入一欄!";
                isEmpty = true;
            }

            if (!isEmpty && mode == mode.Add)
            {
                RosterInfo vRoster = new RosterInfo(APConfig.Conn);
                vRoster.Conditions = vRoster.getCondition(RosterInfo.ncConditions.main.ToString(), txtMain.Text);
                if(vRoster.calculateCount()>0)
                    msg = "該手機號碼已經有資料!請重複確認!";
            }

            if (!string.IsNullOrEmpty(msg))
            {
                APConfig.SweetAlert(ShowBoxType.alert, msg);
            }
            return string.IsNullOrEmpty(msg)? true: false;
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
        private void btnGetAddress_Click(object sender, EventArgs e)
        {
            using (var form = new PickAddress(txtAddr.Text))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    txtAddr.Text = form.address;
            }
        }
        private void txtMain_Leave(object sender, EventArgs e)
        {
            RosterInfo vRoster = new RosterInfo(APConfig.Conn);
            vRoster.Conditions = vRoster.getCondition(RosterInfo.ncConditions.main.ToString(), txtMain.Text);
            if(txtMain.Text.Length >10)
            {
                APConfig.SweetAlert(ShowBoxType.alert, "此主要號碼不符合(市話/手機)格式!");
                txtMain.Text = "";
                txtMain.Focus();
            }
            else if (vRoster.calculateCount()>0)
            {
                APConfig.SweetAlert(ShowBoxType.alert, "此主要號碼已經被使用!");
                txtMain.Text = "";
                txtMain.Focus();
            }
            else
            {
                txtMobile.Text = txtMain.Text.Length == 10 ? txtMain.Text : "";
                txtPhone1.Text = txtMain.Text.Length < 10 ? txtMain.Text : "";
            }
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
    }
}
