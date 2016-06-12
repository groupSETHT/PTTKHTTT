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
    public class KyThiBUS
    {
        KyThiDAO objKyThi = new KyThiDAO();
        public DataTable GetAllKyThi_TheoMa_LoaiKyThi(string ma)
        {
            return objKyThi.GetAll_TheoMaLoaiKyThi(ma);
        }
        public string KyThi_NextID()
        {
            return objKyThi.KyThi_NextID();
        }
        public bool AddKyThi(KyThi kt)
        {
            return objKyThi.AddKyThi(kt);
        }
        public bool EditKyThi(KyThi kt)
        {
            return objKyThi.EditKyThi(kt);
        }
        public bool DeleteKyThi(string ma)
        {
            return objKyThi.DeleteKyThi(ma);
        }
        public DataTable GetMaTenKyThi_TheoLoaiKyThi(string maloaikythi)
        {
            return objKyThi.GetMaTenKyThi_TheoLoaiKyThi(maloaikythi);
        }
        public string GetLop_TheoMaKyThi(string makythi)
        {
            return objKyThi.GetLop_TheoMaKyThi(makythi);
        }
        public DataTable GetDanhSachThi_TheoKyThi(string makythi)
        {
            return objKyThi.GetDSThi(makythi);
        }
    }
}
