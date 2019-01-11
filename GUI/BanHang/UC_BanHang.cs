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
    public partial class UC_BanHang : UserControl
    {
        #region Variable
        private bool IsSelling = false;
        #endregion


        private static UC_BanHang _ins = null;
        public static UC_BanHang Instance
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new UC_BanHang();
                }
                return _ins;
            }
        }
        public UC_BanHang()
        {
            InitializeComponent();

            this.IsSelling = false;

            TurnOnOffFieldsAnhButtons();
        }

        private void EmptyAllFields()
        {
            txbCustomerAddr.Text = "";
            txbCustomerID.Text = "";
            txbCustomerName.Text = "";
            txbCustomerPhone.Text = "";
            txbTotalCost.Text = "";

            dtgvShowProduct.Rows.Clear();
        }

        private void TurnOnOffFieldsAnhButtons()
        {
            // bật tắt các trường
            // nếu isselling = false, các button tắt hết. chỉ bật button lập phiếu và ngược lại
            BtnSetupOrder.Enabled = !this.IsSelling;
            BtnRemoveProduct.Enabled = this.IsSelling;
            BtnPayment.Enabled = this.IsSelling;
            BtnEmptyFields.Enabled = this.IsSelling;
            BtnChooseProducts.Enabled = this.IsSelling;
            txbCustomerAddr.Enabled = this.IsSelling;
            txbCustomerID.Enabled = this.IsSelling;
            txbCustomerName.Enabled = this.IsSelling;
            txbCustomerPhone.Enabled = this.IsSelling;
            dtpkDateSell.Enabled = this.IsSelling;
        }

        public void ReloadForm()
        {
            this.IsSelling = false;

            TurnOnOffFieldsAnhButtons();

            EmptyAllFields();

            // clear datagridview
        }

        private void BtnSetupOrder_Click(object sender, EventArgs e)
        {
            this.IsSelling = true;
            TurnOnOffFieldsAnhButtons();
            EmptyAllFields();
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            this.IsSelling = false;
            TurnOnOffFieldsAnhButtons();
        }

        private void BtnChooseProducts_Click(object sender, EventArgs e)
        {
            // mỗi lần nhấn chọn sản phẩm:
            // - chuyển sang form bên kia
        }
    }
}
