namespace ManageHotel
{
    partial class fCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCustomer));
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.lblRentRoom = new System.Windows.Forms.Label();
            this.dtpRentRoom = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cbCustomerKind = new System.Windows.Forms.ComboBox();
            this.lblCustomerKind = new System.Windows.Forms.Label();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblAsterisk1 = new System.Windows.Forms.Label();
            this.lblAsterisk2 = new System.Windows.Forms.Label();
            this.lblAsterisk3 = new System.Windows.Forms.Label();
            this.lblAsterisk4 = new System.Windows.Forms.Label();
            this.lblAsterisk5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTicket
            // 
            this.dgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTicket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTicket.BackgroundColor = System.Drawing.Color.White;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(16, 227);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.RowHeadersVisible = false;
            this.dgvTicket.Size = new System.Drawing.Size(540, 312);
            this.dgvTicket.TabIndex = 0;
            this.dgvTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellClick);
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(218, 15);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(151, 25);
            this.lblTicket.TabIndex = 2;
            this.lblTicket.Text = "THUÊ PHÒNG";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(15, 62);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(47, 16);
            this.lblRoom.TabIndex = 3;
            this.lblRoom.Text = "Phòng";
            // 
            // cbRoom
            // 
            this.cbRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(122, 58);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(201, 24);
            this.cbRoom.TabIndex = 1;
            this.cbRoom.SelectedValueChanged += new System.EventHandler(this.cbRoom_SelectedValueChanged);
            // 
            // lblRentRoom
            // 
            this.lblRentRoom.AutoSize = true;
            this.lblRentRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentRoom.Location = new System.Drawing.Point(342, 62);
            this.lblRentRoom.Name = "lblRentRoom";
            this.lblRentRoom.Size = new System.Drawing.Size(69, 16);
            this.lblRentRoom.TabIndex = 5;
            this.lblRentRoom.Text = "Ngày thuê";
            // 
            // dtpRentRoom
            // 
            this.dtpRentRoom.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpRentRoom.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtpRentRoom.CustomFormat = "dd/MM/yyyy";
            this.dtpRentRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRentRoom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRentRoom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpRentRoom.Location = new System.Drawing.Point(418, 59);
            this.dtpRentRoom.Name = "dtpRentRoom";
            this.dtpRentRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpRentRoom.Size = new System.Drawing.Size(138, 22);
            this.dtpRentRoom.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(122, 92);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(201, 22);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(15, 96);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(78, 16);
            this.lblCustomerName.TabIndex = 8;
            this.lblCustomerName.Text = "Khách hàng";
            // 
            // cbCustomerKind
            // 
            this.cbCustomerKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbCustomerKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomerKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomerKind.FormattingEnabled = true;
            this.cbCustomerKind.Location = new System.Drawing.Point(122, 126);
            this.cbCustomerKind.Name = "cbCustomerKind";
            this.cbCustomerKind.Size = new System.Drawing.Size(201, 24);
            this.cbCustomerKind.TabIndex = 3;
            // 
            // lblCustomerKind
            // 
            this.lblCustomerKind.AutoSize = true;
            this.lblCustomerKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerKind.Location = new System.Drawing.Point(15, 130);
            this.lblCustomerKind.Name = "lblCustomerKind";
            this.lblCustomerKind.Size = new System.Drawing.Size(73, 16);
            this.lblCustomerKind.TabIndex = 10;
            this.lblCustomerKind.Text = "Loại khách";
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentity.Location = new System.Drawing.Point(15, 163);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(48, 16);
            this.lblIdentity.TabIndex = 12;
            this.lblIdentity.Text = "CMND";
            // 
            // txtIdentity
            // 
            this.txtIdentity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentity.Location = new System.Drawing.Point(122, 160);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(201, 22);
            this.txtIdentity.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(15, 195);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 16);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(122, 192);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(201, 22);
            this.txtAddress.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::ManageHotel.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(342, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 54);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Image = global::ManageHotel.Properties.Resources.Cash;
            this.btnPay.Location = new System.Drawing.Point(342, 160);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(214, 56);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "Thanh toán/Trả phòng...";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::ManageHotel.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(456, 92);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 54);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Lưu";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblAsterisk1
            // 
            this.lblAsterisk1.AutoSize = true;
            this.lblAsterisk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk1.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisk1.Location = new System.Drawing.Point(92, 54);
            this.lblAsterisk1.Name = "lblAsterisk1";
            this.lblAsterisk1.Size = new System.Drawing.Size(17, 24);
            this.lblAsterisk1.TabIndex = 46;
            this.lblAsterisk1.Text = "*";
            // 
            // lblAsterisk2
            // 
            this.lblAsterisk2.AutoSize = true;
            this.lblAsterisk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk2.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisk2.Location = new System.Drawing.Point(92, 88);
            this.lblAsterisk2.Name = "lblAsterisk2";
            this.lblAsterisk2.Size = new System.Drawing.Size(17, 24);
            this.lblAsterisk2.TabIndex = 47;
            this.lblAsterisk2.Text = "*";
            // 
            // lblAsterisk3
            // 
            this.lblAsterisk3.AutoSize = true;
            this.lblAsterisk3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk3.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisk3.Location = new System.Drawing.Point(92, 122);
            this.lblAsterisk3.Name = "lblAsterisk3";
            this.lblAsterisk3.Size = new System.Drawing.Size(17, 24);
            this.lblAsterisk3.TabIndex = 48;
            this.lblAsterisk3.Text = "*";
            // 
            // lblAsterisk4
            // 
            this.lblAsterisk4.AutoSize = true;
            this.lblAsterisk4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk4.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisk4.Location = new System.Drawing.Point(92, 156);
            this.lblAsterisk4.Name = "lblAsterisk4";
            this.lblAsterisk4.Size = new System.Drawing.Size(17, 24);
            this.lblAsterisk4.TabIndex = 49;
            this.lblAsterisk4.Text = "*";
            // 
            // lblAsterisk5
            // 
            this.lblAsterisk5.AutoSize = true;
            this.lblAsterisk5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk5.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisk5.Location = new System.Drawing.Point(92, 188);
            this.lblAsterisk5.Name = "lblAsterisk5";
            this.lblAsterisk5.Size = new System.Drawing.Size(17, 24);
            this.lblAsterisk5.TabIndex = 50;
            this.lblAsterisk5.Text = "*";
            // 
            // fCustomer
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(574, 551);
            this.Controls.Add(this.lblAsterisk5);
            this.Controls.Add(this.lblAsterisk4);
            this.Controls.Add(this.lblAsterisk3);
            this.Controls.Add(this.lblAsterisk2);
            this.Controls.Add(this.lblAsterisk1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblIdentity);
            this.Controls.Add(this.txtIdentity);
            this.Controls.Add(this.lblCustomerKind);
            this.Controls.Add(this.cbCustomerKind);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.dtpRentRoom);
            this.Controls.Add(this.lblRentRoom);
            this.Controls.Add(this.cbRoom);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.dgvTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vé thuê phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Label lblRentRoom;
        private System.Windows.Forms.DateTimePicker dtpRentRoom;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ComboBox cbCustomerKind;
        private System.Windows.Forms.Label lblCustomerKind;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblAsterisk1;
        private System.Windows.Forms.Label lblAsterisk2;
        private System.Windows.Forms.Label lblAsterisk3;
        private System.Windows.Forms.Label lblAsterisk4;
        private System.Windows.Forms.Label lblAsterisk5;
    }
}