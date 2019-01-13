using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_BaoCao : DAL_DBConnect
    {
        public DataTable DAL_GetProductsSoldByYear(int Year, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetSanPhamDaBanTheoNam", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@Nam", Year);
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);

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

        public DataTable DAL_GetProductsSoldByMonth(int Year, int Month, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetSanPhamDaBanTheoThang", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@Nam", Year);
                    cmd.Parameters.AddWithValue("@Thang", Month);
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);

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

        public DataTable DAL_GetProductsSoldByWeek(int Year, int Week, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetSanPhamDaBanTheoTuan", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@Nam", Year);
                    cmd.Parameters.AddWithValue("@Tuan", Week);
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);

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

        public DataTable DAL_GetProductsSoldByDay(int Year, int Month, int Day, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetSanPhamDaBanTheoNgay", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@Nam", Year);
                    cmd.Parameters.AddWithValue("@Thang", Month);
                    cmd.Parameters.AddWithValue("@Ngay", Day);
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);

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
    }
}
