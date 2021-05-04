namespace ManageHotel
{
    partial class introduce
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
            this.ptbIntroduce = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIntroduce)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbIntroduce
            // 
            this.ptbIntroduce.Location = new System.Drawing.Point(1, 0);
            this.ptbIntroduce.Name = "ptbIntroduce";
            this.ptbIntroduce.Size = new System.Drawing.Size(670, 382);
            this.ptbIntroduce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbIntroduce.TabIndex = 0;
            this.ptbIntroduce.TabStop = false;
            // 
            // introduce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 384);
            this.Controls.Add(this.ptbIntroduce);
            this.Name = "introduce";
            this.Text = "introduce";
            this.Load += new System.EventHandler(this.introduce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIntroduce)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbIntroduce;
    }
}