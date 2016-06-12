using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongHoc
    {

        public string _maphong { get; set; }
        public string _tenphong { get; set; }
        public string _diadiem { get; set; }
        public PhongHoc() { }

        public PhongHoc(string maphong, string tenphong, string diadiem)
        {
            // TODO: Complete member initialization
            this._maphong = maphong;
            this._tenphong = tenphong;
            this._diadiem = diadiem;
        }

    }
}
