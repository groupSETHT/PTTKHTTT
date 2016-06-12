using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
    public class LoaiDeThiBUS
    {
        LoaiDeThiDAO objLoaiDeThi = new LoaiDeThiDAO();
        public bool AddLoaiDeThi(LoaiDeThi objloaidethi)
        {
            return objLoaiDeThi.AddLoaiDeThi(objloaidethi);
        }
        public bool EditLoaiDeThi(LoaiDeThi objloaidethi)
        {
            return objLoaiDeThi.EditLoaiDeThi(objloaidethi);
        }
        public bool DeleteLoaiDeThi(string maloaidethi)
        {
            return objLoaiDeThi.DeleteLoaiDeThi(maloaidethi);
        }
        public DataTable GetAllLoaiDeThi()
        {
            return objLoaiDeThi.GetAllLoaiDeThi();
        }
        public string Next_ID_LoaiKyThi()
        {
            return objLoaiDeThi.NextID_LoaiKyThi();
        }
        public string GetMa_TheoTen_LoaiDeThi(string ten)
        {
            return objLoaiDeThi.GetMa_TheoTen(ten);
        }
        public string GetTen_TheoMa_LoaiDeThi(string ma)
        {
            return objLoaiDeThi.GetTen_TheoMa(ma);
        }
    }
}
