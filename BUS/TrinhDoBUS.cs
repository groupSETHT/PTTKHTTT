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
    public class TrinhDoBUS
    {
         TrinhDoDAO objTrinhDo = new TrinhDoDAO();
        public DataTable GetAllTrinhDo()
        {
            return objTrinhDo.GetAllTrinhDo();
        }
        public String GetMa_TheoTen(string ten)
        {
            return objTrinhDo.GetMa_TheoTen(ten);
        }

        public String GetTen_TheoMa(string matd)
        {
            return objTrinhDo.GetTen_TheoMa(matd);
        }
        
    }
}
