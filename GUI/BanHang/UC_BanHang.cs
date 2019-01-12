using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

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
            BtnPayment.Enabled = this.IsSelling;
            BtnEmptyFields.Enabled = this.IsSelling;
            BtnDeleteOrder.Enabled = this.IsSelling;
            txbCustomerAddr.Enabled = this.IsSelling;
            txbCustomerID.Enabled = this.IsSelling;
            txbCustomerName.Enabled = this.IsSelling;
            txbCustomerPhone.Enabled = this.IsSelling;
            dtpkDateSell.Enabled = this.IsSelling;
        }

        public void ReloadForm()
        {
            if(IsSelling == true)
            {
                // xóa dữ liệu trong datagridview
                dtgvShowProduct.Rows.Clear();

                // load du lieu tu Cart vao datagridview

                Dictionary<int,int> listProductID = Cart.GetListProductID();

                BUS_SanPham bus_Product = new BUS_SanPham();

                try
                {
                    int TotalCostForAll = 0;
                    foreach (var key in listProductID.Keys)
                    {
                        DataTable dtProductInfo = bus_Product.BUS_GetBasicInfo_Products(key);

                        if (dtProductInfo == null)
                        {
                            return;
                        }

                        if (dtProductInfo.Rows.Count > 0)
                        {
                            // lấy ảnh
                            Image img;
                            using (System.IO.MemoryStream ms = new System.IO.MemoryStream((Byte[])dtProductInfo.Rows[0]["HinhAnh"]))
                            {
                                img = Image.FromStream(ms);
                            }

                            Image ImgResize = resizeImage(img, img.Width * 100 / img.Height, 100);

                            // lấy tên
                            string ProductName = dtProductInfo.Rows[0]["TenSP"].ToString();
                            // lấy đơn giá
                            int ProductPrice = int.Parse(dtProductInfo.Rows[0]["DonGia"].ToString());
                            // lấy số lượng
                            int ProductQuantityChosen = listProductID[key];
                            // tổng tiền
                            int TotalCost = ProductPrice * ProductQuantityChosen;

                            // thêm row vào datagridview
                            dtgvShowProduct.Rows.Add(ImgResize, key, ProductName, ProductQuantityChosen, ProductPrice, TotalCost);

                            TotalCostForAll += TotalCost;

                            // cập nhật tổng tiền
                            txbTotalCost.Text = TotalCostForAll.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Sản phẩm có mã số {key} không tồn tại!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                catch(Exception ex)
                {

                }
            }
        }

        private void BtnSetupOrder_Click(object sender, EventArgs e)
        {
            this.IsSelling = true;
            TurnOnOffFieldsAnhButtons();
            EmptyAllFields();

            // khi nhấn lập phiếu thì clear cart
            Cart.Clear();
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            // thanh toán
            // kiểm tra các trường dữ liệu có bị rỗng hay không
            if (txbCustomerName.Text=="" || txbCustomerID.Text=="" || txbCustomerPhone.Text== "" || txbCustomerAddr.Text=="")
            {
                MessageBox.Show("Các trường dữ liệu không được để rỗng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // kiểm tra gridview có sản phẩm nào chưa
            if (dtgvShowProduct.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào trong giỏ hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // kiểm tra CMND và số điện thoại có kí tự "lạ" hay không
            if (isNumberic(txbCustomerID.Text) == false)
            {
                MessageBox.Show("Chứng minh nhân dân phải là chữ số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isNumberic(txbCustomerPhone.Text) == false)
            {
                MessageBox.Show("Số điện thoại phải là chữ số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // đóng gói thông tin khách hàng
            DTO_Customer customer = new DTO_Customer()
            {
                CustomerName = txbCustomerName.Text,
                CustomerID = txbCustomerID.Text,
                CustomerPhone = txbCustomerPhone.Text,
                CustomerAddress = txbCustomerAddr.Text
            };

            // đóng gói lại các sản phẩm được chọn
            List<DTO_ProductChosen> listProductChosen = new List<DTO_ProductChosen>();

            foreach (DataGridViewRow row in dtgvShowProduct.Rows)
            {
                DTO_ProductChosen temp = new DTO_ProductChosen()
                {
                    ProductID = (int)row.Cells["ProductID"].Value,
                    ProductPrice = (int)row.Cells["ProductPrice"].Value,
                    ProductQuantity = (int)row.Cells["ProductQuantity"].Value
                };

                listProductChosen.Add(temp);
            }

            // lưu dữ liệu vào database.
            
            // update lại số lượng sản phẩm

            this.IsSelling = false;
            TurnOnOffFieldsAnhButtons();
        }

        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            this.IsSelling = false;

            TurnOnOffFieldsAnhButtons();

            EmptyAllFields();
        }

        private void BtnEmptyFields_Click(object sender, EventArgs e)
        {
            EmptyAllFields();
        }


        private void RemoveProduct_ContextMenu_Click(object sender, EventArgs e)
        {
            // remove dòng hiện tại trong datagridview
            int index = dtgvShowProduct.SelectedRows[0].Index;

            int ProductID = int.Parse(dtgvShowProduct.Rows[index].Cells["ProductID"].Value.ToString());

            int TotalCost = int.Parse(txbTotalCost.Text);

            int productPrice = int.Parse(dtgvShowProduct.Rows[index].Cells["ProductPrice"].Value.ToString());

            int productQuantity = int.Parse(dtgvShowProduct.Rows[index].Cells["ProductQuantity"].Value.ToString());

            txbTotalCost.Text = (TotalCost - productPrice * productQuantity).ToString();

            dtgvShowProduct.Rows.RemoveAt(index);

            // xóa sản phẩm trong cart
            Cart.RemoveProduct(ProductID);
        }

        private void dtgvShowProduct_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (rowSelected != -1)
                {
                    dtgvShowProduct.Rows[rowSelected].Selected = true;
                }
            }
        }

        private void IncreaseQuantity_ContextMenu_Click(object sender, EventArgs e)
        {
            try
            {
                int ProductID = int.Parse(dtgvShowProduct.SelectedRows[0].Cells["ProductID"].Value.ToString());

                int productPrice = int.Parse(dtgvShowProduct.SelectedRows[0].Cells["ProductPrice"].Value.ToString());
                int Quantity = int.Parse(dtgvShowProduct.SelectedRows[0].Cells["ProductQuantity"].Value.ToString());

                // get được số lượng còn lại của sản phẩm này trong kho
                BUS_SanPham bus_Products = new BUS_SanPham();
                DataTable dtProduct = bus_Products.BUS_GetBasicInfo_Products(ProductID);

                if (dtProduct == null)
                {
                    return;
                }
                if (dtProduct.Rows.Count > 0)
                {
                    Quantity++;
                    int MaxProductQuantity = (int)dtProduct.Rows[0]["SoLuong"];
                    if (Quantity > MaxProductQuantity)
                    {
                        MessageBox.Show("Số lượng sản phẩm chọn lớn hơn số lượng còn lại trong kho!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // cập nhật trong cart
                        Cart.IncreaseProductQuantityChosen(ProductID);

                        // update số lượng
                        dtgvShowProduct.SelectedRows[0].Cells["ProductQuantity"].Value = Quantity;

                        // update giá tiền
                        dtgvShowProduct.SelectedRows[0].Cells["ProductTotalCost"].Value = Quantity * productPrice;

                        // update tổng tiền
                        txbTotalCost.Text = (int.Parse(txbTotalCost.Text) + productPrice).ToString();
                    }
                }
                else
                {
                    MessageBox.Show($"Sản phẩm có mã số {ProductID} không tồn tại!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex) { }
        }

        private void DecreaseQuantity_ContextMenu_Click(object sender, EventArgs e)
        {
            try
            {
                int ProductID = int.Parse(dtgvShowProduct.SelectedRows[0].Cells["ProductID"].Value.ToString());

                int productPrice = int.Parse(dtgvShowProduct.SelectedRows[0].Cells["ProductPrice"].Value.ToString());
                int Quantity = int.Parse(dtgvShowProduct.SelectedRows[0].Cells["ProductQuantity"].Value.ToString());
                if (Quantity > 1)
                {
                    Quantity--;

                    // cập nhật trong cart
                    Cart.DecreaseProductQuantityChosen(ProductID);

                    // update số lượng
                    dtgvShowProduct.SelectedRows[0].Cells["ProductQuantity"].Value = Quantity;

                    // update giá tiền
                    dtgvShowProduct.SelectedRows[0].Cells["ProductTotalCost"].Value = Quantity * productPrice;

                    // update tổng tiền
                    txbTotalCost.Text = (int.Parse(txbTotalCost.Text) - productPrice).ToString();
                }
                else
                {
                    MessageBox.Show("Sản phẩm chỉ còn 1 cái!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex) { }
        }


        // PHƯƠNG THỨC HỖ TRỢ
        private Image resizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)b);

            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();

            return (Image)b;
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
