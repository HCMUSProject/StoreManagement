using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_LoaiSanPham
    {
        DAL_LoaiSanPham dal_Categories = new DAL_LoaiSanPham();

        public DataTable BUS_GetCategories()
        {
            return dal_Categories.DAL_GetCategories();
        }
    }
}
