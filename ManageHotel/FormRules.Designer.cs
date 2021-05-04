namespace ManageHotel
{
    partial class FormRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRules));
            this.lblRules = new System.Windows.Forms.Label();
            this.gbRoomProperties = new System.Windows.Forms.GroupBox();
            this.txtKindAndPrice = new System.Windows.Forms.TextBox();
            this.lblRoomNameAndPrice = new System.Windows.Forms.Label();
            this.nudAmountRooms = new System.Windows.Forms.NumericUpDown();
            this.lblAmountRoomKinds = new System.Windows.Forms.Label();
            this.gbCustomerProperties = new System.Windows.Forms.GroupBox();
            this.txtCustomerKinds = new System.Windows.Forms.TextBox();
            this.nudMaximumAmount = new System.Windows.Forms.NumericUpDown();
            this.lblMaximumAmount = new System.Windows.Forms.Label();
            this.lblCustomerKind = new System.Windows.Forms.Label();
            this.nudAmountCustomerKinds = new System.Windows.Forms.NumericUpDown();
            this.lblAmountCustomerKinds = new System.Windows.Forms.Label();
            this.gbSurcharge = new System.Windows.Forms.GroupBox();
            this.nudSurchargeBeginning = new System.Windows.Forms.NumericUpDown();
            this.lblSurcharge = new System.Windows.Forms.Label();
            this.txtRatio = new System.Windows.Forms.TextBox();
            this.lblRatio = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbRoomProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountRooms)).BeginInit();
            this.gbCustomerProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountCustomerKinds)).BeginInit();
            this.gbSurcharge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSurchargeBeginning)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(179, 16);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(114, 25);
            this.lblRules.TabIndex = 9;
            this.lblRules.Text = "QUY ĐỊNH";
            // 
            // gbRoomProperties
            // 
            this.gbRoomProperties.Controls.Add(this.txtKindAndPrice);
            this.gbRoomProperties.Controls.Add(this.lblRoomNameAndPrice);
            this.gbRoomProperties.Controls.Add(this.nudAmountRooms);
            this.gbRoomProperties.Controls.Add(this.lblAmountRoomKinds);
            this.gbRoomProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoomProperties.Location = new System.Drawing.Point(20, 54);
            this.gbRoomProperties.Margin = new System.Windows.Forms.Padding(2);
            this.gbRoomProperties.Name = "gbRoomProperties";
            this.gbRoomProperties.Padding = new System.Windows.Forms.Padding(2);
            this.gbRoomProperties.Size = new System.Drawing.Size(206, 307);
            this.gbRoomProperties.TabIndex = 10;
            this.gbRoomProperties.TabStop = false;
            this.gbRoomProperties.Text = "Thuộc tính phòng";
            // 
            // txtKindAndPrice
            // 
            this.txtKindAndPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtKindAndPrice.Location = new System.Drawing.Point(19, 103);
            this.txtKindAndPrice.Multiline = true;
            this.txtKindAndPrice.Name = "txtKindAndPrice";
            this.txtKindAndPrice.Size = new System.Drawing.Size(168, 184);
            this.txtKindAndPrice.TabIndex = 2;
            // 
            // lblRoomNameAndPrice
            // 
            this.lblRoomNameAndPrice.AutoSize = true;
            this.lblRoomNameAndPrice.Location = new System.Drawing.Point(15, 71);
            this.lblRoomNameAndPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomNameAndPrice.Name = "lblRoomNameAndPrice";
            this.lblRoomNameAndPrice.Size = new System.Drawing.Size(163, 17);
            this.lblRoomNameAndPrice.TabIndex = 2;
            this.lblRoomNameAndPrice.Text = "Tên loại phòng - đơn giá";
            // 
            // nudAmountRooms
            // 
            this.nudAmountRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudAmountRooms.Location = new System.Drawing.Point(128, 35);
            this.nudAmountRooms.Margin = new System.Windows.Forms.Padding(2);
            this.nudAmountRooms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmountRooms.Name = "nudAmountRooms";
            this.nudAmountRooms.Size = new System.Drawing.Size(58, 23);
            this.nudAmountRooms.TabIndex = 1;
            this.nudAmountRooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAmountRoomKinds
            // 
            this.lblAmountRoomKinds.AutoSize = true;
            this.lblAmountRoomKinds.Location = new System.Drawing.Point(15, 37);
            this.lblAmountRoomKinds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountRoomKinds.Name = "lblAmountRoomKinds";
            this.lblAmountRoomKinds.Size = new System.Drawing.Size(95, 17);
            this.lblAmountRoomKinds.TabIndex = 0;
            this.lblAmountRoomKinds.Text = "Số loại phòng";
            // 
            // gbCustomerProperties
            // 
            this.gbCustomerProperties.Controls.Add(this.txtCustomerKinds);
            this.gbCustomerProperties.Controls.Add(this.nudMaximumAmount);
            this.gbCustomerProperties.Controls.Add(this.lblMaximumAmount);
            this.gbCustomerProperties.Controls.Add(this.lblCustomerKind);
            this.gbCustomerProperties.Controls.Add(this.nudAmountCustomerKinds);
            this.gbCustomerProperties.Controls.Add(this.lblAmountCustomerKinds);
            this.gbCustomerProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerProperties.Location = new System.Drawing.Point(242, 54);
            this.gbCustomerProperties.Margin = new System.Windows.Forms.Padding(2);
            this.gbCustomerProperties.Name = "gbCustomerProperties";
            this.gbCustomerProperties.Padding = new System.Windows.Forms.Padding(2);
            this.gbCustomerProperties.Size = new System.Drawing.Size(206, 307);
            this.gbCustomerProperties.TabIndex = 11;
            this.gbCustomerProperties.TabStop = false;
            this.gbCustomerProperties.Text = "Thuộc tính khách";
            // 
            // txtCustomerKinds
            // 
            this.txtCustomerKinds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCustomerKinds.Location = new System.Drawing.Point(19, 103);
            this.txtCustomerKinds.Multiline = true;
            this.txtCustomerKinds.Name = "txtCustomerKinds";
            this.txtCustomerKinds.Size = new System.Drawing.Size(167, 150);
            this.txtCustomerKinds.TabIndex = 4;
            // 
            // nudMaximumAmount
            // 
            this.nudMaximumAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudMaximumAmount.Location = new System.Drawing.Point(130, 268);
            this.nudMaximumAmount.Margin = new System.Windows.Forms.Padding(2);
            this.nudMaximumAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaximumAmount.Name = "nudMaximumAmount";
            this.nudMaximumAmount.Size = new System.Drawing.Size(58, 23);
            this.nudMaximumAmount.TabIndex = 5;
            this.nudMaximumAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMaximumAmount
            // 
            this.lblMaximumAmount.AutoSize = true;
            this.lblMaximumAmount.Location = new System.Drawing.Point(18, 270);
            this.lblMaximumAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaximumAmount.Name = "lblMaximumAmount";
            this.lblMaximumAmount.Size = new System.Drawing.Size(106, 17);
            this.lblMaximumAmount.TabIndex = 4;
            this.lblMaximumAmount.Text = "Số khách tối đa";
            // 
            // lblCustomerKind
            // 
            this.lblCustomerKind.AutoSize = true;
            this.lblCustomerKind.Location = new System.Drawing.Point(16, 71);
            this.lblCustomerKind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerKind.Name = "lblCustomerKind";
            this.lblCustomerKind.Size = new System.Drawing.Size(125, 17);
            this.lblCustomerKind.TabIndex = 2;
            this.lblCustomerKind.Text = "Loại khách - hệ số";
            // 
            // nudAmountCustomerKinds
            // 
            this.nudAmountCustomerKinds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudAmountCustomerKinds.Location = new System.Drawing.Point(128, 35);
            this.nudAmountCustomerKinds.Margin = new System.Windows.Forms.Padding(2);
            this.nudAmountCustomerKinds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmountCustomerKinds.Name = "nudAmountCustomerKinds";
            this.nudAmountCustomerKinds.Size = new System.Drawing.Size(58, 23);
            this.nudAmountCustomerKinds.TabIndex = 3;
            this.nudAmountCustomerKinds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAmountCustomerKinds
            // 
            this.lblAmountCustomerKinds.AutoSize = true;
            this.lblAmountCustomerKinds.Location = new System.Drawing.Point(16, 37);
            this.lblAmountCustomerKinds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountCustomerKinds.Name = "lblAmountCustomerKinds";
            this.lblAmountCustomerKinds.Size = new System.Drawing.Size(93, 17);
            this.lblAmountCustomerKinds.TabIndex = 0;
            this.lblAmountCustomerKinds.Text = "Số loại khách";
            // 
            // gbSurcharge
            // 
            this.gbSurcharge.Controls.Add(this.nudSurchargeBeginning);
            this.gbSurcharge.Controls.Add(this.lblSurcharge);
            this.gbSurcharge.Controls.Add(this.txtRatio);
            this.gbSurcharge.Controls.Add(this.lblRatio);
            this.gbSurcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSurcharge.Location = new System.Drawing.Point(20, 368);
            this.gbSurcharge.Margin = new System.Windows.Forms.Padding(2);
            this.gbSurcharge.Name = "gbSurcharge";
            this.gbSurcharge.Padding = new System.Windows.Forms.Padding(2);
            this.gbSurcharge.Size = new System.Drawing.Size(428, 77);
            this.gbSurcharge.TabIndex = 12;
            this.gbSurcharge.TabStop = false;
            this.gbSurcharge.Text = "Tỷ lệ phụ thu";
            // 
            // nudSurchargeBeginning
            // 
            this.nudSurchargeBeginning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudSurchargeBeginning.Location = new System.Drawing.Point(352, 32);
            this.nudSurchargeBeginning.Margin = new System.Windows.Forms.Padding(2);
            this.nudSurchargeBeginning.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSurchargeBeginning.Name = "nudSurchargeBeginning";
            this.nudSurchargeBeginning.Size = new System.Drawing.Size(58, 23);
            this.nudSurchargeBeginning.TabIndex = 7;
            this.nudSurchargeBeginning.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSurcharge
            // 
            this.lblSurcharge.AutoSize = true;
            this.lblSurcharge.Location = new System.Drawing.Point(220, 35);
            this.lblSurcharge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurcharge.Name = "lblSurcharge";
            this.lblSurcharge.Size = new System.Drawing.Size(131, 17);
            this.lblSurcharge.TabIndex = 6;
            this.lblSurcharge.Text = "Bắt đầu phụ thu khi";
            // 
            // txtRatio
            // 
            this.txtRatio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRatio.Location = new System.Drawing.Point(76, 32);
            this.txtRatio.Margin = new System.Windows.Forms.Padding(2);
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.Size = new System.Drawing.Size(110, 23);
            this.txtRatio.TabIndex = 6;
            // 
            // lblRatio
            // 
            this.lblRatio.AutoSize = true;
            this.lblRatio.Location = new System.Drawing.Point(16, 35);
            this.lblRatio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(39, 17);
            this.lblRatio.TabIndex = 4;
            this.lblRatio.Text = "Tỷ lệ";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::ManageHotel.Properties.Resources.Edit;
            this.btnSave.Location = new System.Drawing.Point(298, 453);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 44);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu thay đổi";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(468, 513);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbSurcharge);
            this.Controls.Add(this.gbCustomerProperties);
            this.Controls.Add(this.gbRoomProperties);
            this.Controls.Add(this.lblRules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quy định";
            this.gbRoomProperties.ResumeLayout(false);
            this.gbRoomProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountRooms)).EndInit();
            this.gbCustomerProperties.ResumeLayout(false);
            this.gbCustomerProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountCustomerKinds)).EndInit();
            this.gbSurcharge.ResumeLayout(false);
            this.gbSurcharge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSurchargeBeginning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.GroupBox gbRoomProperties;
        private System.Windows.Forms.Label lblRoomNameAndPrice;
        private System.Windows.Forms.NumericUpDown nudAmountRooms;
        private System.Windows.Forms.Label lblAmountRoomKinds;
        private System.Windows.Forms.GroupBox gbCustomerProperties;
        private System.Windows.Forms.Label lblCustomerKind;
        private System.Windows.Forms.NumericUpDown nudAmountCustomerKinds;
        private System.Windows.Forms.Label lblAmountCustomerKinds;
        private System.Windows.Forms.NumericUpDown nudMaximumAmount;
        private System.Windows.Forms.Label lblMaximumAmount;
        private System.Windows.Forms.GroupBox gbSurcharge;
        private System.Windows.Forms.TextBox txtRatio;
        private System.Windows.Forms.Label lblRatio;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtKindAndPrice;
        private System.Windows.Forms.TextBox txtCustomerKinds;
        private System.Windows.Forms.NumericUpDown nudSurchargeBeginning;
        private System.Windows.Forms.Label lblSurcharge;
    }
}