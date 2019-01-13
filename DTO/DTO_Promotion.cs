using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Promotion
    {
        private int _PromotionID;
        private string _PromotionName;
        private int _PromotionPercent;
        private int _PromotionMaxDiscount;
        private DateTime _PromotionBeginDate;
        private DateTime _PromotionEndDate;

        public int PromotionID { get => _PromotionID; set => _PromotionID = value; }
        public string PromotionName { get => _PromotionName; set => _PromotionName = value; }
        public int PromotionPercent { get => _PromotionPercent; set => _PromotionPercent = value; }
        public int PromotionMaxDiscount { get => _PromotionMaxDiscount; set => _PromotionMaxDiscount = value; }
        public DateTime PromotionBeginDate { get => _PromotionBeginDate; set => _PromotionBeginDate = value; }
        public DateTime PromotionEndDate { get => _PromotionEndDate; set => _PromotionEndDate = value; }

        public int CalcDiscount(int Money)
        {
            int Discount = 0;

            if (PromotionPercent == 0)
            {
                // nếu phần trăm bằng 0 tức là giảm giá theo số tiền
                Discount = PromotionMaxDiscount;
            }
            else
            {
                // nếu phần trăm khác 0 tức là giảm giá theo phần trăm
                Discount = Convert.ToInt32(Math.Ceiling((float)Money * PromotionPercent / 100));

                if (PromotionMaxDiscount != 0 && Discount > PromotionMaxDiscount)
                {
                    Discount = PromotionMaxDiscount;
                }
            }

            return Money - Discount;
        }
    }
}
