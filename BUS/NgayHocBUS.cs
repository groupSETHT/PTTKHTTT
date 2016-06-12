using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
     public class NgayHocBUS
    {
        NgayHocDAO objNgayHoc = new NgayHocDAO();
       public DataTable GetAllNgayHoc(){
           return objNgayHoc.GetAllNgayHoc();
        }
       public string GetMa_TheoTen(string ten)
       {
           return objNgayHoc.GetMa_TheoTen(ten);
       }
        public string GetTen_TheoMa(string ma)
       {
           return objNgayHoc.GetTen_TheoMa(ma);
       }
    }
}
