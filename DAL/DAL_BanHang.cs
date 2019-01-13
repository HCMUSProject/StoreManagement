using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_BanHang : DAL_DBConnect
    {
        public bool DAL_AddSellingHistory(DTO_Customer customer, DateTime SellingDate, int TotalPrice)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("ThemLichSuBanHang", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@NgayBan", SellingDate);
                    cmd.Parameters.AddWithValue("@TongTien", TotalPrice);
                    cmd.Parameters.AddWithValue("@TenKH", customer.CustomerName);
                    cmd.Parameters.AddWithValue("@CMND", customer.CustomerID);
                    cmd.Parameters.AddWithValue("@SDT", customer.CustomerPhone);
                    cmd.Parameters.AddWithValue("@DiaChi", customer.CustomerAddress);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
            return true;
        }

        public DataTable DAL_GetSellingHistoryByDate(DateTime date)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetLichSuBanHangTheoNgay", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@NgayBan", date);

                    dt = new DataTable();

                    dt.Load(cmd.ExecuteReader());
                }

            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                _conn.Close();
            }

            return dt;
        }

        public bool DAL_AddProductChosenToDetailOrder(int ID_SellingHistory, DTO_ProductChosen product)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("ThemChiTietDonHang", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@ID_LichSuBanHang", ID_SellingHistory);
                    cmd.Parameters.AddWithValue("@ID_MaSP", product.ProductID);
                    cmd.Parameters.AddWithValue("@SoLuong", product.ProductQuantity);
                    cmd.Parameters.AddWithValue("@DonGia", product.ProductPrice);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
            return true;
        }

        public bool DAL_AddPromotionToOrder(int ID_SellingHistory, int ID_Promotion)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("ThemChiTietKhuyenMai", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@MaLichSuBanHang", ID_SellingHistory);
                    cmd.Parameters.AddWithValue("@MaKhuyenMai", ID_Promotion);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
            return true;
        }
    }
}
