namespace GUI.BanHang
{
    partial class UC_KhuyenMai
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
            this.dtgvPromotion = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDeletePromotion = new System.Windows.Forms.Button();
            this.BtnEditPromotion = new System.Windows.Forms.Button();
            this.BtnAddPromotion = new System.Windows.Forms.Button();
            this.dtpkEndDay = new System.Windows.Forms.DateTimePicker();
            this.dtpkStartDay = new System.Windows.Forms.DateTimePicker();
            this.txbPromotionPercent = new System.Windows.Forms.TextBox();
            this.txbPromotionMaxDiscount = new System.Windows.Forms.TextBox();
            this.txbPromotionName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PromotionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromotionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromotionPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromotionMaxDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPromotion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvPromotion
            // 
            this.dtgvPromotion.AllowUserToAddRows = false;
            this.dtgvPromotion.AllowUserToDeleteRows = false;
            this.dtgvPromotion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPromotion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvPromotion.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPromotion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvPromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPromotion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PromotionID,
            this.PromotionName,
            this.PromotionPercent,
            this.PromotionMaxDiscount,
            this.StartDay,
            this.EndDay,
            this.RemainDay});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPromotion.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvPromotion.Location = new System.Drawing.Point(19, 31);
            this.dtgvPromotion.MultiSelect = false;
            this.dtgvPromotion.Name = "dtgvPromotion";
            this.dtgvPromotion.ReadOnly = true;
            this.dtgvPromotion.RowHeadersVisible = false;
            this.dtgvPromotion.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dtgvPromotion.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPromotion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPromotion.Size = new System.Drawing.Size(744, 710);
            this.dtgvPromotion.TabIndex = 0;
            this.dtgvPromotion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPromotion_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ToolTip);
            this.groupBox1.Controls.Add(this.BtnDeletePromotion);
            this.groupBox1.Controls.Add(this.BtnEditPromotion);
            this.groupBox1.Controls.Add(this.BtnAddPromotion);
            this.groupBox1.Controls.Add(this.dtpkEndDay);
            this.groupBox1.Controls.Add(this.dtpkStartDay);
            this.groupBox1.Controls.Add(this.txbPromotionPercent);
            this.groupBox1.Controls.Add(this.txbPromotionMaxDiscount);
            this.groupBox1.Controls.Add(this.txbPromotionName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(787, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 424);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết khuyến mãi";
            // 
            // BtnDeletePromotion
            // 
            this.BtnDeletePromotion.AutoSize = true;
            this.BtnDeletePromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletePromotion.Image = global::GUI.Properties.Resources.icons8_trash_can_24;
            this.BtnDeletePromotion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeletePromotion.Location = new System.Drawing.Point(356, 356);
            this.BtnDeletePromotion.Name = "BtnDeletePromotion";
            this.BtnDeletePromotion.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnDeletePromotion.Size = new System.Drawing.Size(94, 36);
            this.BtnDeletePromotion.TabIndex = 7;
            this.BtnDeletePromotion.Text = "Xóa";
            this.BtnDeletePromotion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDeletePromotion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDeletePromotion.UseVisualStyleBackColor = true;
            this.BtnDeletePromotion.Click += new System.EventHandler(this.BtnDeletePromotion_Click);
            // 
            // BtnEditPromotion
            // 
            this.BtnEditPromotion.AutoSize = true;
            this.BtnEditPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditPromotion.Image = global::GUI.Properties.Resources.icons8_pencil_24;
            this.BtnEditPromotion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditPromotion.Location = new System.Drawing.Point(223, 356);
            this.BtnEditPromotion.Name = "BtnEditPromotion";
            this.BtnEditPromotion.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnEditPromotion.Size = new System.Drawing.Size(94, 36);
            this.BtnEditPromotion.TabIndex = 6;
            this.BtnEditPromotion.Text = "Sửa";
            this.BtnEditPromotion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditPromotion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditPromotion.UseVisualStyleBackColor = true;
            this.BtnEditPromotion.Click += new System.EventHandler(this.BtnEditPromotion_Click);
            // 
            // BtnAddPromotion
            // 
            this.BtnAddPromotion.AutoSize = true;
            this.BtnAddPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddPromotion.Image = global::GUI.Properties.Resources.icons8_plus_math_24;
            this.BtnAddPromotion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddPromotion.Location = new System.Drawing.Point(81, 356);
            this.BtnAddPromotion.Name = "BtnAddPromotion";
            this.BtnAddPromotion.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnAddPromotion.Size = new System.Drawing.Size(94, 36);
            this.BtnAddPromotion.TabIndex = 5;
            this.BtnAddPromotion.Text = "Thêm";
            this.BtnAddPromotion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddPromotion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddPromotion.UseVisualStyleBackColor = true;
            this.BtnAddPromotion.Click += new System.EventHandler(this.BtnAddPromotion_Click);
            // 
            // dtpkEndDay
            // 
            this.dtpkEndDay.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpkEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkEndDay.Location = new System.Drawing.Point(220, 276);
            this.dtpkEndDay.Name = "dtpkEndDay";
            this.dtpkEndDay.Size = new System.Drawing.Size(265, 26);
            this.dtpkEndDay.TabIndex = 4;
            // 
            // dtpkStartDay
            // 
            this.dtpkStartDay.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpkStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkStartDay.Location = new System.Drawing.Point(220, 220);
            this.dtpkStartDay.Name = "dtpkStartDay";
            this.dtpkStartDay.Size = new System.Drawing.Size(265, 26);
            this.dtpkStartDay.TabIndex = 3;
            // 
            // txbPromotionPercent
            // 
            this.txbPromotionPercent.Location = new System.Drawing.Point(219, 108);
            this.txbPromotionPercent.Name = "txbPromotionPercent";
            this.txbPromotionPercent.Size = new System.Drawing.Size(265, 26);
            this.txbPromotionPercent.TabIndex = 1;
            // 
            // txbPromotionMaxDiscount
            // 
            this.txbPromotionMaxDiscount.Location = new System.Drawing.Point(219, 164);
            this.txbPromotionMaxDiscount.Name = "txbPromotionMaxDiscount";
            this.txbPromotionMaxDiscount.Size = new System.Drawing.Size(265, 26);
            this.txbPromotionMaxDiscount.TabIndex = 2;
            // 
            // txbPromotionName
            // 
            this.txbPromotionName.Location = new System.Drawing.Point(219, 52);
            this.txbPromotionName.Name = "txbPromotionName";
            this.txbPromotionName.Size = new System.Drawing.Size(265, 26);
            this.txbPromotionName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phần trăm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tiền tối đa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khuyến mãi";
            // 
            // ToolTip
            // 
            this.ToolTip.AutoSize = true;
            this.ToolTip.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolTip.Location = new System.Drawing.Point(483, 361);
            this.ToolTip.Name = "ToolTip";
            this.ToolTip.Size = new System.Drawing.Size(22, 24);
            this.ToolTip.TabIndex = 13;
            this.ToolTip.Text = "?";
            this.toolTip1.SetToolTip(this.ToolTip, "Click vào từng dòng để sửa hoặc xóa. Click lại vào form để bật tính năng thêm.");
            // 
            // PromotionID
            // 
            this.PromotionID.HeaderText = "Mã khuyến mãi";
            this.PromotionID.Name = "PromotionID";
            this.PromotionID.ReadOnly = true;
            this.PromotionID.Visible = false;
            // 
            // PromotionName
            // 
            this.PromotionName.HeaderText = "Tên khuyến mãi";
            this.PromotionName.Name = "PromotionName";
            this.PromotionName.ReadOnly = true;
            // 
            // PromotionPercent
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.PromotionPercent.DefaultCellStyle = dataGridViewCellStyle2;
            this.PromotionPercent.HeaderText = "Phần trăm";
            this.PromotionPercent.Name = "PromotionPercent";
            this.PromotionPercent.ReadOnly = true;
            this.PromotionPercent.Visible = false;
            // 
            // PromotionMaxDiscount
            // 
            this.PromotionMaxDiscount.HeaderText = "Tiền giảm tối đa";
            this.PromotionMaxDiscount.Name = "PromotionMaxDiscount";
            this.PromotionMaxDiscount.ReadOnly = true;
            this.PromotionMaxDiscount.Visible = false;
            // 
            // StartDay
            // 
            dataGridViewCellStyle3.Format = "dd/MM/yyyy hh:mm tt";
            dataGridViewCellStyle3.NullValue = null;
            this.StartDay.DefaultCellStyle = dataGridViewCellStyle3;
            this.StartDay.HeaderText = "Ngày bắt đầu";
            this.StartDay.Name = "StartDay";
            this.StartDay.ReadOnly = true;
            // 
            // EndDay
            // 
            dataGridViewCellStyle4.Format = "dd/MM/yyyy hh:mm tt";
            dataGridViewCellStyle4.NullValue = null;
            this.EndDay.DefaultCellStyle = dataGridViewCellStyle4;
            this.EndDay.HeaderText = "Ngày kết thúc";
            this.EndDay.Name = "EndDay";
            this.EndDay.ReadOnly = true;
            // 
            // RemainDay
            // 
            this.RemainDay.HeaderText = "Số ngày còn lại";
            this.RemainDay.Name = "RemainDay";
            this.RemainDay.ReadOnly = true;
            // 
            // UC_KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dtgvPromotion);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1330, 770);
            this.Name = "UC_KhuyenMai";
            this.Size = new System.Drawing.Size(1330, 770);
            this.Load += new System.EventHandler(this.UC_KhuyenMai_Load);
            this.Click += new System.EventHandler(this.UC_KhuyenMai_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPromotion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPromotion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDeletePromotion;
        private System.Windows.Forms.Button BtnEditPromotion;
        private System.Windows.Forms.Button BtnAddPromotion;
        private System.Windows.Forms.DateTimePicker dtpkEndDay;
        private System.Windows.Forms.DateTimePicker dtpkStartDay;
        private System.Windows.Forms.TextBox txbPromotionPercent;
        private System.Windows.Forms.TextBox txbPromotionMaxDiscount;
        private System.Windows.Forms.TextBox txbPromotionName;
        private System.Windows.Forms.Label ToolTip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromotionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromotionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromotionPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromotionMaxDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainDay;
    }
}
