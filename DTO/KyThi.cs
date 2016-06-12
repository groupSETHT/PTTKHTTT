using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class KyThi
    {
        public  string _makythi{set; get;}
        public string _tenkythi { set; get; }
        public string _ngaythi { set; get; }
        public string _giothi { set; get; }
        public string _maphongthi { set; get; }
        public string _madethi { set; get; }
        public string _maloaidethi { set; get; }
        public string _malop { set; get; }
        public string _maloaikythi { set; get; }

        public KyThi(string makythi, string tenkythi, string maloaidethi, string madethi, string malop, string ngaythi, string giothi, string maphongthi, string maloaikythi)
        {
            this._makythi = makythi;
            this._tenkythi = tenkythi;
            this._ngaythi = ngaythi;
            this._giothi = giothi;
            this._maphongthi = maphongthi;
            this._madethi = madethi;
            this._maloaidethi = maloaidethi;
            this._malop = malop;
            this._maloaikythi = maloaikythi;
        }

    }
}
