using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_LoaiSanPham : DAL_DBConnect
    {
        public DataTable DAL_GetCategories()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand("GetLoaiSanPham",_conn) {
                                        CommandType = CommandType.StoredProcedure})
                {
                    _conn.Open();

                    dt.Load(cmd.ExecuteReader());
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }

            return dt;
        }
    }
}
