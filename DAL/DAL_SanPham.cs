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
    public class DAL_SanPham : DAL_DBConnect
    {
        public DataTable DAL_GetProductByCategoryID(int nCategoryID)
        {
            DataTable dt = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("GetSanPhamTheoLoai", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    _conn.Open();

                    cmd.Parameters.AddWithValue("@MaLoai", nCategoryID);

                    dt = new DataTable();

                    dt.Load(cmd.ExecuteReader());
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }

        public int DAL_GetCount_Products(int nCategoryID)
        {
            int nCount_Products = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetSoLuongSanPhamTheoDanhMuc", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    _conn.Open();

                    cmd.Parameters.AddWithValue("@MaLoai", nCategoryID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    nCount_Products = reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return nCount_Products;
        }

        public DataTable DAL_GetProductInfoByID(int ProductID)
        {
            DataTable dt = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetThongTinSanPhamBangID", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    _conn.Open();

                    cmd.Parameters.AddWithValue("@MaSP", ProductID);

                    dt = new DataTable();

                    dt.Load(cmd.ExecuteReader());
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }

        public DataTable DAL_GetDetailProductByID(int ProductID)
        {
            DataTable dt = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetCauHinhSanPham", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    _conn.Open();

                    cmd.Parameters.AddWithValue("@MaSP", ProductID);

                    dt = new DataTable();

                    dt.Load(cmd.ExecuteReader());
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }

        public bool DAL_DeleteProductByID(int ProductID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("XoaSanPhamBangID", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    _conn.Open();
                    cmd.Parameters.AddWithValue("@MaSP", ProductID);

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

        public bool DAL_AddNewProduct(DTO_Product product)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("ThemMoiSanPham", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    _conn.Open();

                    cmd.Parameters.AddWithValue("@MaLoai", product.CategoryID);
                    cmd.Parameters.AddWithValue("@MaHangSX", product.ManufacturerID);
                    cmd.Parameters.AddWithValue("@TenSP", product.ProductName);
                    cmd.Parameters.AddWithValue("@DonGia", product.ProductPrice);
                    cmd.Parameters.AddWithValue("@SoLuong", product.ProductQuantity);
                    cmd.Parameters.AddWithValue("@HinhAnh", product.ProductImage);

                    
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

        public DataTable DAL_GetProductInfoByIDAndName(string ProductName, int CategoryID)
        {
            DataTable dt = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetSanPhamTheoTenVaMaLoai", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    _conn.Open();

                    cmd.Parameters.AddWithValue("@TenSP", ProductName);
                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);

                    dt = new DataTable();

                    dt.Load(cmd.ExecuteReader());
                }
            }
            catch(Exception ex)
            {
                dt = null;
            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }

        public bool DAL_AddProductProfile(DTO_ProductProfile productProfile)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("ThemChiTietCauHinhSanPham", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    _conn.Open();

                    cmd.Parameters.AddWithValue("@MaSP", productProfile.ProductID);
                    cmd.Parameters.AddWithValue("@CPU", productProfile.CPU);
                    cmd.Parameters.AddWithValue("@GPU", productProfile.GPU);
                    cmd.Parameters.AddWithValue("@RAM", productProfile.RAM);
                    cmd.Parameters.AddWithValue("@BoNho", productProfile.Storage);
                    cmd.Parameters.AddWithValue("@ManHinh", productProfile.Screen);
                    cmd.Parameters.AddWithValue("@Camera", productProfile.Camera);
                    cmd.Parameters.AddWithValue("@Pin", productProfile.PIN);
                    cmd.Parameters.AddWithValue("@HeDieuHanh", productProfile.OS);
                    cmd.Parameters.AddWithValue("@Khac", productProfile.More);

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

        public DataTable DAL_GetAllProductInfoByID(int ProductID)
        {
            DataTable dt = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetTatCaThongTinSanPhamBangID", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    _conn.Open();

                    cmd.Parameters.AddWithValue("@MaSP", ProductID);

                    dt = new DataTable();

                    dt.Load(cmd.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }

        public DataTable DAL_GetProductInfoByCategoryIDAndTypeSort(int CategoryID, int TypeSort)
        {
            DataTable dt = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetThongTinSanPhamTheoLoaiVaCachSapXep", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    _conn.Open();

                    cmd.Parameters.AddWithValue("@MaLoai", CategoryID);
                    cmd.Parameters.AddWithValue("@CachSapXep", TypeSort);

                    dt = new DataTable();

                    dt.Load(cmd.ExecuteReader());
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }

        public bool DAL_AddProduct_History(int ProductID, int Price, int Quantity, DateTime AdditionDate)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("ThemLichSuNhapKho", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@MaSP", ProductID);
                    cmd.Parameters.AddWithValue("@SoLuong", Quantity);
                    cmd.Parameters.AddWithValue("@DonGia", Price);
                    cmd.Parameters.AddWithValue("@NgayNhap", AdditionDate);

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

        public bool DAL_UpdateProductInfoAndProfile(DTO_Product product, DTO_ProductProfile productProfile)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("UpdateThongTinVaCauHinhSanPham", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    // product
                    cmd.Parameters.AddWithValue("@MaSP", product.ID);
                    cmd.Parameters.AddWithValue("@MaLoai", product.CategoryID);
                    cmd.Parameters.AddWithValue("@MaHangSX", product.ManufacturerID);
                    cmd.Parameters.AddWithValue("@TenSP", product.ProductName);
                    cmd.Parameters.AddWithValue("@DonGia", product.ProductPrice);
                    cmd.Parameters.AddWithValue("@HinhAnh", product.ProductImage);

                    // product profile
                    cmd.Parameters.AddWithValue("@Id_ChiTietCauHinh", productProfile.IDProductProfile);
                    cmd.Parameters.AddWithValue("@CPU", productProfile.CPU);
                    cmd.Parameters.AddWithValue("@GPU", productProfile.GPU);
                    cmd.Parameters.AddWithValue("@RAM", productProfile.RAM);
                    cmd.Parameters.AddWithValue("@BoNho", productProfile.Storage);
                    cmd.Parameters.AddWithValue("@ManHinh", productProfile.Screen);
                    cmd.Parameters.AddWithValue("@Camera", productProfile.Camera);
                    cmd.Parameters.AddWithValue("@Pin", productProfile.PIN);
                    cmd.Parameters.AddWithValue("@HeDieuHanh", productProfile.OS);
                    cmd.Parameters.AddWithValue("@Khac", productProfile.More);

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

        public bool DAL_UpdateProductQuantityAfterSale(int ProductID, int QuantitySold)
        {
            try
            {
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("CapNhatSoLuongSanPhamSauKhiBan", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    cmd.Parameters.AddWithValue("@MaSP", ProductID);
                    cmd.Parameters.AddWithValue("@SoLuongDaBan", QuantitySold);

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
