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
    public partial class UC_ThongKeDoanhThu : UserControl
    {
        private bool IsLoaded = false;
        private int CurrentSelected = 0;

        BUS_BaoCao bus_Statistics = new BUS_BaoCao();

        private List<string> listStatisticsBy = new List<string> { "Năm", "Tháng", "Tuần", "Ngày", "Tùy chọn" };

        private static UC_ThongKeDoanhThu _ins;
        public static UC_ThongKeDoanhThu Instance
        {
            get
            {
                if (_ins == null)
                    {
                    _ins = new UC_ThongKeDoanhThu();
                }
                return _ins;
            }
        }

        public UC_ThongKeDoanhThu()
        {
            InitializeComponent();

            cmbStatisticsBy.DataSource = listStatisticsBy;

            // chọn mặc định là năm
            cmbStatisticsBy.SelectedIndex = 0;

            txbYear.Enabled = true;
            txbMonth.Enabled = false;
            txbWeek.Enabled = false;
            txbDay.Enabled = false;

            PanelEnterValue_2.Visible = false;

            PanelEnterValue_1.Visible = true;

            IsLoaded = true;

            this.ReloadForm();
        }


        public void ReloadForm()
        {
            cmbStatisticsBy.SelectedIndex = 0;

            txbYear.Text = DateTime.Now.Year.ToString();

            BtnLoad.PerformClick();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            ChartImportAndExport.Series.Clear();
            ChartImport.Series.Clear();
            ChartExport.Series.Clear();

            switch (CurrentSelected)
            {
                case 0: // load theo năm
                    {
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

                        // thống kê theo năm. giới hạn là 10 năm so với năm hiện tại
                        int year = DateTime.Now.Year;

                        if (year - int.Parse(txbYear.Text) > 10)
                        {
                            MessageBox.Show("Chương trình chỉ lưu dữ liệu trong vòng 10 năm so với hiện tại!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // get giá trị nhập điên thoại
                        DataTable dtPhoneImport = bus_Statistics.BUS_GetListProductImportByYear(int.Parse(txbYear.Text), 1);

                        // get giá trị nhập laptop
                        DataTable dtLaptopImport = bus_Statistics.BUS_GetListProductImportByYear(int.Parse(txbYear.Text), 2);

                        // get giá trị xuất điện thoại
                        DataTable dtPhoneExport = bus_Statistics.BUS_GetListProductExportByYear(int.Parse(txbYear.Text), 1);

                        // get giá trị xuất laptop
                        DataTable dtLaptopExport = bus_Statistics.BUS_GetListProductExportByYear(int.Parse(txbYear.Text), 2);

                        // tính tổng tiền nhập điện thoại
                        int TotalPhoneImportPrice = 0;
                        foreach (DataRow row in dtPhoneImport.Rows)
                        {
                            TotalPhoneImportPrice += (int)row["SOLUONG"] * (int)row["DONGIA"];
                        }

                        // tính tổng tiền nhập laptop
                        int TotalLaptopImportPrice = 0;
                        foreach (DataRow row in dtLaptopImport.Rows)
                        {
                            TotalLaptopImportPrice += (int)row["SOLUONG"] * (int)row["DONGIA"];
                        }

                        // tính tổng tiền bán điện thoại
                        int TotalPhoneExportPrice = 0;
                        foreach (DataRow row in dtPhoneExport.Rows)
                        {
                            TotalPhoneExportPrice += (int)row["TONGTIEN"];
                        }

                        // tính tổng tiền bán laptop
                        int TotalLaptopExportPrice = 0;
                        foreach (DataRow row in dtLaptopExport.Rows)
                        {
                            TotalLaptopExportPrice += (int)row["TONGTIEN"];
                        }

                        int TotalImport = TotalPhoneImportPrice + TotalLaptopImportPrice;

                        int TotalExport = TotalPhoneExportPrice + TotalLaptopExportPrice;

                        // dựng biểu đồ cột
                        string SeriesImport = "Tổng tiền nhập";
                        ChartImportAndExport.Series.Add(SeriesImport);

                        ChartImportAndExport.Series[SeriesImport].Points.AddXY(SeriesImport, TotalImport);
                        ChartImportAndExport.Series[SeriesImport]["PointWidth"] = "0.5";

                        string SeriesExport = "Tổng tiền bán";
                        ChartImportAndExport.Series.Add(SeriesExport);

                        ChartImportAndExport.Series[SeriesExport].Points.AddXY(SeriesExport, TotalExport);
                        ChartImportAndExport.Series[SeriesExport]["PointWidth"] = "0.5";

                        ChartImportAndExport.AlignDataPointsByAxisLabel();

                        // dựng biểu đồ tròn:
                        // biểu đồ tròn Nhập sản phẩm

                        string SeriesImport_Pie = "Tiền nhập";
                        ChartImport.Series.Add(SeriesImport_Pie);

                        ChartImport.Series[SeriesImport_Pie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        ChartImport.Series[SeriesImport_Pie].Points.AddXY("Tiền nhập điện thoại", TotalPhoneImportPrice);
                        ChartImport.Series[SeriesImport_Pie].Points.AddXY("Tiền nhập laptop", TotalLaptopImportPrice);
                        ChartImport.Series[SeriesImport_Pie].IsValueShownAsLabel = true;
                        ChartImport.Series[SeriesImport_Pie].Label = "#PERCENT\n#VALX";

                        // biểu đồ tròn Bán sản phẩm
                        string SeriesExport_Pie = "Tiền nhập";
                        ChartExport.Series.Add(SeriesExport_Pie);

                        ChartExport.Series[SeriesExport_Pie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        ChartExport.Series[SeriesExport_Pie].Points.AddXY("Tiền bán điện thoại", TotalPhoneExportPrice);
                        ChartExport.Series[SeriesExport_Pie].Points.AddXY("Tiền bán laptop", TotalLaptopExportPrice);
                        ChartExport.Series[SeriesExport_Pie].IsValueShownAsLabel = true;
                        ChartExport.Series[SeriesExport_Pie].Label = "#PERCENT\n#VALX";

                    }
                    break;

                case 1: // tháng
                    {
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


                        // get giá trị nhập điên thoại
                        DataTable dtPhoneImport = bus_Statistics.BUS_GetListProductImportByMonth(int.Parse(txbYear.Text), int.Parse(txbMonth.Text), 1);

                        // get giá trị nhập laptop
                        DataTable dtLaptopImport = bus_Statistics.BUS_GetListProductImportByMonth(int.Parse(txbYear.Text), int.Parse(txbMonth.Text), 2);

                        // get giá trị xuất điện thoại
                        DataTable dtPhoneExport = bus_Statistics.BUS_GetListProductExportByMonth(int.Parse(txbYear.Text), int.Parse(txbMonth.Text), 1);

                        // get giá trị xuất laptop
                        DataTable dtLaptopExport = bus_Statistics.BUS_GetListProductExportByMonth(int.Parse(txbYear.Text), int.Parse(txbMonth.Text), 2);

                        // tính tổng tiền nhập điện thoại
                        int TotalPhoneImportPrice = 0;
                        foreach (DataRow row in dtPhoneImport.Rows)
                        {
                            TotalPhoneImportPrice += (int)row["SOLUONG"] * (int)row["DONGIA"];
                        }

                        // tính tổng tiền nhập laptop
                        int TotalLaptopImportPrice = 0;
                        foreach (DataRow row in dtLaptopImport.Rows)
                        {
                            TotalLaptopImportPrice += (int)row["SOLUONG"] * (int)row["DONGIA"];
                        }

                        // tính tổng tiền bán điện thoại
                        int TotalPhoneExportPrice = 0;
                        foreach (DataRow row in dtPhoneExport.Rows)
                        {
                            TotalPhoneExportPrice += (int)row["TONGTIEN"];
                        }

                        // tính tổng tiền bán laptop
                        int TotalLaptopExportPrice = 0;
                        foreach (DataRow row in dtLaptopExport.Rows)
                        {
                            TotalLaptopExportPrice += (int)row["TONGTIEN"];
                        }

                        int TotalImport = TotalPhoneImportPrice + TotalLaptopImportPrice;

                        int TotalExport = TotalPhoneExportPrice + TotalLaptopExportPrice;

                        // dựng biểu đồ cột
                        string SeriesImport = "Tổng tiền nhập";
                        ChartImportAndExport.Series.Add(SeriesImport);

                        ChartImportAndExport.Series[SeriesImport].Points.AddXY(SeriesImport, TotalImport);
                        ChartImportAndExport.Series[SeriesImport]["PointWidth"] = "0.5";

                        string SeriesExport = "Tổng tiền bán";
                        ChartImportAndExport.Series.Add(SeriesExport);

                        ChartImportAndExport.Series[SeriesExport].Points.AddXY(SeriesExport, TotalExport);
                        ChartImportAndExport.Series[SeriesExport]["PointWidth"] = "0.5";

                        ChartImportAndExport.AlignDataPointsByAxisLabel();

                        // dựng biểu đồ tròn:
                        // biểu đồ tròn Nhập sản phẩm

                        string SeriesImport_Pie = "Tiền nhập";
                        ChartImport.Series.Add(SeriesImport_Pie);

                        ChartImport.Series[SeriesImport_Pie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        ChartImport.Series[SeriesImport_Pie].Points.AddXY("Tiền nhập điện thoại", TotalPhoneImportPrice);
                        ChartImport.Series[SeriesImport_Pie].Points.AddXY("Tiền nhập laptop", TotalLaptopImportPrice);
                        ChartImport.Series[SeriesImport_Pie].IsValueShownAsLabel = true;
                        ChartImport.Series[SeriesImport_Pie].Label = "#PERCENT\n#VALX";

                        // biểu đồ tròn Bán sản phẩm
                        string SeriesExport_Pie = "Tiền nhập";
                        ChartExport.Series.Add(SeriesExport_Pie);

                        ChartExport.Series[SeriesExport_Pie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        ChartExport.Series[SeriesExport_Pie].Points.AddXY("Tiền bán điện thoại", TotalPhoneExportPrice);
                        ChartExport.Series[SeriesExport_Pie].Points.AddXY("Tiền bán laptop", TotalLaptopExportPrice);
                        ChartExport.Series[SeriesExport_Pie].IsValueShownAsLabel = true;
                        ChartExport.Series[SeriesExport_Pie].Label = "#PERCENT\n#VALX";
                    }

                    break;
                case 2:
                    {
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


                        // get giá trị nhập điên thoại
                        DataTable dtPhoneImport = bus_Statistics.BUS_GetListProductImportByWeek(int.Parse(txbYear.Text), int.Parse(txbWeek.Text), 1);

                        // get giá trị nhập laptop
                        DataTable dtLaptopImport = bus_Statistics.BUS_GetListProductImportByWeek(int.Parse(txbYear.Text), int.Parse(txbWeek.Text), 2);

                        // get giá trị xuất điện thoại
                        DataTable dtPhoneExport = bus_Statistics.BUS_GetListProductExportByWeek(int.Parse(txbYear.Text), int.Parse(txbWeek.Text), 1);

                        // get giá trị xuất laptop
                        DataTable dtLaptopExport = bus_Statistics.BUS_GetListProductExportByWeek(int.Parse(txbYear.Text), int.Parse(txbWeek.Text), 2);

                        // tính tổng tiền nhập điện thoại
                        int TotalPhoneImportPrice = 0;
                        foreach (DataRow row in dtPhoneImport.Rows)
                        {
                            TotalPhoneImportPrice += (int)row["SOLUONG"] * (int)row["DONGIA"];
                        }

                        // tính tổng tiền nhập laptop
                        int TotalLaptopImportPrice = 0;
                        foreach (DataRow row in dtLaptopImport.Rows)
                        {
                            TotalLaptopImportPrice += (int)row["SOLUONG"] * (int)row["DONGIA"];
                        }

                        // tính tổng tiền bán điện thoại
                        int TotalPhoneExportPrice = 0;
                        foreach (DataRow row in dtPhoneExport.Rows)
                        {
                            TotalPhoneExportPrice += (int)row["TONGTIEN"];
                        }

                        // tính tổng tiền bán laptop
                        int TotalLaptopExportPrice = 0;
                        foreach (DataRow row in dtLaptopExport.Rows)
                        {
                            TotalLaptopExportPrice += (int)row["TONGTIEN"];
                        }

                        int TotalImport = TotalPhoneImportPrice + TotalLaptopImportPrice;

                        int TotalExport = TotalPhoneExportPrice + TotalLaptopExportPrice;

                        // dựng biểu đồ cột
                        string SeriesImport = "Tổng tiền nhập";
                        ChartImportAndExport.Series.Add(SeriesImport);

                        ChartImportAndExport.Series[SeriesImport].Points.AddXY(SeriesImport, TotalImport);
                        ChartImportAndExport.Series[SeriesImport]["PointWidth"] = "0.5";

                        string SeriesExport = "Tổng tiền bán";
                        ChartImportAndExport.Series.Add(SeriesExport);

                        ChartImportAndExport.Series[SeriesExport].Points.AddXY(SeriesExport, TotalExport);
                        ChartImportAndExport.Series[SeriesExport]["PointWidth"] = "0.5";

                        ChartImportAndExport.AlignDataPointsByAxisLabel();

                        // dựng biểu đồ tròn:
                        // biểu đồ tròn Nhập sản phẩm

                        string SeriesImport_Pie = "Tiền nhập";
                        ChartImport.Series.Add(SeriesImport_Pie);

                        ChartImport.Series[SeriesImport_Pie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        ChartImport.Series[SeriesImport_Pie].Points.AddXY("Tiền nhập điện thoại", TotalPhoneImportPrice);
                        ChartImport.Series[SeriesImport_Pie].Points.AddXY("Tiền nhập laptop", TotalLaptopImportPrice);
                        ChartImport.Series[SeriesImport_Pie].IsValueShownAsLabel = true;
                        ChartImport.Series[SeriesImport_Pie].Label = "#PERCENT\n#VALX";

                        // biểu đồ tròn Bán sản phẩm
                        string SeriesExport_Pie = "Tiền nhập";
                        ChartExport.Series.Add(SeriesExport_Pie);

                        ChartExport.Series[SeriesExport_Pie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        ChartExport.Series[SeriesExport_Pie].Points.AddXY("Tiền bán điện thoại", TotalPhoneExportPrice);
                        ChartExport.Series[SeriesExport_Pie].Points.AddXY("Tiền bán laptop", TotalLaptopExportPrice);
                        ChartExport.Series[SeriesExport_Pie].IsValueShownAsLabel = true;
                        ChartExport.Series[SeriesExport_Pie].Label = "#PERCENT\n#VALX";
                    }
                    break;
                case 3:
                    {
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


                        // get giá trị nhập điên thoại
                        DataTable dtPhoneImport = bus_Statistics.BUS_GetListProductImportByDate(int.Parse(txbYear.Text), int.Parse(txbMonth.Text), int.Parse(txbDay.Text), 1);

                        // get giá trị nhập laptop
                        DataTable dtLaptopImport = bus_Statistics.BUS_GetListProductImportByDate(int.Parse(txbYear.Text), int.Parse(txbMonth.Text), int.Parse(txbDay.Text), 2);

                        // get giá trị xuất điện thoại
                        DataTable dtPhoneExport = bus_Statistics.BUS_GetListProductExportByDate(int.Parse(txbYear.Text), int.Parse(txbMonth.Text), int.Parse(txbDay.Text), 1);

                        // get giá trị xuất laptop
                        DataTable dtLaptopExport = bus_Statistics.BUS_GetListProductExportByDate(int.Parse(txbYear.Text), int.Parse(txbMonth.Text), int.Parse(txbDay.Text), 2);

                        // tính tổng tiền nhập điện thoại
                        int TotalPhoneImportPrice = 0;
                        foreach (DataRow row in dtPhoneImport.Rows)
                        {
                            TotalPhoneImportPrice += (int)row["SOLUONG"] * (int)row["DONGIA"];
                        }

                        // tính tổng tiền nhập laptop
                        int TotalLaptopImportPrice = 0;
                        foreach (DataRow row in dtLaptopImport.Rows)
                        {
                            TotalLaptopImportPrice += (int)row["SOLUONG"] * (int)row["DONGIA"];
                        }

                        // tính tổng tiền bán điện thoại
                        int TotalPhoneExportPrice = 0;
                        foreach (DataRow row in dtPhoneExport.Rows)
                        {
                            TotalPhoneExportPrice += (int)row["TONGTIEN"];
                        }

                        // tính tổng tiền bán laptop
                        int TotalLaptopExportPrice = 0;
                        foreach (DataRow row in dtLaptopExport.Rows)
                        {
                            TotalLaptopExportPrice += (int)row["TONGTIEN"];
                        }

                        int TotalImport = TotalPhoneImportPrice + TotalLaptopImportPrice;

                        int TotalExport = TotalPhoneExportPrice + TotalLaptopExportPrice;

                        // dựng biểu đồ cột
                        string SeriesImport = "Tổng tiền nhập";
                        ChartImportAndExport.Series.Add(SeriesImport);

                        ChartImportAndExport.Series[SeriesImport].Points.AddXY(SeriesImport, TotalImport);
                        ChartImportAndExport.Series[SeriesImport]["PointWidth"] = "0.5";

                        string SeriesExport = "Tổng tiền bán";
                        ChartImportAndExport.Series.Add(SeriesExport);

                        ChartImportAndExport.Series[SeriesExport].Points.AddXY(SeriesExport, TotalExport);
                        ChartImportAndExport.Series[SeriesExport]["PointWidth"] = "0.5";

                        ChartImportAndExport.AlignDataPointsByAxisLabel();

                        // dựng biểu đồ tròn:
                        // biểu đồ tròn Nhập sản phẩm

                        string SeriesImport_Pie = "Tiền nhập";
                        ChartImport.Series.Add(SeriesImport_Pie);

                        ChartImport.Series[SeriesImport_Pie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        ChartImport.Series[SeriesImport_Pie].Points.AddXY("Tiền nhập điện thoại", TotalPhoneImportPrice);
                        ChartImport.Series[SeriesImport_Pie].Points.AddXY("Tiền nhập laptop", TotalLaptopImportPrice);
                        ChartImport.Series[SeriesImport_Pie].IsValueShownAsLabel = true;
                        ChartImport.Series[SeriesImport_Pie].Label = "#PERCENT\n#VALX";

                        // biểu đồ tròn Bán sản phẩm
                        string SeriesExport_Pie = "Tiền nhập";
                        ChartExport.Series.Add(SeriesExport_Pie);

                        ChartExport.Series[SeriesExport_Pie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        ChartExport.Series[SeriesExport_Pie].Points.AddXY("Tiền bán điện thoại", TotalPhoneExportPrice);
                        ChartExport.Series[SeriesExport_Pie].Points.AddXY("Tiền bán laptop", TotalLaptopExportPrice);
                        ChartExport.Series[SeriesExport_Pie].IsValueShownAsLabel = true;
                        ChartExport.Series[SeriesExport_Pie].Label = "#PERCENT\n#VALX";
                    }
                    break;
                case 4:
                    {
                        if (dtpkFrom.Value >= dtpkTo.Value)
                        {
                            MessageBox.Show("Ngày bắt đầu và ngày kết thúc không trùng nhau!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // get giá trị nhập điên thoại
                        DataTable dtPhoneImport = bus_Statistics.BUS_GetListProductImportByOption(dtpkFrom.Value, dtpkTo.Value ,1);

                        // get giá trị nhập laptop
                        DataTable dtLaptopImport = bus_Statistics.BUS_GetListProductImportByOption(dtpkFrom.Value, dtpkTo.Value, 2);

                        // get giá trị xuất điện thoại
                        DataTable dtPhoneExport = bus_Statistics.BUS_GetListProductExportByOption(dtpkFrom.Value, dtpkTo.Value, 1);

                        // get giá trị xuất laptop
                        DataTable dtLaptopExport = bus_Statistics.BUS_GetListProductExportByOption(dtpkFrom.Value, dtpkTo.Value, 2);

                        // tính tổng tiền nhập điện thoại
                        int TotalPhoneImportPrice = 0;
                        foreach (DataRow row in dtPhoneImport.Rows)
                        {
                            TotalPhoneImportPrice += (int)row["SOLUONG"] * (int)row["DONGIA"];
                        }

                        // tính tổng tiền nhập laptop
                        int TotalLaptopImportPrice = 0;
                        foreach (DataRow row in dtLaptopImport.Rows)
                        {
                            TotalLaptopImportPrice += (int)row["SOLUONG"] * (int)row["DONGIA"];
                        }

                        // tính tổng tiền bán điện thoại
                        int TotalPhoneExportPrice = 0;
                        foreach (DataRow row in dtPhoneExport.Rows)
                        {
                            TotalPhoneExportPrice += (int)row["TONGTIEN"];
                        }

                        // tính tổng tiền bán laptop
                        int TotalLaptopExportPrice = 0;
                        foreach (DataRow row in dtLaptopExport.Rows)
                        {
                            TotalLaptopExportPrice += (int)row["TONGTIEN"];
                        }

                        int TotalImport = TotalPhoneImportPrice + TotalLaptopImportPrice;

                        int TotalExport = TotalPhoneExportPrice + TotalLaptopExportPrice;

                        // dựng biểu đồ cột
                        string SeriesImport = "Tổng tiền nhập";
                        ChartImportAndExport.Series.Add(SeriesImport);

                        ChartImportAndExport.Series[SeriesImport].Points.AddXY(SeriesImport, TotalImport);
                        ChartImportAndExport.Series[SeriesImport]["PointWidth"] = "0.5";

                        string SeriesExport = "Tổng tiền bán";
                        ChartImportAndExport.Series.Add(SeriesExport);

                        ChartImportAndExport.Series[SeriesExport].Points.AddXY(SeriesExport, TotalExport);
                        ChartImportAndExport.Series[SeriesExport]["PointWidth"] = "0.5";

                        ChartImportAndExport.AlignDataPointsByAxisLabel();

                        // dựng biểu đồ tròn:
                        // biểu đồ tròn Nhập sản phẩm

                        string SeriesImport_Pie = "Tiền nhập";
                        ChartImport.Series.Add(SeriesImport_Pie);

                        ChartImport.Series[SeriesImport_Pie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        ChartImport.Series[SeriesImport_Pie].Points.AddXY("Tiền nhập điện thoại", TotalPhoneImportPrice);
                        ChartImport.Series[SeriesImport_Pie].Points.AddXY("Tiền nhập laptop", TotalLaptopImportPrice);
                        ChartImport.Series[SeriesImport_Pie].IsValueShownAsLabel = true;
                        ChartImport.Series[SeriesImport_Pie].Label = "#PERCENT\n#VALX";

                        // biểu đồ tròn Bán sản phẩm
                        string SeriesExport_Pie = "Tiền nhập";
                        ChartExport.Series.Add(SeriesExport_Pie);

                        ChartExport.Series[SeriesExport_Pie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        ChartExport.Series[SeriesExport_Pie].Points.AddXY("Tiền bán điện thoại", TotalPhoneExportPrice);
                        ChartExport.Series[SeriesExport_Pie].Points.AddXY("Tiền bán laptop", TotalLaptopExportPrice);
                        ChartExport.Series[SeriesExport_Pie].IsValueShownAsLabel = true;
                        ChartExport.Series[SeriesExport_Pie].Label = "#PERCENT\n#VALX";
                    }

                    break;
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

                        PanelEnterValue_1.Visible = true;
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

        
    }
}
