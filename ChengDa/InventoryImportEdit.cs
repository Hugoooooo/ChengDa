﻿using Bunifu.Framework.UI;
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
    public partial class InventoryImportEdit : Form
    {
        public mode mode;
        public string postSerno="";
        public string serno;
        public InventoryImportEdit(mode pmode, string pserno = "")
        {
            InitializeComponent();
            serno = pserno;
            mode = pmode;
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
                dpkImportDTTM.Value = DateTime.Today;
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
                btnItemPost.Visible = false;
                btnClear.Visible = false;
                lblTotalAmt.Visible = false;
                txtCode.Enabled = false;
                InventoryInfo view = new InventoryInfo(APConfig.Conn);
                view.Conditions = " 1=1 ";
                view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.serno.ToString(), serno);
                view.load();
                if (view.load())
                {
                    txtCode.Text = view.INV_CODE;
                    txtName.Text = view.INV_NAME;
                    txtAmount.Text = view.INV_INAMT.ToString();
                    txtComment.Text = view.INV_INCOMMENT;
                    dpkImportDTTM.Value = view.INV_INDTTM;
                }
            }
            else if (mode == mode.View)
            {
                DisableControls();
                btnOK.ButtonText = "確認";
                btnItemAdd.Visible = false;
                btnItemDel.Visible = false;
                btnItemPost.Visible = false;
                btnClear.Visible = false;
                lblTotalAmt.Visible = false;
                InventoryInfo view = new InventoryInfo(APConfig.Conn);
                view.Conditions = " 1=1 ";
                view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.serno.ToString(), serno);
                view.load();
                if (view.load())
                {
                    txtCode.Text = view.INV_CODE;
                    txtName.Text = view.INV_NAME;
                    txtAmount.Text = view.INV_INAMT.ToString();
                    txtComment.Text = view.INV_INCOMMENT;
                    dpkImportDTTM.Value = view.INV_INDTTM;
                }
            }
        }
        private bool checkAdd()
        {
            string msg = "";
            if (mode == mode.Add && dgvItem.RowCount<=0)
                msg = "商品資訊無法為空!";
            else if (mode == mode.Edit && string.IsNullOrEmpty(txtAmount.Text))
                msg = "商品金額無法為空!";
            else if (mode == mode.Edit && string.IsNullOrEmpty(txtName.Text))
                msg = "商品名稱無法為空!";
            else if (mode == mode.Edit && string.IsNullOrEmpty(txtCode.Text))
                msg = "商品代碼無法為空!";


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
        private void loadRowColor()
        {
            foreach (DataGridViewRow row in dgvItem.Rows)
            {
                if(!string.IsNullOrEmpty(row.Cells["dgvItem_Serno"].Value.ToString()))
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        private void itemInfoAdd()
        {
            #region 判斷
            string msg = "";
            if (string.IsNullOrEmpty(txtAmount.Text))
                msg = "請輸入金額";
            else if (!int.TryParse(txtAmount.Text,out int n))
                msg = "金額欄位請輸入數字";
            else if (string.IsNullOrEmpty(txtCode.Text))
                msg = "請輸入商品代碼";
            else if (string.IsNullOrEmpty(txtName.Text))
                msg = "請輸入商品名稱";

            //進階判斷
            if(string.IsNullOrEmpty(msg))
            {
                //條碼不行重複!!!!
                InventoryInfo view = new InventoryInfo(APConfig.Conn);
                view.Conditions = " 1=1 ";
                view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.code.ToString(), txtCode.Text);
                if (view.calculateCount() > 0)
                    msg = "該條碼已經被使用!";

                foreach (DataGridViewRow row in dgvItem.Rows)
                {
                    if (txtCode.Text == row.Cells["dgvItem_Code"].Value.ToString())
                    {
                        msg = "該條碼已經被使用!";
                        break;
                    }
                    else if (!string.IsNullOrEmpty(postSerno) && postSerno == row.Cells["dgvItem_Serno"].Value.ToString())
                    {
                        msg = "該寄庫品已重複!";
                        break;
                    }

                }
            }

            if (!string.IsNullOrEmpty(msg))
            {
                APConfig.SweetAlert(ShowBoxType.alert, msg);
                return;
            }
            #endregion


            DataGridViewRowCollection rows = dgvItem.Rows;
            rows.Add(new Object[] { postSerno, txtCode.Text, txtName.Text, txtAmount.Text, dpkImportDTTM.Value.ToShortDateString(), txtComment.Text });
            postSerno = "";
            clearPage();
            loadTotalAmount();
            loadRowColor();
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
            txtCode.Text = row.Cells["dgvItem_Code"].Value.ToString();
            txtName.Text = row.Cells["dgvItem_Name"].Value.ToString();
            txtAmount.Text = row.Cells["dgvItem_Amount"].Value.ToString();
            dpkImportDTTM.Value = Convert.ToDateTime(row.Cells["dgvItem_ImportDTTM"].Value);
            txtComment.Text = row.Cells["dgvItem_Comment"].Value.ToString();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (mode == mode.Add && checkAdd())
            {
                int newCount = 0,postCount=0;
                foreach (DataGridViewRow row in dgvItem.Rows)
                {
                    //寄庫存進貨
                    if(!string.IsNullOrEmpty(row.Cells["dgvItem_Serno"].Value.ToString()))
                    {
                        Inventory ent = new Inventory(APConfig.Conn);
                        ent.INV_SERNO = row.Cells["dgvItem_Serno"].Value.ToString();
                        ent.ModifyFields = string.Format("{0};{1};{2};{3};{4};{5};{6};{7}"
                            ,Inventory.ncFields.INV_STATUS.ToString()
                            , Inventory.ncFields.INV_NAME.ToString()
                            , Inventory.ncFields.INV_CODE.ToString()
                            , Inventory.ncFields.INV_INAMT.ToString()
                            , Inventory.ncFields.INV_INDTTM.ToString()
                            , Inventory.ncFields.INV_INCOMMENT.ToString()
                            , Inventory.ncFields.INV_MODIFIEDBY.ToString()
                            , Inventory.ncFields.INV_MODIFIEDDTTM.ToString());
                        ent.INV_STATUS = InventoryStatus.庫存中.ToString();
                        ent.INV_CODE = row.Cells["dgvItem_Code"].Value.ToString();
                        ent.INV_NAME = row.Cells["dgvItem_Name"].Value.ToString();
                        ent.INV_INAMT = Convert.ToInt32(row.Cells["dgvItem_Amount"].Value);
                        ent.INV_INDTTM = DateTime.Parse(row.Cells["dgvItem_ImportDTTM"].Value.ToString());
                        ent.INV_INCOMMENT = row.Cells["dgvItem_Comment"].Value.ToString();
                        ent.INV_MODIFIEDBY = APConfig.AccountName;
                        ent.INV_MODIFIEDDTTM = DateTime.Now;
                        postCount += ent.update();
                    }
                    
                    else
                    {
                        Inventory ent = new Inventory(APConfig.Conn);
                        ent.INV_SERNO = My.GenSerNo();
                        ent.INV_STATUS = InventoryStatus.庫存中.ToString();
                        ent.INV_CODE = row.Cells["dgvItem_Code"].Value.ToString();
                        ent.INV_NAME = row.Cells["dgvItem_Name"].Value.ToString();
                        ent.INV_INCOMMENT = row.Cells["dgvItem_Comment"].Value.ToString();
                        ent.INV_INAMT = Convert.ToInt32(row.Cells["dgvItem_Amount"].Value);
                        ent.INV_INDTTM = DateTime.Parse(row.Cells["dgvItem_ImportDTTM"].Value.ToString());
                        ent.INV_MODIFIEDBY = APConfig.AccountName;
                        ent.INV_MODIFIEDDTTM = DateTime.Now;
                        newCount += ent.insert();
                    }
                }
                APConfig.SweetAlert(ShowBoxType.alert, string.Format("進貨完成!\r\n新增 {0} 件進貨單 和 {1} 件寄庫存進貨單", newCount.ToString(), postCount.ToString()));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (mode == mode.Edit && checkAdd())
            {
                Inventory ent = new Inventory(APConfig.Conn);
                ent.INV_SERNO = serno;
                ent.ModifyFields = string.Format("{0};{1};{2};{3};{4};{5}"
                    , Inventory.ncFields.INV_NAME.ToString()
                    , Inventory.ncFields.INV_INAMT.ToString()
                    , Inventory.ncFields.INV_INDTTM.ToString()
                    , Inventory.ncFields.INV_INCOMMENT.ToString()
                    , Inventory.ncFields.INV_MODIFIEDBY.ToString()
                    , Inventory.ncFields.INV_MODIFIEDDTTM.ToString());
                ent.INV_NAME = txtName.Text;
                ent.INV_INAMT = Convert.ToInt32(txtAmount.Text);
                ent.INV_INDTTM = DateTime.Parse(dpkImportDTTM.Value.ToString());
                ent.INV_INCOMMENT = txtComment.Text;
                ent.INV_MODIFIEDBY = APConfig.AccountName;
                ent.INV_MODIFIEDDTTM = DateTime.Now;
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
            clearPage();
        }
        private void clearPage()
        {
            postSerno = "";
            txtCode.Text = "";
            txtName.Text = "";
            txtAmount.Text = "";
            //dpkImportDTTM.Value = DateTime.Today;
            txtComment.Text = "";
            txtCode.Focus();
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
        private void txtComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemInfoAdd();
            }
        }
        private void btnItemPost_Click(object sender, EventArgs e)
        {
            List<string> curPostList = new List<string>();
            foreach (DataGridViewRow row in dgvItem.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells["dgvItem_Serno"].Value.ToString()))
                    curPostList.Add(row.Cells["dgvItem_Serno"].Value.ToString());
            }
            using (var form = new PickInventoryPost(string.Join(",", curPostList)))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    loadPostSerno(form.itemserno);
                }
            }
        }
        private void loadPostSerno(string serno)
        {
            if (string.IsNullOrEmpty(serno))
                APConfig.SweetAlert(ShowBoxType.alert, "寄存品載入失敗!聯繫Hugo!");
            else
            {
                InventoryInfo view = new InventoryInfo(APConfig.Conn);
                view.Conditions = " 1=1 ";
                view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.serno.ToString(), serno);
                if(view.load())
                {
                    txtName.Text = view.INV_NAME;
                    txtAmount.Text = view.INV_POSTAMT.ToString();
                    postSerno = view.INV_SERNO;
                }

            }
        }
    }
}
