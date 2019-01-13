namespace GUI.BaoCao
{
    partial class UC_PanelBaoCao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.BtnStatisticsProduct = new System.Windows.Forms.Button();
            this.BtnStatisticsProfit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.BtnStatisticsProduct);
            this.panel1.Controls.Add(this.BtnStatisticsProfit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 50);
            this.panel1.TabIndex = 2;
            // 
            // PanelContent
            // 
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 50);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1330, 770);
            this.PanelContent.TabIndex = 3;
            // 
            // BtnStatisticsProduct
            // 
            this.BtnStatisticsProduct.AutoSize = true;
            this.BtnStatisticsProduct.FlatAppearance.BorderSize = 0;
            this.BtnStatisticsProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnStatisticsProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnStatisticsProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStatisticsProduct.ForeColor = System.Drawing.Color.Black;
            this.BtnStatisticsProduct.Image = global::GUI.Properties.Resources.icons8_pie_chart_24;
            this.BtnStatisticsProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStatisticsProduct.Location = new System.Drawing.Point(238, 0);
            this.BtnStatisticsProduct.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStatisticsProduct.Name = "BtnStatisticsProduct";
            this.BtnStatisticsProduct.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnStatisticsProduct.Size = new System.Drawing.Size(238, 50);
            this.BtnStatisticsProduct.TabIndex = 2;
            this.BtnStatisticsProduct.Tag = "0";
            this.BtnStatisticsProduct.Text = "  Thống kê sản phẩm";
            this.BtnStatisticsProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnStatisticsProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStatisticsProduct.UseVisualStyleBackColor = true;
            this.BtnStatisticsProduct.Click += new System.EventHandler(this.BtnStatisticsProduct_Click);
            // 
            // BtnStatisticsProfit
            // 
            this.BtnStatisticsProfit.AutoSize = true;
            this.BtnStatisticsProfit.FlatAppearance.BorderSize = 0;
            this.BtnStatisticsProfit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnStatisticsProfit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnStatisticsProfit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStatisticsProfit.ForeColor = System.Drawing.Color.Black;
            this.BtnStatisticsProfit.Image = global::GUI.Properties.Resources.icons8_account_24;
            this.BtnStatisticsProfit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStatisticsProfit.Location = new System.Drawing.Point(0, 0);
            this.BtnStatisticsProfit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStatisticsProfit.Name = "BtnStatisticsProfit";
            this.BtnStatisticsProfit.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnStatisticsProfit.Size = new System.Drawing.Size(238, 50);
            this.BtnStatisticsProfit.TabIndex = 1;
            this.BtnStatisticsProfit.Tag = "0";
            this.BtnStatisticsProfit.Text = "  Thống kê doanh thu";
            this.BtnStatisticsProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnStatisticsProfit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStatisticsProfit.UseVisualStyleBackColor = true;
            this.BtnStatisticsProfit.Click += new System.EventHandler(this.BtnStatisticsProfit_Click);
            // 
            // UC_PanelBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1330, 820);
            this.Name = "UC_PanelBaoCao";
            this.Size = new System.Drawing.Size(1330, 820);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnStatisticsProduct;
        private System.Windows.Forms.Button BtnStatisticsProfit;
        private System.Windows.Forms.Panel PanelContent;
    }
}
