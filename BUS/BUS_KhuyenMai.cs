using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_KhuyenMai
    {
        DAL_KhuyenMai dal_Promotion = new DAL_KhuyenMai();
        public DataTable BUS_GetAllPromotionNow(DateTime dateNow)
        {
            return dal_Promotion.DAL_GetAllPromotionNow(dateNow);
        }
    }
}
