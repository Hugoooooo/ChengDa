namespace ChengDa
{
    partial class Home
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelSale = new System.Windows.Forms.Panel();
            this.panelSaleView = new System.Windows.Forms.Panel();
            this.dgvSale = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgvSale_Serno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSale_CSTName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSale_Main = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSale_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSale_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSale_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSale_Dealer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSale_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSale_Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSale_DealDTTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSale_ModifyDTTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSaleSearch = new System.Windows.Forms.Panel();
            this.lblSaleTotalAmount = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSaleComment = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSaleTotal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ckbSaleDealDTTM = new Bunifu.Framework.UI.BunifuCheckbox();
            this.dpkSaleDealEDTTM = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dpkSaleDealSDTTM = new Bunifu.Framework.UI.BunifuDatepicker();
            this.ddlSaleDealer = new System.Windows.Forms.ComboBox();
            this.ddlSaleType = new System.Windows.Forms.ComboBox();
            this.ddlSaleStatus = new System.Windows.Forms.ComboBox();
            this.txtSaleItem = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtSaleMain = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtSaleName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaleDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSaleSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSaleModify = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSaleAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ckbSaleModifyDTTM = new Bunifu.Framework.UI.BunifuCheckbox();
            this.dpkSaleModifyEDTTM = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dpkSaleModifySDTTM = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panelSale.SuspendLayout();
            this.panelSaleView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.panelSaleSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSale
            // 
            this.panelSale.Controls.Add(this.panelSaleView);
            this.panelSale.Location = new System.Drawing.Point(81, 28);
            this.panelSale.Name = "panelSale";
            this.panelSale.Size = new System.Drawing.Size(1000, 695);
            this.panelSale.TabIndex = 2;
            // 
            // panelSaleView
            // 
            this.panelSaleView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelSaleView.Controls.Add(this.dgvSale);
            this.panelSaleView.Controls.Add(this.panelSaleSearch);
            this.panelSaleView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSaleView.Location = new System.Drawing.Point(0, 0);
            this.panelSaleView.Name = "panelSaleView";
            this.panelSaleView.Size = new System.Drawing.Size(1000, 695);
            this.panelSaleView.TabIndex = 1;
            // 
            // dgvSale
            // 
            this.dgvSale.AllowUserToAddRows = false;
            this.dgvSale.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSale.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSale_Serno,
            this.dgvSale_CSTName,
            this.dgvSale_Main,
            this.dgvSale_Status,
            this.dgvSale_Type,
            this.dgvSale_Item,
            this.dgvSale_Dealer,
            this.dgvSale_Amount,
            this.dgvSale_Comment,
            this.dgvSale_DealDTTM,
            this.dgvSale_ModifyDTTM});
            this.dgvSale.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSale.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSale.DoubleBuffered = true;
            this.dgvSale.EnableHeadersVisualStyles = false;
            this.dgvSale.HeaderBgColor = System.Drawing.Color.Gray;
            this.dgvSale.HeaderForeColor = System.Drawing.Color.White;
            this.dgvSale.Location = new System.Drawing.Point(0, 243);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.ReadOnly = true;
            this.dgvSale.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSale.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSale.RowHeadersVisible = false;
            this.dgvSale.RowHeadersWidth = 50;
            this.dgvSale.RowTemplate.Height = 24;
            this.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSale.Size = new System.Drawing.Size(1000, 452);
            this.dgvSale.TabIndex = 0;
            // 
            // dgvSale_Serno
            // 
            this.dgvSale_Serno.HeaderText = "Serno";
            this.dgvSale_Serno.Name = "dgvSale_Serno";
            this.dgvSale_Serno.ReadOnly = true;
            this.dgvSale_Serno.Visible = false;
            // 
            // dgvSale_CSTName
            // 
            this.dgvSale_CSTName.HeaderText = "客戶姓名";
            this.dgvSale_CSTName.Name = "dgvSale_CSTName";
            this.dgvSale_CSTName.ReadOnly = true;
            // 
            // dgvSale_Main
            // 
            this.dgvSale_Main.HeaderText = "主電話";
            this.dgvSale_Main.Name = "dgvSale_Main";
            this.dgvSale_Main.ReadOnly = true;
            // 
            // dgvSale_Status
            // 
            this.dgvSale_Status.HeaderText = "訂單狀態";
            this.dgvSale_Status.Name = "dgvSale_Status";
            this.dgvSale_Status.ReadOnly = true;
            // 
            // dgvSale_Type
            // 
            this.dgvSale_Type.HeaderText = "收入類別";
            this.dgvSale_Type.Name = "dgvSale_Type";
            this.dgvSale_Type.ReadOnly = true;
            // 
            // dgvSale_Item
            // 
            this.dgvSale_Item.HeaderText = "商品資訊";
            this.dgvSale_Item.Name = "dgvSale_Item";
            this.dgvSale_Item.ReadOnly = true;
            this.dgvSale_Item.Width = 250;
            // 
            // dgvSale_Dealer
            // 
            this.dgvSale_Dealer.HeaderText = "銷售人員";
            this.dgvSale_Dealer.Name = "dgvSale_Dealer";
            this.dgvSale_Dealer.ReadOnly = true;
            // 
            // dgvSale_Amount
            // 
            this.dgvSale_Amount.HeaderText = "實收金額";
            this.dgvSale_Amount.Name = "dgvSale_Amount";
            this.dgvSale_Amount.ReadOnly = true;
            // 
            // dgvSale_Comment
            // 
            this.dgvSale_Comment.HeaderText = "銷售備註";
            this.dgvSale_Comment.Name = "dgvSale_Comment";
            this.dgvSale_Comment.ReadOnly = true;
            this.dgvSale_Comment.Width = 150;
            // 
            // dgvSale_DealDTTM
            // 
            this.dgvSale_DealDTTM.HeaderText = "完成日期";
            this.dgvSale_DealDTTM.Name = "dgvSale_DealDTTM";
            this.dgvSale_DealDTTM.ReadOnly = true;
            this.dgvSale_DealDTTM.Width = 150;
            // 
            // dgvSale_ModifyDTTM
            // 
            this.dgvSale_ModifyDTTM.HeaderText = "修改日期";
            this.dgvSale_ModifyDTTM.Name = "dgvSale_ModifyDTTM";
            this.dgvSale_ModifyDTTM.ReadOnly = true;
            this.dgvSale_ModifyDTTM.Width = 150;
            // 
            // panelSaleSearch
            // 
            this.panelSaleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelSaleSearch.Controls.Add(this.lblSaleTotalAmount);
            this.panelSaleSearch.Controls.Add(this.label24);
            this.panelSaleSearch.Controls.Add(this.txtSaleComment);
            this.panelSaleSearch.Controls.Add(this.label11);
            this.panelSaleSearch.Controls.Add(this.lblSaleTotal);
            this.panelSaleSearch.Controls.Add(this.label17);
            this.panelSaleSearch.Controls.Add(this.ckbSaleDealDTTM);
            this.panelSaleSearch.Controls.Add(this.dpkSaleDealEDTTM);
            this.panelSaleSearch.Controls.Add(this.label9);
            this.panelSaleSearch.Controls.Add(this.dpkSaleDealSDTTM);
            this.panelSaleSearch.Controls.Add(this.ddlSaleDealer);
            this.panelSaleSearch.Controls.Add(this.ddlSaleType);
            this.panelSaleSearch.Controls.Add(this.ddlSaleStatus);
            this.panelSaleSearch.Controls.Add(this.txtSaleItem);
            this.panelSaleSearch.Controls.Add(this.txtSaleMain);
            this.panelSaleSearch.Controls.Add(this.txtSaleName);
            this.panelSaleSearch.Controls.Add(this.label5);
            this.panelSaleSearch.Controls.Add(this.label14);
            this.panelSaleSearch.Controls.Add(this.label6);
            this.panelSaleSearch.Controls.Add(this.btnSaleDelete);
            this.panelSaleSearch.Controls.Add(this.btnSaleSearch);
            this.panelSaleSearch.Controls.Add(this.btnSaleModify);
            this.panelSaleSearch.Controls.Add(this.btnSaleAdd);
            this.panelSaleSearch.Controls.Add(this.ckbSaleModifyDTTM);
            this.panelSaleSearch.Controls.Add(this.dpkSaleModifyEDTTM);
            this.panelSaleSearch.Controls.Add(this.label10);
            this.panelSaleSearch.Controls.Add(this.dpkSaleModifySDTTM);
            this.panelSaleSearch.Controls.Add(this.label12);
            this.panelSaleSearch.Controls.Add(this.label13);
            this.panelSaleSearch.Controls.Add(this.label15);
            this.panelSaleSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSaleSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSaleSearch.Name = "panelSaleSearch";
            this.panelSaleSearch.Size = new System.Drawing.Size(1000, 243);
            this.panelSaleSearch.TabIndex = 0;
            // 
            // lblSaleTotalAmount
            // 
            this.lblSaleTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaleTotalAmount.AutoSize = true;
            this.lblSaleTotalAmount.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.lblSaleTotalAmount.Location = new System.Drawing.Point(293, 205);
            this.lblSaleTotalAmount.Name = "lblSaleTotalAmount";
            this.lblSaleTotalAmount.Size = new System.Drawing.Size(46, 19);
            this.lblSaleTotalAmount.TabIndex = 97;
            this.lblSaleTotalAmount.Text = "Total";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(455, 205);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 19);
            this.label24.TabIndex = 96;
            this.label24.Text = "總筆數:";
            // 
            // txtSaleComment
            // 
            this.txtSaleComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaleComment.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtSaleComment.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSaleComment.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtSaleComment.BorderThickness = 2;
            this.txtSaleComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSaleComment.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleComment.ForeColor = System.Drawing.Color.Black;
            this.txtSaleComment.isPassword = false;
            this.txtSaleComment.Location = new System.Drawing.Point(109, 105);
            this.txtSaleComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaleComment.Name = "txtSaleComment";
            this.txtSaleComment.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtSaleComment.Size = new System.Drawing.Size(395, 35);
            this.txtSaleComment.TabIndex = 95;
            this.txtSaleComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(23, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 19);
            this.label11.TabIndex = 94;
            this.label11.Text = "商品備註:";
            // 
            // lblSaleTotal
            // 
            this.lblSaleTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaleTotal.AutoSize = true;
            this.lblSaleTotal.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleTotal.ForeColor = System.Drawing.Color.Black;
            this.lblSaleTotal.Location = new System.Drawing.Point(519, 205);
            this.lblSaleTotal.Name = "lblSaleTotal";
            this.lblSaleTotal.Size = new System.Drawing.Size(46, 19);
            this.lblSaleTotal.TabIndex = 93;
            this.lblSaleTotal.Text = "Total";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(237, 205);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 19);
            this.label17.TabIndex = 91;
            this.label17.Text = "總金額:";
            // 
            // ckbSaleDealDTTM
            // 
            this.ckbSaleDealDTTM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.ckbSaleDealDTTM.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.ckbSaleDealDTTM.Checked = false;
            this.ckbSaleDealDTTM.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ckbSaleDealDTTM.ForeColor = System.Drawing.Color.White;
            this.ckbSaleDealDTTM.Location = new System.Drawing.Point(646, 112);
            this.ckbSaleDealDTTM.Name = "ckbSaleDealDTTM";
            this.ckbSaleDealDTTM.Size = new System.Drawing.Size(20, 20);
            this.ckbSaleDealDTTM.TabIndex = 90;
            // 
            // dpkSaleDealEDTTM
            // 
            this.dpkSaleDealEDTTM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dpkSaleDealEDTTM.BorderRadius = 0;
            this.dpkSaleDealEDTTM.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dpkSaleDealEDTTM.ForeColor = System.Drawing.Color.DimGray;
            this.dpkSaleDealEDTTM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkSaleDealEDTTM.FormatCustom = null;
            this.dpkSaleDealEDTTM.Location = new System.Drawing.Point(834, 105);
            this.dpkSaleDealEDTTM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpkSaleDealEDTTM.Name = "dpkSaleDealEDTTM";
            this.dpkSaleDealEDTTM.Size = new System.Drawing.Size(150, 35);
            this.dpkSaleDealEDTTM.TabIndex = 89;
            this.dpkSaleDealEDTTM.Value = new System.DateTime(2018, 6, 18, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(560, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 88;
            this.label9.Text = "完成日期:";
            // 
            // dpkSaleDealSDTTM
            // 
            this.dpkSaleDealSDTTM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dpkSaleDealSDTTM.BorderRadius = 0;
            this.dpkSaleDealSDTTM.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dpkSaleDealSDTTM.ForeColor = System.Drawing.Color.DimGray;
            this.dpkSaleDealSDTTM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkSaleDealSDTTM.FormatCustom = null;
            this.dpkSaleDealSDTTM.Location = new System.Drawing.Point(676, 105);
            this.dpkSaleDealSDTTM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpkSaleDealSDTTM.Name = "dpkSaleDealSDTTM";
            this.dpkSaleDealSDTTM.Size = new System.Drawing.Size(150, 35);
            this.dpkSaleDealSDTTM.TabIndex = 87;
            this.dpkSaleDealSDTTM.Value = new System.DateTime(2018, 6, 18, 13, 48, 49, 0);
            // 
            // ddlSaleDealer
            // 
            this.ddlSaleDealer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ddlSaleDealer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSaleDealer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSaleDealer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSaleDealer.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.ddlSaleDealer.ForeColor = System.Drawing.Color.DimGray;
            this.ddlSaleDealer.FormattingEnabled = true;
            this.ddlSaleDealer.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ddlSaleDealer.Items.AddRange(new object[] {
            "全部",
            "劉居政",
            "劉奇信"});
            this.ddlSaleDealer.Location = new System.Drawing.Point(110, 155);
            this.ddlSaleDealer.Name = "ddlSaleDealer";
            this.ddlSaleDealer.Size = new System.Drawing.Size(185, 27);
            this.ddlSaleDealer.TabIndex = 86;
            // 
            // ddlSaleType
            // 
            this.ddlSaleType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ddlSaleType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSaleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSaleType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSaleType.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.ddlSaleType.ForeColor = System.Drawing.Color.DimGray;
            this.ddlSaleType.FormattingEnabled = true;
            this.ddlSaleType.Items.AddRange(new object[] {
            "全部",
            "銷貨收入",
            "營業收入"});
            this.ddlSaleType.Location = new System.Drawing.Point(459, 155);
            this.ddlSaleType.Name = "ddlSaleType";
            this.ddlSaleType.Size = new System.Drawing.Size(174, 27);
            this.ddlSaleType.TabIndex = 85;
            // 
            // ddlSaleStatus
            // 
            this.ddlSaleStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ddlSaleStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSaleStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSaleStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSaleStatus.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.ddlSaleStatus.ForeColor = System.Drawing.Color.DimGray;
            this.ddlSaleStatus.FormattingEnabled = true;
            this.ddlSaleStatus.Items.AddRange(new object[] {
            "全部",
            "未處理",
            "未完成已付款",
            "已完成未付款",
            "已完成"});
            this.ddlSaleStatus.Location = new System.Drawing.Point(805, 155);
            this.ddlSaleStatus.Name = "ddlSaleStatus";
            this.ddlSaleStatus.Size = new System.Drawing.Size(174, 27);
            this.ddlSaleStatus.TabIndex = 83;
            // 
            // txtSaleItem
            // 
            this.txtSaleItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaleItem.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtSaleItem.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSaleItem.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtSaleItem.BorderThickness = 2;
            this.txtSaleItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSaleItem.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleItem.ForeColor = System.Drawing.Color.Black;
            this.txtSaleItem.isPassword = false;
            this.txtSaleItem.Location = new System.Drawing.Point(111, 59);
            this.txtSaleItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaleItem.Name = "txtSaleItem";
            this.txtSaleItem.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtSaleItem.Size = new System.Drawing.Size(395, 35);
            this.txtSaleItem.TabIndex = 81;
            this.txtSaleItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSaleMain
            // 
            this.txtSaleMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaleMain.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtSaleMain.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSaleMain.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtSaleMain.BorderThickness = 2;
            this.txtSaleMain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSaleMain.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleMain.ForeColor = System.Drawing.Color.Black;
            this.txtSaleMain.isPassword = false;
            this.txtSaleMain.Location = new System.Drawing.Point(647, 12);
            this.txtSaleMain.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaleMain.Name = "txtSaleMain";
            this.txtSaleMain.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtSaleMain.Size = new System.Drawing.Size(337, 35);
            this.txtSaleMain.TabIndex = 80;
            this.txtSaleMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSaleName
            // 
            this.txtSaleName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaleName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtSaleName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSaleName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtSaleName.BorderThickness = 2;
            this.txtSaleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSaleName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleName.ForeColor = System.Drawing.Color.Black;
            this.txtSaleName.isPassword = false;
            this.txtSaleName.Location = new System.Drawing.Point(110, 12);
            this.txtSaleName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaleName.Name = "txtSaleName";
            this.txtSaleName.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtSaleName.Size = new System.Drawing.Size(395, 35);
            this.txtSaleName.TabIndex = 79;
            this.txtSaleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 76;
            this.label5.Text = "銷售負責人:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(375, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 19);
            this.label14.TabIndex = 74;
            this.label14.Text = "收入類別:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(721, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 71;
            this.label6.Text = "訂單狀態:";
            // 
            // btnSaleDelete
            // 
            this.btnSaleDelete.ActiveBorderThickness = 1;
            this.btnSaleDelete.ActiveCornerRadius = 30;
            this.btnSaleDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnSaleDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaleDelete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnSaleDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnSaleDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaleDelete.BackgroundImage")));
            this.btnSaleDelete.ButtonText = "刪 除";
            this.btnSaleDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaleDelete.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaleDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSaleDelete.IdleBorderThickness = 1;
            this.btnSaleDelete.IdleCornerRadius = 30;
            this.btnSaleDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnSaleDelete.IdleForecolor = System.Drawing.Color.White;
            this.btnSaleDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnSaleDelete.Location = new System.Drawing.Point(907, 193);
            this.btnSaleDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaleDelete.Name = "btnSaleDelete";
            this.btnSaleDelete.Size = new System.Drawing.Size(80, 42);
            this.btnSaleDelete.TabIndex = 46;
            this.btnSaleDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaleSearch
            // 
            this.btnSaleSearch.ActiveBorderThickness = 1;
            this.btnSaleSearch.ActiveCornerRadius = 30;
            this.btnSaleSearch.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnSaleSearch.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaleSearch.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnSaleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnSaleSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaleSearch.BackgroundImage")));
            this.btnSaleSearch.ButtonText = "查 詢";
            this.btnSaleSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaleSearch.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaleSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSaleSearch.IdleBorderThickness = 1;
            this.btnSaleSearch.IdleCornerRadius = 30;
            this.btnSaleSearch.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnSaleSearch.IdleForecolor = System.Drawing.Color.White;
            this.btnSaleSearch.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnSaleSearch.Location = new System.Drawing.Point(641, 193);
            this.btnSaleSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaleSearch.Name = "btnSaleSearch";
            this.btnSaleSearch.Size = new System.Drawing.Size(80, 42);
            this.btnSaleSearch.TabIndex = 45;
            this.btnSaleSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaleModify
            // 
            this.btnSaleModify.ActiveBorderThickness = 1;
            this.btnSaleModify.ActiveCornerRadius = 30;
            this.btnSaleModify.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.btnSaleModify.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaleModify.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.btnSaleModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnSaleModify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaleModify.BackgroundImage")));
            this.btnSaleModify.ButtonText = "修 改";
            this.btnSaleModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaleModify.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaleModify.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSaleModify.IdleBorderThickness = 1;
            this.btnSaleModify.IdleCornerRadius = 30;
            this.btnSaleModify.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.btnSaleModify.IdleForecolor = System.Drawing.Color.White;
            this.btnSaleModify.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.btnSaleModify.Location = new System.Drawing.Point(819, 193);
            this.btnSaleModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaleModify.Name = "btnSaleModify";
            this.btnSaleModify.Size = new System.Drawing.Size(80, 42);
            this.btnSaleModify.TabIndex = 44;
            this.btnSaleModify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaleAdd
            // 
            this.btnSaleAdd.ActiveBorderThickness = 1;
            this.btnSaleAdd.ActiveCornerRadius = 30;
            this.btnSaleAdd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(166)))), ((int)(((byte)(117)))));
            this.btnSaleAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaleAdd.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(166)))), ((int)(((byte)(117)))));
            this.btnSaleAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnSaleAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaleAdd.BackgroundImage")));
            this.btnSaleAdd.ButtonText = "新 增";
            this.btnSaleAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaleAdd.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaleAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSaleAdd.IdleBorderThickness = 1;
            this.btnSaleAdd.IdleCornerRadius = 30;
            this.btnSaleAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(166)))), ((int)(((byte)(117)))));
            this.btnSaleAdd.IdleForecolor = System.Drawing.Color.White;
            this.btnSaleAdd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(166)))), ((int)(((byte)(117)))));
            this.btnSaleAdd.Location = new System.Drawing.Point(730, 193);
            this.btnSaleAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaleAdd.Name = "btnSaleAdd";
            this.btnSaleAdd.Size = new System.Drawing.Size(80, 42);
            this.btnSaleAdd.TabIndex = 43;
            this.btnSaleAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbSaleModifyDTTM
            // 
            this.ckbSaleModifyDTTM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.ckbSaleModifyDTTM.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.ckbSaleModifyDTTM.Checked = false;
            this.ckbSaleModifyDTTM.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ckbSaleModifyDTTM.ForeColor = System.Drawing.Color.White;
            this.ckbSaleModifyDTTM.Location = new System.Drawing.Point(646, 65);
            this.ckbSaleModifyDTTM.Name = "ckbSaleModifyDTTM";
            this.ckbSaleModifyDTTM.Size = new System.Drawing.Size(20, 20);
            this.ckbSaleModifyDTTM.TabIndex = 42;
            // 
            // dpkSaleModifyEDTTM
            // 
            this.dpkSaleModifyEDTTM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dpkSaleModifyEDTTM.BorderRadius = 0;
            this.dpkSaleModifyEDTTM.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dpkSaleModifyEDTTM.ForeColor = System.Drawing.Color.DimGray;
            this.dpkSaleModifyEDTTM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkSaleModifyEDTTM.FormatCustom = null;
            this.dpkSaleModifyEDTTM.Location = new System.Drawing.Point(834, 58);
            this.dpkSaleModifyEDTTM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpkSaleModifyEDTTM.Name = "dpkSaleModifyEDTTM";
            this.dpkSaleModifyEDTTM.Size = new System.Drawing.Size(150, 35);
            this.dpkSaleModifyEDTTM.TabIndex = 34;
            this.dpkSaleModifyEDTTM.Value = new System.DateTime(2018, 6, 18, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(560, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 19);
            this.label10.TabIndex = 32;
            this.label10.Text = "修改日期:";
            // 
            // dpkSaleModifySDTTM
            // 
            this.dpkSaleModifySDTTM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dpkSaleModifySDTTM.BorderRadius = 0;
            this.dpkSaleModifySDTTM.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dpkSaleModifySDTTM.ForeColor = System.Drawing.Color.DimGray;
            this.dpkSaleModifySDTTM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkSaleModifySDTTM.FormatCustom = null;
            this.dpkSaleModifySDTTM.Location = new System.Drawing.Point(676, 58);
            this.dpkSaleModifySDTTM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpkSaleModifySDTTM.Name = "dpkSaleModifySDTTM";
            this.dpkSaleModifySDTTM.Size = new System.Drawing.Size(150, 35);
            this.dpkSaleModifySDTTM.TabIndex = 29;
            this.dpkSaleModifySDTTM.Value = new System.DateTime(2018, 6, 18, 13, 48, 49, 0);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(23, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "商品資訊:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(575, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "主電話:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(23, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 19);
            this.label15.TabIndex = 13;
            this.label15.Text = "客戶姓名:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 750);
            this.Controls.Add(this.panelSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Form1";
            this.panelSale.ResumeLayout(false);
            this.panelSaleView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.panelSaleSearch.ResumeLayout(false);
            this.panelSaleSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSale;
        private System.Windows.Forms.Panel panelSaleView;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSale_Serno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSale_CSTName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSale_Main;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSale_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSale_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSale_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSale_Dealer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSale_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSale_Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSale_DealDTTM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSale_ModifyDTTM;
        private System.Windows.Forms.Panel panelSaleSearch;
        private System.Windows.Forms.Label lblSaleTotalAmount;
        private System.Windows.Forms.Label label24;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSaleComment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSaleTotal;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuCheckbox ckbSaleDealDTTM;
        private Bunifu.Framework.UI.BunifuDatepicker dpkSaleDealEDTTM;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuDatepicker dpkSaleDealSDTTM;
        private System.Windows.Forms.ComboBox ddlSaleDealer;
        private System.Windows.Forms.ComboBox ddlSaleType;
        private System.Windows.Forms.ComboBox ddlSaleStatus;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSaleItem;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSaleMain;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSaleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaleDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaleSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaleModify;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaleAdd;
        private Bunifu.Framework.UI.BunifuCheckbox ckbSaleModifyDTTM;
        private Bunifu.Framework.UI.BunifuDatepicker dpkSaleModifyEDTTM;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuDatepicker dpkSaleModifySDTTM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
    }
}

