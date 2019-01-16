namespace GUI.BaoCao
{
    partial class UC_ThongKeDoanhThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartImportAndExport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelEnterValue_1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txbYear = new System.Windows.Forms.TextBox();
            this.txbDay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbMonth = new System.Windows.Forms.TextBox();
            this.txbWeek = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PanelEnterValue_2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpkTo = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpkFrom = new System.Windows.Forms.DateTimePicker();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.cmbStatisticsBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChartImport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartExport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChartImportAndExport)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelEnterValue_1.SuspendLayout();
            this.PanelEnterValue_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartExport)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartImportAndExport
            // 
            this.ChartImportAndExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartImportAndExport.BorderlineColor = System.Drawing.Color.Black;
            this.ChartImportAndExport.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.ChartImportAndExport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartImportAndExport.Legends.Add(legend1);
            this.ChartImportAndExport.Location = new System.Drawing.Point(25, 134);
            this.ChartImportAndExport.Name = "ChartImportAndExport";
            this.ChartImportAndExport.Size = new System.Drawing.Size(721, 605);
            this.ChartImportAndExport.TabIndex = 0;
            this.ChartImportAndExport.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PanelEnterValue_1);
            this.panel1.Controls.Add(this.PanelEnterValue_2);
            this.panel1.Controls.Add(this.BtnLoad);
            this.panel1.Controls.Add(this.cmbStatisticsBy);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(25, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 108);
            this.panel1.TabIndex = 2;
            // 
            // PanelEnterValue_1
            // 
            this.PanelEnterValue_1.Controls.Add(this.label6);
            this.PanelEnterValue_1.Controls.Add(this.txbYear);
            this.PanelEnterValue_1.Controls.Add(this.txbDay);
            this.PanelEnterValue_1.Controls.Add(this.label7);
            this.PanelEnterValue_1.Controls.Add(this.label9);
            this.PanelEnterValue_1.Controls.Add(this.txbMonth);
            this.PanelEnterValue_1.Controls.Add(this.txbWeek);
            this.PanelEnterValue_1.Controls.Add(this.label8);
            this.PanelEnterValue_1.Location = new System.Drawing.Point(12, 47);
            this.PanelEnterValue_1.Name = "PanelEnterValue_1";
            this.PanelEnterValue_1.Size = new System.Drawing.Size(737, 51);
            this.PanelEnterValue_1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Năm:";
            // 
            // txbYear
            // 
            this.txbYear.Location = new System.Drawing.Point(73, 12);
            this.txbYear.Name = "txbYear";
            this.txbYear.Size = new System.Drawing.Size(100, 26);
            this.txbYear.TabIndex = 2;
            // 
            // txbDay
            // 
            this.txbDay.Location = new System.Drawing.Point(622, 13);
            this.txbDay.Name = "txbDay";
            this.txbDay.Size = new System.Drawing.Size(100, 26);
            this.txbDay.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tháng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(555, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ngày:";
            // 
            // txbMonth
            // 
            this.txbMonth.Location = new System.Drawing.Point(262, 13);
            this.txbMonth.Name = "txbMonth";
            this.txbMonth.Size = new System.Drawing.Size(100, 26);
            this.txbMonth.TabIndex = 3;
            // 
            // txbWeek
            // 
            this.txbWeek.Location = new System.Drawing.Point(442, 13);
            this.txbWeek.Name = "txbWeek";
            this.txbWeek.Size = new System.Drawing.Size(100, 26);
            this.txbWeek.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tuần:";
            // 
            // PanelEnterValue_2
            // 
            this.PanelEnterValue_2.Controls.Add(this.label13);
            this.PanelEnterValue_2.Controls.Add(this.dtpkTo);
            this.PanelEnterValue_2.Controls.Add(this.label12);
            this.PanelEnterValue_2.Controls.Add(this.dtpkFrom);
            this.PanelEnterValue_2.Location = new System.Drawing.Point(12, 47);
            this.PanelEnterValue_2.Name = "PanelEnterValue_2";
            this.PanelEnterValue_2.Size = new System.Drawing.Size(737, 51);
            this.PanelEnterValue_2.TabIndex = 5;
            this.PanelEnterValue_2.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(373, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Đến";
            // 
            // dtpkTo
            // 
            this.dtpkTo.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpkTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTo.Location = new System.Drawing.Point(427, 13);
            this.dtpkTo.Name = "dtpkTo";
            this.dtpkTo.Size = new System.Drawing.Size(220, 26);
            this.dtpkTo.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Từ";
            // 
            // dtpkFrom
            // 
            this.dtpkFrom.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpkFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkFrom.Location = new System.Drawing.Point(112, 13);
            this.dtpkFrom.Name = "dtpkFrom";
            this.dtpkFrom.Size = new System.Drawing.Size(220, 26);
            this.dtpkFrom.TabIndex = 0;
            // 
            // BtnLoad
            // 
            this.BtnLoad.AutoSize = true;
            this.BtnLoad.Location = new System.Drawing.Point(304, 9);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnLoad.Size = new System.Drawing.Size(101, 33);
            this.BtnLoad.TabIndex = 6;
            this.BtnLoad.Text = "Thống kê";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // cmbStatisticsBy
            // 
            this.cmbStatisticsBy.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbStatisticsBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatisticsBy.FormattingEnabled = true;
            this.cmbStatisticsBy.Location = new System.Drawing.Point(165, 12);
            this.cmbStatisticsBy.Name = "cmbStatisticsBy";
            this.cmbStatisticsBy.Size = new System.Drawing.Size(111, 27);
            this.cmbStatisticsBy.TabIndex = 0;
            this.cmbStatisticsBy.SelectionChangeCommitted += new System.EventHandler(this.cmbStatisticsBy_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thống kê theo:";
            // 
            // ChartImport
            // 
            this.ChartImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartImport.BorderlineColor = System.Drawing.Color.Black;
            this.ChartImport.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.ChartImport.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartImport.Legends.Add(legend2);
            this.ChartImport.Location = new System.Drawing.Point(755, 134);
            this.ChartImport.Name = "ChartImport";
            this.ChartImport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartImport.Series.Add(series1);
            this.ChartImport.Size = new System.Drawing.Size(549, 297);
            this.ChartImport.TabIndex = 3;
            this.ChartImport.Text = "chart2";
            // 
            // ChartExport
            // 
            this.ChartExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartExport.BorderlineColor = System.Drawing.Color.Black;
            this.ChartExport.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.ChartExport.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartExport.Legends.Add(legend3);
            this.ChartExport.Location = new System.Drawing.Point(755, 442);
            this.ChartExport.Name = "ChartExport";
            this.ChartExport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartExport.Series.Add(series2);
            this.ChartExport.Size = new System.Drawing.Size(549, 297);
            this.ChartExport.TabIndex = 4;
            this.ChartExport.Text = "chart2";
            // 
            // UC_ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.ChartExport);
            this.Controls.Add(this.ChartImport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChartImportAndExport);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1330, 770);
            this.Name = "UC_ThongKeDoanhThu";
            this.Size = new System.Drawing.Size(1330, 770);
            ((System.ComponentModel.ISupportInitialize)(this.ChartImportAndExport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelEnterValue_1.ResumeLayout(false);
            this.PanelEnterValue_1.PerformLayout();
            this.PanelEnterValue_2.ResumeLayout(false);
            this.PanelEnterValue_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartExport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartImportAndExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelEnterValue_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbYear;
        private System.Windows.Forms.TextBox txbDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbMonth;
        private System.Windows.Forms.TextBox txbWeek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PanelEnterValue_2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpkTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpkFrom;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.ComboBox cmbStatisticsBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartImport;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartExport;
    }
}
