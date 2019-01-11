using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Cart
    {
        private static DTO_Cart _ShopCart = null;

        private List<int> _listProductChoose = new List<int>();

        public static DTO_Cart ShopCart {
            get
            {
                if (_ShopCart == null)
                {
                    _ShopCart = new DTO_Cart();
                }
                return _ShopCart;
            }
        }
        //public List<int> ListProductChoose { get => _listProductChoose; }

        public void AddNewProduct(int ProductID)
        {
            this._listProductChoose.Add(ProductID);
        }

        public void RemoveProduct(int ProductID)
        {
            this._listProductChoose.Remove(ProductID);
        }

        public void Clear()
        {
            this._listProductChoose.Clear();
        }
    }
}
