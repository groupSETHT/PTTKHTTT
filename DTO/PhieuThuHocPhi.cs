using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThuHocPhi
    {
        public string _maphieuthu { get; set; }
        public string _mahv { get; set; }
        public double _hocphi { get; set; }
        public double _sotiendong { get; set; }
        public double _conno { get; set; }
        public string _ngaydong { get; set; }

        public PhieuThuHocPhi()
        {

        }
        public PhieuThuHocPhi(string maphieuthu,string mahv,double hocphi, double sotiendong, double conno,string ngaydong)
        {
            _maphieuthu = maphieuthu;
            _mahv = mahv;
            _hocphi = hocphi;
            _sotiendong = sotiendong;
            _conno = conno;
            _ngaydong = ngaydong;
        }

    }
}
