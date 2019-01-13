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
    public partial class UC_ThongKeDoanhThu : UserControl
    {
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
        }
    }
}
