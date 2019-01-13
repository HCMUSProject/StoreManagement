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
    public partial class UC_ThongKeSanPhan : UserControl
    {
        private static UC_ThongKeSanPhan _ins;
        public static UC_ThongKeSanPhan Instance
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new UC_ThongKeSanPhan();
                }
                return _ins;
            }
        }

        public UC_ThongKeSanPhan()
        {
            InitializeComponent();
        }
    }
}
