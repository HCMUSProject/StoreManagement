namespace GUI.SanPham
{
    partial class UC_ViewProduct
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
            this.lbProductName = new System.Windows.Forms.Label();
            this.picImageProduct = new System.Windows.Forms.PictureBox();
            this.lbProductPrice = new System.Windows.Forms.Label();
            this.lbProductPriceDiscount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProductName
            // 
            this.lbProductName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(12, 164);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(204, 46);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "Product name";
            this.lbProductName.Click += new System.EventHandler(this.lbProductName_Click);
            // 
            // picImageProduct
            // 
            this.picImageProduct.Location = new System.Drawing.Point(16, 9);
            this.picImageProduct.Name = "picImageProduct";
            this.picImageProduct.Size = new System.Drawing.Size(200, 150);
            this.picImageProduct.TabIndex = 1;
            this.picImageProduct.TabStop = false;
            this.picImageProduct.Click += new System.EventHandler(this.picImageProduct_Click);
            // 
            // lbProductPrice
            // 
            this.lbProductPrice.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductPrice.Location = new System.Drawing.Point(13, 215);
            this.lbProductPrice.Name = "lbProductPrice";
            this.lbProductPrice.Size = new System.Drawing.Size(203, 22);
            this.lbProductPrice.TabIndex = 2;
            this.lbProductPrice.Text = "20.000.000";
            this.lbProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbProductPrice.Click += new System.EventHandler(this.lbProductPrice_Click);
            // 
            // lbProductPriceDiscount
            // 
            this.lbProductPriceDiscount.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductPriceDiscount.ForeColor = System.Drawing.Color.Red;
            this.lbProductPriceDiscount.Location = new System.Drawing.Point(13, 237);
            this.lbProductPriceDiscount.Name = "lbProductPriceDiscount";
            this.lbProductPriceDiscount.Size = new System.Drawing.Size(203, 22);
            this.lbProductPriceDiscount.TabIndex = 3;
            this.lbProductPriceDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbProductPriceDiscount);
            this.Controls.Add(this.lbProductPrice);
            this.Controls.Add(this.picImageProduct);
            this.Controls.Add(this.lbProductName);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(230, 270);
            this.MinimumSize = new System.Drawing.Size(230, 270);
            this.Name = "UC_ViewProduct";
            this.Size = new System.Drawing.Size(230, 270);
            this.Click += new System.EventHandler(this.UC_ViewProduct_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.PictureBox picImageProduct;
        private System.Windows.Forms.Label lbProductPrice;
        private System.Windows.Forms.Label lbProductPriceDiscount;
    }
}
