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
    public class GiangVienBUS
    {

        GiangVienDAO objGiangVien = new GiangVienDAO();
        public DataTable GetAllGiangVien()
        {
            return objGiangVien.GetAllGiangVien();
        }
        public bool AddGiangVien(GiangVien gv)
        {
            return objGiangVien.AddGiangVien(gv);
        }
        public bool EditGiangVien(GiangVien gv)
        {
            return objGiangVien.EditGiangVien(gv);
        }
        public bool DeleteGiangVien(string maGV)
        {
            return objGiangVien.DeleteGiangVien(maGV);
        }
        public string NextID()
        {
            return objGiangVien.NextID_GiangVien();
        }
        public DataTable TimTen_GiangVien(string tengv)
        {
            return objGiangVien.TimGiangVien(tengv);
        }
        public DataTable GetMaTen()
        {
            return objGiangVien.GetMaTenGV();
        }
        public string GetMa_TheoTen(string ma)
        {
            return objGiangVien.GetMa_TheoTen(ma);
        }
    }
}
