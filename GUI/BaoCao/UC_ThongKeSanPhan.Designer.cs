﻿namespace GUI.BaoCao
{
    partial class UC_ThongKeSanPhan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelChart = new System.Windows.Forms.Panel();
            this.ChartBestSellingProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbBestSellingProduct = new System.Windows.Forms.Label();
            this.lbTotalProduct = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvProducts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbDay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbWeek = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbMonth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.cmbStatisticsBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelEnterValue_1 = new System.Windows.Forms.Panel();
            this.PanelEnterValue_2 = new System.Windows.Forms.Panel();
            this.dtpkFrom = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpkTo = new System.Windows.Forms.DateTimePicker();
            this.PanelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBestSellingProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelEnterValue_1.SuspendLayout();
            this.PanelEnterValue_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelChart
            // 
            this.PanelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelChart.Controls.Add(this.ChartBestSellingProducts);
            this.PanelChart.Controls.Add(this.label4);
            this.PanelChart.Location = new System.Drawing.Point(25, 146);
            this.PanelChart.Name = "PanelChart";
            this.PanelChart.Size = new System.Drawing.Size(761, 604);
            this.PanelChart.TabIndex = 1;
            // 
            // ChartBestSellingProducts
            // 
            this.ChartBestSellingProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.ChartBestSellingProducts.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.ChartBestSellingProducts.Legends.Add(legend6);
            this.ChartBestSellingProducts.Location = new System.Drawing.Point(29, 94);
            this.ChartBestSellingProducts.Name = "ChartBestSellingProducts";
            this.ChartBestSellingProducts.Size = new System.Drawing.Size(701, 485);
            this.ChartBestSellingProducts.TabIndex = 3;
            this.ChartBestSellingProducts.Text = "chart1";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(119, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(539, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "TOP 10 SẢN PHẨM BÁN CHẠY NHẤT";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbQuantity);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbBestSellingProduct);
            this.groupBox1.Controls.Add(this.lbTotalProduct);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgvProducts);
            this.groupBox1.Location = new System.Drawing.Point(802, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 729);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // lbQuantity
            // 
            this.lbQuantity.Location = new System.Drawing.Point(126, 148);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(302, 23);
            this.lbQuantity.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Số lượng:";
            // 
            // lbBestSellingProduct
            // 
            this.lbBestSellingProduct.Location = new System.Drawing.Point(44, 114);
            this.lbBestSellingProduct.Name = "lbBestSellingProduct";
            this.lbBestSellingProduct.Size = new System.Drawing.Size(435, 23);
            this.lbBestSellingProduct.TabIndex = 5;
            // 
            // lbTotalProduct
            // 
            this.lbTotalProduct.AutoSize = true;
            this.lbTotalProduct.Location = new System.Drawing.Point(244, 43);
            this.lbTotalProduct.Name = "lbTotalProduct";
            this.lbTotalProduct.Size = new System.Drawing.Size(0, 19);
            this.lbTotalProduct.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Các sản phẩm gần hết trong kho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sản phẩm bán chạy nhất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số sản phẩm bán được:";
            // 
            // dtgvProducts
            // 
            this.dtgvProducts.AllowUserToAddRows = false;
            this.dtgvProducts.AllowUserToDeleteRows = false;
            this.dtgvProducts.AllowUserToResizeColumns = false;
            this.dtgvProducts.AllowUserToResizeRows = false;
            this.dtgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProducts.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvProducts.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtgvProducts.Location = new System.Drawing.Point(23, 252);
            this.dtgvProducts.MultiSelect = false;
            this.dtgvProducts.Name = "dtgvProducts";
            this.dtgvProducts.ReadOnly = true;
            this.dtgvProducts.RowHeadersVisible = false;
            this.dtgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProducts.Size = new System.Drawing.Size(456, 455);
            this.dtgvProducts.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PanelEnterValue_1);
            this.panel1.Controls.Add(this.PanelEnterValue_2);
            this.panel1.Controls.Add(this.cmbCategories);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.BtnLoad);
            this.panel1.Controls.Add(this.cmbStatisticsBy);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(25, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 108);
            this.panel1.TabIndex = 0;
            // 
            // cmbCategories
            // 
            this.cmbCategories.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(426, 12);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(168, 27);
            this.cmbCategories.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Loại sản phẩm";
            // 
            // txbDay
            // 
            this.txbDay.Location = new System.Drawing.Point(622, 13);
            this.txbDay.Name = "txbDay";
            this.txbDay.Size = new System.Drawing.Size(100, 26);
            this.txbDay.TabIndex = 5;
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
            // txbMonth
            // 
            this.txbMonth.Location = new System.Drawing.Point(262, 13);
            this.txbMonth.Name = "txbMonth";
            this.txbMonth.Size = new System.Drawing.Size(100, 26);
            this.txbMonth.TabIndex = 3;
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
            // txbYear
            // 
            this.txbYear.Location = new System.Drawing.Point(73, 12);
            this.txbYear.Name = "txbYear";
            this.txbYear.Size = new System.Drawing.Size(100, 26);
            this.txbYear.TabIndex = 2;
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
            // BtnLoad
            // 
            this.BtnLoad.AutoSize = true;
            this.BtnLoad.Location = new System.Drawing.Point(630, 8);
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
            // dtpkFrom
            // 
            this.dtpkFrom.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpkFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkFrom.Location = new System.Drawing.Point(112, 13);
            this.dtpkFrom.Name = "dtpkFrom";
            this.dtpkFrom.Size = new System.Drawing.Size(220, 26);
            this.dtpkFrom.TabIndex = 0;
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
            // UC_ThongKeSanPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PanelChart);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1330, 770);
            this.Name = "UC_ThongKeSanPhan";
            this.Size = new System.Drawing.Size(1330, 770);
            this.PanelChart.ResumeLayout(false);
            this.PanelChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBestSellingProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelEnterValue_1.ResumeLayout(false);
            this.PanelEnterValue_1.PerformLayout();
            this.PanelEnterValue_2.ResumeLayout(false);
            this.PanelEnterValue_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbBestSellingProduct;
        private System.Windows.Forms.Label lbTotalProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.ComboBox cmbStatisticsBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbWeek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBestSellingProducts;
        private System.Windows.Forms.Panel PanelEnterValue_1;
        private System.Windows.Forms.Panel PanelEnterValue_2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpkTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpkFrom;
    }
}
