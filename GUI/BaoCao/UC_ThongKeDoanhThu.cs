using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI.BaoCao
{
    public partial class UC_ThongKeDoanhThu : UserControl
    {
        BUS_BaoCao bus_Statistics = new BUS_BaoCao();

        private List<string> listStatisticsBy = new List<string> { "Năm", "Tháng", "Tuần", "Ngày" };

        private static UC_ThongKeDoanhThu _ins;
        public static UC_ThongKeDoanhThu Instance
        {
            get
            {
                if (_ins == null)
                    {
                    _ins = new UC_ThongKeDoanhThu();
                }
                return _ins;
            }
        }

        public UC_ThongKeDoanhThu()
        {
            InitializeComponent();

            cmbStatisticsBy.DataSource = listStatisticsBy;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            ChartProfit.Series.Clear();
            // Tổng việc nhập. Tổng việc bán bao gồm điện thoại và laptop
            if (cmbStatisticsBy.SelectedIndex == 0)
            {
                // thống kê theo năm. giới hạn là 5 năm so với năm hiện tại
                int year = DateTime.Now.Year;

                

            }
        }
    }
}
