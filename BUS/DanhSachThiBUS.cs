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
    public  class DanhSachThiBUS
    {
        DanhSachThiDAO objDanhSachThi = new DanhSachThiDAO();
        public DataTable GetAllDanhSachThi_TheoKyThi(string makythi)
        {
            return objDanhSachThi.GetAllDanhSachThi_TheoKyThi(makythi);
        }
        public bool EditDiemDanhSachThi(DanhSachThi dst)
        {
            return objDanhSachThi.EditDanhSachThi(dst);
        }
        public bool EditDanhSachThi(DanhSachThi dst)
        {
            return objDanhSachThi.EditDanhSachThi(dst);
        }
        public bool AddDanhSachThi(DanhSachThi dst)
        {
            return objDanhSachThi.AddDanhSachThi(dst);
        }
        public bool CheckHV_DaCoDiem_DanhSachThi(string mahv)
        {
            return objDanhSachThi.CheckHV_DaCoDiem(mahv);
        }
    }
}
