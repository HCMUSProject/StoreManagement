using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BanHang
{
    public partial class UC_PanelBanHang : UserControl
    {
        private static UC_PanelBanHang _ins = null;
        public static UC_PanelBanHang Instance
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new UC_PanelBanHang();
                }
                return _ins;
            }
        }

        public UC_PanelBanHang()
        {
            InitializeComponent();

            BtnSellProducts.PerformClick();
        }

        public void ReloadForm()
        {
            BtnSellProducts.PerformClick();
        }

        private void BtnSellProducts_Click(object sender, EventArgs e)
        {
            if (!PanelContent.Controls.Contains(BanHang.UC_BanHang.Instance))
            {
                PanelContent.Controls.Add(BanHang.UC_BanHang.Instance);
                BanHang.UC_BanHang.Instance.Dock = DockStyle.Fill;
                BanHang.UC_BanHang.Instance.BringToFront();
            }
            else
            {
                BanHang.UC_BanHang.Instance.ReloadForm();
                BanHang.UC_BanHang.Instance.BringToFront();
            }
        }
    }
}
