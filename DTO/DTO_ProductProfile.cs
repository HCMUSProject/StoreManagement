using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ProductProfile
    {
        private int _IDProductProfile;
        private int _ProductID;
        private string _CPU;
        private string _GPU;
        private string _RAM;
        private string _Storage;
        private string _Screen;
        private string _Camera;
        private string _PIN;
        private string _OS;
        private string _More;

        public int IDProductProfile { get => _IDProductProfile; set => _IDProductProfile = value; }
        public int ProductID { get => _ProductID; set => _ProductID = value; }
        public string CPU { get => _CPU; set => _CPU = value; }
        public string GPU { get => _GPU; set => _GPU = value; }
        public string RAM { get => _RAM; set => _RAM = value; }
        public string Storage { get => _Storage; set => _Storage = value; }
        public string Screen { get => _Screen; set => _Screen = value; }
        public string Camera { get => _Camera; set => _Camera = value; }
        public string PIN { get => _PIN; set => _PIN = value; }
        public string OS { get => _OS; set => _OS = value; }
        public string More { get => _More; set => _More = value; }

        public DTO_ProductProfile()
        {
            this.IDProductProfile = -1;
            this.ProductID = -1;
            this.CPU = "";
            this.GPU = "";
            this.RAM = "";
            this.Storage = "";
            this.Screen = "";
            this.Camera = "";
            this.PIN = "";
            this.OS = "";
            this.More = "";
        }
    }
}
