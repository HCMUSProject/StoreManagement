using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI.SanPham
{
    public partial class UC_SanPham : UserControl
    {
        #region Basic Varible
        private enum SortTypeIndex {Khong, GiaTangDan, GiaGiamDan,HangSanXuat};

        private List<string> SortType = new List<string> {"Không", "Giá tăng dần", "Giá giảm dần", "Hãng sản xuất" };

        private int ComboBox_CurrentSelectedValue = -1;

        private int ProductView_MaxCellDisplayInPage = 0;

        private int ProductView_SpaceBetweenCell = 20;

        private int ProductView_Width = 230;

        private int ProductView_Height = 270;

        private int MaxPage = 0;

        private int CurrentPage = 1;
        #endregion

        #region Variable Data

        List<Panel> GridPanel = new List<Panel>();

        List<DTO_Product> listProducts = new List<DTO_Product>();

        private static UC_SanPham _ins;

        BUS_LoaiSanPham bus_Categories = new BUS_LoaiSanPham();

        BUS_SanPham bus_Products = new BUS_SanPham();
        #endregion

        #region basic method
        public static UC_SanPham Instance
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new UC_SanPham();
                }
                return _ins;
            }
        }
        #endregion


        #region function process

        public UC_SanPham()
        {
            InitializeComponent();

            LoadDataToComboBox();

            // set currentpage là page đầu tiên
            CurrentPage = 1;

            // load data
            GetDataProducts();

            if (listProducts.Count == 0)
            {
                MessageBox.Show("Không có data để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // get max cell
            this.GetMaxCellInPage_PanelGridProducts();

            // get max page
            this.GetMaxPage_PanelGridProducts();

            RenderFrameAndDataToCurrentPage();
        }

        // lưu danh sách các sản phẩm dựa vào danh mục vào 1 list
        private void GetDataProducts(int nComboBoxSeletedValue = -1)
        {
            listProducts.Clear();

            // nếu chọn tất cả thì cho = -1
            if (cmbProductCategories.GetItemText(cmbProductCategories.SelectedItem) == "Tất cả")
            {
                nComboBoxSeletedValue = -1;
            }

            // lây danh sách sản phẩm dựa vào loại sản phẩm
            DataTable dtProducts = bus_Products.BUS_GetProduct(nComboBoxSeletedValue);

            if (dtProducts == null)
            {
                MessageBox.Show("Có lỗi xảy ra khi load dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataRow row in dtProducts.Rows)
            {
                DTO_Product product = new DTO_Product
                {
                    ID = int.Parse(row["ID_MASP"].ToString()),
                    CategoryID = int.Parse(row["ID_MALOAI"].ToString()),
                    ManufacturerID = int.Parse(row["ID_HANGSX"].ToString()),
                    ProductName = row["TENSP"].ToString(),
                    ProductQuantity = int.Parse(row["SOLUONG"].ToString()),
                    ProductPrice = int.Parse(row["DONGIA"].ToString()),
                    ProductImage = (Byte[])row["HINHANH"]
                };

                listProducts.Add(product);
            }
        }

        // load loại sản phẩm vào combo box
        private void LoadDataToComboBox()
        {
            // load dữ liệu loại sản phẩm vào combo box
            DataTable dtCategories = bus_Categories.BUS_GetCategories();

            if (dtCategories == null)
            {
                // thông báo lỗi
                MessageBox.Show("error");
                return;
            }

            cmbProductCategories.ValueMember = "ID_MALOAI";
            cmbProductCategories.DisplayMember = "TENLOAI";
            cmbProductCategories.DataSource = dtCategories;

            cmbProductCategories.SelectedIndex = cmbProductCategories.FindString("Tất cả");
            ComboBox_CurrentSelectedValue = int.Parse(cmbProductCategories.SelectedValue.ToString());

            // load các loại sắp xếp
            cmbSort.DataSource = SortType;
        }

        // get số lượng ô có thể hiển thị
        private void GetMaxCellInPage_PanelGridProducts()
        {
            // số cột tối đa của khung.
            int NumCol = Convert.ToInt32(Math.Floor((float)(PanelGridProduct.Width) / (ProductView_Width + ProductView_SpaceBetweenCell)));

            // số hàng tối đa của khung
            int NumRow = Convert.ToInt32(Math.Floor((float)(PanelGridProduct.Height) / (ProductView_Height + ProductView_SpaceBetweenCell)));

            ProductView_MaxCellDisplayInPage = NumCol * NumRow;
        }

        // get max page
        private void GetMaxPage_PanelGridProducts()
        {
            // số lượng sản phẩm
            int NumberOfProducts = listProducts.Count;

            // số lượng page cần tạo
            MaxPage = Convert.ToInt32(Math.Ceiling((double)NumberOfProducts / ProductView_MaxCellDisplayInPage));
        }

        // set trạng thái của các button arrows
        private void SetStatusOfArrowButtons()
        {
            if (CurrentPage == 1)
            {
                if (MaxPage != 1)   // có nhiều trang và trang hiện tại là 1
                {
                    BtnPrevPage.Enabled = false;
                    BtnNextPage.Enabled = true;
                }
                else
                {
                    // chỉ có 1 trang duy nhất
                    BtnPrevPage.Enabled = false;
                    BtnNextPage.Enabled = false;
                }
            }
            else
            {
                if (CurrentPage != MaxPage)
                {
                    // có nhiều trang và trang hiện tại ở giữa
                    BtnPrevPage.Enabled = true;
                    BtnNextPage.Enabled = true;
                }
                else
                {
                    // có nhiều trang và trang hiện tại năm ở cuói
                    BtnPrevPage.Enabled = true;
                    BtnNextPage.Enabled = false;
                }
            }
        }

        // tạo khung và load data vào current page
        private void RenderFrameAndDataToCurrentPage()
        {
            // tìm số lượng dữ liệu đổ vào
            // nếu ở chỉ có 1 trang thì đổ hết vào
            // nếu ở trang cuối cùng thì đổ số còn lại
            // nếu ở giữa thì đổ bằng maxcell

            int NumberOfDataCellsInPage = 0;

            if (MaxPage == 1)
            {
                NumberOfDataCellsInPage = listProducts.Count;
                SetStatusOfArrowButtons();
            }
            else
            {
                if (CurrentPage == MaxPage)
                {
                    // tìm số lượng dữ liệu còn lại
                    NumberOfDataCellsInPage = listProducts.Count - (CurrentPage - 1) * ProductView_MaxCellDisplayInPage;
                    SetStatusOfArrowButtons();
                }
                else
                {
                    NumberOfDataCellsInPage = ProductView_MaxCellDisplayInPage;
                    SetStatusOfArrowButtons();
                }
            }

            // bắt đầu tạo 1 grid đê hiển thị
            int currentHeight = 0;

            // chỉ số cột hiện tại
            int CurentColumn = 0;

            for (int i = 0; i < NumberOfDataCellsInPage; i++)
            {
                // lấy vị trí tiếp theo render ra 1 panel view product mới
                int CurentColumnPosition = ProductView_SpaceBetweenCell * (CurentColumn + 1) + CurentColumn * ProductView_Width;

                // nếu panel view product tiếp theo mà nhét không đủ thì bắt đầu xuống dòng mới
                // reset lại chỉ số cột hiện tại và trở lại về khung chuẩn bị tạo nhưng bị xuống hàng.
                if (CurentColumnPosition + ProductView_Width >= PanelGridProduct.Width)
                {
                    currentHeight += ProductView_SpaceBetweenCell + ProductView_Height;
                    CurentColumn = 0;
                    i--;
                    continue;
                }

                // kiểm tra xem hàng mới xuống có thể chứa thêm 1 dòng panel nữa không.
                // nếu không đủ return
                if (currentHeight > PanelGridProduct.Height)
                {
                    return;
                }

                // tạo 1 view product
                Panel newpanel = new Panel();

                newpanel.BorderStyle = BorderStyle.FixedSingle;
                newpanel.Location = new System.Drawing.Point(CurentColumnPosition, currentHeight);
                newpanel.Name = "panel" + i.ToString();
                newpanel.Size = new System.Drawing.Size(ProductView_Width, ProductView_Height);
                newpanel.TabIndex = 0;
                newpanel.Cursor = Cursors.Hand;

                // thêm vào list panel
                GridPanel.Add(newpanel);

                // thêm vào panel chứa grid view product
                PanelGridProduct.Controls.Add(newpanel);

                // tăng cột
                CurentColumn++;
            }


            // LOAD DỮ LIÊU

            //// nếu chọn tất cả thì cho = -1
            //if (cmbProductCategories.GetItemText(cmbProductCategories.SelectedItem) == "Tất cả")
            //{
            //    nComboBoxSeletedValue = -1;
            //}

            int index = (CurrentPage - 1) * ProductView_MaxCellDisplayInPage;

            foreach (Panel panel in GridPanel)
            {
                panel.Controls.Add(new UC_ViewProduct(listProducts[index].ID, listProducts[index].ProductName, listProducts[index].ProductPrice, listProducts[index].ProductImage));

                index++;
            }

        }

        private void XoaDuLieu()
        {
            GridPanel.Clear();
            //cmbProductCategories.DataSource = null;
            PanelGridProduct.Controls.Clear();
        }

        #endregion

        #region event
        private void PanelGridProduct_Resize(object sender, EventArgs e)
        {
            XoaDuLieu();

            // set currentpage là page đầu tiên
            CurrentPage = 1;

            // load data
            GetDataProducts(ComboBox_CurrentSelectedValue);

            if (listProducts.Count == 0)
            {
                MessageBox.Show("Không có data để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // get max cell
            this.GetMaxCellInPage_PanelGridProducts();

            // get max page
            this.GetMaxPage_PanelGridProducts();

            // load data vô current page
            RenderFrameAndDataToCurrentPage();
        }

        private void cmbProductCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // trả lại trạng thái ban đầu của combobox sort
            cmbSort.SelectedIndex = 0;

            int nComboBoxSelectedValue = int.Parse(cmbProductCategories.SelectedValue.ToString());

            if (ComboBox_CurrentSelectedValue != nComboBoxSelectedValue)
            {
                XoaDuLieu();

                ComboBox_CurrentSelectedValue = nComboBoxSelectedValue;

                // set currentpage là page đầu tiên
                CurrentPage = 1;

                // load data
                GetDataProducts(ComboBox_CurrentSelectedValue);

                if (listProducts.Count == 0)
                {
                    MessageBox.Show("Không có data để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // get max cell
                this.GetMaxCellInPage_PanelGridProducts();

                // get max page
                this.GetMaxPage_PanelGridProducts();

                // load data vô current page
                RenderFrameAndDataToCurrentPage();
            }
        }

        private void BtnPrevPage_Click(object sender, EventArgs e)
        {
            CurrentPage--;

            XoaDuLieu();

            // get max cell
            this.GetMaxCellInPage_PanelGridProducts();

            // get max page
            this.GetMaxPage_PanelGridProducts();

            // load data vô page 0
            RenderFrameAndDataToCurrentPage();
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            CurrentPage++;

            XoaDuLieu();

            // get max cell
            this.GetMaxCellInPage_PanelGridProducts();

            // get max page
            this.GetMaxPage_PanelGridProducts();

            // load data vô page 0
            RenderFrameAndDataToCurrentPage();
        }

        private void cmbSort_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // hàng mới, giá tăng dần, giá giảm dần, hãng sx
            int SelectedIndex = cmbSort.SelectedIndex;

            int nComboBoxSeletedValue = ComboBox_CurrentSelectedValue;

            listProducts.Clear();
            GridPanel.Clear();
            PanelGridProduct.Controls.Clear();

            // nếu chọn tất cả thì cho = -1
            if (cmbProductCategories.GetItemText(cmbProductCategories.SelectedItem) == "Tất cả")
            {
                nComboBoxSeletedValue = -1;
            }

            // lây danh sách sản phẩm dựa vào loại sản phẩm
            DataTable dtProducts = null;

            switch (SelectedIndex)
            {
                case (int)SortTypeIndex.Khong:
                    GetDataProducts(nComboBoxSeletedValue);
                    break;
                case (int)SortTypeIndex.GiaGiamDan:
                    // chọn sản phẩm được xếp theo giá giảm dần
                    dtProducts = bus_Products.BUS_GetProductInfoByCategoryIDAndTypeSort
                        (nComboBoxSeletedValue, (int)SortTypeIndex.GiaGiamDan);
                    break;
                case (int)SortTypeIndex.GiaTangDan:
                    // chọn sản phẩm được xếp theo giá
                    dtProducts = bus_Products.BUS_GetProductInfoByCategoryIDAndTypeSort
                        (nComboBoxSeletedValue, (int)SortTypeIndex.GiaTangDan);
                    break;
                case (int)SortTypeIndex.HangSanXuat:
                    // chọn sản phẩm được xếp theo hãng sản xuất
                    dtProducts = bus_Products.BUS_GetProductInfoByCategoryIDAndTypeSort
                        (nComboBoxSeletedValue, (int)SortTypeIndex.HangSanXuat);
                    break;
            }

            if (SelectedIndex != (int)SortTypeIndex.Khong)
            {
                if (dtProducts == null)
                {
                    MessageBox.Show("Có lỗi xảy ra khi load dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataRow row in dtProducts.Rows)
                {
                    DTO_Product product = new DTO_Product
                    {
                        ID = int.Parse(row["ID_MASP"].ToString()),
                        CategoryID = int.Parse(row["ID_MALOAI"].ToString()),
                        ManufacturerID = int.Parse(row["ID_HANGSX"].ToString()),
                        ProductName = row["TENSP"].ToString(),
                        ProductQuantity = int.Parse(row["SOLUONG"].ToString()),
                        ProductPrice = int.Parse(row["DONGIA"].ToString()),
                        ProductImage = (Byte[])row["HINHANH"]
                    };

                    listProducts.Add(product);
                }
            }

            if (listProducts.Count == 0)
            {
                MessageBox.Show("Không có data để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // get max cell
            this.GetMaxCellInPage_PanelGridProducts();

            // get max page
            this.GetMaxPage_PanelGridProducts();

            // load data vô current page
            RenderFrameAndDataToCurrentPage();
        }

        #endregion

        public void ReloadForm()
        {
            txbSearch.Text = "";

            XoaDuLieu();

            // set currentpage là page đầu tiên
            CurrentPage = 1;

            // load data
            GetDataProducts(ComboBox_CurrentSelectedValue);

            if (listProducts.Count == 0)
            {
                MessageBox.Show("Không có data để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // get max cell
            this.GetMaxCellInPage_PanelGridProducts();

            // get max page
            this.GetMaxPage_PanelGridProducts();

            // load data vô current page
            RenderFrameAndDataToCurrentPage();
        }

       

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            XoaDuLieu();

            listProducts.Clear();

            DataTable dtProductSearch = bus_Products.BUS_SearchProductByString(txbSearch.Text);

            if (txbSearch.Text.Length == 0)
            {
                MessageBox.Show("Ô tìm kiếm không được để rỗng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtProductSearch == null)
            {
                MessageBox.Show("Có lỗi xảy ra khi load dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtProductSearch.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm để hiển thị!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // reset combo box về mặc định
            cmbProductCategories.SelectedIndex = cmbProductCategories.FindString("Tất cả");

            ComboBox_CurrentSelectedValue = (int)cmbProductCategories.SelectedValue;

            cmbSort.SelectedIndex = cmbSort.FindString("Không");
            

            // set currentpage là page đầu tiên
            CurrentPage = 1;

            // load data
            foreach (DataRow row in dtProductSearch.Rows)
            {
                DTO_Product product = new DTO_Product
                {
                    ID = int.Parse(row["ID_MASP"].ToString()),
                    CategoryID = int.Parse(row["ID_MALOAI"].ToString()),
                    ManufacturerID = int.Parse(row["ID_HANGSX"].ToString()),
                    ProductName = row["TENSP"].ToString(),
                    ProductQuantity = int.Parse(row["SOLUONG"].ToString()),
                    ProductPrice = int.Parse(row["DONGIA"].ToString()),
                    ProductImage = (Byte[])row["HINHANH"]
                };

                listProducts.Add(product);
            }

            // get max cell
            this.GetMaxCellInPage_PanelGridProducts();

            // get max page
            this.GetMaxPage_PanelGridProducts();

            // load data vô current page
            RenderFrameAndDataToCurrentPage();
        }


        private bool isSearched = false;

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)    // nhấn enter
            {
                isSearched = true;
                BtnSearch.PerformClick();
            }
        }

        

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            if (txbSearch.Text.Length == 0 && isSearched == true)
            {
                // lúc này mới reload lại form với category là tất cả. gọi hàm reload
                isSearched = false;

                listProducts.Clear();

                this.ReloadForm();
            }
        }
    }
}
