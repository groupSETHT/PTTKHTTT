using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhSachLop
    {
        public string _malop { get; set; }
        public string _mahv { get; set; }
        public string _ketquathicuoikhoa { get; set; }
        public double _dadonghocphi { get; set; }
        public DanhSachLop()
        {
        }
        public DanhSachLop(string malop, string mahv, string ketquathicuoikhoa, double dadonghocphi)
        {
            this._malop = malop;
            this._mahv = mahv;
            this._ketquathicuoikhoa = ketquathicuoikhoa;
            this._dadonghocphi = dadonghocphi;
        }
    }
}
