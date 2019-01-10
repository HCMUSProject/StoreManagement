using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Manufacturer
    {
        private int _ManufacturerID;
        private string _ManufacturerName;

        public int ManufacturerID { get => _ManufacturerID; set => _ManufacturerID = value; }
        public string ManufacturerName { get => _ManufacturerName; set => _ManufacturerName = value; }
    }
}
