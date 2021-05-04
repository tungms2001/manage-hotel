namespace ManageHotel
{
    partial class fRoomCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRoomCategories));
            this.dgvRoomCategories = new System.Windows.Forms.DataGridView();
            this.lblRoomCategories = new System.Windows.Forms.Label();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.lblRoomKind = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.cbRoomKind = new System.Windows.Forms.ComboBox();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.chươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRules = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblAsterisk1 = new System.Windows.Forms.Label();
            this.lblAsterisk2 = new System.Windows.Forms.Label();
            this.lblAsterisk3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomCategories)).BeginInit();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRoomCategories
            // 
            this.dgvRoomCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomCategories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRoomCategories.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvRoomCategories.Location = new System.Drawing.Point(15, 205);
            this.dgvRoomCategories.Name = "dgvRoomCategories";
            this.dgvRoomCategories.RowHeadersVisible = false;
            this.dgvRoomCategories.RowTemplate.Height = 50;
            this.dgvRoomCategories.Size = new System.Drawing.Size(544, 310);
            this.dgvRoomCategories.TabIndex = 10;
            // 
            // lblRoomCategories
            // 
            this.lblRoomCategories.AutoSize = true;
            this.lblRoomCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomCategories.Location = new System.Drawing.Point(189, 28);
            this.lblRoomCategories.Name = "lblRoomCategories";
            this.lblRoomCategories.Size = new System.Drawing.Size(207, 25);
            this.lblRoomCategories.TabIndex = 1;
            this.lblRoomCategories.Text = "DANH MỤC PHÒNG";
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomPrice.Location = new System.Drawing.Point(107, 135);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.ReadOnly = true;
            this.txtRoomPrice.Size = new System.Drawing.Size(221, 22);
            this.txtRoomPrice.TabIndex = 4;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.Location = new System.Drawing.Point(14, 137);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(29, 16);
            this.lblRoomPrice.TabIndex = 40;
            this.lblRoomPrice.Text = "Giá";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.Location = new System.Drawing.Point(13, 73);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(73, 16);
            this.lblRoomName.TabIndex = 31;
            this.lblRoomName.Text = "Tên phòng";
            // 
            // txtRoomName
            // 
            this.txtRoomName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomName.Location = new System.Drawing.Point(107, 71);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(221, 22);
            this.txtRoomName.TabIndex = 2;
            // 
            // lblRoomKind
            // 
            this.lblRoomKind.AutoSize = true;
            this.lblRoomKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomKind.Location = new System.Drawing.Point(14, 105);
            this.lblRoomKind.Name = "lblRoomKind";
            this.lblRoomKind.Size = new System.Drawing.Size(75, 16);
            this.lblRoomKind.TabIndex = 32;
            this.lblRoomKind.Text = "Kiểu phòng";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(107, 167);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(221, 22);
            this.txtNote.TabIndex = 5;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(15, 170);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(52, 16);
            this.lblNote.TabIndex = 33;
            this.lblNote.Text = "Ghi chú";
            // 
            // cbRoomKind
            // 
            this.cbRoomKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbRoomKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoomKind.FormattingEnabled = true;
            this.cbRoomKind.Location = new System.Drawing.Point(107, 102);
            this.cbRoomKind.Name = "cbRoomKind";
            this.cbRoomKind.Size = new System.Drawing.Size(221, 24);
            this.cbRoomKind.TabIndex = 3;
            this.cbRoomKind.SelectedValueChanged += new System.EventHandler(this.cbRoomKind_SelectedValueChanged);
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.msMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chươngTrìnhToolStripMenuItem,
            this.tínhNăngToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(578, 25);
            this.msMain.TabIndex = 44;
            this.msMain.Text = "msMain";
            // 
            // chươngTrìnhToolStripMenuItem
            // 
            this.chươngTrìnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAccount,
            this.tsmiLogout,
            this.tsmiExit});
            this.chươngTrìnhToolStripMenuItem.Name = "chươngTrìnhToolStripMenuItem";
            this.chươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.chươngTrìnhToolStripMenuItem.Text = "Chương trình";
            // 
            // tsmiAccount
            // 
            this.tsmiAccount.Name = "tsmiAccount";
            this.tsmiAccount.Size = new System.Drawing.Size(180, 22);
            this.tsmiAccount.Text = "Đổi mật khẩu";
            this.tsmiAccount.Click += new System.EventHandler(this.tsmiAccount_Click);
            // 
            // tsmiLogout
            // 
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.tsmiLogout.Size = new System.Drawing.Size(180, 22);
            this.tsmiLogout.Text = "Đăng xuất";
            this.tsmiLogout.Click += new System.EventHandler(this.tsmiLogout_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "Thoát";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tínhNăngToolStripMenuItem
            // 
            this.tínhNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRules,
            this.tsmiReport});
            this.tínhNăngToolStripMenuItem.Name = "tínhNăngToolStripMenuItem";
            this.tínhNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.tínhNăngToolStripMenuItem.Text = "Tính năng";
            // 
            // tsmiRules
            // 
            this.tsmiRules.Name = "tsmiRules";
            this.tsmiRules.Size = new System.Drawing.Size(180, 22);
            this.tsmiRules.Text = "Quy định";
            this.tsmiRules.Click += new System.EventHandler(this.tsmiRules_Click);
            // 
            // tsmiReport
            // 
            this.tsmiReport.Name = "tsmiReport";
            this.tsmiReport.Size = new System.Drawing.Size(180, 22);
            this.tsmiReport.Text = "Báo cáo";
            this.tsmiReport.Click += new System.EventHandler(this.tsmiStatistic_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::ManageHotel.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(344, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 57);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCheckStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckStatus.Image = global::ManageHotel.Properties.Resources.Scan;
            this.btnCheckStatus.Location = new System.Drawing.Point(344, 137);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(215, 54);
            this.btnCheckStatus.TabIndex = 9;
            this.btnCheckStatus.Text = "Tình trạng phòng...";
            this.btnCheckStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckStatus.UseVisualStyleBackColor = false;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::ManageHotel.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(494, 71);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 57);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Lưu";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::ManageHotel.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(419, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 57);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Loại bỏ";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblAsterisk1
            // 
            this.lblAsterisk1.AutoSize = true;
            this.lblAsterisk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk1.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisk1.Location = new System.Drawing.Point(85, 67);
            this.lblAsterisk1.Name = "lblAsterisk1";
            this.lblAsterisk1.Size = new System.Drawing.Size(17, 24);
            this.lblAsterisk1.TabIndex = 45;
            this.lblAsterisk1.Text = "*";
            // 
            // lblAsterisk2
            // 
            this.lblAsterisk2.AutoSize = true;
            this.lblAsterisk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk2.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisk2.Location = new System.Drawing.Point(85, 98);
            this.lblAsterisk2.Name = "lblAsterisk2";
            this.lblAsterisk2.Size = new System.Drawing.Size(17, 24);
            this.lblAsterisk2.TabIndex = 46;
            this.lblAsterisk2.Text = "*";
            // 
            // lblAsterisk3
            // 
            this.lblAsterisk3.AutoSize = true;
            this.lblAsterisk3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk3.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisk3.Location = new System.Drawing.Point(85, 131);
            this.lblAsterisk3.Name = "lblAsterisk3";
            this.lblAsterisk3.Size = new System.Drawing.Size(17, 24);
            this.lblAsterisk3.TabIndex = 47;
            this.lblAsterisk3.Text = "*";
            // 
            // fRoomCategories
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(578, 534);
            this.Controls.Add(this.lblAsterisk3);
            this.Controls.Add(this.lblAsterisk2);
            this.Controls.Add(this.lblAsterisk1);
            this.Controls.Add(this.btnCheckStatus);
            this.Controls.Add(this.cbRoomKind);
            this.Controls.Add(this.txtRoomPrice);
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.lblRoomCategories);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvRoomCategories);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblRoomKind);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.Name = "fRoomCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomCategories)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoomCategories;
        private System.Windows.Forms.Label lblRoomCategories;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblRoomKind;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ComboBox cbRoomKind;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem chươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tínhNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiRules;
        private System.Windows.Forms.ToolStripMenuItem tsmiReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
        private System.Windows.Forms.Label lblAsterisk1;
        private System.Windows.Forms.Label lblAsterisk2;
        private System.Windows.Forms.Label lblAsterisk3;
    }
}

