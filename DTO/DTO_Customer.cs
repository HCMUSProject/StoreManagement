using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Customer
    {
        private string _CustomerName;
        private string _CustomerID;
        private string _CustomerPhone;
        private string _CustomerAddress;

        public string CustomerName { get => _CustomerName; set => _CustomerName = value; }
        public string CustomerID { get => _CustomerID; set => _CustomerID = value; }
        public string CustomerPhone { get => _CustomerPhone; set => _CustomerPhone = value; }
        public string CustomerAddress { get => _CustomerAddress; set => _CustomerAddress = value; }
    }
}
