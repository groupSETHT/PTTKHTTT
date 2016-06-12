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
    public class ChuongTrinhHocBUS
    {
        ChuongTrinhHocDAO objChuongTrinhHoc = new ChuongTrinhHocDAO();
        public DataTable GetAllChuongTrinhHoc()
        {
            return objChuongTrinhHoc.GetAllKhoaHoc();
        }
        public bool AddChuongTrinhHoc(ChuongTrinhHoc cth)
        {
            return objChuongTrinhHoc.AddChuongTrinhHoc(cth);
        }
        public bool EditChuongTrinhHoc(ChuongTrinhHoc cth)
        {
            return objChuongTrinhHoc.EditChuongTrinhHoc(cth);
        }

        public bool DeleteChuongTrinhHoc(string ma_cth)
        {
            return objChuongTrinhHoc.DeleteChuongTrinhHoc(ma_cth);
        }
        public DataTable GetChuongTrinhHoc_TheoKhoaHoc(string makh)
        {
            return objChuongTrinhHoc.GetChuongTrinhHoc_TheoKhoaHoc(makh);
        }

        public String GetMa_TheoKhoa(string ten)
        {
            return objChuongTrinhHoc.GetMa_TheoKhoa(ten);
        }
        public string NextID()
        {
            return objChuongTrinhHoc.NextID_ChuongTrinhHoc();
        }
        public DataTable GetMaTen_TheoKhoa(string makhoa)
        {
            return objChuongTrinhHoc.GetMaTen_TheoKhoa(makhoa);
        }
        public string GetMa_TheoTen(string ma)
        {
            return objChuongTrinhHoc.GetMa_TheoTen(ma);
        }
        public double GetHocPhi_TheoMaChuongTrinhHoc(string machuongtrinhhoc)
        {
            return objChuongTrinhHoc.GetHocPhi_TheoMaChuongTrinhHoc(machuongtrinhhoc);
        }
    }
}
