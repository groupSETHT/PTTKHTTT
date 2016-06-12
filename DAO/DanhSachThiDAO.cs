using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DanhSachThiDAO : DBConnection
    {
        public DanhSachThiDAO() : base() { }
        public DataTable GetAllDanhSachThi_TheoKyThi(string makythi)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("DanhSachThi_GetAll_TheoKyThi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKyThi", SqlDbType.VarChar).Value = makythi;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
                return null;
            }
        }
        public bool AddDanhSachThi(DanhSachThi dst)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("DanhSachThi_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKyThi", SqlDbType.VarChar).Value = dst._makithi;
                cmd.Parameters.Add("@MaHV", SqlDbType.VarChar).Value = dst._mahv;
                cmd.Parameters.Add("@Diem", SqlDbType.Float).Value = dst._ketquathi;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
        public bool EditDanhSachThi(DanhSachThi dst)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("DanhSachThi_Edit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKyThi", SqlDbType.VarChar).Value = dst._makithi;
                cmd.Parameters.Add("@MaHV", SqlDbType.VarChar).Value = dst._mahv;
                cmd.Parameters.Add("@Diem", SqlDbType.Float).Value = dst._ketquathi;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
        public bool CheckHV_DaCoDiem(string mahv)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("DanhSachThi_CheckHV_DaCoDiem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHV", SqlDbType.VarChar).Value = mahv;
                int a = (int)cmd.ExecuteScalar();
                conn.Close();
                if (a > 0)
                {
                    return true;
                }


                return false;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
    }
}
