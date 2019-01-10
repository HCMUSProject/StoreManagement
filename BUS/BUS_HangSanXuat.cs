using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_HangSanXuat
    {
        DAL_HangSanXuat dal_Manufacturer = new DAL_HangSanXuat();
        public DataTable BUS_GetManufacturers()
        {
            return dal_Manufacturer.DAL_GetListManufacturers();
        }
    }
}
