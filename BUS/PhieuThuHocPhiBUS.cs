using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class PhieuThuHocPhiBUS
    {
        PhieuThuHocPhiDAO objPhieuThuHocPhi = new PhieuThuHocPhiDAO();

        public bool AddPhieuThuHocPhi(PhieuThuHocPhi phieuthuhocphi)
        {
            return objPhieuThuHocPhi.AddPhieuThuHocPhi(phieuthuhocphi);
        }
        public string NextIDPhieuThuHocPhi()
        {
            return objPhieuThuHocPhi.NextIDPhieuThuHocPhi();
        }
    }
}
