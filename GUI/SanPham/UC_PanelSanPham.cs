using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.SanPham
{
    public partial class UC_PanelSanPham : UserControl
    {
        private static UC_PanelSanPham _ins;

        bool IsLoaded = false;

        public static UC_PanelSanPham Instance
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new UC_PanelSanPham();
                }
                return _ins;
            }
        }

        private UC_PanelSanPham()
        {
            InitializeComponent();

            // mặc định load trang sản phẩm
            BtnProduct.PerformClick();

            IsLoaded = true;
        }

        public void ReLoad()
        {
            if (IsLoaded == true)
            {
                PanelContent.Controls.Clear();
            }
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            if (!PanelContent.Controls.Contains(SanPham.UC_SanPham.Instance))
            {
                PanelContent.Controls.Add(SanPham.UC_SanPham.Instance);
                SanPham.UC_SanPham.Instance.Dock = DockStyle.Fill;
                SanPham.UC_SanPham.Instance.BringToFront();
            }
            else
            {
                SanPham.UC_SanPham.Instance.ReloadForm();
                SanPham.UC_SanPham.Instance.BringToFront();
            }
        }

        private void BtnAddNewProduct_Click(object sender, EventArgs e)
        {
            frmThemSanPham frmAddNewProduct = new frmThemSanPham();

            frmAddNewProduct.ReloadData += EventReLoadData;

            frmAddNewProduct.ShowDialog();

            frmAddNewProduct.Close();
        }

        private void EventReLoadData(object sender, EventArgs e)
        {
            // gọi hàm reload form
            SanPham.UC_SanPham.Instance.ReloadForm();
        }
    }
}
