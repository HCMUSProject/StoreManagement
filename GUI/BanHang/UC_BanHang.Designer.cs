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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbPromotion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpkDateSell = new System.Windows.Forms.DateTimePicker();
            this.txbCustomerPhone = new System.Windows.Forms.TextBox();
            this.txbCustomerAddr = new System.Windows.Forms.TextBox();
            this.txbCustomerID = new System.Windows.Forms.TextBox();
            this.txbCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbTotalCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgvShowProduct = new System.Windows.Forms.DataGridView();
            this.dtgvRow_ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveProduct_ContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.IncreaseQuantity_ContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DecreaseQuantity_ContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnDeleteOrder = new System.Windows.Forms.Button();
            this.BtnEmptyFields = new System.Windows.Forms.Button();
            this.BtnSetupOrder = new System.Windows.Forms.Button();
            this.BtnPayment = new System.Windows.Forms.Button();
            this.ProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowProduct)).BeginInit();
            this.dtgvRow_ContextMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.txbPromotion);
            this.groupBox1.Controls.Add(this.label9);
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
            this.groupBox1.Size = new System.Drawing.Size(436, 494);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txbPromotion
            // 
            this.txbPromotion.BackColor = System.Drawing.SystemColors.Window;
            this.txbPromotion.Location = new System.Drawing.Point(167, 363);
            this.txbPromotion.Multiline = true;
            this.txbPromotion.Name = "txbPromotion";
            this.txbPromotion.ReadOnly = true;
            this.txbPromotion.Size = new System.Drawing.Size(248, 115);
            this.txbPromotion.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Khuyến mãi";
            // 
            // dtpkDateSell
            // 
            this.dtpkDateSell.CustomFormat = "dd/MM/yyyy";
            this.dtpkDateSell.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDateSell.Location = new System.Drawing.Point(167, 306);
            this.dtpkDateSell.Name = "dtpkDateSell";
            this.dtpkDateSell.Size = new System.Drawing.Size(248, 26);
            this.dtpkDateSell.TabIndex = 4;
            this.dtpkDateSell.ValueChanged += new System.EventHandler(this.dtpkDateSell_ValueChanged);
            // 
            // txbCustomerPhone
            // 
            this.txbCustomerPhone.Location = new System.Drawing.Point(167, 184);
            this.txbCustomerPhone.Name = "txbCustomerPhone";
            this.txbCustomerPhone.Size = new System.Drawing.Size(248, 26);
            this.txbCustomerPhone.TabIndex = 2;
            // 
            // txbCustomerAddr
            // 
            this.txbCustomerAddr.Location = new System.Drawing.Point(167, 245);
            this.txbCustomerAddr.Name = "txbCustomerAddr";
            this.txbCustomerAddr.Size = new System.Drawing.Size(248, 26);
            this.txbCustomerAddr.TabIndex = 3;
            // 
            // txbCustomerID
            // 
            this.txbCustomerID.Location = new System.Drawing.Point(167, 123);
            this.txbCustomerID.Name = "txbCustomerID";
            this.txbCustomerID.Size = new System.Drawing.Size(248, 26);
            this.txbCustomerID.TabIndex = 1;
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.Location = new System.Drawing.Point(167, 62);
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.Size = new System.Drawing.Size(248, 26);
            this.txbCustomerName.TabIndex = 0;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "CMND";
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
            // txbTotalCost
            // 
            this.txbTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotalCost.Location = new System.Drawing.Point(560, 598);
            this.txbTotalCost.Name = "txbTotalCost";
            this.txbTotalCost.ReadOnly = true;
            this.txbTotalCost.Size = new System.Drawing.Size(198, 26);
            this.txbTotalCost.TabIndex = 0;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvShowProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvShowProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductImage,
            this.ProductID,
            this.ProductName,
            this.ProductQuantity,
            this.ProductPrice,
            this.ProductPriceSale,
            this.ProductTotalCost});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvShowProduct.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvShowProduct.Location = new System.Drawing.Point(6, 36);
            this.dtgvShowProduct.MultiSelect = false;
            this.dtgvShowProduct.Name = "dtgvShowProduct";
            this.dtgvShowProduct.ReadOnly = true;
            this.dtgvShowProduct.RowHeadersVisible = false;
            this.dtgvShowProduct.RowTemplate.ContextMenuStrip = this.dtgvRow_ContextMenu;
            this.dtgvShowProduct.RowTemplate.Height = 100;
            this.dtgvShowProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvShowProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvShowProduct.Size = new System.Drawing.Size(833, 535);
            this.dtgvShowProduct.TabIndex = 0;
            this.dtgvShowProduct.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvShowProduct_CellMouseDown);
            // 
            // dtgvRow_ContextMenu
            // 
            this.dtgvRow_ContextMenu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvRow_ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveProduct_ContextMenu,
            this.IncreaseQuantity_ContextMenu,
            this.DecreaseQuantity_ContextMenu});
            this.dtgvRow_ContextMenu.Name = "dtgvRow_ContextMenu";
            this.dtgvRow_ContextMenu.Size = new System.Drawing.Size(196, 76);
            // 
            // RemoveProduct_ContextMenu
            // 
            this.RemoveProduct_ContextMenu.Image = global::GUI.Properties.Resources.icons8_trash_can_24;
            this.RemoveProduct_ContextMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveProduct_ContextMenu.Name = "RemoveProduct_ContextMenu";
            this.RemoveProduct_ContextMenu.Size = new System.Drawing.Size(195, 24);
            this.RemoveProduct_ContextMenu.Text = "Xóa sản phẩm";
            this.RemoveProduct_ContextMenu.Click += new System.EventHandler(this.RemoveProduct_ContextMenu_Click);
            // 
            // IncreaseQuantity_ContextMenu
            // 
            this.IncreaseQuantity_ContextMenu.Image = global::GUI.Properties.Resources.icons8_plus_math_24;
            this.IncreaseQuantity_ContextMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IncreaseQuantity_ContextMenu.Name = "IncreaseQuantity_ContextMenu";
            this.IncreaseQuantity_ContextMenu.Size = new System.Drawing.Size(195, 24);
            this.IncreaseQuantity_ContextMenu.Text = "Thêm số lượng";
            this.IncreaseQuantity_ContextMenu.Click += new System.EventHandler(this.IncreaseQuantity_ContextMenu_Click);
            // 
            // DecreaseQuantity_ContextMenu
            // 
            this.DecreaseQuantity_ContextMenu.Image = global::GUI.Properties.Resources.icons8_subtract_24;
            this.DecreaseQuantity_ContextMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DecreaseQuantity_ContextMenu.Name = "DecreaseQuantity_ContextMenu";
            this.DecreaseQuantity_ContextMenu.Size = new System.Drawing.Size(195, 24);
            this.DecreaseQuantity_ContextMenu.Text = "Giảm số lượng";
            this.DecreaseQuantity_ContextMenu.Click += new System.EventHandler(this.DecreaseQuantity_ContextMenu_Click);
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
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.BtnDeleteOrder);
            this.groupBox3.Controls.Add(this.BtnEmptyFields);
            this.groupBox3.Controls.Add(this.BtnSetupOrder);
            this.groupBox3.Controls.Add(this.BtnPayment);
            this.groupBox3.Location = new System.Drawing.Point(15, 600);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 143);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tùy chọn";
            // 
            // BtnDeleteOrder
            // 
            this.BtnDeleteOrder.AutoSize = true;
            this.BtnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteOrder.Location = new System.Drawing.Point(18, 88);
            this.BtnDeleteOrder.Name = "BtnDeleteOrder";
            this.BtnDeleteOrder.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnDeleteOrder.Size = new System.Drawing.Size(112, 35);
            this.BtnDeleteOrder.TabIndex = 5;
            this.BtnDeleteOrder.Text = "Hủy phiếu";
            this.BtnDeleteOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDeleteOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDeleteOrder.UseVisualStyleBackColor = true;
            this.BtnDeleteOrder.Click += new System.EventHandler(this.BtnDeleteOrder_Click);
            // 
            // BtnEmptyFields
            // 
            this.BtnEmptyFields.AutoSize = true;
            this.BtnEmptyFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmptyFields.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmptyFields.Location = new System.Drawing.Point(291, 35);
            this.BtnEmptyFields.Name = "BtnEmptyFields";
            this.BtnEmptyFields.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnEmptyFields.Size = new System.Drawing.Size(112, 35);
            this.BtnEmptyFields.TabIndex = 4;
            this.BtnEmptyFields.Text = "Xóa rỗng";
            this.BtnEmptyFields.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEmptyFields.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEmptyFields.UseVisualStyleBackColor = true;
            this.BtnEmptyFields.Click += new System.EventHandler(this.BtnEmptyFields_Click);
            // 
            // BtnSetupOrder
            // 
            this.BtnSetupOrder.AutoSize = true;
            this.BtnSetupOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetupOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSetupOrder.Location = new System.Drawing.Point(18, 35);
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
            // BtnPayment
            // 
            this.BtnPayment.AutoSize = true;
            this.BtnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPayment.Location = new System.Drawing.Point(152, 35);
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
            // ProductImage
            // 
            this.ProductImage.HeaderText = "Sản phẩm";
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.ReadOnly = true;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Mã sản phẩm";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductQuantity.HeaderText = "Số lượng";
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            this.ProductQuantity.Width = 106;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductPrice.HeaderText = "Đơn giá";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // ProductPriceSale
            // 
            this.ProductPriceSale.HeaderText = "Đơn giá khuyến mãi";
            this.ProductPriceSale.Name = "ProductPriceSale";
            this.ProductPriceSale.ReadOnly = true;
            // 
            // ProductTotalCost
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductTotalCost.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProductTotalCost.HeaderText = "Tổng giá";
            this.ProductTotalCost.Name = "ProductTotalCost";
            this.ProductTotalCost.ReadOnly = true;
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1330, 770);
            this.Name = "UC_BanHang";
            this.Size = new System.Drawing.Size(1330, 770);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowProduct)).EndInit();
            this.dtgvRow_ContextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Button BtnPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbTotalCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSetupOrder;
        private System.Windows.Forms.Button BtnEmptyFields;
        private System.Windows.Forms.Button BtnDeleteOrder;
        private System.Windows.Forms.ContextMenuStrip dtgvRow_ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem RemoveProduct_ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem IncreaseQuantity_ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem DecreaseQuantity_ContextMenu;
        private System.Windows.Forms.TextBox txbPromotion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewImageColumn ProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotalCost;
    }
}
