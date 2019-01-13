using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_BaoCao
    {
        DAL_BaoCao dal_Statistics = new DAL_BaoCao();

        public DataTable BUS_GetProductsSoldByYear(int Year, int CategoryID)
        {
            return dal_Statistics.DAL_GetProductsSoldByYear(Year, CategoryID);
        }

        public DataTable BUS_GetProductsSoldByMonth(int Year, int Month, int CategoryID)
        {
            return dal_Statistics.DAL_GetProductsSoldByMonth(Year, Month, CategoryID);
        }

        public DataTable BUS_GetProductsSoldByWeek(int Year, int Week, int CategoryID)
        {
            return dal_Statistics.DAL_GetProductsSoldByWeek(Year, Week, CategoryID);
        }

        public DataTable BUS_GetProductsSoldByDay(int Year, int Month, int Day, int CategoryID)
        {
            return dal_Statistics.DAL_GetProductsSoldByDay(Year, Month, Day, CategoryID);
        }
    }
}
