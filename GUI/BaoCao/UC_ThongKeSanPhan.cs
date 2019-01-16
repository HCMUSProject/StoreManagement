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

namespace GUI.BaoCao
{
    public partial class UC_ThongKeSanPhan : UserControl
    {
        
        BUS_BaoCao bus_Statistics = new BUS_BaoCao();

        private List<string> listStatisticsBy = new List<string> { "Năm", "Tháng", "Tuần", "Ngày", "Tùy chọn" };
        private bool IsLoaded = false;
        private int CurrentSelected = 0;

        private static UC_ThongKeSanPhan _ins;
        public static UC_ThongKeSanPhan Instance
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new UC_ThongKeSanPhan();
                }
                return _ins;
            }
        }

        public UC_ThongKeSanPhan()
        {
            InitializeComponent();

            cmbStatisticsBy.DataSource = listStatisticsBy;

            bool res = LoadComboBoxCategory();

            if (res == false)
            {
                MessageBox.Show("Tải dữ liệu vào combo box không thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                IsLoaded = false;

                return;
            }
            // chọn mặc định combo box
            cmbCategories.SelectedIndex = 0;

            // chọn mặc định là năm
            cmbStatisticsBy.SelectedIndex = 0;

            txbYear.Enabled = true;
            txbMonth.Enabled = false;
            txbWeek.Enabled = false;
            txbDay.Enabled = false;

            IsLoaded = true;

            LoadListProductExpire();

            PanelEnterValue_2.Visible = false;

            PanelEnterValue_1.Visible = true;
        }

        private bool LoadComboBoxCategory()
        {
            BUS_LoaiSanPham bus_Category = new BUS_LoaiSanPham();

            DataTable dtCategories = bus_Category.BUS_GetCategories();

            if (dtCategories == null)
            {
                MessageBox.Show("Có lỗi trong quá trình load dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            dtCategories.Rows.RemoveAt(0);  // remove tất cả

            cmbCategories.ValueMember = "ID_MALOAI";
            cmbCategories.DisplayMember = "TENLOAI";
            cmbCategories.DataSource = dtCategories;

            return true;
        }

        private void LoadListProductExpire()
        {
            if (IsLoaded == true)
            {
                BUS_SanPham bus_Products = new BUS_SanPham();

                DataTable dtProductExpire = bus_Products.BUS_GetListProductExpireByCategoryID((int)cmbCategories.SelectedValue);

                if (dtgvProducts == null)
                {
                    MessageBox.Show("Có lỗi xảy ra khi load dữ liệu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // chỉ hiển thị 10 sản phẩm gần hết
                if (dtProductExpire.Rows.Count > 10)
                {
                    // xóa những row nhiều hơn 10
                    int index = 0;
                    foreach(DataRow row in dtProductExpire.Rows)
                    {
                        index++;

                        if (index > 10)
                        {
                            dtProductExpire.Rows.Remove(row);
                        }
                    }
                }
                dtgvProducts.DataSource = dtProductExpire;

                dtgvProducts.Columns["ID_MASP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dtgvProducts.Columns["SOLUONG"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                dtgvProducts.Columns["ID_MASP"].HeaderText = "Mã loại";
                dtgvProducts.Columns["TENSP"].HeaderText = "Tên sản phẩm";
                dtgvProducts.Columns["SOLUONG"].HeaderText = "Số lượng";
            }
        }

        private void cmbStatisticsBy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (IsLoaded == true)
            {
                if (CurrentSelected == cmbStatisticsBy.SelectedIndex)
                {
                    return;
                }

                CurrentSelected = cmbStatisticsBy.SelectedIndex;


                switch (CurrentSelected)
                {
                    case 0: // năm
                        txbYear.Enabled = true;
                        txbMonth.Enabled = false;
                        txbWeek.Enabled = false;
                        txbDay.Enabled = false;

                        PanelEnterValue_2.Visible = false;

                        PanelEnterValue_1.Visible=true;
                        break;
                    case 1: // tháng
                        txbYear.Enabled = true;
                        txbMonth.Enabled = true;
                        txbWeek.Enabled = false;
                        txbDay.Enabled = false;

                        PanelEnterValue_2.Visible = false;

                        PanelEnterValue_1.Visible = true;
                        break;
                    case 2: // tuần
                        txbYear.Enabled = true;
                        txbMonth.Enabled = false;
                        txbWeek.Enabled = true;
                        txbDay.Enabled = false;

                        PanelEnterValue_2.Visible = false;

                        PanelEnterValue_1.Visible = true;
                        break;
                    case 3: // ngày
                        txbYear.Enabled = true;
                        txbMonth.Enabled = true;
                        txbWeek.Enabled = false;
                        txbDay.Enabled = true;

                        PanelEnterValue_2.Visible = false;

                        PanelEnterValue_1.Visible = true;
                        break;
                    case 4:
                        PanelEnterValue_1.Visible = false;

                        PanelEnterValue_2.Visible = true;
                        break;
                }
            }
        }

        private void ShowInfo_RightPanel()
        {
            int max = 0, index = -1, totalQuantity = 0, idx = 0;
            foreach (var series in ChartBestSellingProducts.Series)
            {
                index = ChartBestSellingProducts.Series.IndexOf(series);
                totalQuantity += (int)series.Points[index].YValues[0];
                if (max < (int)series.Points[index].YValues[0])
                {
                    max = (int)series.Points[index].YValues[0];
                    idx = index;
                }
            }

            if (index == -1)
            {
                lbTotalProduct.Text = "";
                lbQuantity.Text = "";
                lbBestSellingProduct.Text = "";
                return;
            }

            lbTotalProduct.Text = totalQuantity.ToString();

            lbQuantity.Text = max.ToString();

            lbBestSellingProduct.Text = ChartBestSellingProducts.Series[idx].Name;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (IsLoaded == true)
            {
                dtgvProducts.DataSource = null;
                LoadListProductExpire();

                ChartBestSellingProducts.Series.Clear();

                switch (CurrentSelected)
                {
                    case 0: // năm
                        // kiểm tra điều kiện
                        if (txbYear.Text == "")
                        {
                            MessageBox.Show("Không được để trống các trường!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (MySupportMethods.isNumberic(txbYear.Text) == false)
                        {
                            MessageBox.Show("Các trường chỉ được phép là số!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (int.Parse(txbYear.Text) < 0)
                        {
                            MessageBox.Show("Các trường là số không âm!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }


                        // load dữ liệu theo năm:
                        DataTable dtProduct_Year = bus_Statistics.BUS_GetProductsSoldByYear(int.Parse(txbYear.Text), (int)cmbCategories.SelectedValue);

                        if (dtProduct_Year == null)
                        {
                            MessageBox.Show("Có lỗi khi load dữ liệu!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        foreach(DataRow row in dtProduct_Year.Rows)
                        {
                            string SeriesName = row["TENSP"].ToString();
                            ChartBestSellingProducts.Series.Add(SeriesName);

                            ChartBestSellingProducts.Series[SeriesName]["PointWidth"] = "0.5";

                            int Quantity = (int)row["SOLUONG"];
                            ChartBestSellingProducts.Series[SeriesName].Points.AddXY(SeriesName, Quantity);

                        }

                        ChartBestSellingProducts.AlignDataPointsByAxisLabel();

                        ShowInfo_RightPanel();

                        break;
                    case 1: // tháng
                        // kiểm tra điều kiện
                        if (txbYear.Text == "" || txbMonth.Text == "")
                        {
                            MessageBox.Show("Không được để trống các trường!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (MySupportMethods.isNumberic(txbYear.Text) == false || MySupportMethods.isNumberic(txbMonth.Text) == false)
                        {
                            MessageBox.Show("Các trường chỉ được phép là số!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (int.Parse(txbYear.Text) < 0 || int.Parse(txbMonth.Text) < 0)
                        {
                            MessageBox.Show("Các trường là số không âm!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (int.Parse(txbMonth.Text) > 12)
                        {
                            MessageBox.Show("Tháng chỉ từ 1 -> 12!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // load dữ liệu theo tháng:
                        DataTable dtProduct_Month = bus_Statistics.BUS_GetProductsSoldByMonth(int.Parse(txbYear.Text), int.Parse(txbMonth.Text), (int)cmbCategories.SelectedValue);

                        if (dtProduct_Month == null)
                        {
                            MessageBox.Show("Có lỗi khi load dữ liệu!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        foreach (DataRow row in dtProduct_Month.Rows)
                        {
                            string SeriesName = row["TENSP"].ToString();
                            ChartBestSellingProducts.Series.Add(SeriesName);

                            ChartBestSellingProducts.Series[SeriesName]["PointWidth"] = "0.5";

                            int Quantity = (int)row["SOLUONG"];
                            ChartBestSellingProducts.Series[SeriesName].Points.AddXY(SeriesName, Quantity);

                        }

                        ChartBestSellingProducts.AlignDataPointsByAxisLabel();

                        ShowInfo_RightPanel();

                        break;
                    case 2: // tuần
                        // kiểm tra điều kiện
                        if (txbYear.Text == "" || txbWeek.Text == "")
                        {
                            MessageBox.Show("Không được để trống các trường!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (MySupportMethods.isNumberic(txbYear.Text) == false || MySupportMethods.isNumberic(txbWeek.Text) == false)
                        {
                            MessageBox.Show("Các trường chỉ được phép là số!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (int.Parse(txbYear.Text) < 0 || int.Parse(txbWeek.Text) < 0)
                        {
                            MessageBox.Show("Các trường là số không âm!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (int.Parse(txbWeek.Text) > 52)
                        {
                            MessageBox.Show("Tuần chỉ từ 1 -> 52!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // load dữ liệu theo tháng:
                        DataTable dtProduct_Week = bus_Statistics.BUS_GetProductsSoldByWeek(int.Parse(txbYear.Text), int.Parse(txbWeek.Text), (int)cmbCategories.SelectedValue);

                        if (dtProduct_Week == null)
                        {
                            MessageBox.Show("Có lỗi khi load dữ liệu!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        foreach (DataRow row in dtProduct_Week.Rows)
                        {
                            string SeriesName = row["TENSP"].ToString();
                            ChartBestSellingProducts.Series.Add(SeriesName);

                            ChartBestSellingProducts.Series[SeriesName]["PointWidth"] = "0.5";

                            int Quantity = (int)row["SOLUONG"];
                            ChartBestSellingProducts.Series[SeriesName].Points.AddXY(SeriesName, Quantity);

                        }

                        ChartBestSellingProducts.AlignDataPointsByAxisLabel();


                        ShowInfo_RightPanel();

                        break;
                    case 3: // ngày
                        // kiểm tra điều kiện
                        if (txbYear.Text == "" || txbMonth.Text == "" || txbDay.Text == "")
                        {
                            MessageBox.Show("Không được để trống các trường!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (MySupportMethods.isNumberic(txbYear.Text) == false || MySupportMethods.isNumberic(txbMonth.Text) == false
                            || MySupportMethods.isNumberic(txbDay.Text) == false)
                        {
                            MessageBox.Show("Các trường chỉ được phép là số!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (int.Parse(txbYear.Text) < 0 || int.Parse(txbMonth.Text) < 0 || int.Parse(txbDay.Text) < 0)
                        {
                            MessageBox.Show("Các trường là số không âm!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (int.Parse(txbMonth.Text) > 12)
                        {
                            MessageBox.Show("Tháng chỉ từ 1 -> 12!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        int[] arr = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                        int Day = int.Parse(txbDay.Text), Month = int.Parse(txbMonth.Text), Year = int.Parse(txbYear.Text);

                        if ((Month != 2 && (Day > arr[Month] || Day < 0))
                                || (Year / 4 == 0 && Year / 100 != 0 && Month == 2 && (Day > 29 || Day < 0))
                                || (!(Year / 4 == 0 && Year / 100 != 0) && Month == 2 && (Day > 28 || Day < 0)))
                        {
                            MessageBox.Show("Ngày nhập không đúng!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }


                        // load dữ liệu theo tháng:
                        DataTable dtProduct_Day = bus_Statistics.BUS_GetProductsSoldByDay(Year, Month, Day, (int)cmbCategories.SelectedValue);

                        if (dtProduct_Day == null)
                        {
                            MessageBox.Show("Có lỗi khi load dữ liệu!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        foreach (DataRow row in dtProduct_Day.Rows)
                        {
                            string SeriesName = row["TENSP"].ToString();
                            ChartBestSellingProducts.Series.Add(SeriesName);

                            ChartBestSellingProducts.Series[SeriesName]["PointWidth"] = "0.5";

                            int Quantity = (int)row["SOLUONG"];
                            ChartBestSellingProducts.Series[SeriesName].Points.AddXY(SeriesName, Quantity);

                        }

                        ChartBestSellingProducts.AlignDataPointsByAxisLabel();

                        ShowInfo_RightPanel();

                        break;
                    case 4: // tùy chọn
                        if (dtpkFrom.Value >= dtpkTo.Value)
                        {
                            MessageBox.Show("Ngày bắt đầu và ngày kết thúc không trùng nhau!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        DataTable dtProduct_Option = bus_Statistics.BUS_GetProductSoldByOption(dtpkFrom.Value, dtpkTo.Value, (int)cmbCategories.SelectedValue);

                        if (dtProduct_Option == null)
                        {
                            MessageBox.Show("Có lỗi khi load dữ liệu!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        foreach (DataRow row in dtProduct_Option.Rows)
                        {
                            string SeriesName = row["TENSP"].ToString();
                            ChartBestSellingProducts.Series.Add(SeriesName);

                            ChartBestSellingProducts.Series[SeriesName]["PointWidth"] = "0.5";

                            int Quantity = (int)row["SOLUONG"];
                            ChartBestSellingProducts.Series[SeriesName].Points.AddXY(SeriesName, Quantity);

                        }

                        ChartBestSellingProducts.AlignDataPointsByAxisLabel();

                        ShowInfo_RightPanel();

                        break;
                }
            }
        }
    }
}
