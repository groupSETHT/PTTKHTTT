using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop
    {
        public string _malop { get; set; }
        public string _tenlop { get; set; }
        public string _makhoahoc { get; set; }
        public string _machuongtrinhhoc { get; set; }
        public DateTime _ngaybatdau { get; set; }
        public DateTime _ngayketthuc { get; set; }
        public string _maca { get; set; }
        public string _mangay { get; set; }
        public string _magiangvien { get; set; }
        public string _maphonghoc { get; set; }
        public  Lop() { }
        public Lop(string malop,string tenlop, string makhoahoc, string machuongtrinhhoc, DateTime ngaybatdau, DateTime ngayketthuc, string maca, string mangay, string magiangvien, string maphonghoc)
        {
            this._malop = malop;
            this._tenlop = tenlop;
            this._makhoahoc = makhoahoc;
            this._machuongtrinhhoc = machuongtrinhhoc;
            this._ngaybatdau = ngaybatdau;
            this._ngayketthuc = ngayketthuc;
            this._maca = maca;
            this._mangay = mangay;
            this._magiangvien = magiangvien;
            this._maphonghoc = maphonghoc;
        }
    }
}
