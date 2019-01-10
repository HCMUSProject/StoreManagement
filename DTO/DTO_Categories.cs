using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Categories
    {
        private int _CategoryID;
        private string _CategoryName;

        public int CategoryID { get => _CategoryID; set => _CategoryID = value; }
        public string CategoryName { get => _CategoryName; set => _CategoryName = value; }
    }
}
