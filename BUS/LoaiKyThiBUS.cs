using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class LoaiKyThiBUS
    {
        LoaiKyThiDAO objLoaiKyThi = new LoaiKyThiDAO();
        public DataTable GetAllLoaiKyThi()
        {
            return objLoaiKyThi.GetAllLoaiKyThi();
        }
        public bool AddLoaiKyThi(LoaiKyThi lkt)
        {
            return objLoaiKyThi.AddLoaiKyThi(lkt);
        }
        public bool EditLoaiKyThi(LoaiKyThi lkt)
        {
            return objLoaiKyThi.EditLoaiKyThi(lkt);
        }
        public bool DeleteLoaiKyThi(string malkt)
        {
            return objLoaiKyThi.DeleteLoaiKyThi(malkt);
        }
        public string NextID()
        {
            return objLoaiKyThi.NextID_LoaiKyThi();
        }
        public string GetMa_TheoTen_LoaiKyThi(string ten)
        {
            return objLoaiKyThi.GetMa_TheoTen(ten);
        }
    }
}
