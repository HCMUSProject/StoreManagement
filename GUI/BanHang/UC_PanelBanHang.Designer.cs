namespace GUI.BanHang
{
    partial class UC_PanelBanHang
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
            this.BtnSellProducts = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.BtnSellProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 50);
            this.panel1.TabIndex = 1;
            // 
            // PanelContent
            // 
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 50);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1330, 770);
            this.PanelContent.TabIndex = 2;
            // 
            // BtnSellProducts
            // 
            this.BtnSellProducts.AutoSize = true;
            this.BtnSellProducts.FlatAppearance.BorderSize = 0;
            this.BtnSellProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnSellProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnSellProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSellProducts.ForeColor = System.Drawing.Color.Black;
            this.BtnSellProducts.Image = global::GUI.Properties.Resources.icons8_money_bag_24;
            this.BtnSellProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSellProducts.Location = new System.Drawing.Point(0, 0);
            this.BtnSellProducts.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSellProducts.Name = "BtnSellProducts";
            this.BtnSellProducts.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnSellProducts.Size = new System.Drawing.Size(156, 50);
            this.BtnSellProducts.TabIndex = 1;
            this.BtnSellProducts.Tag = "0";
            this.BtnSellProducts.Text = "  Bán hàng";
            this.BtnSellProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSellProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSellProducts.UseVisualStyleBackColor = true;
            this.BtnSellProducts.Click += new System.EventHandler(this.BtnSellProducts_Click);
            // 
            // UC_PanelBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1330, 820);
            this.Name = "UC_PanelBanHang";
            this.Size = new System.Drawing.Size(1330, 820);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSellProducts;
        private System.Windows.Forms.Panel PanelContent;
    }
}
