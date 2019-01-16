namespace GUI.SanPham
{
    partial class UC_SanPham
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
            this.PanelGridProduct = new System.Windows.Forms.Panel();
            this.PanelPgaeNumbers = new System.Windows.Forms.Panel();
            this.BtnNextPage = new System.Windows.Forms.Button();
            this.BtnPrevPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProductCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.PanelPgaeNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGridProduct
            // 
            this.PanelGridProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelGridProduct.BackColor = System.Drawing.SystemColors.Window;
            this.PanelGridProduct.Location = new System.Drawing.Point(29, 67);
            this.PanelGridProduct.Name = "PanelGridProduct";
            this.PanelGridProduct.Size = new System.Drawing.Size(1273, 661);
            this.PanelGridProduct.TabIndex = 0;
            this.PanelGridProduct.Resize += new System.EventHandler(this.PanelGridProduct_Resize);
            // 
            // PanelPgaeNumbers
            // 
            this.PanelPgaeNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPgaeNumbers.Controls.Add(this.BtnNextPage);
            this.PanelPgaeNumbers.Controls.Add(this.BtnPrevPage);
            this.PanelPgaeNumbers.Location = new System.Drawing.Point(29, 734);
            this.PanelPgaeNumbers.Name = "PanelPgaeNumbers";
            this.PanelPgaeNumbers.Size = new System.Drawing.Size(1273, 30);
            this.PanelPgaeNumbers.TabIndex = 3;
            // 
            // BtnNextPage
            // 
            this.BtnNextPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnNextPage.FlatAppearance.BorderSize = 0;
            this.BtnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextPage.Image = global::GUI.Properties.Resources.icons8_right_arrow_filled_24;
            this.BtnNextPage.Location = new System.Drawing.Point(644, 0);
            this.BtnNextPage.Name = "BtnNextPage";
            this.BtnNextPage.Size = new System.Drawing.Size(30, 30);
            this.BtnNextPage.TabIndex = 5;
            this.BtnNextPage.UseVisualStyleBackColor = true;
            this.BtnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // BtnPrevPage
            // 
            this.BtnPrevPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnPrevPage.FlatAppearance.BorderSize = 0;
            this.BtnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrevPage.Image = global::GUI.Properties.Resources.icons8_long_arrow_left_filled_24;
            this.BtnPrevPage.Location = new System.Drawing.Point(598, 0);
            this.BtnPrevPage.Name = "BtnPrevPage";
            this.BtnPrevPage.Size = new System.Drawing.Size(30, 30);
            this.BtnPrevPage.TabIndex = 4;
            this.BtnPrevPage.UseVisualStyleBackColor = true;
            this.BtnPrevPage.Click += new System.EventHandler(this.BtnPrevPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại sản phẩm";
            // 
            // cmbProductCategories
            // 
            this.cmbProductCategories.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbProductCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductCategories.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbProductCategories.FormattingEnabled = true;
            this.cmbProductCategories.Location = new System.Drawing.Point(189, 16);
            this.cmbProductCategories.Name = "cmbProductCategories";
            this.cmbProductCategories.Size = new System.Drawing.Size(170, 27);
            this.cmbProductCategories.TabIndex = 2;
            this.cmbProductCategories.SelectionChangeCommitted += new System.EventHandler(this.cmbProductCategories_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(712, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm";
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(812, 16);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(240, 26);
            this.txbSearch.TabIndex = 5;
            // 
            // cmbSort
            // 
            this.cmbSort.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(506, 17);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(170, 27);
            this.cmbSort.TabIndex = 7;
            this.cmbSort.SelectionChangeCommitted += new System.EventHandler(this.cmbSort_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sắp xếp theo";
            // 
            // BtnSearch
            // 
            this.BtnSearch.AutoSize = true;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Location = new System.Drawing.Point(1070, 13);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnSearch.Size = new System.Drawing.Size(58, 35);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "Tìm";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // UC_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PanelPgaeNumbers);
            this.Controls.Add(this.cmbProductCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelGridProduct);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1330, 710);
            this.Name = "UC_SanPham";
            this.Size = new System.Drawing.Size(1330, 770);
            this.PanelPgaeNumbers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelGridProduct;
        private System.Windows.Forms.Panel PanelPgaeNumbers;
        private System.Windows.Forms.Button BtnPrevPage;
        private System.Windows.Forms.Button BtnNextPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProductCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSearch;
    }
}
