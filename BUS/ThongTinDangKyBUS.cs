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
    public class ThongTinDangKyBUS
    {
        ThongTinDangKyDAO objTTDK = new ThongTinDangKyDAO();


        public bool AddThongTinDangKy(ThongTinDangKy ttdk)
        {
            return objTTDK.AddThongTinDangKy(ttdk);
        }
        public bool DeleteThongTinDangKy(String mahv)
        {
            return objTTDK.DeleteThongTinDangKy(mahv);
        }
        public bool EditThongTinDangKy(ThongTinDangKy ttdk)
        {
            return objTTDK.EditThongTinDangKy(ttdk);
        }
        public bool Edit_TrangThai_ThongTinDangKy(string mahocvien, string trangthai)
        {
            return objTTDK.Edit_TrangThai_ThongTinDangKy(mahocvien, trangthai);
        }
    }
}
