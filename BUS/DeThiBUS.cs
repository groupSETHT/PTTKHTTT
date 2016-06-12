using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
    public class DeThiBUS
    {
        DeThiDAO objDeThi = new DeThiDAO();
        public DataTable GetAllDeThi_TheoMaLoaiDeThi(string ma)
        {
            return objDeThi.GetAllDeThi_TheoMa_LoaiDeThi(ma);
        }
        public bool AddDeThi(DeThi dethi)
        {
            return objDeThi.AddDeThi(dethi);
        }
        public bool EditDeThi(DeThi dethi)
        {
            return objDeThi.EditDeThi(dethi);
        }
        public bool DeleteDeThi(string ma)
        {
            return objDeThi.DeleteDeThi(ma);
        }
        public string NextID_DeThi()
        {
            return objDeThi.NextID_DeThi();
        }
        public DataTable GetAllTen_DeThi_TheoMa_LoaiDeThi(string ma)
        {
            return objDeThi.GetTen_TheoMa_LoaiDeThi(ma);
        }
        public string GetTen_TheoMa_DeThi(string ma)
        {
            return objDeThi.GetTen_TheoMa(ma);
        }
        public string GetMa_TheoTen_DeThi(string ten)
        {
            return objDeThi.GetMa_TheoTen(ten);
        }
    }
}
