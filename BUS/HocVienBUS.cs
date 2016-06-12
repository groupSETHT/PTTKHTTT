using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class HocVienBUS 
    {
        HocVienDAO objHocVien = new HocVienDAO();

        public DataTable GetAllHocVien()
        {
            return objHocVien.GetAllHocVien();
        }
        public DataTable GetAllHocVien_ChiTiet()
        {
            return objHocVien.GetAllHocVien_ChiTiet();
        }
        public bool EditHocVien(HocVien hv)
        {
            return objHocVien.EditHocVien(hv);
        }
        public bool DeleteHocVien(string mahv)
        {
            return objHocVien.DeleteHocVien(mahv);
        }
        public bool AddHocVien(HocVien hv)
        {
            return objHocVien.AddHocVien(hv);
        }
        public DataTable FindTenHV(string tenhv)
        {
            return objHocVien.FindTenHV(tenhv);
        }
        public string NextIDHocVien()
        {
            return objHocVien.NextIDHocVien();
        }
        public DataTable GetAllHocVienTiemNang()
        {
            return objHocVien.GetAllHocVienTiemNang();
        }
        public DataTable GetAllHocVienTiemNang_ChiTiet()
        {
            return objHocVien.GetAllHocVienTiemNang_ChiTiet();
        }
        public DataTable GetAllHocVienChinhThuc_ChiTiet()
        {
            return objHocVien.GetAllHocVienChinhThuc_ChiTiet();
        }
        public DataTable GetAllHocVienTheoMaLop(string malop)
        {
            return objHocVien.GetAllHocVienTheoMaLop_ChiTiet(malop);
        }
        public bool Edit_MaLop_HocVien(string mahocvien, string malop)
        {
            return objHocVien.Edit_MaLop_HocVien(mahocvien, malop);
        }
        public DataTable FindTenHV_ChinhThuc(string tenhv)
        {
            return objHocVien.FindTenHV_ChinhThuc(tenhv);
        }
        public DataTable FindTenHV_TiemNang(string tenhv)
        {
            return objHocVien.FindTenHV_TiemNang(tenhv);
        }
        public DataTable FindTenHV_ChinhThuc_TheoMaLop_TenHV(string malop, string tenhv)
        {
            return objHocVien.FindTenHV_ChinhThuc_TheoMaLop_TenHV(malop, tenhv);
        }
        public DataTable FindTenHV_ConNoHP(string tenhv)
        {
            return objHocVien.FindTenHV_ConNoHP(tenhv);
        }
        public DataTable GetAllHocVienConNoHP_ChiTiet()
        {
            return objHocVien.GetAllHocVienConNoHP_ChiTiet();
        }
        public bool Edit_NoHP_HocVien(string mahocvien, double nohp)
        {
            return objHocVien.Edit_NoHP_HocVien(mahocvien, nohp);
        }


    }
}
