using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuongTrinhHoc
    {
        public string _machuongtrinhhoc { get; set; }
        public string _chuongtrinhhoc { get; set; }
        public string _matrinhdo { get; set; }
        public string _makhoahoc { get; set; }
        public double _hocphi { get; set; }
        public ChuongTrinhHoc()
        {
        }
        public ChuongTrinhHoc(string machuongtrinhhoc, string chuongtrinhhoc, string matrinhdo, string makhoahoc, double hocphi)
        {
            this._machuongtrinhhoc = machuongtrinhhoc;
            this._chuongtrinhhoc = chuongtrinhhoc;
            this._matrinhdo = matrinhdo;
            this._makhoahoc = makhoahoc;
            this._hocphi = hocphi;
        }
    }
}
