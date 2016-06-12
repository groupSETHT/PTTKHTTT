using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhSachThi
    {
        public string _makithi;
        public string _mahv;
        public float _ketquathi;

        public DanhSachThi() { }
        public DanhSachThi(string makithi, string mahv, float ketquathi)
        {
            this._makithi = makithi;
            this._mahv = mahv;
            this._ketquathi = ketquathi;
        }
    }
}
