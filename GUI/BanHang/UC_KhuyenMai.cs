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
    public partial class UC_KhuyenMai : UserControl
    {
        BUS_KhuyenMai bus_Promotion = new BUS_KhuyenMai();

        private static UC_KhuyenMai _ins;
        public static UC_KhuyenMai Instance
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new UC_KhuyenMai();
                }
                return _ins;
            }
        }

        public UC_KhuyenMai()
        {
            InitializeComponent();
        }

        public void XoaDuLieu()
        {
            dtpkStartDay.Value = DateTime.Now;
            dtpkEndDay.Value = DateTime.Now;

            txbPromotionMaxDiscount.Text = "";
            txbPromotionName.Text = "";
            txbPromotionPercent.Text = "";

            BtnAddPromotion.Enabled = true;
            BtnDeletePromotion.Enabled = false;
            BtnEditPromotion.Enabled = false;
        }

        public void ReloadForm()
        {
            this.UC_KhuyenMai_Load(this, EventArgs.Empty);
        }

        private void UC_KhuyenMai_Load(object sender, EventArgs e)
        {
            dtgvPromotion.Rows.Clear();

            // bật tắt các button
            BtnAddPromotion.Enabled = true;
            BtnDeletePromotion.Enabled = false;
            BtnEditPromotion.Enabled = false;

            // load danh sách các khuyến mãi chưa bị xóa vào datagridview

            DataTable dtPromotion = bus_Promotion.BUS_GetAllPromotionNotDeleted();

            if (dtPromotion == null)
            {
                MessageBox.Show("Có lỗi xảy ra trong khi load dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataRow row in dtPromotion.Rows)
            {
                dtgvPromotion.Rows.Add();
                int Index = dtgvPromotion.Rows.Count - 1;
                dtgvPromotion.Rows[Index].Cells["PromotionID"].Value = (int)row["ID_KHUYENMAI"];

                dtgvPromotion.Rows[Index].Cells["PromotionName"].Value = $"{row["TENKHUYENMAI"]} "
                    + $"giảm giá {row["PHANTRAM"]}% tối đa {MySupportMethods.StrMoneyToStrCurrency(row["TIENTOIDA"].ToString())} đồng";

                dtgvPromotion.Rows[Index].Cells["PromotionPercent"].Value = (int)row["PHANTRAM"];

                dtgvPromotion.Rows[Index].Cells["PromotionMaxDiscount"].Value = (int)row["TIENTOIDA"];

                dtgvPromotion.Rows[Index].Cells["StartDay"].Value = (DateTime)row["NGAYBATDAU"];

                dtgvPromotion.Rows[Index].Cells["EndDay"].Value = (DateTime)row["NGAYKETTHUC"];
                // tính toán ngày còn lại

                DateTime now = DateTime.Now;
                if ((DateTime)dtgvPromotion.Rows[Index].Cells["EndDay"].Value < now)
                {
                    dtgvPromotion.Rows[Index].Cells["RemainDay"].Value = (int)0;
                }
                else
                {
                    dtgvPromotion.Rows[Index].Cells["RemainDay"].Value = (int)((DateTime)row["NGAYKETTHUC"] - now).TotalDays;
                }
            }

            // resize columns
            //dtgvPromotion.Columns["RemainDay"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            
        }

        private void dtgvPromotion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // disable nút thêm
            BtnAddPromotion.Enabled = false;
            BtnDeletePromotion.Enabled = true;
            BtnEditPromotion.Enabled = true;

            int idx = e.RowIndex;

            string name = dtgvPromotion.Rows[idx].Cells["PromotionName"].Value.ToString();
            txbPromotionName.Text = name.Substring(0, name.IndexOf(" giảm"));

            txbPromotionPercent.Text = dtgvPromotion.Rows[idx].Cells["PromotionPercent"].Value.ToString();

            txbPromotionMaxDiscount.Text = dtgvPromotion.Rows[idx].Cells["PromotionMaxDiscount"].Value.ToString();

            dtpkStartDay.Value = (DateTime)dtgvPromotion.Rows[idx].Cells["StartDay"].Value;

            dtpkEndDay.Value = (DateTime)dtgvPromotion.Rows[idx].Cells["EndDay"].Value;
        }

        private void UC_KhuyenMai_Click(object sender, EventArgs e)
        {
            this.XoaDuLieu();
        }

        private void BtnAddPromotion_Click(object sender, EventArgs e)
        {
            // kiểm tra các trường có bị rỗng hay không
            if (txbPromotionName.Text.Length == 0 || txbPromotionPercent.Text.Length == 0 || txbPromotionMaxDiscount.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống các trường dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // kiểm tra trong text box có toàn chữ số hay không
            if (MySupportMethods.isNumberic(txbPromotionPercent.Text) == false)
            {
                MessageBox.Show("Phần trăm khuyến mãi chỉ bao gồm các chữ số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // kiểm tra trong text box có toàn chữ số hay không
            if (MySupportMethods.isNumberic(txbPromotionMaxDiscount.Text) == false)
            {
                MessageBox.Show("Số tiền khuyến mãi tối đa chỉ bao gồm các chữ số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // kiểm tra xem phần trăm có nằm trong khoảng từ 0 đến 100 hay không?
            if (int.Parse(txbPromotionPercent.Text) < 0 || int.Parse(txbPromotionPercent.Text) > 100)
            {
                MessageBox.Show("Phần trăm khuyến mãi phải nằm trong đoạn [0, 100]", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // đóng gói thông tin từ text box
            DTO_Promotion promotion = new DTO_Promotion()
            {
                PromotionName = txbPromotionName.Text,
                PromotionMaxDiscount = int.Parse(txbPromotionMaxDiscount.Text),
                PromotionPercent = int.Parse(txbPromotionPercent.Text),
                PromotionBeginDate = dtpkStartDay.Value,
                PromotionEndDate = dtpkEndDay.Value
            };

            // lưu thông tin xuống db
            bool res = bus_Promotion.BUS_AddNewPromotion(promotion);

            if (res == true)
            {
                MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.XoaDuLieu();
                this.ReloadForm();
            }
            else
            {
                MessageBox.Show("Thêm khuyến mãi thất bại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditPromotion_Click(object sender, EventArgs e)
        {
            // kiểm tra các trường có bị rỗng hay không
            if (txbPromotionName.Text.Length == 0 || txbPromotionPercent.Text.Length == 0 || txbPromotionMaxDiscount.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống các trường dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // kiểm tra trong text box có toàn chữ số hay không
            if (MySupportMethods.isNumberic(txbPromotionPercent.Text) == false)
            {
                MessageBox.Show("Phần trăm khuyến mãi chỉ bao gồm các chữ số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // kiểm tra trong text box có toàn chữ số hay không
            if (MySupportMethods.isNumberic(txbPromotionMaxDiscount.Text) == false)
            {
                MessageBox.Show("Số tiền khuyến mãi tối đa chỉ bao gồm các chữ số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // kiểm tra xem phần trăm có nằm trong khoảng từ 0 đến 100 hay không?
            if (int.Parse(txbPromotionPercent.Text) < 0 || int.Parse(txbPromotionPercent.Text) > 100)
            {
                MessageBox.Show("Phần trăm khuyến mãi phải nằm trong đoạn [0, 100]", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // đóng gói thông tin từ text box
            DTO_Promotion promotion = new DTO_Promotion()
            {
                PromotionID = (int)dtgvPromotion.SelectedRows[0].Cells["PromotionID"].Value,
                PromotionName = txbPromotionName.Text,
                PromotionMaxDiscount = int.Parse(txbPromotionMaxDiscount.Text),
                PromotionPercent = int.Parse(txbPromotionPercent.Text),
                PromotionBeginDate = dtpkStartDay.Value,
                PromotionEndDate = dtpkEndDay.Value
            };

            // lưu thông tin xuống db

            bool res = bus_Promotion.BUS_EditPromotion(promotion);

            if (res == false)
            {
                MessageBox.Show("Sửa khuyến mãi thất bại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Sửa khuyến mãi thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.XoaDuLieu();
                this.ReloadForm();
            }

            
        }

        private void BtnDeletePromotion_Click(object sender, EventArgs e)
        {
            int PromotionID = (int)dtgvPromotion.SelectedRows[0].Cells["PromotionID"].Value;

            bool res = bus_Promotion.BUS_DeletePromotion(PromotionID);

            if (res == false)
            {
                MessageBox.Show("Xóa khuyến mãi thất bại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Xóa khuyến mãi thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.XoaDuLieu();
                this.ReloadForm();
            }
        }
    }
}
