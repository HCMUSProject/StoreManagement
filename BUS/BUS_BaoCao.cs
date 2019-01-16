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

        public DataTable BUS_GetProductSoldByOption(DateTime from, DateTime to, int CategoryID)
        {
            return dal_Statistics.DAL_GetProductSoldByOption(from, to, CategoryID);
        }

        public DataTable BUS_GetListProductImportByYear(int Year, int CategoryID)
        {
            return dal_Statistics.DAL_GetListProductImportByYear(Year, CategoryID);
        }

        public DataTable BUS_GetListProductImportByMonth(int Year, int Month, int CategoryID)
        {
            return dal_Statistics.DAL_GetListProductImportByMonth(Year, Month, CategoryID);
        }

        public DataTable BUS_GetListProductImportByWeek(int Year, int Week, int CategoryID)
        {
            return dal_Statistics.DAL_GetListProductImportByWeek(Year, Week, CategoryID);
        }

        public DataTable BUS_GetListProductImportByDate(int Year, int Month, int Day, int CategoryID)
        {
            return dal_Statistics.DAL_GetListProductImportByDate(Year, Month, Day, CategoryID);
        }

        public DataTable BUS_GetListProductImportByOption(DateTime from, DateTime to ,int CategoryID)
        {
            return dal_Statistics.DAL_GetListProductImportByOption(from, to, CategoryID);
        }

        // xuất

        public DataTable BUS_GetListProductExportByYear(int Year, int CategoryID)
        {
            return dal_Statistics.DAL_GetListProductExportByYear(Year, CategoryID);
        }

        public DataTable BUS_GetListProductExportByMonth(int Year, int Month, int CategoryID)
        {
            return dal_Statistics.DAL_GetListProductExportByMonth(Year, Month, CategoryID);
        }

        public DataTable BUS_GetListProductExportByWeek(int Year, int Week, int CategoryID)
        {
            return dal_Statistics.DAL_GetListProductExportByWeek(Year, Week, CategoryID);
        }

        public DataTable BUS_GetListProductExportByDate(int Year, int Month, int Day, int CategoryID)
        {
            return dal_Statistics.DAL_GetListProductExportByDate(Year, Month, Day, CategoryID);
        }

        public DataTable BUS_GetListProductExportByOption(DateTime from, DateTime to, int CategoryID)
        {
            return dal_Statistics.DAL_GetListProductExportByOption(from, to, CategoryID);
        }
    }
}
