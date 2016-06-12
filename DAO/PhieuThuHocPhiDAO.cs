using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DTO;
namespace DAO
{
    public class PhieuThuHocPhiDAO :DBConnection
    {
          public PhieuThuHocPhiDAO() : base() { }
          DataTable dt = new DataTable();
          public bool AddPhieuThuHocPhi(PhieuThuHocPhi phieuthuhocphi)
          {
              try
              {
                  if (conn.State != ConnectionState.Open)
                      conn.Open();
                  SqlCommand cmd = new SqlCommand("PhieuThuHocPhi_Insert", conn);
                  cmd.CommandType = CommandType.StoredProcedure;
                  cmd.Parameters.Add("@MaPhieuThu", SqlDbType.VarChar).Value = phieuthuhocphi._maphieuthu;
                  cmd.Parameters.Add("@MaHV", SqlDbType.VarChar).Value = phieuthuhocphi._mahv;
                  cmd.Parameters.Add("@HocPhi", SqlDbType.Money).Value = phieuthuhocphi._hocphi;
                  cmd.Parameters.Add("@SoTienDong", SqlDbType.Money).Value = phieuthuhocphi._sotiendong;
                  cmd.Parameters.Add("@ConNo", SqlDbType.Money).Value = phieuthuhocphi._conno;
                  cmd.Parameters.Add("@NgayDong", SqlDbType.DateTime).Value = phieuthuhocphi._ngaydong;

                
                  cmd.ExecuteNonQuery();
                  conn.Close();
                  return true;
              }
              catch (Exception e)
              {
                  conn.Close();
                  Console.WriteLine(e);
                  return false;
              }
          }
          public string NextIDPhieuThuHocPhi()
          {
              try
              {
                  SqlCommand cmd = new SqlCommand("PhieuThuHocPhi_NextID", conn);
                  cmd.CommandType = CommandType.StoredProcedure;
                  cmd.Parameters.Add(new SqlParameter("@maphieuthu", SqlDbType.Char, 6));
                  cmd.Parameters["@maphieuthu"].Direction = ParameterDirection.Output;
                  conn.Open();
                  cmd.Parameters["@maphieuthu"].Value = "";
                  cmd.ExecuteNonQuery();
                  string mahocvien = cmd.Parameters["@maphieuthu"].Value.ToString();
                  conn.Close();
                  return mahocvien;
              }
              catch (Exception)
              {

              }
              return "";
          }
    }
}
