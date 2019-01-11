namespace GUI.BanHang
{
    partial class UC_BanHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCustomerName = new System.Windows.Forms.TextBox();
            this.txbCustomerID = new System.Windows.Forms.TextBox();
            this.txbCustomerAddr = new System.Windows.Forms.TextBox();
            this.txbCustomerPhone = new System.Windows.Forms.TextBox();
            this.dtpkDateSell = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvShowProduct = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnPayment = new System.Windows.Forms.Button();
            this.BtnChooseProducts = new System.Windows.Forms.Button();
            this.BtnRemoveProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTotalCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ProductTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnSetupOrder = new System.Windows.Forms.Button();
            this.BtnEmptyFields = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowProduct)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dtpkDateSell);
            this.groupBox1.Controls.Add(this.txbCustomerPhone);
            this.groupBox1.Controls.Add(this.txbCustomerAddr);
            this.groupBox1.Controls.Add(this.txbCustomerID);
            this.groupBox1.Controls.Add(this.txbCustomerName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txbTotalCost);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtgvShowProduct);
            this.groupBox2.Location = new System.Drawing.Point(470, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 644);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm đã chọn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "CMND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày mua";
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.Location = new System.Drawing.Point(167, 62);
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.Size = new System.Drawing.Size(248, 26);
            this.txbCustomerName.TabIndex = 0;
            // 
            // txbCustomerID
            // 
            this.txbCustomerID.Location = new System.Drawing.Point(167, 123);
            this.txbCustomerID.Name = "txbCustomerID";
            this.txbCustomerID.Size = new System.Drawing.Size(248, 26);
            this.txbCustomerID.TabIndex = 1;
            // 
            // txbCustomerAddr
            // 
            this.txbCustomerAddr.Location = new System.Drawing.Point(167, 245);
            this.txbCustomerAddr.Name = "txbCustomerAddr";
            this.txbCustomerAddr.Size = new System.Drawing.Size(248, 26);
            this.txbCustomerAddr.TabIndex = 3;
            // 
            // txbCustomerPhone
            // 
            this.txbCustomerPhone.Location = new System.Drawing.Point(167, 184);
            this.txbCustomerPhone.Name = "txbCustomerPhone";
            this.txbCustomerPhone.Size = new System.Drawing.Size(248, 26);
            this.txbCustomerPhone.TabIndex = 2;
            // 
            // dtpkDateSell
            // 
            this.dtpkDateSell.CustomFormat = "dd/MM/yyyy";
            this.dtpkDateSell.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDateSell.Location = new System.Drawing.Point(167, 306);
            this.dtpkDateSell.Name = "dtpkDateSell";
            this.dtpkDateSell.Size = new System.Drawing.Size(248, 26);
            this.dtpkDateSell.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(407, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(467, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "PHIẾU THANH TOÁN SẢN PHẨM";
            // 
            // dtgvShowProduct
            // 
            this.dtgvShowProduct.AllowUserToAddRows = false;
            this.dtgvShowProduct.AllowUserToDeleteRows = false;
            this.dtgvShowProduct.AllowUserToResizeColumns = false;
            this.dtgvShowProduct.AllowUserToResizeRows = false;
            this.dtgvShowProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvShowProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvShowProduct.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvShowProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductImage,
            this.ProductName,
            this.ProductQuantity,
            this.ProductPrice,
            this.ProductTotalCost});
            this.dtgvShowProduct.Location = new System.Drawing.Point(6, 36);
            this.dtgvShowProduct.MultiSelect = false;
            this.dtgvShowProduct.Name = "dtgvShowProduct";
            this.dtgvShowProduct.ReadOnly = true;
            this.dtgvShowProduct.RowHeadersVisible = false;
            this.dtgvShowProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvShowProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvShowProduct.Size = new System.Drawing.Size(833, 535);
            this.dtgvShowProduct.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.BtnEmptyFields);
            this.groupBox3.Controls.Add(this.BtnSetupOrder);
            this.groupBox3.Controls.Add(this.BtnRemoveProduct);
            this.groupBox3.Controls.Add(this.BtnChooseProducts);
            this.groupBox3.Controls.Add(this.BtnPayment);
            this.groupBox3.Location = new System.Drawing.Point(15, 489);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 254);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tùy chọn";
            // 
            // BtnPayment
            // 
            this.BtnPayment.AutoSize = true;
            this.BtnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPayment.Location = new System.Drawing.Point(150, 54);
            this.BtnPayment.Name = "BtnPayment";
            this.BtnPayment.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnPayment.Size = new System.Drawing.Size(121, 35);
            this.BtnPayment.TabIndex = 0;
            this.BtnPayment.Text = "Thanh toán";
            this.BtnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPayment.UseVisualStyleBackColor = true;
            this.BtnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // BtnChooseProducts
            // 
            this.BtnChooseProducts.AutoSize = true;
            this.BtnChooseProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChooseProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChooseProducts.Location = new System.Drawing.Point(16, 107);
            this.BtnChooseProducts.Name = "BtnChooseProducts";
            this.BtnChooseProducts.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnChooseProducts.Size = new System.Drawing.Size(148, 35);
            this.BtnChooseProducts.TabIndex = 1;
            this.BtnChooseProducts.Text = "Chọn sản phẩm";
            this.BtnChooseProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnChooseProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnChooseProducts.UseVisualStyleBackColor = true;
            this.BtnChooseProducts.Click += new System.EventHandler(this.BtnChooseProducts_Click);
            // 
            // BtnRemoveProduct
            // 
            this.BtnRemoveProduct.AutoSize = true;
            this.BtnRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRemoveProduct.Location = new System.Drawing.Point(187, 107);
            this.BtnRemoveProduct.Name = "BtnRemoveProduct";
            this.BtnRemoveProduct.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnRemoveProduct.Size = new System.Drawing.Size(148, 35);
            this.BtnRemoveProduct.TabIndex = 2;
            this.BtnRemoveProduct.Text = "Xóa sản phẩm";
            this.BtnRemoveProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRemoveProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 602);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tổng tiền:";
            // 
            // txbTotalCost
            // 
            this.txbTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotalCost.Location = new System.Drawing.Point(560, 598);
            this.txbTotalCost.Name = "txbTotalCost";
            this.txbTotalCost.ReadOnly = true;
            this.txbTotalCost.Size = new System.Drawing.Size(198, 26);
            this.txbTotalCost.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(771, 602);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "VND";
            // 
            // ProductTotalCost
            // 
            this.ProductTotalCost.HeaderText = "Thành tiền (VND)";
            this.ProductTotalCost.Name = "ProductTotalCost";
            this.ProductTotalCost.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Đon giá (VND)";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.HeaderText = "Số lượng";
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductImage
            // 
            this.ProductImage.HeaderText = "Sản phẩm";
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.ReadOnly = true;
            // 
            // BtnSetupOrder
            // 
            this.BtnSetupOrder.AutoSize = true;
            this.BtnSetupOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetupOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSetupOrder.Location = new System.Drawing.Point(16, 54);
            this.BtnSetupOrder.Name = "BtnSetupOrder";
            this.BtnSetupOrder.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnSetupOrder.Size = new System.Drawing.Size(112, 35);
            this.BtnSetupOrder.TabIndex = 3;
            this.BtnSetupOrder.Text = "Lập phiếu";
            this.BtnSetupOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSetupOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSetupOrder.UseVisualStyleBackColor = true;
            this.BtnSetupOrder.Click += new System.EventHandler(this.BtnSetupOrder_Click);
            // 
            // BtnEmptyFields
            // 
            this.BtnEmptyFields.AutoSize = true;
            this.BtnEmptyFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmptyFields.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmptyFields.Location = new System.Drawing.Point(289, 54);
            this.BtnEmptyFields.Name = "BtnEmptyFields";
            this.BtnEmptyFields.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnEmptyFields.Size = new System.Drawing.Size(112, 35);
            this.BtnEmptyFields.TabIndex = 4;
            this.BtnEmptyFields.Text = "Xóa rỗng";
            this.BtnEmptyFields.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEmptyFields.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEmptyFields.UseVisualStyleBackColor = true;
            // 
            // UC_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1330, 770);
            this.Name = "UC_BanHang";
            this.Size = new System.Drawing.Size(1330, 770);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowProduct)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpkDateSell;
        private System.Windows.Forms.TextBox txbCustomerPhone;
        private System.Windows.Forms.TextBox txbCustomerAddr;
        private System.Windows.Forms.TextBox txbCustomerID;
        private System.Windows.Forms.TextBox txbCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvShowProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnRemoveProduct;
        private System.Windows.Forms.Button BtnChooseProducts;
        private System.Windows.Forms.Button BtnPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbTotalCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewImageColumn ProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotalCost;
        private System.Windows.Forms.Button BtnSetupOrder;
        private System.Windows.Forms.Button BtnEmptyFields;
    }
}
