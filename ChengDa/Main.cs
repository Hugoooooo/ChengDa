using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Application.DataAccess.Common;
using System.Framework;
using System.DataLayer.Entities;
using System.DataLayer.Views;

namespace ChengDa
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            memberInitial();
            lblUser.Text = APConfig.AccountName;
            panelSale.Visible = false;
            panelInventory.Visible = false;
            panelPhrase.Visible = false;
            panelMember.Visible = true;
        }

        #region Panel Member
        private void memberInitial()
        {
            dgvMember.Rows.Clear();
            txtMemberAddr.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtMemberTel.Text = string.Empty;
            ckbMemberInsertDTTM.Checked = false;
            ckbMemberModifyDTTM.Checked = false;
            dpkMemberInsertSDTTM.Value = DateTime.Today;
            dpkMemberInsertEDTTM.Value = DateTime.Today;
            dpkMemberModifySDTTM.Value = DateTime.Today;
            dpkMemberModifyEDTTM.Value = DateTime.Today;
            ddlMemberPage.Items.Clear();
            lblMemberTotal.Text = "0";
        }
        private void memberLoadData(int pageNum)
        {
            dgvMember.Rows.Clear();
            DataGridViewRowCollection rows = dgvMember.Rows;
            RosterInfo vRoster = new RosterInfo(APConfig.Conn);
            vRoster.Conditions = " 1=1 ";
            if (!string.IsNullOrEmpty(txtMemberName.Text))
                vRoster.Conditions += " AND " + vRoster.getCondition(RosterInfo.ncConditions.name.ToString(), txtMemberName.Text);
            if (!string.IsNullOrEmpty(txtMemberTel.Text))
                vRoster.Conditions += " AND " + vRoster.getCondition(RosterInfo.ncConditions.phoneLike.ToString(), txtMemberTel.Text);
            if (!string.IsNullOrEmpty(txtMemberAddr.Text))
                vRoster.Conditions += " AND " + vRoster.getCondition(RosterInfo.ncConditions.address.ToString(), txtMemberAddr.Text);
            if (!string.IsNullOrEmpty(dpkMemberInsertSDTTM.Value.ToString()) && ckbMemberInsertDTTM.Checked)
                vRoster.Conditions += " AND " + vRoster.getCondition(RosterInfo.ncConditions.createSDTTM.ToString(), dpkMemberInsertSDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkMemberInsertEDTTM.Value.ToString()) && ckbMemberInsertDTTM.Checked)
                vRoster.Conditions += " AND " + vRoster.getCondition(RosterInfo.ncConditions.createEDTTM.ToString(), dpkMemberInsertEDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkMemberModifySDTTM.Value.ToString()) && ckbMemberModifyDTTM.Checked)
                vRoster.Conditions += " AND " + vRoster.getCondition(RosterInfo.ncConditions.modifySDTTM.ToString(), dpkMemberModifySDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkMemberModifyEDTTM.Value.ToString()) && ckbMemberModifyDTTM.Checked)
                vRoster.Conditions += " AND " + vRoster.getCondition(RosterInfo.ncConditions.modifyEDTTM.ToString(), dpkMemberModifyEDTTM.Value.ToString("yyyy/MM/dd"));
            //組排序指令
            if(dgvMember.SortedColumn is null)
                vRoster.OrderBy = vRoster.getOptionOrderBy(RosterInfo.ncSort.Default.ToString());
            else
            {
                string sortname = dgvMember.SortedColumn.Name;
                string sortmode = APConfig.GetValueFromDescription<SortMode>(dgvMember.SortOrder.ToString()).ToString();
                vRoster.OrderBy = string.Format("{0} {1}", vRoster.getOptionOrderBy(sortname), sortmode);
            }
            //查詢頁數初始化且自動跳轉至第一頁
            if (pageNum == 0)
            {
                APConfig.loadPage(ddlMemberPage, vRoster.calculatePage(APConfig.PageCount));
                return;
            }
            //塞入資料
            lblMemberTotal.Text = vRoster.calculateCount().ToString();
            DataSet ds = APConfig.GoPage(vRoster.SQLStatement, pageNum);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rows.Add(new Object[] { dr.ItemArray[0], dr.ItemArray[1], dr.ItemArray[6], dr.ItemArray[4], dr.ItemArray[5], dr.ItemArray[8], dr.ItemArray[10], dr.ItemArray[13] });
            }
        }
        private void btnMemberDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMember.SelectedRows.Count > 0 && APConfig.SweetAlert(ShowBoxType.confirm, string.Format("是否確定要刪除{0}筆?", dgvMember.SelectedRows.Count)))
                {
                    List<string> sernolist = new List<string>();
                    string delSernoList = "";
                    foreach (DataGridViewRow row in dgvMember.SelectedRows)
                    {
                        sernolist.Add(string.Format("'{0}'", row.Cells["dgvMember_Serno"].Value.ToString()));
                    }
                    delSernoList = string.Join(",", sernolist);
                    Roster entRoster = new Roster(APConfig.Conn);
                    string sConditions = entRoster.getCondition(Roster.ncConditions.sernolist.ToString(), delSernoList);
                    entRoster.deleteAll(sConditions);
                    memberLoadData(ddlMemberPage.SelectedIndex + 1);
                    APConfig.SweetAlert(ShowBoxType.alert, "刪除完成");
                }
            }
            catch (Exception ex)
            {
                APConfig.SweetAlert(ShowBoxType.alert, string.Format("刪除失敗 {0}", ex.Message));
            }
        }
        private void btnMemberAdd_Click(object sender, EventArgs e)
        {
            using (var form = new MemberEdit(mode.Add))
            {
                panelMember.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelMember.Visible = true;
                panelMask.Visible = false;
            }
            memberInitial();
        }
        private void btnMemberSearch_Click(object sender, EventArgs e)
        {
            memberLoadData(0);
        }
        private void btnMemberModify_Click(object sender, EventArgs e)
        {
            if (this.dgvMember.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvMember.SelectedRows[0];
                using (var form = new MemberEdit(mode.Edit, row.Cells["dgvMember_Serno"].Value.ToString()))
                {
                    panelMember.Visible = false;
                    panelMask.Visible = true;
                    var result = form.ShowDialog();
                    panelMember.Visible = true;
                    panelMask.Visible = false;
                }
                memberLoadData(ddlMemberPage.SelectedIndex + 1);
            }
        }
        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.dgvMember.SelectedRows[0];
            using (var form = new MemberEdit(mode.View, row.Cells["dgvMember_Serno"].Value.ToString()))
            {
                panelMember.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelMember.Visible = true;
                panelMask.Visible = false;
            }
        }
        private void btnMemberRight_Click(object sender, EventArgs e)
        {
            if (APConfig.nextPage(ref ddlMemberPage))
                memberLoadData(ddlMemberPage.SelectedIndex + 1);
        }
        private void btnMemberLeft_Click(object sender, EventArgs e)
        {
            if (APConfig.prevPage(ref ddlMemberPage))
                memberLoadData(ddlMemberPage.SelectedIndex + 1);
        }
        private void ddlMemberPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlMemberPage.SelectedIndex == -1) return;
            memberLoadData(ddlMemberPage.SelectedIndex + 1);
        }
        private void dgvMember_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1 || dgvMember.RowCount == 0) return;
            memberLoadData(ddlMemberPage.SelectedIndex + 1);
        }
        #endregion

        #region Panel Sale
        private void saleInitial()
        {
            dgvSale.Rows.Clear();
            APConfig.loadPhrase(ddlSaleDealer, PhraseCategory.案件負責人.ToString(), true);
            APConfig.loadPhrase(ddlSaleType, PhraseCategory.收入類別.ToString(), true);
            txtSaleItem.Text = string.Empty;
            txtSaleMain.Text = string.Empty;
            txtSaleName.Text = string.Empty;
            txtSaleComment.Text = string.Empty;
            ddlSaleDealer.SelectedIndex = 0;
            ddlSaleStatus.SelectedIndex = 0;
            ddlSaleType.SelectedIndex = 0;
            ddlSaleType.Items.Add("銷貨淨值");
            ckbSaleModifyDTTM.Checked = false;
            ckbSaleDealDTTM.Checked = false;
            dpkSaleDealEDTTM.Value = DateTime.Today;
            dpkSaleDealSDTTM.Value = DateTime.Today;
            //dpkSaleInsertEDTTM.Value = DateTime.Today;
            //dpkSaleInsertSDTTM.Value = DateTime.Today;
            dpkSaleModifySDTTM.Value = DateTime.Today;
            dpkSaleModifyEDTTM.Value = DateTime.Today;
            lblSaleTotal.Text = "0";
            lblSaleTotalAmount.Text = "0 元";
            ddlSalePage.Items.Clear();
        }
        private void saleLoadData(int pageNum)
        {
            int total = 0;
            dgvSale.Rows.Clear();
            DataGridViewRowCollection rows = dgvSale.Rows;
            RosterDial_RInfo view = new RosterDial_RInfo(APConfig.Conn);
            view.Conditions = " 1=1 ";
            if (!string.IsNullOrEmpty(txtSaleItem.Text))
                view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.item.ToString(), txtSaleItem.Text);
            if (!string.IsNullOrEmpty(txtSaleMain.Text))
                view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.main.ToString(), txtSaleMain.Text);
            if (!string.IsNullOrEmpty(txtSaleName.Text))
                view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.name.ToString(), txtSaleName.Text);
            if (!string.IsNullOrEmpty(txtSaleComment.Text))
                view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.comment.ToString(), txtSaleComment.Text);
            //if (!string.IsNullOrEmpty(dpkSaleInsertSDTTM.Value.ToString()) && ckbSaleInsertDTTM.Checked)
            //    view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.createSDTTM.ToString(), dpkSaleInsertSDTTM.Value.ToString("yyyy/MM/dd"));
            //if (!string.IsNullOrEmpty(dpkSaleInsertSDTTM.Value.ToString()) && ckbSaleInsertDTTM.Checked)
            //    view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.createEDTTM.ToString(), dpkSaleInsertSDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkSaleModifySDTTM.Value.ToString()) && ckbSaleModifyDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.modifySDTTM.ToString(), dpkSaleModifySDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkSaleModifyEDTTM.Value.ToString()) && ckbSaleModifyDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.modifyEDTTM.ToString(), dpkSaleModifyEDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkSaleDealSDTTM.Value.ToString()) && ckbSaleDealDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.dealSDTTM.ToString(), dpkSaleDealSDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkSaleDealEDTTM.Value.ToString()) && ckbSaleDealDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.dealEDTTM.ToString(), dpkSaleDealEDTTM.Value.ToString("yyyy/MM/dd"));
            if (ddlSaleDealer.SelectedIndex!=0)
                view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.dealer.ToString(), ddlSaleDealer.SelectedItem.ToString());
            if (ddlSaleStatus.SelectedIndex != 0)
                view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.status.ToString(), ddlSaleStatus.SelectedItem.ToString());
            if (ddlSaleType.SelectedIndex != 0)
            {
                if (ddlSaleType.SelectedItem.ToString() == "銷貨淨值") //Harsh Code
                    view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.typelist.ToString(), " '銷貨收入','銷貨折扣'");
                else
                    view.Conditions += " AND " + view.getCondition(RosterDial_RInfo.ncConditions.type.ToString(), ddlSaleType.SelectedItem.ToString());
            }
            //組排序指令
            if (dgvSale.SortedColumn is null)
                view.OrderBy = view.getOptionOrderBy(RosterDial_RInfo.ncSort.Default.ToString());
            else
            {
                string sortname = dgvSale.SortedColumn.Name;
                string sortmode = APConfig.GetValueFromDescription<SortMode>(dgvSale.SortOrder.ToString()).ToString();
                view.OrderBy = string.Format("{0} {1}", view.getOptionOrderBy(sortname), sortmode);
            }
            //查詢頁數初始化且自動跳轉至第一頁
            if (pageNum == 0)
            {
                APConfig.loadPage(ddlSalePage, view.calculatePage(APConfig.PageCount));
                return;
            }
            //計算總合
            if (view.load())
            {
                while (!view.IsEof)
                {
                    total += int.Parse(view.RSD_AMOUNT);
                    view.next();
                }
            }
            //塞入資料
            DataSet ds = APConfig.GoPage(view.SQLStatement, pageNum);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rows.Add(new Object[] { dr.ItemArray[0], dr.ItemArray[14], dr.ItemArray[13], dr.ItemArray[1], dr.ItemArray[2], dr.ItemArray[3], dr.ItemArray[6], dr.ItemArray[4], dr.ItemArray[5], dr.ItemArray[7], dr.ItemArray[10] });
            }
            lblSaleTotal.Text = view.calculateCount().ToString();
            lblSaleTotalAmount.Text = string.Format("{0:n0} 元", total);
        }
        private void btnSaleSearch_Click(object sender, EventArgs e)
        {
            saleLoadData(0);
        }
        private void btnSaleAdd_Click(object sender, EventArgs e)
        {
            using (var form = new PickMember())
            {
                panelSale.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelSale.Visible = true;
                panelMask.Visible = false;
            }
            saleInitial();
        }
        private void btnSaleModify_Click(object sender, EventArgs e)
        {
            if (this.dgvSale.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvSale.SelectedRows[0];
                using (var form = new TradeEdit(mode.Edit, row.Cells["dgvSale_Serno"].Value.ToString()))
                {
                    panelSale.Visible = false;
                    panelMask.Visible = true;
                    var result = form.ShowDialog();
                    panelSale.Visible = true;
                    panelMask.Visible = false;
                }
                saleLoadData(ddlSalePage.SelectedIndex + 1);
            }
        }
        private void btnSaleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSale.SelectedRows.Count > 0 && APConfig.SweetAlert(ShowBoxType.confirm, string.Format("是否確定要刪除{0}筆?", dgvSale.SelectedRows.Count)))
                {
                    List<string> sernolist = new List<string>();
                    string delSernoList = "";
                    foreach (DataGridViewRow row in dgvSale.SelectedRows)
                    {
                        sernolist.Add(string.Format("'{0}'", row.Cells["dgvSale_Serno"].Value.ToString()));
                    }
                    delSernoList = string.Join(",", sernolist);
                    RosterDial entRosterDial = new RosterDial(APConfig.Conn);
                    string sConditions = entRosterDial.getCondition(RosterDial.ncConditions.sernolist.ToString(), delSernoList);
                    entRosterDial.deleteAll(sConditions);
                    saleLoadData(ddlSalePage.SelectedIndex + 1);
                    APConfig.SweetAlert(ShowBoxType.alert, "刪除完成");
                }
            }
            catch(Exception ex)
            {
                APConfig.SweetAlert(ShowBoxType.alert, string.Format("刪除失敗 {0}", ex.Message));
            }
        }
        private void dgvSale_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.dgvSale.SelectedRows[0];
            using (var form = new TradeEdit(mode.View, row.Cells["dgvSale_Serno"].Value.ToString()))
            {
                panelSale.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelSale.Visible = true;
                panelMask.Visible = false;
            }
        }
        private void btnSaleRight_Click(object sender, EventArgs e)
        {
            if (APConfig.nextPage(ref ddlSalePage))
                saleLoadData(ddlSalePage.SelectedIndex + 1);
        }
        private void btnSaleLeft_Click(object sender, EventArgs e)
        {
            if (APConfig.prevPage(ref ddlSalePage))
                saleLoadData(ddlSalePage.SelectedIndex + 1);
        }
        private void ddlSalePage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSalePage.SelectedIndex == -1) return;
            saleLoadData(ddlSalePage.SelectedIndex + 1);
        }
        private void dgvSale_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1 || dgvSale.RowCount == 0) return;
            saleLoadData(ddlSalePage.SelectedIndex + 1);
        }
        #endregion

        #region Panel Phrase
        private void phraseInitial()
        {
            APConfig.loadEnum<PhraseCategory>(ddlPhraseCategory);
            dgvPhrase.Rows.Clear();
            txtPhraseName.Text = string.Empty;
            txtPhraseType.Text = string.Empty;
            lblPhraseTotal.Text = "0";
        }
        private void phraseLoadData()
        {
            dgvPhrase.Rows.Clear();
            DataGridViewRowCollection rows = dgvPhrase.Rows;
            PhraseInfo view = new PhraseInfo(APConfig.Conn);
            view.Conditions = " 1=1 ";
            view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.category.ToString(), ddlPhraseCategory.SelectedItem.ToString());
            if (!string.IsNullOrEmpty(txtPhraseName.Text))
                view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.name.ToString(), txtPhraseName.Text);
            if (!string.IsNullOrEmpty(txtPhraseType.Text))
                view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.type.ToString(), txtPhraseType.Text);
            if (view.load())
            {
                while (!view.IsEof)
                {
                    rows.Add(new Object[] { view.PHS_SERNO,view.PHS_NAME,view.PHS_TYPE,view.PHS_INDEX });
                    view.next();
                }
            }
            lblPhraseTotal.Text = view.calculateCount().ToString();
        }
        private void btnPhraseSearch_Click(object sender, EventArgs e)
        {
            phraseLoadData();
        }
        private void btnPhraseAdd_Click(object sender, EventArgs e)
        {
            using (var form = new PhraseEdit(mode.Add,ddlPhraseCategory.SelectedItem.ToString()))
            {
                panelPhrase.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelPhrase.Visible = true;
                panelMask.Visible = false;
            }
            phraseLoadData();
        }
        private void btnPhraseModify_Click(object sender, EventArgs e)
        {
            if (this.dgvPhrase.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvPhrase.SelectedRows[0];
                using (var form = new PhraseEdit(mode.Edit, ddlPhraseCategory.SelectedItem.ToString(), row.Cells["dgvPhrase_Serno"].Value.ToString()))
                {
                    panelPhrase.Visible = false;
                    panelMask.Visible = true;
                    var result = form.ShowDialog();
                    panelPhrase.Visible = true;
                    panelMask.Visible = false;
                }
                phraseLoadData();
            }
        }
        private void btnPhraseDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhrase.SelectedRows.Count > 0 && APConfig.SweetAlert(ShowBoxType.confirm, string.Format("是否確定要刪除{0}筆?", dgvPhrase.SelectedRows.Count)))
                {
                    List<string> sernolist = new List<string>();
                    string delSernoList = "";
                    foreach (DataGridViewRow row in dgvPhrase.SelectedRows)
                    {
                        sernolist.Add(string.Format("'{0}'", row.Cells["dgvPhrase_Serno"].Value.ToString()));
                    }
                    delSernoList = string.Join(",", sernolist);
                    Phrase ent = new Phrase(APConfig.Conn);
                    string sConditions = ent.getCondition(Phrase.ncConditions.sernolist.ToString(), delSernoList);
                    ent.deleteAll(sConditions);
                    phraseLoadData();
                    APConfig.SweetAlert(ShowBoxType.alert, "刪除完成");
                }
            }
            catch (Exception ex)
            {
                APConfig.SweetAlert(ShowBoxType.alert, string.Format("刪除失敗 {0}", ex.Message));
            }
        }
        private void dgvPhrase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.dgvPhrase.SelectedRows[0];
            using (var form = new PhraseEdit(mode.View, ddlPhraseCategory.SelectedItem.ToString(), row.Cells["dgvPhrase_Serno"].Value.ToString()))
            {
                panelPhrase.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelPhrase.Visible = true;
                panelMask.Visible = false;
            }
        }
        private void ddlPhraseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            phraseLoadData();
        }
        #endregion
        
        #region Panel Inventory
        private void inventoryInitial()
        {
            dgvInventory.Rows.Clear();
            APConfig.loadPhrase(ddlInventoryDealer, PhraseCategory.案件負責人.ToString(), true);
            APConfig.loadEnum<InventoryStatus>(ddlInventoryStatus,"",true);
            txtInventoryCode.Text = string.Empty;
            txtInventoryName.Text = string.Empty;
            ckbInventoryINDTTM.Checked = false;
            ckbInventoryOUTDTTM.Checked = false;
            ckbInventoryPOSTDTTM.Checked = false;
            ckbInventoryRETURNDTTM.Checked = false;
            ddlInventoryDealer.SelectedIndex = 0;
            ddlInventoryStatus.SelectedIndex = 0;
            dpkInventoryINSDTTM.Value = DateTime.Today;
            dpkInventoryINEDTTM.Value = DateTime.Today;
            dpkInventoryOUTEDTTM.Value = DateTime.Today;
            dpkInventoryOUTSDTTM.Value = DateTime.Today;
            dpkInventoryRETURNSDTTM.Value = DateTime.Today;
            dpkInventoryRETURNEDTTM.Value = DateTime.Today;
            dpkInventoryPOSTSDTTM.Value = DateTime.Today;
            dpkInventoryPOSTEDTTM.Value = DateTime.Today;
            lblInventoryINAMT.Text = "0 元";
            lblInventoryOUTAMT.Text = "0 元";
            lblInventoryPOSTAMT.Text = "0 元";
            lblInventoryRETURNAMT.Text = "0 元";
            lblInventoryTotal.Text = "0";
            ddlInventoryPage.Items.Clear();
        }
        private void inventoryLoadData(int pageNum)
        {
            int importTotal = 0, exportTotal = 0, itemTotal = 0, postTotal = 0, returnTotal = 0;
            dgvInventory.Rows.Clear();
            DataGridViewRowCollection rows = dgvInventory.Rows;
            InventroyRPTInfo view = new InventroyRPTInfo(APConfig.Conn);
            view.Conditions = " 1=1 ";
            if (!string.IsNullOrEmpty(txtInventoryName.Text))
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.name.ToString(), txtInventoryName.Text);
            if (!string.IsNullOrEmpty(txtInventoryCode.Text))
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.code.ToString(), txtInventoryCode.Text);
            if (!string.IsNullOrEmpty(dpkInventoryINSDTTM.Value.ToString()) && ckbInventoryINDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.importSDTTM.ToString(), dpkInventoryINSDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkInventoryINEDTTM.Value.ToString()) && ckbInventoryINDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.importEDTTM.ToString(), dpkInventoryINEDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkInventoryOUTSDTTM.Value.ToString()) && ckbInventoryOUTDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.exportSDTTM.ToString(), dpkInventoryOUTSDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkInventoryOUTEDTTM.Value.ToString()) && ckbInventoryOUTDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.exportEDTTM.ToString(), dpkInventoryOUTEDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkInventoryPOSTSDTTM.Value.ToString()) && ckbInventoryPOSTDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.postSDTTM.ToString(), dpkInventoryPOSTSDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkInventoryPOSTEDTTM.Value.ToString()) && ckbInventoryPOSTDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.postEDTTM.ToString(), dpkInventoryPOSTEDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkInventoryRETURNSDTTM.Value.ToString()) && ckbInventoryRETURNDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.returnSDTTM.ToString(), dpkInventoryRETURNSDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkInventoryRETURNEDTTM.Value.ToString()) && ckbInventoryRETURNDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.returnEDTTM.ToString(), dpkInventoryRETURNEDTTM.Value.ToString("yyyy/MM/dd"));

            if (ddlInventoryDealer.SelectedIndex != 0)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.dealer.ToString(), ddlInventoryDealer.SelectedItem.ToString());
            if (ddlInventoryStatus.SelectedIndex != 0)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.status.ToString(), ddlInventoryStatus.SelectedItem.ToString());

            view.condFormat(string.Format(" AND {0} ",view.Conditions));



            //組排序指令
            if (dgvInventory.SortedColumn is null)
                view.OrderBy = view.getOptionOrderBy(RosterDial_RInfo.ncSort.Default.ToString());
            else
            {
                string sortname = dgvInventory.SortedColumn.Name;
                string sortmode = APConfig.GetValueFromDescription<SortMode>(dgvInventory.SortOrder.ToString()).ToString();
                view.OrderBy = string.Format("{0} {1}", view.getOptionOrderBy(sortname), sortmode);
            }
            //查詢頁數初始化且自動跳轉至第一頁
            if (pageNum == 0)
            {
                APConfig.loadPage(ddlInventoryPage, view.calculatePage(APConfig.PageCount));
                return;
            }
            //塞入資料
            DataSet ds = APConfig.GoPage(view.SQLStatement, pageNum);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rows.Add(new Object[] { dr.ItemArray[1], dr.ItemArray[0], dr.ItemArray[2], dr.ItemArray[3], dr.ItemArray[4], dr.ItemArray[5], dr.ItemArray[6] });
            }
            //計算總合
            if (view.load())
            {
                while (!view.IsEof)
                {
                    importTotal += view.INAMT;
                    exportTotal += view.OUTAMT;
                    postTotal += view.POSTAMT;
                    returnTotal += view.RETURNAMT;
                    itemTotal += Convert.ToInt32(view.ITEMTOTAL);
                    view.next();
                }
            }
            lblInventoryTotal.Text = string.Format("{0}", itemTotal.ToString());
            lblInventoryINAMT.Text = string.Format("{0:n0} 元", importTotal);
            lblInventoryOUTAMT.Text = string.Format("{0:n0} 元", exportTotal);
            lblInventoryPOSTAMT.Text = string.Format("{0:n0} 元", postTotal);
            lblInventoryRETURNAMT.Text = string.Format("{0:n0} 元", returnTotal);
        }
        private void btnInventorySearch_Click(object sender, EventArgs e)
        {
            inventoryLoadData(0);
        }
        private void btnInventoryImportAdd_Click(object sender, EventArgs e)
        {
            using (var form = new InventoryImportEdit(mode.Add))
            {
                panelInventory.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelInventory.Visible = true;
                panelMask.Visible = false;
            }
            inventoryInitial();
        }
        private void btnInventoryPostAdd_Click(object sender, EventArgs e)
        {
            using (var form = new InventoryPostEdit(mode.Add))
            {
                panelInventory.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelInventory.Visible = true;
                panelMask.Visible = false;
            }
            inventoryInitial();
        }
        private void btnInventoryExportAdd_Click(object sender, EventArgs e)
        {
            using (var form = new InventoryExportEdit(mode.Add))
            {
                panelInventory.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelInventory.Visible = true;
                panelMask.Visible = false;
            }
            inventoryInitial();
        }
        private void btnInventoryReturnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new InventoryReturnEdit(mode.Add))
            {
                panelInventory.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelInventory.Visible = true;
                panelMask.Visible = false;
            }
            inventoryInitial();
        }
        private void btnInventoryModify_Click(object sender, EventArgs e)
        {
            if (this.dgvInventory.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvInventory.SelectedRows[0];
                using (var form = new PickInventoryCode(mode.Edit, row.Cells["dgvInventory_Serno"].Value.ToString()))
                {
                    panelInventory.Visible = false;
                    panelMask.Visible = true;
                    var result = form.ShowDialog();
                    panelInventory.Visible = true;
                    panelMask.Visible = false;
                }
                inventoryLoadData(ddlInventoryPage.SelectedIndex + 1);
            }
        }
        private void btnInventoryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventory.SelectedRows.Count > 0)
                {
                    List<string> sernolist = new List<string>();
                    string delSernoList = "";
                    foreach (DataGridViewRow row in dgvInventory.SelectedRows)
                    {
                        sernolist.Add(row.Cells["dgvInventory_Serno"].Value.ToString());
                    }
                    delSernoList = APConfig.sqlArrayFormat(string.Join(",", sernolist));

                    using (var form = new PickInventoryDelete(mode.View, delSernoList))
                    {
                        panelInventory.Visible = false;
                        panelMask.Visible = true;
                        var result = form.ShowDialog();
                        panelInventory.Visible = true;
                        panelMask.Visible = false;
                    }
                    inventoryLoadData(ddlInventoryPage.SelectedIndex + 1);
                }
            }
            catch (Exception ex)
            {
                APConfig.SweetAlert(ShowBoxType.alert, string.Format("刪除失敗 {0}", ex.Message));
            }

        }
        private void dgvInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.dgvInventory.SelectedRows[0];
            using (var form = new PickInventoryCode(mode.View, row.Cells["dgvInventory_Serno"].Value.ToString()))
            {
                panelInventory.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelInventory.Visible = true;
                panelMask.Visible = false;
            }
        }
        private void btnInventoryRight_Click(object sender, EventArgs e)
        {
            if (APConfig.nextPage(ref ddlInventoryPage))
                inventoryLoadData(ddlInventoryPage.SelectedIndex + 1);
        }
        private void btnInventoryLeft_Click(object sender, EventArgs e)
        {
            if (APConfig.prevPage(ref ddlInventoryPage))
                inventoryLoadData(ddlInventoryPage.SelectedIndex + 1);
        }
        private void ddlInventoryPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlInventoryPage.SelectedIndex == -1) return;
            inventoryLoadData(ddlInventoryPage.SelectedIndex + 1);
        }
        private void dgvInventory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1 || dgvInventory.RowCount == 0) return;
            inventoryLoadData(ddlInventoryPage.SelectedIndex + 1);
        }
        #endregion

        #region Main
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (APConfig.SweetAlert(ShowBoxType.confirm, "確定要離開嗎?"))
            {
                this.Close();
                Environment.Exit(Environment.ExitCode);
            }
        }
        private void btnMember_Click(object sender, EventArgs e)
        {
            panelStats.Height = btnMember.Height;
            panelStats.Top = btnMember.Top;
            ShowMainPanel(panelMember);
            lblBarTitle.Text = "會員專區";
            memberInitial();
        }
        private void btnTrade_Click(object sender, EventArgs e)
        {
            panelStats.Height = btnTrade.Height;
            panelStats.Top = btnTrade.Top;
            ShowMainPanel(panelSale);
            lblBarTitle.Text = "行銷專區";
            saleInitial();
        }
        private void btnPhrase_Click(object sender, EventArgs e)
        {
            panelStats.Height = btnPhrase.Height;
            panelStats.Top = btnPhrase.Top;
            ShowMainPanel(panelPhrase);
            lblBarTitle.Text = "交易參數";
            phraseInitial();
            phraseLoadData();
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            panelStats.Height = btnInventory.Height;
            panelStats.Top = btnInventory.Top;
            ShowMainPanel(panelInventory);
            lblBarTitle.Text = "進銷存專區";
            inventoryInitial();
        }

        private void ShowMainPanel(Panel showPanel)
        {
            panelSale.Visible = false;
            panelInventory.Visible = false;
            panelMember.Visible = false;
            panelPhrase.Visible = false;

            showPanel.Visible = true;
        }
        #endregion

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

        #region 備份
        private void btnBackUp_Click(object sender, EventArgs e)
        {
            if (APConfig.SweetAlert(ShowBoxType.confirm, "是否確定要備份?"))
            {
                try
                {
                    SqlConnection conn = new SqlConnection(APConfig.Conn.getConnectionString());
                    SqlCommand cmd = new SqlCommand(string.Empty, conn);
                    conn.Open();

                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_BackupData";

                    SqlParameter result = cmd.Parameters.Add("@result", SqlDbType.Int);
                    result.Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    if (Convert.ToInt32(result.Value) == 1)
                        APConfig.SweetAlert(ShowBoxType.alert, "備份成功!");
                    else
                        APConfig.SweetAlert(ShowBoxType.alert, "備份失敗!");


                    conn.Close();
                    conn.Dispose();
                }
                catch (Exception ex)
                {
                    APConfig.SweetAlert(ShowBoxType.alert, string.Format("備份失敗!{0}", ex.Message));
                }
            }
        }
        #endregion
    }
}
