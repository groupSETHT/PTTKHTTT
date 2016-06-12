using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDeThi
    {
        public string _maloaidethi { get; set; }
        public string _tenloaidethi { get; set; }
        public  int _thoiluongdethi { get; set; }

        public LoaiDeThi() { }
        public LoaiDeThi(string maloaidethi, string tenloaidethi, int thoiluongthi)
        {
            this._maloaidethi = maloaidethi;
            this._tenloaidethi = tenloaidethi;
            this._thoiluongdethi = thoiluongthi;
        }

    }
}
