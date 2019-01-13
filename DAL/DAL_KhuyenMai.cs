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
    }
}
