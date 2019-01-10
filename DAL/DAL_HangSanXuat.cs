using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_HangSanXuat : DAL_DBConnect
    {
        public DataTable DAL_GetListManufacturers()
        {
            DataTable dt = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetHangSanXuat", _conn)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    _conn.Open();

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
    }
}
