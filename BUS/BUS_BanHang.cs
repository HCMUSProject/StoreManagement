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
    public class BUS_BanHang
    {
        DAL_BanHang dal_SellProducts = new DAL_BanHang();

        
        public bool BUS_InsertNewOrder(DTO_Customer customer, List<DTO_ProductChosen> listProductChosen, DateTime SellingDate, int TotalPrice, List<DTO_Promotion> promotions)
        {
            // thêm vào lịch sử bán hàng
            bool res = dal_SellProducts.DAL_AddSellingHistory(customer, SellingDate, TotalPrice);

            if (res == false)
            {
                return false;
            }

            // lấy ra ID_LICHSUBANHANG gần đây nhất
            DataTable dtSellingHistory = dal_SellProducts.DAL_GetSellingHistoryByDate(SellingDate);

            if (dtSellingHistory == null)
            {
                return false;
            }

            int ID_SellingHistory = -1;

            if (dtSellingHistory.Rows.Count > 0)
            {
                // lấy dòng đầu tiên
                ID_SellingHistory = (int)dtSellingHistory.Rows[0]["ID_LICHSUBANHANG"];
            }
            else
            {
                return false;
            }
            
            // thêm từng sản phẩm vào kho

            foreach(var productChosen in listProductChosen)
            {
                bool result = dal_SellProducts.DAL_AddProductChosenToDetailOrder(ID_SellingHistory, productChosen);

                if (result == true)
                {
                    // update lại số lượng sản phẩm này trong database
                    DAL_SanPham dal_Product = new DAL_SanPham();

                    bool res1 = dal_Product.DAL_UpdateProductQuantityAfterSale(productChosen.ProductID, 
                        productChosen.ProductQuantity);
                }
            }

            // thêm khuyến mãi vào chi tiết khuyến mãi
            foreach(var promo in promotions)
            {
                int ID_Promotion = promo.PromotionID;
                bool result = dal_SellProducts.DAL_AddPromotionToOrder(ID_SellingHistory, ID_Promotion);
            }

            return true;
        }

        // lưu thông tin khách hàng vào database - > có mã khách hàng

        // lưu dữ liệu vào bảng lịch sử bán hàng - > có id lịch sử
        // thêm vào bảng khuyến mãi
        // thêm vào bảng chi tiết đon hàng

    }
}
