﻿using System;
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

        public DataTable DAL_GetProductSoldByOption(DateTime from, DateTime to, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetSanPhamDaBanTheoTuyChon", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);
                    cmd.Parameters.AddWithValue("@TuNgay", from);
                    cmd.Parameters.AddWithValue("@DenNgay", to);

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

        // lấy danh sách các sản phẩm được nhập

        public DataTable DAL_GetListProductImportByYear(int Year, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetDanhSachSanPhamNhapTrongNam", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);
                    cmd.Parameters.AddWithValue("@Nam", Year);

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

        public DataTable DAL_GetListProductImportByMonth(int Year, int Month, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetDanhSachSanPhamNhapTrongThang", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);
                    cmd.Parameters.AddWithValue("@Nam", Year);
                    cmd.Parameters.AddWithValue("@Thang", Month);

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

        public DataTable DAL_GetListProductImportByWeek(int Year, int Week, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetDanhSachSanPhamNhapTrongTuan", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);
                    cmd.Parameters.AddWithValue("@Nam", Year);
                    cmd.Parameters.AddWithValue("@Tuan", Week);

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

        public DataTable DAL_GetListProductImportByDate(int Year, int Month, int Day, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetDanhSachSanPhamNhapTrongNgay", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);
                    cmd.Parameters.AddWithValue("@Nam", Year);
                    cmd.Parameters.AddWithValue("@Thang", Month);
                    cmd.Parameters.AddWithValue("@Ngay", Day);

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

        public DataTable DAL_GetListProductImportByOption(DateTime from, DateTime to, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetDanhSachSanPhamNhapTuyChon", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);
                    cmd.Parameters.AddWithValue("@TuNgay", from);
                    cmd.Parameters.AddWithValue("@DenNgay", to);

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

        // lấy danh sách các sản phẩm được bán 

        public DataTable DAL_GetListProductExportByYear(int Year, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetDanhSachSanPhamXuatTrongNam", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);
                    cmd.Parameters.AddWithValue("@Nam", Year);

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

        public DataTable DAL_GetListProductExportByMonth(int Year, int Month, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetDanhSachSanPhamXuatTrongThang", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);
                    cmd.Parameters.AddWithValue("@Nam", Year);
                    cmd.Parameters.AddWithValue("@Thang", Month);

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

        public DataTable DAL_GetListProductExportByWeek(int Year, int Week, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetDanhSachSanPhamXuatTrongTuan", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);
                    cmd.Parameters.AddWithValue("@Nam", Year);
                    cmd.Parameters.AddWithValue("@Tuan", Week);

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

        public DataTable DAL_GetListProductExportByDate(int Year, int Month, int Day, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetDanhSachSanPhamXuatTrongNgay", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);
                    cmd.Parameters.AddWithValue("@Nam", Year);
                    cmd.Parameters.AddWithValue("@Thang", Month);
                    cmd.Parameters.AddWithValue("@Ngay", Day);

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

        public DataTable DAL_GetListProductExportByOption(DateTime from, DateTime to, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetDanhSachSanPhamXuatTuyChon", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);
                    cmd.Parameters.AddWithValue("@TuNgay", from);
                    cmd.Parameters.AddWithValue("@DenNgay", to);

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
