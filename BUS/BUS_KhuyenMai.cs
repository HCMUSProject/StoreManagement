using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_KhuyenMai
    {
        DAL_KhuyenMai dal_Promotion = new DAL_KhuyenMai();
        public DataTable BUS_GetAllPromotionNow(DateTime dateNow)
        {
            return dal_Promotion.DAL_GetAllPromotionNow(dateNow);
        }

        public DataTable BUS_GetAllPromotionNotDeleted()
        {
            return dal_Promotion.DAL_GetAllPromotionNotDeleted();
        }
        public bool BUS_AddNewPromotion(DTO_Promotion promotion)
        {
            return dal_Promotion.DAL_AddNewPromotion(promotion);
        }
        public bool BUS_EditPromotion(DTO_Promotion promotion)
        {
            return dal_Promotion.DAL_EditPromotion(promotion);
        }
        public bool BUS_DeletePromotion(int PromotionID)
        {
            return dal_Promotion.DAL_DeletePromotion(PromotionID);
        }
    }
}
