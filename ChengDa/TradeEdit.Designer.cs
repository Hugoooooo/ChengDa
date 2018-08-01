namespace ChengDa
{
    partial class TradeEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TradeEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtItemInfo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtComment = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label17 = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblModifyDTTM = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblInsertBy = new System.Windows.Forms.Label();
            this.lblInsertDTTM = new System.Windows.Forms.Label();
            this.lblModifyBy = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.ddlDealer = new System.Windows.Forms.ComboBox();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.dgvItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgvItem_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAddr = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMobile = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.dpkDealDTTM = new Bunifu.Framework.UI.BunifuDatepicker();
            this.ddlType = new System.Windows.Forms.ComboBox();
            this.lblTotalAmt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlY = new System.Windows.Forms.ComboBox();
            this.ddlM = new System.Windows.Forms.ComboBox();
            this.btnDone = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnItemPick = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnItemDel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnItemAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnOK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelBar.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "客戶姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(103, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "銷售資料";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(117, 127);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtName.Size = new System.Drawing.Size(120, 30);
            this.txtName.TabIndex = 32;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelBar.Controls.Add(this.lblClose);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(602, 32);
            this.panelBar.TabIndex = 66;
            this.panelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBar_MouseDown);
            this.panelBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBar_MouseMove);
            this.panelBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBar_MouseUp);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(572, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 23);
            this.lblClose.TabIndex = 64;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(18, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 67;
            this.label10.Text = "銷售負責人:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(293, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 69;
            this.label6.Text = "訂單狀態:";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtAmount.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAmount.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtAmount.BorderThickness = 2;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.isPassword = false;
            this.txtAmount.Location = new System.Drawing.Point(374, 246);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtAmount.Size = new System.Drawing.Size(188, 30);
            this.txtAmount.TabIndex = 13;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(293, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 19);
            this.label11.TabIndex = 71;
            this.label11.Text = "實收金額:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(36, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 19);
            this.label14.TabIndex = 73;
            this.label14.Text = "收入類別:";
            // 
            // txtItemInfo
            // 
            this.txtItemInfo.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtItemInfo.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtItemInfo.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtItemInfo.BorderThickness = 2;
            this.txtItemInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemInfo.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemInfo.ForeColor = System.Drawing.Color.Black;
            this.txtItemInfo.isPassword = false;
            this.txtItemInfo.Location = new System.Drawing.Point(113, 285);
            this.txtItemInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemInfo.Name = "txtItemInfo";
            this.txtItemInfo.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtItemInfo.Size = new System.Drawing.Size(382, 30);
            this.txtItemInfo.TabIndex = 14;
            this.txtItemInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtItemInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemInfo_KeyDown);
            // 
            // txtComment
            // 
            this.txtComment.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtComment.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtComment.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtComment.BorderThickness = 2;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.ForeColor = System.Drawing.Color.Black;
            this.txtComment.isPassword = false;
            this.txtComment.Location = new System.Drawing.Point(112, 569);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtComment.Name = "txtComment";
            this.txtComment.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtComment.Size = new System.Drawing.Size(450, 30);
            this.txtComment.TabIndex = 15;
            this.txtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(32, 575);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 19);
            this.label17.TabIndex = 80;
            this.label17.Text = "銷售備註:";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInfo.Controls.Add(this.label8);
            this.panelInfo.Controls.Add(this.lblModifyDTTM);
            this.panelInfo.Controls.Add(this.label12);
            this.panelInfo.Controls.Add(this.lblInsertBy);
            this.panelInfo.Controls.Add(this.lblInsertDTTM);
            this.panelInfo.Controls.Add(this.lblModifyBy);
            this.panelInfo.Controls.Add(this.label19);
            this.panelInfo.Controls.Add(this.label21);
            this.panelInfo.Controls.Add(this.label23);
            this.panelInfo.Controls.Add(this.label26);
            this.panelInfo.Location = new System.Drawing.Point(33, 609);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(536, 68);
            this.panelInfo.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(7, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 63;
            this.label8.Text = "新增人員:";
            // 
            // lblModifyDTTM
            // 
            this.lblModifyDTTM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModifyDTTM.AutoSize = true;
            this.lblModifyDTTM.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblModifyDTTM.ForeColor = System.Drawing.Color.Black;
            this.lblModifyDTTM.Location = new System.Drawing.Point(256, 38);
            this.lblModifyDTTM.Name = "lblModifyDTTM";
            this.lblModifyDTTM.Size = new System.Drawing.Size(124, 19);
            this.lblModifyDTTM.TabIndex = 70;
            this.lblModifyDTTM.Text = "lblModifyDTTM";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 19);
            this.label12.TabIndex = 66;
            this.label12.Text = "修改人員:";
            // 
            // lblInsertBy
            // 
            this.lblInsertBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInsertBy.AutoSize = true;
            this.lblInsertBy.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInsertBy.ForeColor = System.Drawing.Color.Black;
            this.lblInsertBy.Location = new System.Drawing.Point(80, 11);
            this.lblInsertBy.Name = "lblInsertBy";
            this.lblInsertBy.Size = new System.Drawing.Size(87, 19);
            this.lblInsertBy.TabIndex = 67;
            this.lblInsertBy.Text = "lblInsertBy";
            // 
            // lblInsertDTTM
            // 
            this.lblInsertDTTM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInsertDTTM.AutoSize = true;
            this.lblInsertDTTM.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInsertDTTM.ForeColor = System.Drawing.Color.Black;
            this.lblInsertDTTM.Location = new System.Drawing.Point(256, 11);
            this.lblInsertDTTM.Name = "lblInsertDTTM";
            this.lblInsertDTTM.Size = new System.Drawing.Size(114, 19);
            this.lblInsertDTTM.TabIndex = 69;
            this.lblInsertDTTM.Text = "lblInsertDTTM";
            // 
            // lblModifyBy
            // 
            this.lblModifyBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModifyBy.AutoSize = true;
            this.lblModifyBy.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblModifyBy.ForeColor = System.Drawing.Color.Black;
            this.lblModifyBy.Location = new System.Drawing.Point(80, 38);
            this.lblModifyBy.Name = "lblModifyBy";
            this.lblModifyBy.Size = new System.Drawing.Size(97, 19);
            this.lblModifyBy.TabIndex = 68;
            this.lblModifyBy.Text = "lblModifyBy";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label19.Location = new System.Drawing.Point(17, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 19);
            this.label19.TabIndex = 47;
            this.label19.Text = "新增人員:";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label21.Location = new System.Drawing.Point(16, 38);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 19);
            this.label21.TabIndex = 55;
            this.label21.Text = "修改人員:";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label23.Location = new System.Drawing.Point(207, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 19);
            this.label23.TabIndex = 48;
            this.label23.Text = "時間:";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label26.Location = new System.Drawing.Point(207, 38);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 19);
            this.label26.TabIndex = 52;
            this.label26.Text = "時間:";
            // 
            // ddlDealer
            // 
            this.ddlDealer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ddlDealer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlDealer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDealer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlDealer.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.ddlDealer.ForeColor = System.Drawing.Color.DimGray;
            this.ddlDealer.FormattingEnabled = true;
            this.ddlDealer.Location = new System.Drawing.Point(117, 210);
            this.ddlDealer.Name = "ddlDealer";
            this.ddlDealer.Size = new System.Drawing.Size(150, 27);
            this.ddlDealer.TabIndex = 10;
            // 
            // ddlStatus
            // 
            this.ddlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ddlStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlStatus.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.ddlStatus.ForeColor = System.Drawing.Color.DimGray;
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Items.AddRange(new object[] {
            "未處理",
            "未完成已付款",
            "已完成未付款",
            "已完成"});
            this.ddlStatus.Location = new System.Drawing.Point(378, 210);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(192, 27);
            this.ddlStatus.TabIndex = 11;
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvItem_Type,
            this.dgvItem_Item,
            this.dgvItem_Amount});
            this.dgvItem.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvItem.DoubleBuffered = true;
            this.dgvItem.EnableHeadersVisualStyles = false;
            this.dgvItem.HeaderBgColor = System.Drawing.Color.Gray;
            this.dgvItem.HeaderForeColor = System.Drawing.Color.White;
            this.dgvItem.Location = new System.Drawing.Point(36, 361);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.RowHeadersWidth = 50;
            this.dgvItem.RowTemplate.Height = 24;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(533, 154);
            this.dgvItem.TabIndex = 87;
            this.dgvItem.DoubleClick += new System.EventHandler(this.dgvItem_DoubleClick);
            // 
            // dgvItem_Type
            // 
            this.dgvItem_Type.HeaderText = "收入類別";
            this.dgvItem_Type.Name = "dgvItem_Type";
            this.dgvItem_Type.ReadOnly = true;
            // 
            // dgvItem_Item
            // 
            this.dgvItem_Item.HeaderText = "商品資訊";
            this.dgvItem_Item.Name = "dgvItem_Item";
            this.dgvItem_Item.ReadOnly = true;
            this.dgvItem_Item.Width = 300;
            // 
            // dgvItem_Amount
            // 
            this.dgvItem_Amount.HeaderText = "金額";
            this.dgvItem_Amount.Name = "dgvItem_Amount";
            this.dgvItem_Amount.ReadOnly = true;
            this.dgvItem_Amount.Width = 130;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(63, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 19);
            this.label13.TabIndex = 40;
            this.label13.Text = "地址:";
            // 
            // txtAddr
            // 
            this.txtAddr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAddr.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtAddr.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAddr.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtAddr.BorderThickness = 2;
            this.txtAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddr.Enabled = false;
            this.txtAddr.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr.ForeColor = System.Drawing.Color.Black;
            this.txtAddr.isPassword = false;
            this.txtAddr.Location = new System.Drawing.Point(118, 167);
            this.txtAddr.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtAddr.Size = new System.Drawing.Size(451, 30);
            this.txtAddr.TabIndex = 42;
            this.txtAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(293, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "主要號碼:";
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMobile.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtMobile.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtMobile.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtMobile.BorderThickness = 2;
            this.txtMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobile.Enabled = false;
            this.txtMobile.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.ForeColor = System.Drawing.Color.Black;
            this.txtMobile.isPassword = false;
            this.txtMobile.Location = new System.Drawing.Point(373, 127);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtMobile.Size = new System.Drawing.Size(196, 30);
            this.txtMobile.TabIndex = 33;
            this.txtMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 91;
            this.label4.Text = "完成日期:";
            // 
            // dpkDealDTTM
            // 
            this.dpkDealDTTM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dpkDealDTTM.BorderRadius = 0;
            this.dpkDealDTTM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dpkDealDTTM.ForeColor = System.Drawing.Color.DimGray;
            this.dpkDealDTTM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkDealDTTM.FormatCustom = null;
            this.dpkDealDTTM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dpkDealDTTM.Location = new System.Drawing.Point(117, 527);
            this.dpkDealDTTM.Name = "dpkDealDTTM";
            this.dpkDealDTTM.Size = new System.Drawing.Size(150, 35);
            this.dpkDealDTTM.TabIndex = 91;
            this.dpkDealDTTM.Value = new System.DateTime(2018, 6, 30, 3, 42, 0, 0);
            // 
            // ddlType
            // 
            this.ddlType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ddlType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlType.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.ddlType.ForeColor = System.Drawing.Color.DimGray;
            this.ddlType.FormattingEnabled = true;
            this.ddlType.Location = new System.Drawing.Point(113, 248);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(150, 27);
            this.ddlType.TabIndex = 12;
            // 
            // lblTotalAmt
            // 
            this.lblTotalAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmt.AutoSize = true;
            this.lblTotalAmt.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmt.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmt.Location = new System.Drawing.Point(426, 535);
            this.lblTotalAmt.Name = "lblTotalAmt";
            this.lblTotalAmt.Size = new System.Drawing.Size(90, 19);
            this.lblTotalAmt.TabIndex = 96;
            this.lblTotalAmt.Text = "總金額: 0 元";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(33, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 97;
            this.label7.Text = "商品資訊:";
            // 
            // ddlY
            // 
            this.ddlY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ddlY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlY.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.ddlY.ForeColor = System.Drawing.Color.DimGray;
            this.ddlY.FormattingEnabled = true;
            this.ddlY.Items.AddRange(new object[] {
            "2018",
            "2017",
            "2016"});
            this.ddlY.Location = new System.Drawing.Point(273, 532);
            this.ddlY.Name = "ddlY";
            this.ddlY.Size = new System.Drawing.Size(77, 27);
            this.ddlY.TabIndex = 98;
            this.ddlY.SelectedIndexChanged += new System.EventHandler(this.ddlY_SelectedIndexChanged);
            // 
            // ddlM
            // 
            this.ddlM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ddlM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlM.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.ddlM.ForeColor = System.Drawing.Color.DimGray;
            this.ddlM.FormattingEnabled = true;
            this.ddlM.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.ddlM.Location = new System.Drawing.Point(356, 532);
            this.ddlM.Name = "ddlM";
            this.ddlM.Size = new System.Drawing.Size(64, 27);
            this.ddlM.TabIndex = 99;
            this.ddlM.SelectedIndexChanged += new System.EventHandler(this.ddlM_SelectedIndexChanged);
            // 
            // btnDone
            // 
            this.btnDone.ActiveBorderThickness = 1;
            this.btnDone.ActiveCornerRadius = 30;
            this.btnDone.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.btnDone.ActiveForecolor = System.Drawing.Color.White;
            this.btnDone.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDone.BackgroundImage")));
            this.btnDone.ButtonText = "完成";
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDone.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDone.IdleBorderThickness = 1;
            this.btnDone.IdleCornerRadius = 30;
            this.btnDone.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.btnDone.IdleForecolor = System.Drawing.Color.White;
            this.btnDone.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.btnDone.Location = new System.Drawing.Point(487, 318);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(80, 42);
            this.btnDone.TabIndex = 115;
            this.btnDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnItemPick
            // 
            this.btnItemPick.ActiveBorderThickness = 1;
            this.btnItemPick.ActiveCornerRadius = 30;
            this.btnItemPick.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.btnItemPick.ActiveForecolor = System.Drawing.Color.White;
            this.btnItemPick.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.btnItemPick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnItemPick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItemPick.BackgroundImage")));
            this.btnItemPick.ButtonText = "+";
            this.btnItemPick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemPick.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnItemPick.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnItemPick.IdleBorderThickness = 1;
            this.btnItemPick.IdleCornerRadius = 30;
            this.btnItemPick.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.btnItemPick.IdleForecolor = System.Drawing.Color.White;
            this.btnItemPick.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.btnItemPick.Location = new System.Drawing.Point(512, 279);
            this.btnItemPick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnItemPick.Name = "btnItemPick";
            this.btnItemPick.Size = new System.Drawing.Size(50, 42);
            this.btnItemPick.TabIndex = 110;
            this.btnItemPick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnItemPick.Click += new System.EventHandler(this.btnItemPick_Click);
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 30;
            this.btnClear.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.ActiveForecolor = System.Drawing.Color.White;
            this.btnClear.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "清除";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 30;
            this.btnClear.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.IdleForecolor = System.Drawing.Color.White;
            this.btnClear.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.Location = new System.Drawing.Point(402, 318);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 42);
            this.btnClear.TabIndex = 113;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnItemDel
            // 
            this.btnItemDel.ActiveBorderThickness = 1;
            this.btnItemDel.ActiveCornerRadius = 30;
            this.btnItemDel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnItemDel.ActiveForecolor = System.Drawing.Color.White;
            this.btnItemDel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnItemDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnItemDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItemDel.BackgroundImage")));
            this.btnItemDel.ButtonText = "刪除";
            this.btnItemDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemDel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnItemDel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnItemDel.IdleBorderThickness = 1;
            this.btnItemDel.IdleCornerRadius = 30;
            this.btnItemDel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnItemDel.IdleForecolor = System.Drawing.Color.White;
            this.btnItemDel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnItemDel.Location = new System.Drawing.Point(317, 318);
            this.btnItemDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnItemDel.Name = "btnItemDel";
            this.btnItemDel.Size = new System.Drawing.Size(80, 42);
            this.btnItemDel.TabIndex = 112;
            this.btnItemDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnItemDel.Click += new System.EventHandler(this.btnItemDel_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.ActiveBorderThickness = 1;
            this.btnItemAdd.ActiveCornerRadius = 30;
            this.btnItemAdd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(166)))), ((int)(((byte)(117)))));
            this.btnItemAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnItemAdd.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(166)))), ((int)(((byte)(117)))));
            this.btnItemAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnItemAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItemAdd.BackgroundImage")));
            this.btnItemAdd.ButtonText = "新增";
            this.btnItemAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemAdd.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnItemAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnItemAdd.IdleBorderThickness = 1;
            this.btnItemAdd.IdleCornerRadius = 30;
            this.btnItemAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(166)))), ((int)(((byte)(117)))));
            this.btnItemAdd.IdleForecolor = System.Drawing.Color.White;
            this.btnItemAdd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(166)))), ((int)(((byte)(117)))));
            this.btnItemAdd.Location = new System.Drawing.Point(232, 318);
            this.btnItemAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(80, 42);
            this.btnItemAdd.TabIndex = 111;
            this.btnItemAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(32, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 65;
            this.pictureBox4.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.ActiveBorderThickness = 1;
            this.btnOK.ActiveCornerRadius = 30;
            this.btnOK.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnOK.ActiveForecolor = System.Drawing.Color.White;
            this.btnOK.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.ButtonText = "待";
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOK.IdleBorderThickness = 1;
            this.btnOK.IdleCornerRadius = 30;
            this.btnOK.IdleFillColor = System.Drawing.Color.Gray;
            this.btnOK.IdleForecolor = System.Drawing.Color.White;
            this.btnOK.IdleLineColor = System.Drawing.Color.Gray;
            this.btnOK.Location = new System.Drawing.Point(265, 682);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 41);
            this.btnOK.TabIndex = 64;
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // TradeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(602, 726);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.ddlM);
            this.Controls.Add(this.ddlY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalAmt);
            this.Controls.Add(this.ddlType);
            this.Controls.Add(this.btnItemPick);
            this.Controls.Add(this.dpkDealDTTM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnItemDel);
            this.Controls.Add(this.btnItemAdd);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.ddlDealer);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtItemInfo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TradeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MemberEdit";
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOK;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtItemInfo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtComment;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblModifyDTTM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblInsertBy;
        private System.Windows.Forms.Label lblInsertDTTM;
        private System.Windows.Forms.Label lblModifyBy;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox ddlDealer;
        private System.Windows.Forms.ComboBox ddlStatus;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvItem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnItemDel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnItemAdd;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAddr;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMobile;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker dpkDealDTTM;
        private Bunifu.Framework.UI.BunifuThinButton2 btnItemPick;
        private System.Windows.Forms.ComboBox ddlType;
        private System.Windows.Forms.Label lblTotalAmt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Amount;
        private System.Windows.Forms.ComboBox ddlM;
        private System.Windows.Forms.ComboBox ddlY;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDone;
    }
}