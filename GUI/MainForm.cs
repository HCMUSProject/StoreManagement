using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.MinimumSize = this.Size;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            if (!PanelContent.Controls.Contains(SanPham.UC_PanelSanPham.Instance))
            {
                PanelContent.Controls.Add(SanPham.UC_PanelSanPham.Instance);
                SanPham.UC_PanelSanPham.Instance.Dock = DockStyle.Fill;
                SanPham.UC_PanelSanPham.Instance.BringToFront();
            }
            else
            {
                SanPham.UC_PanelSanPham.Instance.ReLoad();
                SanPham.UC_PanelSanPham.Instance.BringToFront();
            }
        }
    }
}
