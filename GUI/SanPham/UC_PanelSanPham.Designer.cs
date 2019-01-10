namespace GUI.SanPham
{
    partial class UC_PanelSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PanelSanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.BtnAddNewProduct = new System.Windows.Forms.Button();
            this.BtnProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.BtnAddNewProduct);
            this.panel1.Controls.Add(this.BtnProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 50);
            this.panel1.TabIndex = 0;
            // 
            // PanelContent
            // 
            this.PanelContent.BackColor = System.Drawing.SystemColors.Window;
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 50);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1330, 770);
            this.PanelContent.TabIndex = 1;
            // 
            // BtnAddNewProduct
            // 
            this.BtnAddNewProduct.AutoSize = true;
            this.BtnAddNewProduct.FlatAppearance.BorderSize = 0;
            this.BtnAddNewProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnAddNewProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNewProduct.ForeColor = System.Drawing.Color.Black;
            this.BtnAddNewProduct.Image = global::GUI.Properties.Resources.icons8_plus_math_24;
            this.BtnAddNewProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddNewProduct.Location = new System.Drawing.Point(156, 0);
            this.BtnAddNewProduct.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAddNewProduct.Name = "BtnAddNewProduct";
            this.BtnAddNewProduct.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnAddNewProduct.Size = new System.Drawing.Size(229, 50);
            this.BtnAddNewProduct.TabIndex = 1;
            this.BtnAddNewProduct.Text = "  Thêm mới sản phẩm";
            this.BtnAddNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddNewProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddNewProduct.UseVisualStyleBackColor = true;
            this.BtnAddNewProduct.Click += new System.EventHandler(this.BtnAddNewProduct_Click);
            // 
            // BtnProduct
            // 
            this.BtnProduct.AutoSize = true;
            this.BtnProduct.FlatAppearance.BorderSize = 0;
            this.BtnProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProduct.ForeColor = System.Drawing.Color.Black;
            this.BtnProduct.Image = ((System.Drawing.Image)(resources.GetObject("BtnProduct.Image")));
            this.BtnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProduct.Location = new System.Drawing.Point(0, 0);
            this.BtnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.BtnProduct.Name = "BtnProduct";
            this.BtnProduct.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnProduct.Size = new System.Drawing.Size(156, 50);
            this.BtnProduct.TabIndex = 1;
            this.BtnProduct.Tag = "0";
            this.BtnProduct.Text = "  Sản phẩm";
            this.BtnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProduct.UseVisualStyleBackColor = true;
            this.BtnProduct.Click += new System.EventHandler(this.BtnProduct_Click);
            // 
            // UC_PanelSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1330, 820);
            this.Name = "UC_PanelSanPham";
            this.Size = new System.Drawing.Size(1330, 820);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Button BtnProduct;
        private System.Windows.Forms.Button BtnAddNewProduct;
    }
}
