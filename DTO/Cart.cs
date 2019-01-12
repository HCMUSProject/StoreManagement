using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Cart
    {
        private static Dictionary<int,int> _listProductIDChosen = new Dictionary<int,int>();

        private Cart()
        {

        }

        public static Dictionary<int, int> GetListProductID()
        {
            return _listProductIDChosen;
        }

        public static void AddNewProduct(int ProductID)
        {
            if (!_listProductIDChosen.ContainsKey(ProductID))
            {
                _listProductIDChosen[ProductID] = 1;
            }
        }

        public static void IncreaseProductQuantityChosen(int ProductID)
        {
            if (_listProductIDChosen.ContainsKey(ProductID))
            {
                _listProductIDChosen[ProductID] += 1;
            }
        }

        public static void DecreaseProductQuantityChosen(int ProductID)
        {
            if (_listProductIDChosen.ContainsKey(ProductID))
            {
                if (_listProductIDChosen[ProductID] > 1)
                {
                    _listProductIDChosen[ProductID] -= 1;
                }
            }
        }

        public static void RemoveProduct(int ProductID)
        {
            _listProductIDChosen.Remove(ProductID);
        }

        public static void Clear()
        {
            _listProductIDChosen.Clear();
        }
    }
}
