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
    public partial class frmXemChiTietSanPham : Form
    {
        private int _ProductID;
        public int ProductID { get => _ProductID; set => _ProductID = value; }

        BUS_SanPham bus_Products = new BUS_SanPham();

        public frmXemChiTietSanPham()
        {
            InitializeComponent();
        }

        public frmXemChiTietSanPham(int Product_ID)
        {
            InitializeComponent();


            this.ProductID = Product_ID;

            Picimage.SizeMode = PictureBoxSizeMode.StretchImage;

            DisplayProductDetail();
        }

        private void DisplayProductDetail()
        {
            DataTable dtProductInfo = bus_Products.BUS_GetBasicInfo_Products(ProductID);

            if (dtProductInfo == null)
            {
                MessageBox.Show("Có lỗi xảy ra khi load dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtProductInfo.Rows.Count > 0)
            {
                // display basic info
                lbName.Text = dtProductInfo.Rows[0]["TENSP"].ToString();
                lbManufacturer.Text = dtProductInfo.Rows[0]["TENHANG"].ToString();
                lbQuantity.Text = dtProductInfo.Rows[0]["SOLUONG"].ToString();
                lbPrice.Text = dtProductInfo.Rows[0]["DONGIA"].ToString();
                Byte[] arrByteImage = (Byte[])dtProductInfo.Rows[0]["HINHANH"];

                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(arrByteImage))
                {
                    Picimage.Image = Image.FromStream(ms);
                }
            }
            else
            {
                return;
            }

            // hiển thị thông tin chi tiết (cấu hình)

            DataTable dtProductDetail = bus_Products.BUS_GetDetail_Product(ProductID);

            if (dtProductDetail == null)
            {
                MessageBox.Show("Có lỗi xảy ra khi load dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtProductDetail.Rows.Count > 0)
            {
                lbCPU.Text = dtProductDetail.Rows[0]["CPU"].ToString();
                lbGPU.Text = dtProductDetail.Rows[0]["GPU"].ToString();
                lbRam.Text = dtProductDetail.Rows[0]["RAM"].ToString();
                lbStorage.Text = dtProductDetail.Rows[0]["BONHO"].ToString();
                lbScreen.Text = dtProductDetail.Rows[0]["MANHINH"].ToString();
                lbCamera.Text = dtProductDetail.Rows[0]["CAMERA"].ToString();
                lbPin.Text = dtProductDetail.Rows[0]["PIN"].ToString();
                lbOS.Text = dtProductDetail.Rows[0]["HEDIEUHANH"].ToString();
                lbMore.Text = dtProductDetail.Rows[0]["KHAC"].ToString();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Bạn có thực sự muốn xóa sản phẩm?", "Thông báo", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.OK)
            {
                // thực hiện xóa
                bool DeletedResult = bus_Products.BUS_DeleteProduct(ProductID);

                if (DeletedResult == true)
                {
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // đóng form hiện tại
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm không thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            frmSuaSanPham frmEditProduct = new frmSuaSanPham(this.ProductID);

            frmEditProduct.ShowDialog();

            this.Close();
        }

        private void BtnWarehousing_Click(object sender, EventArgs e)
        {
            frmWarehousing frmAdd = new frmWarehousing(this.ProductID);

            frmAdd.ShowDialog();
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thêm sản phẩm này vào giỏ hàng?", "Thông báo", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                bool result = Cart.AddNewProduct(this.ProductID);

                if (result == false)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại trong giỏ hàng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.Close();
            }
        }

        // ------------------------------------------------------------------------------------
        // di chuyển form

        bool isMouseDown = false;
        int posX = 0, posY = 0;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                this.SetDesktopLocation(MousePosition.X - posX, MousePosition.Y - posY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;

            posX = e.X;
            posY = e.Y;
        }
    }
}
