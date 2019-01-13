using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BaoCao
{
    public partial class UC_PanelBaoCao : UserControl
    {
        private static UC_PanelBaoCao _ins;

        public static UC_PanelBaoCao Instance
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new UC_PanelBaoCao();
                }

                return _ins;
            }

        }

        public UC_PanelBaoCao()
        {
            InitializeComponent();
        }

        private void BtnStatisticsProfit_Click(object sender, EventArgs e)
        {
            if (!PanelContent.Controls.Contains(BaoCao.UC_ThongKeDoanhThu.Instance))
            {
                PanelContent.Controls.Add(BaoCao.UC_ThongKeDoanhThu.Instance);
                BaoCao.UC_ThongKeDoanhThu.Instance.Dock = DockStyle.Fill;
                BaoCao.UC_ThongKeDoanhThu.Instance.BringToFront();
            }
            else
            {
                BaoCao.UC_ThongKeDoanhThu.Instance.BringToFront();
            }
        }

        private void BtnStatisticsProduct_Click(object sender, EventArgs e)
        {
            if (!PanelContent.Controls.Contains(BaoCao.UC_ThongKeSanPhan.Instance))
            {
                PanelContent.Controls.Add(BaoCao.UC_ThongKeSanPhan.Instance);
                BaoCao.UC_ThongKeSanPhan.Instance.Dock = DockStyle.Fill;
                BaoCao.UC_ThongKeSanPhan.Instance.BringToFront();
            }
            else
            {
                BaoCao.UC_ThongKeSanPhan.Instance.BringToFront();
            }
        }
    }
}
