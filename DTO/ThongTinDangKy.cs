using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinDangKy
    {
        public string _mahv { get; set; }
        public string _ngaydangky { get; set; }
        public string _trangthai { get; set; }
        public int _soluongcuochen { get; set; }
        public string _mangayranh { get; set; }
        public string _macaranh { get; set; }
        public string _matrinhdohientai { get; set; }
        public string _matrinhdomuonhoc { get; set; }
        public string _matrinhdoduochoc { get; set; }
        public string _makithixeplop { get; set; }
        public ThongTinDangKy() { }
        public ThongTinDangKy(string mahv, string ngaydangky, string trangthai, int soluongcuochen, string mangayranh, string macaranh, string matrinhdohientai, string matrinhdomuonhoc, string matrinhdoduochoc, string makithixeplop)
        {
            this._mahv = mahv;
            this._ngaydangky = ngaydangky;
            this._trangthai = trangthai;
            this._soluongcuochen = soluongcuochen;
            this._mangayranh = mangayranh;
            this._macaranh = macaranh;
            this._matrinhdohientai = matrinhdohientai;
            this._matrinhdomuonhoc = matrinhdomuonhoc;
            this._matrinhdoduochoc = matrinhdoduochoc;
            this._makithixeplop = makithixeplop;
        }
    }
}
