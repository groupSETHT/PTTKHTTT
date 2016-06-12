using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVien
    {
        public string _magv { get; set; }
        public string _tengv { get; set; }
        public string _ngaysinh { get; set; }
        public string _gioitinh { get; set; }
        public string _sdt { get; set; }
        public string _diachi { get; set; }
        public GiangVien()
        {

        }
        public GiangVien(string magv, string tengv, string ngaysinh, string gioitinh, string sdt, string diachi)
        {
            this._magv = magv;
            this._tengv = tengv;
            this._ngaysinh = ngaysinh;
            this._gioitinh = gioitinh;
            this._sdt = sdt;
            this._diachi = diachi;
        }
    }
}
