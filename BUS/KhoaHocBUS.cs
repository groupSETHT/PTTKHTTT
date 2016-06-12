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
     public class KhoaHocBUS
    {
        KhoaHocDAO objKhoaHoc = new KhoaHocDAO();
        public DataTable GetAllKhoaHoc()
        {
            return objKhoaHoc.GetAllKhoaHoc();
        }
        public bool AddKhoaHoc(KhoaHoc kh)
        {
            return objKhoaHoc.AddKhoaHoc(kh);
        }
        public bool EditKhoaHoc(KhoaHoc kh)
        {
            return objKhoaHoc.EditKhoaHoc(kh);
        }
        public bool DeleteKhoaHoc(String maKh)
        {
            return objKhoaHoc.DeleteKhoaHoc(maKh);
        }
        public DataTable GetAllTenKhoaHoc()
        {
            return objKhoaHoc.GetAllTenKhoaHoc();
        }
        public string NextID()
        {
            return objKhoaHoc.NextIDKhoaHoc();
        }
        public string NextID_DataGridView(string id)
        {

            string _id_gridview = id;
            int _id_next = int.Parse(_id_gridview.Substring(2, id.Length - 2));
            _id_next++;
            if (_id_next < 10)
                return "KH0" + _id_next.ToString();
            else
                return "KH" + _id_next.ToString();
        }
        public DataTable GetMaTenKhoaHoc()
        {
           return  objKhoaHoc.GetMaTenKhoaHoc();
        }
        public string  GetMa_TheoTen(string ma)
        {
            return objKhoaHoc.GetMa_TheoTen(ma);
        }
    }
}
