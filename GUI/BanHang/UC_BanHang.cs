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

        private List<DTO_Promotion> listPromotion = new List<DTO_Promotion>();
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
            txbPromotion.Text = "";

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

            dtgvShowProduct.Enabled = this.IsSelling;
        }

        public void ReloadForm()
        {
            //dtpkDateSell.Value = DateTime.Now;

            if (IsSelling == true)
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

                            Image ImgResize = MySupportMethods.ResizeImage(img, img.Width * 100 / img.Height, 100);

                            // lấy tên
                            string ProductName = dtProductInfo.Rows[0]["TenSP"].ToString();
                            // lấy đơn giá
                            int ProductPrice = int.Parse(dtProductInfo.Rows[0]["DonGia"].ToString());
                            // lấy số lượng
                            int ProductQuantityChosen = listProductID[key];

                            
                            
                            // đơn giá khuyến mãi
                            int ProductPriceSale = ProductPrice;
                            // lấy giá sau khuyến mãi
                            foreach (var promo in listPromotion)
                            {
                                ProductPriceSale = promo.CalcDiscount(ProductPriceSale);
                            }

                            // tổng tiền
                            int TotalCost = ProductPriceSale * ProductQuantityChosen;


                            // thêm row vào datagridview
                            dtgvShowProduct.Rows.Add(ImgResize, key, ProductName, ProductQuantityChosen, ProductPrice, ProductPriceSale, TotalCost);

                            TotalCostForAll += TotalCost;

                            // cập nhật tổng tiền
                            txbTotalCost.Text = MySupportMethods.StrMoneyToStrCurrency(TotalCostForAll.ToString());
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
            else
            {
                //dtpkDateSell.Value = DateTime.Now;
            }
        }

        private void BtnSetupOrder_Click(object sender, EventArgs e)
        {
            this.IsSelling = true;
            TurnOnOffFieldsAnhButtons();
            EmptyAllFields();

            dtpkDateSell.Value = DateTime.Now;

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
            if (MySupportMethods.isNumberic(txbCustomerID.Text) == false)
            {
                MessageBox.Show("Chứng minh nhân dân phải là chữ số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MySupportMethods.isNumberic(txbCustomerPhone.Text) == false)
            {
                MessageBox.Show("Số điện thoại phải là chữ số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dlgRes = MessageBox.Show("Bạn có muốn thanh toán?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dlgRes == DialogResult.Cancel)
            {
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

            BUS_BanHang bus_SellProducts = new BUS_BanHang();

            int TotalPrice = MySupportMethods.StrCurrencyToInt(txbTotalCost.Text);

            // lưu dữ liệu vào database.
            bool res = bus_SellProducts.BUS_InsertNewOrder(customer, listProductChosen, dtpkDateSell.Value, TotalPrice, listPromotion);

            if (res == false)
            {
                MessageBox.Show("Lập phiếu thanh toán thất bại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lập phiếu thanh toán thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            this.IsSelling = false;

            EmptyAllFields();

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

            int TotalCost = MySupportMethods.StrCurrencyToInt(txbTotalCost.Text);

            int productPrice = int.Parse(dtgvShowProduct.Rows[index].Cells["ProductPriceSale"].Value.ToString());

            int productQuantity = int.Parse(dtgvShowProduct.Rows[index].Cells["ProductQuantity"].Value.ToString());

            txbTotalCost.Text = MySupportMethods.StrMoneyToStrCurrency((TotalCost - productPrice * productQuantity).ToString());

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

                        // lấy giá 1 sản phẩm
                        int productPriceAfterSale = (int)dtgvShowProduct.SelectedRows[0].Cells["ProductPriceSale"].Value;

                        // update giá tiền
                        int TotalPrice = Quantity * productPriceAfterSale;

                        dtgvShowProduct.SelectedRows[0].Cells["ProductTotalCost"].Value = TotalPrice;

                        // update tổng tiền
                        txbTotalCost.Text = MySupportMethods.StrMoneyToStrCurrency((MySupportMethods.StrCurrencyToInt(txbTotalCost.Text) + productPriceAfterSale).ToString());
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

                int Quantity = int.Parse(dtgvShowProduct.SelectedRows[0].Cells["ProductQuantity"].Value.ToString());
                if (Quantity > 1)
                {
                    Quantity--;

                    // cập nhật trong cart
                    Cart.DecreaseProductQuantityChosen(ProductID);

                    // update số lượng
                    dtgvShowProduct.SelectedRows[0].Cells["ProductQuantity"].Value = Quantity;

                    // lấy giá 1 sản phẩm được giảm giá
                    int productPriceAfterSale = (int)dtgvShowProduct.SelectedRows[0].Cells["ProductPriceSale"].Value;

                    // update giá tiền
                    int TotalPrice = Quantity * productPriceAfterSale;

                    dtgvShowProduct.SelectedRows[0].Cells["ProductTotalCost"].Value = TotalPrice;

                    // update tổng tiền
                    txbTotalCost.Text = MySupportMethods.StrMoneyToStrCurrency((MySupportMethods.StrCurrencyToInt(txbTotalCost.Text) - productPriceAfterSale).ToString());
                }
                else
                {
                    MessageBox.Show("Sản phẩm chỉ còn 1 cái!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex) { }
        }

        private void dtpkDateSell_ValueChanged(object sender, EventArgs e)
        {
            // xóa danh sách promotion
            listPromotion.Clear();
            // reload lại khuyến mãi
            txbPromotion.Text = "";

            BUS_KhuyenMai bus_Promotion = new BUS_KhuyenMai();

            DataTable dtPromotions = bus_Promotion.BUS_GetAllPromotionNow(dtpkDateSell.Value);

            if (dtPromotions == null)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình load dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtPromotions.Rows.Count > 0)
            {
                foreach(DataRow row in dtPromotions.Rows)
                {
                    string temp = "";

                    if ((int)row["PHANTRAM"] > 0 && (int)row["TIENTOIDA"] > 0)
                    {
                        temp = $"{row["TENKHUYENMAI"].ToString()} giảm {(int)row["PHANTRAM"]}% tối đa {(int)row["TIENTOIDA"]} VND.";
                    }

                    if ((int)row["PHANTRAM"] > 0 && (int)row["TIENTOIDA"] == 0)
                    {
                        temp = $"{row["TENKHUYENMAI"].ToString()} giảm {(int)row["PHANTRAM"]}%.";
                    }
                    if ((int)row["PHANTRAM"] == 0 && (int)row["TIENTOIDA"] > 0)
                    {
                        temp = $"{row["TENKHUYENMAI"].ToString()} giảm {(int)row["TIENTOIDA"]} VND.";
                    }

                    txbPromotion.Text = txbPromotion.Text + temp + Environment.NewLine;

                    // thêm vào list promotions
                    DTO_Promotion promotion = new DTO_Promotion()
                    {
                        PromotionID = (int)row["ID_KHUYENMAI"],
                        PromotionName = row["TENKHUYENMAI"].ToString(),
                        PromotionPercent = (int)row["PHANTRAM"],
                        PromotionMaxDiscount = (int)row["TIENTOIDA"],
                        PromotionBeginDate = (DateTime)row["NGAYBATDAU"],
                        PromotionEndDate = (DateTime)row["NGAYKETTHUC"]
                    };

                    listPromotion.Add(promotion);
                }
            }
            else
            {
                // nếu không có khuyến mãi
                listPromotion.Clear();
            }

            this.ReloadForm();

            //// update lại giá sau khi chọn lại sản phẩm nếu trong bảng sản phẩm có
            //if (dtgvShowProduct.Rows.Count >= 1)
            //{
            //    int TotalPriceForAll = 0;
            //    foreach(DataGridViewRow row in dtgvShowProduct.Rows)
            //    {
            //        // lấy giá gốc của sp
            //        int ProductPrice = (int)row.Cells["ProductPrice"].Value;

            //        // đơn giá khuyến mãi
            //        int ProductPriceSale = ProductPrice;
            //        // lấy giá sau khuyến mãi
            //        foreach (var promo in listPromotion)
            //        {
            //            ProductPriceSale = promo.CalcDiscount(ProductPriceSale);
            //        }

            //        // update lại giá khuyến mãi
            //        row.Cells["ProductPriceSale"].Value = ProductPriceSale;

            //        // get số lượng
            //        int Quantity = int.Parse(row.Cells["ProductQuantity"].Value.ToString());

            //        // update giá tiền
            //        int TotalPrice = Quantity * ProductPriceSale;

            //        row.Cells["ProductTotalCost"].Value = TotalPrice;

            //        // update lại tổng tiền thanh toán
            //        TotalPriceForAll += TotalPrice;
            //    }

            //    txbTotalCost.Text = TotalPriceForAll.ToString();

            //}
        }
    }
}
