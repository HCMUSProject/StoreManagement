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
    public class DAL_KhuyenMai : DAL_DBConnect
    {
        public DataTable DAL_GetAllPromotionNow(DateTime dateNow)
        {
            DataTable dt = null;

            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetTatCaKhuyenMaiHienCo", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@NgayHienTai", dateNow);

                    dt = new DataTable();

                    dt.Load(cmd.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }

        public DataTable DAL_GetAllPromotionNotDeleted()
        {
            DataTable dt = null;

            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetTatCaCacKhuyenMaiChuaXoa", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {

                    dt = new DataTable();

                    dt.Load(cmd.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }

        public bool DAL_AddNewPromotion(DTO_Promotion promotion)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("ThemKhuyenMaiMoi", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@TenKM", promotion.PromotionName);
                    cmd.Parameters.AddWithValue("@PhanTram", promotion.PromotionPercent);
                    cmd.Parameters.AddWithValue("@TienToiDa", promotion.PromotionMaxDiscount);
                    cmd.Parameters.AddWithValue("@NgayBatDau", promotion.PromotionBeginDate);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", promotion.PromotionEndDate);

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

        public bool DAL_EditPromotion(DTO_Promotion promotion)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("SuaKhuyenMai", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@MaKM", promotion.PromotionID);
                    cmd.Parameters.AddWithValue("@TenKM", promotion.PromotionName);
                    cmd.Parameters.AddWithValue("@PhanTram", promotion.PromotionPercent);
                    cmd.Parameters.AddWithValue("@TienToiDa", promotion.PromotionMaxDiscount);
                    cmd.Parameters.AddWithValue("@NgayBatDau", promotion.PromotionBeginDate);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", promotion.PromotionEndDate);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
            return true;
        }

        public bool DAL_DeletePromotion(int PromotionID)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("XoaKhuyenMai", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {

                    cmd.Parameters.AddWithValue("@MaKM", PromotionID);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
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
