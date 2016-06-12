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
    public class LopBUS
    {
        LopDAO objLop = new LopDAO();
        public string Lop_NextID()
        {
            return objLop.Lop_NextID();
        }
        public DataTable GetAllLop()
        {
            return objLop.GetAllLop();
        }
        public string NextID_DataGridView(string id)
        {

            string _id_gridview = id;
            int _id_next = int.Parse(_id_gridview.Substring(1, id.Length - 1));
            _id_next++;
            if (_id_next < 10)
                return "L0" + _id_next.ToString();
            else
                return "L" + _id_next.ToString();
        }
        public bool AddLop(Lop l)
        {
            return objLop.AddLop(l);
        }
        public DataTable GetAll_CT()
        {
            return objLop.GetAll_CT();
        }
        public DataTable FindCT_TheoTenLop(string tenlop)
        {
            return objLop.FindCT_TheoTenLop(tenlop);
        }
        public bool DeleteLop(string ma)
        {
            return objLop.DeleteLop(ma);
        }
        public bool EditLop(Lop lop)
        {
            return objLop.EditLop(lop);
        }
        public string GetMa_TheoTen_LopHoc(string ten)
        {
            return objLop.GetMa_TheoTen(ten);
        }
        public string GetTen_TheoMa_LopHoc(string ma)
        {
            return objLop.GetTen_TheoMa(ma);
        }
        public DataTable GetMaTen_TheoChuongTrinhHoc(string machuongtrinhhoc)
        {
            return objLop.GetMaTen_TheoChuongTrinhHoc(machuongtrinhhoc);
        }
        public DataTable GetAll_TheoCTH_KH(string makhoa, string machuongtrinhhoc)
        {
            return objLop.GetAll_TheoCTH_KH(makhoa, machuongtrinhhoc);
        }
        public int GetSoLuongHocVien(string malop)
        {
            return objLop.GetSoLuongHocVien(malop);
        }
        public DataTable FindCT_TheoTen_KhoaHoc_ChuongTrinhHoc(string tenlop, string makhoa, string machuongtrinhhoc)
        {
            return objLop.FindCT_TheoTen_KhoaHoc_ChuongTrinhHoc(tenlop, makhoa, machuongtrinhhoc);
        }
    }
}
