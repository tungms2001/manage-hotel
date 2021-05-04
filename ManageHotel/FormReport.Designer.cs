using System.Windows.Forms.DataVisualization.Charting;

namespace ManageHotel
{
    partial class FormReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.tcReport = new System.Windows.Forms.TabControl();
            this.tpRevenue = new System.Windows.Forms.TabPage();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cbMonthRevenue = new System.Windows.Forms.ComboBox();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.tpDensity = new System.Windows.Forms.TabPage();
            this.chartDensity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMonthDensity = new System.Windows.Forms.ComboBox();
            this.dgvDensity = new System.Windows.Forms.DataGridView();
            this.lblTicket = new System.Windows.Forms.Label();
            this.tcReport.SuspendLayout();
            this.tpRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            this.tpDensity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDensity)).BeginInit();
            this.SuspendLayout();
            // 
            // tcReport
            // 
            this.tcReport.Controls.Add(this.tpRevenue);
            this.tcReport.Controls.Add(this.tpDensity);
            this.tcReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcReport.Location = new System.Drawing.Point(13, 47);
            this.tcReport.Name = "tcReport";
            this.tcReport.SelectedIndex = 0;
            this.tcReport.Size = new System.Drawing.Size(731, 383);
            this.tcReport.TabIndex = 0;
            // 
            // tpRevenue
            // 
            this.tpRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpRevenue.Controls.Add(this.chartRevenue);
            this.tpRevenue.Controls.Add(this.lblMonth);
            this.tpRevenue.Controls.Add(this.cbMonthRevenue);
            this.tpRevenue.Controls.Add(this.dgvRevenue);
            this.tpRevenue.Location = new System.Drawing.Point(4, 25);
            this.tpRevenue.Name = "tpRevenue";
            this.tpRevenue.Padding = new System.Windows.Forms.Padding(3);
            this.tpRevenue.Size = new System.Drawing.Size(723, 354);
            this.tpRevenue.TabIndex = 0;
            this.tpRevenue.Text = "Doanh thu theo loại phòng";
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Title = "Loại phòng";
            chartArea1.AxisY.Title = "Doanh thu (VNĐ)";
            chartArea1.Name = "caRevenue";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "lgRevenue";
            legend1.Position.Auto = false;
            legend1.Position.Height = 7.453416F;
            legend1.Position.Width = 30.63063F;
            legend1.Position.X = 66.36937F;
            legend1.Position.Y = 3F;
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(383, 6);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "caRevenue";
            series1.Legend = "lgRevenue";
            series1.Name = "Doanh thu";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(323, 341);
            this.chartRevenue.TabIndex = 3;
            this.chartRevenue.Text = "Doanh thu theo phòng";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(5, 12);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(47, 16);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Tháng";
            // 
            // cbMonthRevenue
            // 
            this.cbMonthRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbMonthRevenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonthRevenue.FormattingEnabled = true;
            this.cbMonthRevenue.Location = new System.Drawing.Point(58, 8);
            this.cbMonthRevenue.Name = "cbMonthRevenue";
            this.cbMonthRevenue.Size = new System.Drawing.Size(121, 24);
            this.cbMonthRevenue.TabIndex = 1;
            this.cbMonthRevenue.SelectedValueChanged += new System.EventHandler(this.cbMonth_SelectedValueChanged);
            // 
            // dgvRevenue
            // 
            this.dgvRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevenue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenue.Location = new System.Drawing.Point(7, 43);
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.ReadOnly = true;
            this.dgvRevenue.RowHeadersVisible = false;
            this.dgvRevenue.Size = new System.Drawing.Size(370, 304);
            this.dgvRevenue.TabIndex = 0;
            // 
            // tpDensity
            // 
            this.tpDensity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpDensity.Controls.Add(this.chartDensity);
            this.tpDensity.Controls.Add(this.label1);
            this.tpDensity.Controls.Add(this.cbMonthDensity);
            this.tpDensity.Controls.Add(this.dgvDensity);
            this.tpDensity.Location = new System.Drawing.Point(4, 25);
            this.tpDensity.Name = "tpDensity";
            this.tpDensity.Padding = new System.Windows.Forms.Padding(3);
            this.tpDensity.Size = new System.Drawing.Size(723, 354);
            this.tpDensity.TabIndex = 1;
            this.tpDensity.Text = "Mật độ sử dụng phòng";
            // 
            // chartDensity
            // 
            this.chartDensity.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.Title = "Phòng";
            chartArea2.AxisY.Title = "Số ngày";
            chartArea2.Name = "caDensity";
            this.chartDensity.ChartAreas.Add(chartArea2);
            legend2.Name = "lgDensity";
            legend2.Position.Auto = false;
            legend2.Position.Height = 7.453416F;
            legend2.Position.Width = 30.63063F;
            legend2.Position.X = 66.36937F;
            legend2.Position.Y = 3F;
            legend2.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.chartDensity.Legends.Add(legend2);
            this.chartDensity.Location = new System.Drawing.Point(383, 6);
            this.chartDensity.Name = "chartDensity";
            this.chartDensity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "caDensity";
            series2.Legend = "lgDensity";
            series2.Name = "Số ngày thuê";
            this.chartDensity.Series.Add(series2);
            this.chartDensity.Size = new System.Drawing.Size(323, 341);
            this.chartDensity.TabIndex = 5;
            this.chartDensity.Text = "Mật độ sử dụng phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tháng";
            // 
            // cbMonthDensity
            // 
            this.cbMonthDensity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbMonthDensity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonthDensity.FormattingEnabled = true;
            this.cbMonthDensity.Location = new System.Drawing.Point(58, 8);
            this.cbMonthDensity.Name = "cbMonthDensity";
            this.cbMonthDensity.Size = new System.Drawing.Size(121, 24);
            this.cbMonthDensity.TabIndex = 3;
            this.cbMonthDensity.SelectedValueChanged += new System.EventHandler(this.cbMonthDensity_SelectedValueChanged);
            // 
            // dgvDensity
            // 
            this.dgvDensity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDensity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDensity.BackgroundColor = System.Drawing.Color.White;
            this.dgvDensity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDensity.Location = new System.Drawing.Point(7, 43);
            this.dgvDensity.Name = "dgvDensity";
            this.dgvDensity.ReadOnly = true;
            this.dgvDensity.RowHeadersVisible = false;
            this.dgvDensity.Size = new System.Drawing.Size(370, 304);
            this.dgvDensity.TabIndex = 1;
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(336, 13);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(107, 25);
            this.lblTicket.TabIndex = 3;
            this.lblTicket.Text = "BÁO CÁO";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(756, 444);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.tcReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.tcReport.ResumeLayout(false);
            this.tpRevenue.ResumeLayout(false);
            this.tpRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            this.tpDensity.ResumeLayout(false);
            this.tpDensity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcReport;
        private System.Windows.Forms.TabPage tpDensity;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.DataGridView dgvDensity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMonthDensity;
        private System.Windows.Forms.TabPage tpRevenue;
        private Chart chartRevenue;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cbMonthRevenue;
        private System.Windows.Forms.DataGridView dgvRevenue;
        private Chart chartDensity;
    }
}