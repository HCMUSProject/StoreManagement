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

namespace GUI.SanPham
{
    public partial class UC_ViewProduct : UserControl
    {
        private int _ProductID;
        private string _ProductName = "";
        private int _Price = 0;
        private Image _Img;


        public UC_ViewProduct()
        {
            InitializeComponent();
        }

        public UC_ViewProduct(int ID, string Name, int Price, Byte[] arrByteImage)
        {
            InitializeComponent();

            picImageProduct.SizeMode = PictureBoxSizeMode.StretchImage;

            _ProductID = ID;
            _ProductName = Name;
            _Price = Price;

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(arrByteImage))
            {
                _Img = Image.FromStream(ms);
            }

            lbProductName.Text = _ProductName;
            lbProductPrice.Text = MySupportMethods.StrMoneyToStrCurrency(_Price.ToString());
            //lbProductPrice.Text = _Price.ToString();
            picImageProduct.Image = _Img;

            // tìm khuyến mãi hiện tại có phần trăm lớn nhất
            // update giá
            BUS_KhuyenMai bus_Promotion = new BUS_KhuyenMai();

            DataTable dtPromotions = bus_Promotion.BUS_GetAllPromotionNow(DateTime.Now);

            if (dtPromotions == null)
            {
                MessageBox.Show("Có lỗi trong quá trình load dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtPromotions.Rows.Count == 0)
            {
                // không có giảm giá
                lbProductPriceDiscount.Text = lbProductPrice.Text;
                lbProductPriceDiscount.Visible = false;

                lbProductPrice.Font = new Font(lbProductPrice.Font, FontStyle.Regular);
            }
            else
            {
                //  nếu có khuyến mãi
                DTO_Promotion promotion = new DTO_Promotion()
                {
                    PromotionID = (int)dtPromotions.Rows[0]["ID_KHUYENMAI"],
                    PromotionName = dtPromotions.Rows[0]["TENKHUYENMAI"].ToString(),
                    PromotionPercent = (int)dtPromotions.Rows[0]["PHANTRAM"],
                    PromotionMaxDiscount = (int)dtPromotions.Rows[0]["TIENTOIDA"],
                    PromotionBeginDate = (DateTime)dtPromotions.Rows[0]["NGAYBATDAU"],
                    PromotionEndDate = (DateTime)dtPromotions.Rows[0]["NGAYKETTHUC"],
                };

                if (DateTime.Now >= promotion.PromotionBeginDate && DateTime.Now <= promotion.PromotionEndDate)
                {
                    lbProductPriceDiscount.Visible = true;

                    lbProductPrice.Font = new Font(lbProductPrice.Font, FontStyle.Strikeout);

                    // remove tất cả các dấu chấm phân cách
                    int productPrice = MySupportMethods.StrCurrencyToInt(lbProductPrice.Text);

                    lbProductPriceDiscount.Text = MySupportMethods.StrMoneyToStrCurrency(promotion.CalcDiscount(productPrice).ToString());
                }
            }
        }

        private void picImageProduct_Click(object sender, EventArgs e)
        {
            frmXemChiTietSanPham frmViewProduct = new frmXemChiTietSanPham(this._ProductID);
            frmViewProduct.ShowDialog();
        }

        private void UC_ViewProduct_Click(object sender, EventArgs e)
        {
            frmXemChiTietSanPham frmViewProduct = new frmXemChiTietSanPham(this._ProductID);
            frmViewProduct.ShowDialog();
        }

        private void lbProductPrice_Click(object sender, EventArgs e)
        {
            frmXemChiTietSanPham frmViewProduct = new frmXemChiTietSanPham(this._ProductID);
            frmViewProduct.ShowDialog();
        }

        private void lbProductName_Click(object sender, EventArgs e)
        {
            frmXemChiTietSanPham frmViewProduct = new frmXemChiTietSanPham(this._ProductID);
            frmViewProduct.ShowDialog();
        }
    }
}
