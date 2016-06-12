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
    public  class PhongHocBUS
    {
        PhongHocDAO objPhongHoc = new PhongHocDAO();
        public DataTable GetMaTen()
        {
            return objPhongHoc.GetMaTen();
        }
        public string GetMa_TheoTen_PhongHoc(string ten)
        {
            return objPhongHoc.GetMa_TheoTen(ten);
        }
        public string GetTen_TheoMa_PhongHoc(string ma)
        {
            return objPhongHoc.GetTen_TheoMa(ma);
        }
        public DataTable GetAllPhongHoc()
        {
            return objPhongHoc.GetAllPhongHoc();
        }
        public string NextID()
        {
            return objPhongHoc.PhongHoc_NextID();
        }
        public bool AddPhongHoc(PhongHoc ph)
        {
            return objPhongHoc.AddPhongHoc(ph);
        }
        public DataTable Find_PhongHoc(string ten)
        {
            return objPhongHoc.Find_PhongHoc(ten);
        }
        public bool EditPhongHoc(PhongHoc ph)
        {
            return objPhongHoc.EditPhongHoc(ph);
        }
        public bool DeletePhongHoc(string ma)
        {
            return objPhongHoc.DeletePhongHoc(ma);
        }
    }
}
