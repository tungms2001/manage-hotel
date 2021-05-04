namespace ManageHotel
{
    partial class FormBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBill));
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.dgvRentRoom = new System.Windows.Forms.DataGridView();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPriceValue = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(19, 93);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 16);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(19, 61);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(78, 16);
            this.lblCustomer.TabIndex = 9;
            this.lblCustomer.Text = "Khách hàng";
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(220, 17);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(109, 25);
            this.lblBill.TabIndex = 8;
            this.lblBill.Text = "HÓA ĐƠN";
            // 
            // dgvRentRoom
            // 
            this.dgvRentRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentRoom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRentRoom.BackgroundColor = System.Drawing.Color.White;
            this.dgvRentRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentRoom.Location = new System.Drawing.Point(22, 131);
            this.dgvRentRoom.Name = "dgvRentRoom";
            this.dgvRentRoom.ReadOnly = true;
            this.dgvRentRoom.RowHeadersVisible = false;
            this.dgvRentRoom.Size = new System.Drawing.Size(500, 315);
            this.dgvRentRoom.TabIndex = 7;
            this.dgvRentRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentRoom_CellClick);
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceValue.Location = new System.Drawing.Point(307, 63);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(46, 16);
            this.lblPriceValue.TabIndex = 12;
            this.lblPriceValue.Text = "Trị giá";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(102, 59);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(186, 22);
            this.txtCustomer.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(102, 91);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(186, 22);
            this.txtAddress.TabIndex = 14;
            // 
            // txtPriceValue
            // 
            this.txtPriceValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceValue.Location = new System.Drawing.Point(368, 61);
            this.txtPriceValue.Name = "txtPriceValue";
            this.txtPriceValue.ReadOnly = true;
            this.txtPriceValue.Size = new System.Drawing.Size(155, 22);
            this.txtPriceValue.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(367, 89);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(156, 26);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Tính";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Image = global::ManageHotel.Properties.Resources.Home;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMenu.Location = new System.Drawing.Point(401, 462);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(121, 33);
            this.btnMenu.TabIndex = 16;
            this.btnMenu.Text = "Màn hình chính";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // FormBill
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(544, 515);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPriceValue);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblPriceValue);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.dgvRentRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.DataGridView dgvRentRoom;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPriceValue;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnMenu;
    }
}