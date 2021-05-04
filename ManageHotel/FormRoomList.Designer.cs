namespace ManageHotel
{
    partial class fRoomList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRoomList));
            this.dgvRoomList = new System.Windows.Forms.DataGridView();
            this.lblRoomList = new System.Windows.Forms.Label();
            this.cbRoomKind = new System.Windows.Forms.ComboBox();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblRoomKind = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRoomList.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomList.Location = new System.Drawing.Point(18, 166);
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.RowHeadersVisible = false;
            this.dgvRoomList.Size = new System.Drawing.Size(544, 372);
            this.dgvRoomList.TabIndex = 6;
            // 
            // lblRoomList
            // 
            this.lblRoomList.AutoSize = true;
            this.lblRoomList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomList.Location = new System.Drawing.Point(186, 22);
            this.lblRoomList.Name = "lblRoomList";
            this.lblRoomList.Size = new System.Drawing.Size(217, 25);
            this.lblRoomList.TabIndex = 2;
            this.lblRoomList.Text = "DANH SÁCH PHÒNG";
            // 
            // cbRoomKind
            // 
            this.cbRoomKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbRoomKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoomKind.FormattingEnabled = true;
            this.cbRoomKind.Location = new System.Drawing.Point(94, 92);
            this.cbRoomKind.Name = "cbRoomKind";
            this.cbRoomKind.Size = new System.Drawing.Size(242, 24);
            this.cbRoomKind.TabIndex = 2;
            this.cbRoomKind.SelectedValueChanged += new System.EventHandler(this.cbRoomKind_SelectedValueChanged);
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomPrice.Location = new System.Drawing.Point(94, 125);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.ReadOnly = true;
            this.txtRoomPrice.Size = new System.Drawing.Size(242, 22);
            this.txtRoomPrice.TabIndex = 3;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.Location = new System.Drawing.Point(16, 128);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(29, 16);
            this.lblRoomPrice.TabIndex = 52;
            this.lblRoomPrice.Text = "Giá";
            // 
            // lblRoomKind
            // 
            this.lblRoomKind.AutoSize = true;
            this.lblRoomKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomKind.Location = new System.Drawing.Point(17, 95);
            this.lblRoomKind.Name = "lblRoomKind";
            this.lblRoomKind.Size = new System.Drawing.Size(75, 16);
            this.lblRoomKind.TabIndex = 45;
            this.lblRoomKind.Text = "Kiểu phòng";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.Location = new System.Drawing.Point(16, 63);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(73, 16);
            this.lblRoomName.TabIndex = 44;
            this.lblRoomName.Text = "Tên phòng";
            // 
            // txtRoomName
            // 
            this.txtRoomName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomName.Location = new System.Drawing.Point(94, 61);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.ReadOnly = true;
            this.txtRoomName.Size = new System.Drawing.Size(242, 22);
            this.txtRoomName.TabIndex = 1;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Image = global::ManageHotel.Properties.Resources.Cash;
            this.btnPay.Location = new System.Drawing.Point(461, 61);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(101, 87);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Thanh toán...";
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Image = global::ManageHotel.Properties.Resources.Key;
            this.btnView.Location = new System.Drawing.Point(347, 61);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 87);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "Thuê phòng...";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fRoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(580, 555);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.cbRoomKind);
            this.Controls.Add(this.txtRoomPrice);
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblRoomKind);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.lblRoomList);
            this.Controls.Add(this.dgvRoomList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fRoomList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoomList;
        private System.Windows.Forms.Label lblRoomList;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ComboBox cbRoomKind;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblRoomKind;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.TextBox txtRoomName;
    }
}