using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocVien
    {
        public string _mahv { get; set; }
        public string _hoten { get; set; }
        public string _phai { get; set; }
        public string _diachi { get; set; }
        public string _sdt { get; set; }
        public string _malop { get; set; }
        public double _nohp { get; set; }

        public HocVien() { }
        public HocVien(string mahv,string hoten,string phai,string diachi,string sdt,string malop,double nohp)
        {
            this._mahv = mahv;
            this._hoten = hoten;
            this._phai = phai;
            this._diachi = diachi;
            this._sdt = sdt;
            this._malop = malop;
            this._nohp = nohp;
        }
    }
}
