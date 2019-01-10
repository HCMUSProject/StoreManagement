using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            lbProductPrice.Text = _Price.ToString();
            picImageProduct.Image = _Img;
        }

        private void EventWhenClick()
        {
            MessageBox.Show("aaa");
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
