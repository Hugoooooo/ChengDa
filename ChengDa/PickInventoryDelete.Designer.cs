namespace ChengDa
{
    partial class PickInventoryDelete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickInventoryDelete));
            this.btnMemberAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.dgvInventory = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgvInventory_Serno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventory_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventory_Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvInventory_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMemberAdd
            // 
            this.btnMemberAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnMemberAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMemberAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMemberAdd.BorderRadius = 0;
            this.btnMemberAdd.ButtonText = "Add";
            this.btnMemberAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMemberAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnMemberAdd.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMemberAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMemberAdd.Iconimage = null;
            this.btnMemberAdd.Iconimage_right = null;
            this.btnMemberAdd.Iconimage_right_Selected = null;
            this.btnMemberAdd.Iconimage_Selected = null;
            this.btnMemberAdd.IconMarginLeft = 0;
            this.btnMemberAdd.IconMarginRight = 0;
            this.btnMemberAdd.IconRightVisible = true;
            this.btnMemberAdd.IconRightZoom = 0D;
            this.btnMemberAdd.IconVisible = true;
            this.btnMemberAdd.IconZoom = 90D;
            this.btnMemberAdd.IsTab = false;
            this.btnMemberAdd.Location = new System.Drawing.Point(363, 612);
            this.btnMemberAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMemberAdd.Name = "btnMemberAdd";
            this.btnMemberAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMemberAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnMemberAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMemberAdd.selected = false;
            this.btnMemberAdd.Size = new System.Drawing.Size(109, 46);
            this.btnMemberAdd.TabIndex = 45;
            this.btnMemberAdd.Text = "Add";
            this.btnMemberAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMemberAdd.Textcolor = System.Drawing.Color.White;
            this.btnMemberAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.Gray;
            this.panelBar.Controls.Add(this.lblClose);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(430, 32);
            this.panelBar.TabIndex = 63;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(393, 4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 23);
            this.lblClose.TabIndex = 64;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvInventory_Serno,
            this.dgvInventory_Status,
            this.dgvInventory_Checkbox,
            this.dgvInventory_Name});
            this.dgvInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventory.DoubleBuffered = true;
            this.dgvInventory.EnableHeadersVisualStyles = false;
            this.dgvInventory.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.dgvInventory.HeaderForeColor = System.Drawing.Color.White;
            this.dgvInventory.Location = new System.Drawing.Point(0, 30);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidth = 50;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(430, 397);
            this.dgvInventory.TabIndex = 66;
            this.dgvInventory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 30;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "刪 除";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 30;
            this.btnDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnDelete.IdleForecolor = System.Drawing.Color.White;
            this.btnDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnDelete.Location = new System.Drawing.Point(175, 426);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 42);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvInventory_Serno
            // 
            this.dgvInventory_Serno.HeaderText = "Serno";
            this.dgvInventory_Serno.Name = "dgvInventory_Serno";
            this.dgvInventory_Serno.Visible = false;
            // 
            // dgvInventory_Status
            // 
            this.dgvInventory_Status.HeaderText = "狀態";
            this.dgvInventory_Status.Name = "dgvInventory_Status";
            this.dgvInventory_Status.Visible = false;
            // 
            // dgvInventory_Checkbox
            // 
            this.dgvInventory_Checkbox.HeaderText = "";
            this.dgvInventory_Checkbox.Name = "dgvInventory_Checkbox";
            this.dgvInventory_Checkbox.Width = 30;
            // 
            // dgvInventory_Name
            // 
            this.dgvInventory_Name.HeaderText = "同款機型條碼列表";
            this.dgvInventory_Name.Name = "dgvInventory_Name";
            this.dgvInventory_Name.Width = 400;
            // 
            // PickInventoryDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(430, 471);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.btnMemberAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PickInventoryDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberEdit";
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnMemberAdd;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Label lblClose;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvInventory;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventory_Serno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventory_Status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvInventory_Checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventory_Name;
    }
}