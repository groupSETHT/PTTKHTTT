using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiKyThi
    {
        public string _maloaikythi { set; get; }
        public string _tenloaikythi { set; get; }

        public LoaiKyThi() { }
        public LoaiKyThi(string maloaikythi, string tenloaikythi)
        {
            this._maloaikythi = maloaikythi;
            this._tenloaikythi = tenloaikythi;
        }
    }
}
