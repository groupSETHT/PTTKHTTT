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
    public class CaHocBUS
    {
        CaHocDAO objCaHoc = new CaHocDAO();
        public DataTable GetMaTen()
        {
            return objCaHoc.GetMaTen();
        }
        public DataTable GetAllCaHoc()
        {
            return objCaHoc.GetAllCaHoc();
        }
        public DataTable Get_CT(string maca)
        {
            return objCaHoc.Get_CT(maca);
        }
        public string GetMa_TheoTen(string ten)
        {
            return objCaHoc.GetMa_TheoTen(ten);
        }
        public string GetTen_TheoMa(string ma)
        {
            return objCaHoc.GetTen_TheoMa(ma);
        }
        public string NextIDCaHoc()
        {
            return objCaHoc.NextIDCaHoc();
        }
        public bool AddCaHoc(CaHoc ch)
        {
            return objCaHoc.AddCaHoc(ch);
        }
        public bool EditCaHoc(CaHoc ch)
        {
            return objCaHoc.EditCaHoc(ch);
        }
        public bool DeleteCaHoc(string ma)
        {
            return objCaHoc.DeleteCaHoc(ma);
        }
    }
}
