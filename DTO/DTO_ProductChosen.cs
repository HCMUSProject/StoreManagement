using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ProductChosen
    {
        private int _ProductID;
        private int _ProductPrice;
        private int _ProductQuantity;

        public int ProductID { get => _ProductID; set => _ProductID = value; }
        public int ProductPrice { get => _ProductPrice; set => _ProductPrice = value; }
        public int ProductQuantity { get => _ProductQuantity; set => _ProductQuantity = value; }
    }
}
