using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrinhDo
    {
        public string _matrinhdo { get; set; }
        public string _tentrinhdo { get; set; }
        public string _maloaidethi { get; set; }
        public string _trinhdotienquyet { get; set; }
        public TrinhDo() { }
        public TrinhDo(string matrinhdo,string tentrinhdo,string maloaidethi,string trinhdotienquyet)
        {
            this._matrinhdo = matrinhdo;
            this._tentrinhdo = tentrinhdo;
            this._maloaidethi = maloaidethi;
            this._trinhdotienquyet = trinhdotienquyet;
        }
    }
}
