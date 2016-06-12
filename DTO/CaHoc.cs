using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CaHoc
    {
        public string _maca { get; set; }
        public string _tenca { get; set; }
        public string _giobatdau { get; set; }
        public string _gioketthuc { get; set; }
        public CaHoc()
        {
        }
        public CaHoc(string maca,string tenca,string giobatdau,string gioketthuc)
        {
            this._maca = maca;
            this._tenca = tenca;
            this._giobatdau = giobatdau;
            this._gioketthuc = gioketthuc;
        }
    }
}
