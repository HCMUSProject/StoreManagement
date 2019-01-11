namespace GUI
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanelButton = new System.Windows.Forms.Panel();
            this.BtnSale = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.PanelIntro = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.PanelButton.SuspendLayout();
            this.PanelIntro.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelButton
            // 
            this.PanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelButton.Controls.Add(this.BtnSale);
            this.PanelButton.Controls.Add(this.BtnHome);
            this.PanelButton.Controls.Add(this.BtnProducts);
            this.PanelButton.Controls.Add(this.BtnReport);
            this.PanelButton.Location = new System.Drawing.Point(0, 80);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(70, 820);
            this.PanelButton.TabIndex = 2;
            // 
            // BtnSale
            // 
            this.BtnSale.FlatAppearance.BorderSize = 0;
            this.BtnSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSale.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSale.ForeColor = System.Drawing.Color.Black;
            this.BtnSale.Image = global::GUI.Properties.Resources.icons8_bill_36;
            this.BtnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSale.Location = new System.Drawing.Point(1, 264);
            this.BtnSale.MinimumSize = new System.Drawing.Size(200, 60);
            this.BtnSale.Name = "BtnSale";
            this.BtnSale.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnSale.Size = new System.Drawing.Size(200, 60);
            this.BtnSale.TabIndex = 4;
            this.BtnSale.Text = "Bán hàng";
            this.BtnSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSale.UseVisualStyleBackColor = true;
            this.BtnSale.Click += new System.EventHandler(this.BtnSale_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.Black;
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(1, 86);
            this.BtnHome.MinimumSize = new System.Drawing.Size(200, 60);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnHome.Size = new System.Drawing.Size(200, 60);
            this.BtnHome.TabIndex = 3;
            this.BtnHome.Text = "Trang chủ";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.FlatAppearance.BorderSize = 0;
            this.BtnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducts.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducts.ForeColor = System.Drawing.Color.Black;
            this.BtnProducts.Image = ((System.Drawing.Image)(resources.GetObject("BtnProducts.Image")));
            this.BtnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducts.Location = new System.Drawing.Point(1, 175);
            this.BtnProducts.MinimumSize = new System.Drawing.Size(200, 60);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnProducts.Size = new System.Drawing.Size(200, 60);
            this.BtnProducts.TabIndex = 0;
            this.BtnProducts.Text = "Sản phẩm";
            this.BtnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProducts.UseVisualStyleBackColor = true;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.Black;
            this.BtnReport.Image = ((System.Drawing.Image)(resources.GetObject("BtnReport.Image")));
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.Location = new System.Drawing.Point(-1, 353);
            this.BtnReport.MinimumSize = new System.Drawing.Size(200, 60);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnReport.Size = new System.Drawing.Size(200, 60);
            this.BtnReport.TabIndex = 2;
            this.BtnReport.Text = "Báo cáo";
            this.BtnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReport.UseVisualStyleBackColor = true;
            // 
            // PanelContent
            // 
            this.PanelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContent.BackColor = System.Drawing.SystemColors.Window;
            this.PanelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelContent.Location = new System.Drawing.Point(70, 80);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1330, 820);
            this.PanelContent.TabIndex = 1;
            // 
            // PanelIntro
            // 
            this.PanelIntro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(53)))), ((int)(((byte)(238)))));
            this.PanelIntro.Controls.Add(this.BtnExit);
            this.PanelIntro.Controls.Add(this.BtnMinimize);
            this.PanelIntro.Controls.Add(this.BtnMaximize);
            this.PanelIntro.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelIntro.Location = new System.Drawing.Point(0, 0);
            this.PanelIntro.Name = "PanelIntro";
            this.PanelIntro.Size = new System.Drawing.Size(1400, 80);
            this.PanelIntro.TabIndex = 3;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(1358, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(30, 30);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.Image")));
            this.BtnMinimize.Location = new System.Drawing.Point(1272, 12);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(30, 30);
            this.BtnMinimize.TabIndex = 1;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximize.Image")));
            this.BtnMaximize.Location = new System.Drawing.Point(1315, 12);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(30, 30);
            this.BtnMaximize.TabIndex = 0;
            this.BtnMaximize.UseVisualStyleBackColor = true;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.PanelIntro);
            this.Controls.Add(this.PanelButton);
            this.Controls.Add(this.PanelContent);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng";
            this.PanelButton.ResumeLayout(false);
            this.PanelIntro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelButton;
        private System.Windows.Forms.Button BtnProducts;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Panel PanelIntro;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Button BtnSale;
    }
}

