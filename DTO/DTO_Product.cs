using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Product
    {
        private int _ID;
        private int _CategoryID;
        private int _ManufacturerID;
        private string _ProductName;
        private int _ProductQuantity;
        private int _ProductPrice;
        private Byte[] _ProductImage;

        public int ID { get => _ID; set => _ID = value; }
        public int CategoryID { get => _CategoryID; set => _CategoryID = value; }
        public int ManufacturerID { get => _ManufacturerID; set => _ManufacturerID = value; }
        public string ProductName { get => _ProductName; set => _ProductName = value; }
        public int ProductQuantity { get => _ProductQuantity; set => _ProductQuantity = value; }
        public int ProductPrice { get => _ProductPrice; set => _ProductPrice = value; }
        public byte[] ProductImage { get => _ProductImage; set => _ProductImage = value; }

    }
}
