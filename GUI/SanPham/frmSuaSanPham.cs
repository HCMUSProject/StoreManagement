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
    public partial class frmSuaSanPham : Form
    {
        private int _ProductID;
        private int _ID_ProductProfile;

        #region Variable
        BUS_LoaiSanPham bus_Category = new BUS_LoaiSanPham();

        BUS_HangSanXuat bus_Manufacturer = new BUS_HangSanXuat();

        BUS_SanPham bus_Product = new BUS_SanPham();
        #endregion

        public frmSuaSanPham()
        {
            InitializeComponent();
        }

        public frmSuaSanPham(int ProductID)
        {
            InitializeComponent();

            this._ProductID = ProductID;

            bool resultLoad = LoadDataComboBox();

            if (resultLoad == false)    // trường hợp load không được thì sẽ thoát
            {
                MessageBox.Show("Vui lòng tải lại chức năng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            Picimage.SizeMode = PictureBoxSizeMode.StretchImage;

            LoadDefaultDataToForm();

        }
        // load data bằng productID
        private void LoadDefaultDataToForm()
        {
            DataTable dtProductInfo = bus_Product.BUS_GetAllProductInfoByID(this._ProductID);

            if (dtProductInfo == null)
            {
                MessageBox.Show("Có lỗi xảy ra khi load dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtProductInfo.Rows.Count > 0)
            {
                // load dữ liệu vào các field
                cmbCategories.SelectedValue = int.Parse(dtProductInfo.Rows[0]["ID_MALOAI"].ToString());

                cmbManufacturer.SelectedValue = int.Parse(dtProductInfo.Rows[0]["ID_HANGSX"].ToString());

                txbProductName.Text = dtProductInfo.Rows[0]["TENSP"].ToString();
                txbProductPrice.Text = dtProductInfo.Rows[0]["DONGIA"].ToString();
                txbProductQuantity.Text = dtProductInfo.Rows[0]["SOLUONG"].ToString();

                txbCPU.Text = dtProductInfo.Rows[0]["CPU"].ToString();
                txbGPU.Text = dtProductInfo.Rows[0]["GPU"].ToString();
                txbRAM.Text = dtProductInfo.Rows[0]["RAM"].ToString();
                txbStorage.Text = dtProductInfo.Rows[0]["BONHO"].ToString();
                txbScreen.Text = dtProductInfo.Rows[0]["MANHINH"].ToString();
                txbCamera.Text = dtProductInfo.Rows[0]["CAMERA"].ToString();
                txbPin.Text = dtProductInfo.Rows[0]["PIN"].ToString();
                txbOS.Text = dtProductInfo.Rows[0]["HEDIEUHANH"].ToString();
                txbMore.Text = dtProductInfo.Rows[0]["KHAC"].ToString();

                Byte[] arrByteImage = (Byte[])dtProductInfo.Rows[0]["HINHANH"];

                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(arrByteImage))
                {
                    Picimage.Image = Image.FromStream(ms);
                }

                // set dữ liệu cho product profile
                this._ID_ProductProfile = int.Parse(dtProductInfo.Rows[0]["ID_CHITIETCAUHINH"].ToString());
            }
            else
            {
                return;
            }
        }

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

        private void BtnApplyEdit_Click(object sender, EventArgs e)
        {
            // get được ID_MASP, get ID_CHITIETCAUHINH
            // ghi đè thông tin dựa vào 2 ID này

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();

            dlgOpen.Filter = "Images(.jpg,.png)|*.png;*.jpg";

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                Picimage.Image = null;

                string filePath = dlgOpen.FileName;

                Picimage.Image = new Bitmap(filePath);
            }
        }

        
        
        // ===========================================================================================

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
