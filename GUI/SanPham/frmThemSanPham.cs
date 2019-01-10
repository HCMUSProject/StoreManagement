using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI.SanPham
{
    public partial class frmThemSanPham : Form
    {
        public event EventHandler ReloadData;

        #region Variable
        BUS_LoaiSanPham bus_Category = new BUS_LoaiSanPham();

        BUS_HangSanXuat bus_Manufacturer = new BUS_HangSanXuat();

        BUS_SanPham bus_Product = new BUS_SanPham();
        #endregion

        public frmThemSanPham()
        {
            InitializeComponent();

            bool resultLoad = LoadDataComboBox();

            if (resultLoad == false)    // trường hợp load không được thì sẽ thoát
            {
                MessageBox.Show("Vui lòng tải lại chức năng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            Picimage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // trước tiên là load dữ liệu vào các combo box
        private bool LoadDataComboBox()
        {
            // load list các loại sản phẩm
            DataTable dtCategories = bus_Category.BUS_GetCategories();

            if (dtCategories == null)
            {
                MessageBox.Show("Có lỗi xảy ra khi lấy dữ liệu!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (dtCategories.Rows.Count == 0)   // không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu về loại sản phẩm !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            foreach (DataRow row in dtCategories.Rows)
            {
                if (row["TENLOAI"].ToString() == "Tất cả")
                {
                    dtCategories.Rows.Remove(row);
                    break;
                }
            }

            cmbCategories.DisplayMember = dtCategories.Columns["TENLOAI"].ToString();
            cmbCategories.ValueMember = dtCategories.Columns["ID_MALOAI"].ToString();

            cmbCategories.DataSource = dtCategories;

            // load list các hãng sản xuất

            DataTable dtManufacturer = bus_Manufacturer.BUS_GetManufacturers();

            if (dtManufacturer == null)
            {

                MessageBox.Show("Có lỗi xảy ra khi lấy dữ liệu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (dtManufacturer.Rows.Count == 0)   // không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu về loại sản phẩm !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            cmbManufacturer.DisplayMember = dtManufacturer.Columns["TENHANG"].ToString();
            cmbManufacturer.ValueMember = dtManufacturer.Columns["ID_HANGSX"].ToString();

            cmbManufacturer.DataSource = dtManufacturer;


            return true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEmptyFields_Click(object sender, EventArgs e)
        {
            Picimage.Image = null;
            txbCamera.Text = "";
            txbCPU.Text = "";
            txbGPU.Text = "";
            txbMore.Text = "";
            txbOS.Text = "";
            txbPin.Text = "";
            txbProductName.Text = "";
            txbProductPrice.Text = "";
            txbProductQuantity.Text = "";
            txbRAM.Text = "";
            txbScreen.Text = "";
            txbStorage.Text = "";
        }

        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();

            dlgOpen.Filter = "Images(.jpg,.png)|*.png;*.jpg";

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlgOpen.FileName;

                Picimage.Image = new Bitmap(filePath);
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            // kiểm tra các trường thông tin cơ bản có bị trống hay không
            if (txbProductName.Text == "" || txbProductPrice.Text == "" || txbProductQuantity.Text == "")
            {
                MessageBox.Show("Không được để trống các trường dữ liệu cơ bản!",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            // kiểm tra ở các ô chỉ toàn số có kí tự lạ hay không
            if(isNumberic(txbProductPrice.Text) == false)
            {
                MessageBox.Show("Đơn giá chỉ bao gồm các chữ số!",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (isNumberic(txbProductQuantity.Text) == false)
            {
                MessageBox.Show("Số lượng chỉ bao gồm các chữ số!",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }


            if (txbCamera.Text=="" || txbCPU.Text == "" || txbGPU.Text == "" || txbMore.Text == "" 
                || txbOS.Text == "" || txbPin.Text == "" || txbRAM.Text == "" || txbScreen.Text == "" || txbStorage.Text == "")
            {
                DialogResult dlgResult = MessageBox.Show("Có một số thông tin về Thông số kĩ thuật còn trống!\n Bạn có muốn tiếp tục?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dlgResult == DialogResult.Cancel)   // nếu người dùng khong muốn tiếp tục
                {
                    return;
                }
            }

            // thực hiện việc thêm 1 sản phẩm mới vào database

            // chuyển từ image sang byte []
            Byte[] arrImage;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            Image img = Picimage.Image;
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            arrImage = ms.ToArray();

            // lưu thông tin cơ bản vào DTO

            DTO_Product product = new DTO_Product()
            {
                CategoryID = (int)cmbCategories.SelectedValue,
                ManufacturerID = (int)cmbManufacturer.SelectedValue,
                ProductImage = arrImage,
                ProductName = txbProductName.Text,
                ProductPrice = int.Parse(txbProductPrice.Text.ToString()),
                ProductQuantity = int.Parse(txbProductQuantity.Text.ToString())
            };

            // lưu DTO product xuống database
            bool resultAdd = bus_Product.BUS_AddNewProduct(product);

            if (resultAdd == false)
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // get được ID của product vừa được lưu vào bảng SANPHAM dựa vào tên và ID

            DataTable dtProductInfo = bus_Product.BUS_GetProductInfoByIDAndName(txbProductName.Text, (int)cmbCategories.SelectedValue);

            if (dtProductInfo == null)
            {
                MessageBox.Show("Có lỗi xảy ra khi load dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtProductInfo.Rows.Count > 0)
            {
                try
                {
                    // lưu thông số cấu hình vào DTO
                    DTO_ProductProfile productProfile = new DTO_ProductProfile()
                    {
                        ProductID = int.Parse(dtProductInfo.Rows[0]["ID_MASP"].ToString()),
                        CPU = txbCPU.Text,
                        GPU = txbGPU.Text,
                        RAM = txbRAM.Text,
                        Storage = txbStorage.Text,
                        Screen = txbScreen.Text,
                        Camera = txbCamera.Text,
                        PIN = txbPin.Text,
                        OS = txbOS.Text,
                        More = txbMore.Text
                    };

                    // lưu DTO xuống database
                    bool resultAddProductProfile = bus_Product.BUS_AddProductProfile(productProfile);

                    if (resultAddProductProfile == false)
                    {
                        MessageBox.Show("Thêm không thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex) { }
            }
            else
            {
                MessageBox.Show("Không thể thêm thông số kĩ thuật!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // thêm dữ liệu vào lịch sử nhập kho
            // TẠI ĐÂY PRODUCT.QUANTITY = 0 VÌ SỐ LƯỢNG SẢN PHẨM THÊM VÀO TRƯỚC ĐÓ ĐÃ CÓ TRONG SANPHAM.
            // SAU KHI THỰC HIỆN LỆNH NÀY SẼ LẤY TRONG SẢN PHẨM + SỐ TRUYỀN VÀO.
            // VÌ VẬY THAM SỐ PRODUCT.QUANTITY = 0 SẼ KHÔNG BỊ CỘNG DỒN LÊN.
            bool result = bus_Product.BUS_AddProduct_History(int.Parse(dtProductInfo.Rows[0]["ID_MASP"].ToString()), product.ProductPrice, 0, DateTime.Now);

            if (result == false)
            {
                MessageBox.Show("Không thể thêm lịch sử nhập kho!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

            // khi thêm sp thành công thì gửi 1 sự kiện reload lại tại form cha
            ReloadData?.Invoke(this, EventArgs.Empty);

            this.Close();
        }


        // ============================ sub function ========================
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


        // di chuyển form

        bool isMouseDown = false;
        int posX = 0, posY = 0;

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;

            posX = e.X;
            posY = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                this.SetDesktopLocation(MousePosition.X - posX, MousePosition.Y - posY);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
