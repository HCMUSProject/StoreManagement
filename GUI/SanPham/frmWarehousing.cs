using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI.SanPham
{
    public partial class frmWarehousing : Form
    {
        private int _ProductID;

        private BUS_SanPham bus_Product = new BUS_SanPham();

        public frmWarehousing(int ProductID)
        {
            InitializeComponent();

            this._ProductID = ProductID;

            // get product name
            DataTable dt = bus_Product.BUS_GetBasicInfo_Products(this._ProductID);

            if (dt == null)
            {
                MessageBox.Show("Có lỗi xẩy ra trong quá trình load dữ liệu!\nVui lòng tải lại dữ liệu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }

            if (dt.Rows.Count > 0)
            {
                txbProductName.Text = dt.Rows[0]["TENSP"].ToString();
            }
            else
            {
                MessageBox.Show("Có lỗi xẩy ra trong quá trình load dữ liệu!\nVui lòng tải lại dữ liệu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txbProductPrice.Text == "" || txbProductQuantity.Text == "")
            {
                MessageBox.Show("Không được để trống dữ liệu!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isNumberic(txbProductPrice.Text) == false || isNumberic(txbProductQuantity.Text) == false)
            {
                MessageBox.Show("Đơn giá hoặc số lượng chỉ bao gồm các chữ số!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // xử lí
            int price = int.Parse(txbProductPrice.Text.ToString());
            int quantity = int.Parse(txbProductQuantity.Text.ToString());
            bool result = bus_Product.BUS_AddProduct_History(this._ProductID, price, quantity, DateTime.Now);

            if (result == false)
            {
                MessageBox.Show("Nhập thêm vào kho không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Nhập thêm vào kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private bool isNumberic(string str)
        {
            if (str.Length == 0)
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (!(str[i] >= '0' && str[i] <= '9'))
                {
                    return false;
                }
            }

            return true;
        }

        
    }
}
