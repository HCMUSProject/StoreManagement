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
    public class BUS_SanPham
    {
        private DAL_SanPham dal_Products = new DAL_SanPham();

        public DataTable BUS_GetProduct(int nCategoryID = -1)
        {
            return dal_Products.DAL_GetProductByCategoryID(nCategoryID);
        }

        public int BUS_GetCount_Products(int nCategoryID = -1)
        {
            return dal_Products.DAL_GetCount_Products(nCategoryID);
        }

        public DataTable BUS_GetBasicInfo_Products(int ProductID)
        {
            return dal_Products.DAL_GetProductInfoByID(ProductID);
        }

        public DataTable BUS_GetDetail_Product(int ProductID)
        {
            return dal_Products.DAL_GetDetailProductByID(ProductID);
        }

        public bool BUS_DeleteProduct(int ProductID)
        {
            return dal_Products.DAL_DeleteProductByID(ProductID);
        }

        public bool BUS_AddNewProduct(DTO_Product product)
        {
            return dal_Products.DAL_AddNewProduct(product);
        }

        public bool BUS_AddProductProfile(DTO_ProductProfile productProfile)
        {
            return dal_Products.DAL_AddProductProfile(productProfile);
        }

        public DataTable BUS_GetProductInfoByIDAndName(string ProductName, int ProductID)
        {
            return dal_Products.DAL_GetProductInfoByIDAndName(ProductName, ProductID);
        }

        public DataTable BUS_GetAllProductInfoByID(int ProductID)
        {
            return dal_Products.DAL_GetAllProductInfoByID(ProductID);
        }

        public DataTable BUS_GetProductInfoByCategoryIDAndTypeSort(int CategoryID, int TypeSort)
        {
            return dal_Products.DAL_GetProductInfoByCategoryIDAndTypeSort(CategoryID, TypeSort);
        }

        public bool BUS_AddProduct_History(int ProductID, int Price, int Quantity, DateTime AdditionDate)
        {
            return dal_Products.DAL_AddProduct_History(ProductID, Price, Quantity, AdditionDate);
        }

        public bool BUS_UpdateProductInfoAndProfile(DTO_Product product, DTO_ProductProfile productProfile)
        {
            return dal_Products.DAL_UpdateProductInfoAndProfile(product, productProfile);
        }
    }
}
