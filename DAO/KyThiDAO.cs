using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class KyThiDAO : DBConnection
    {
        public bool AddKyThi(KyThi kt)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("KyThi_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKyThi", SqlDbType.VarChar).Value = kt._makythi;
                cmd.Parameters.Add("@TenKyThi", SqlDbType.NVarChar).Value = kt._tenkythi;
                cmd.Parameters.Add("@NgayThi", SqlDbType.SmallDateTime).Value = kt._ngaythi ;
                cmd.Parameters.Add("@GioThi", SqlDbType.Time).Value = kt._giothi;
                cmd.Parameters.Add("@MaPhongThi", SqlDbType.VarChar).Value = kt._maphongthi;
                cmd.Parameters.Add("@MaDeThi", SqlDbType.VarChar).Value = kt._madethi;
                cmd.Parameters.Add("@MaLoaiKyThi", SqlDbType.VarChar).Value = kt._maloaikythi;
                cmd.Parameters.Add("@MaLoaiDeThi", SqlDbType.VarChar).Value = kt._maloaidethi;
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = kt._malop;
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
        public bool EditKyThi(KyThi kt)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("KyThi_Edit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKyThi", SqlDbType.VarChar).Value = kt._makythi;
                cmd.Parameters.Add("@TenKyThi", SqlDbType.NVarChar).Value = kt._tenkythi;
                cmd.Parameters.Add("@NgayThi", SqlDbType.SmallDateTime).Value = kt._ngaythi;
                cmd.Parameters.Add("@GioThi", SqlDbType.Time).Value = kt._giothi;
                cmd.Parameters.Add("@MaPhongThi", SqlDbType.VarChar).Value = kt._maphongthi;
                cmd.Parameters.Add("@MaDeThi", SqlDbType.VarChar).Value = kt._madethi;
                cmd.Parameters.Add("@MaLoaiKyThi", SqlDbType.VarChar).Value = kt._maloaikythi;
                cmd.Parameters.Add("@MaLoaiDeThi", SqlDbType.VarChar).Value = kt._maloaidethi;
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = kt._malop;
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
        public bool DeleteKyThi(string makythi)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("KyThi_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKyThi", SqlDbType.VarChar).Value = makythi;
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
        public DataTable GetAll_TheoMaLoaiKyThi(string ma)
        {
            try
            {
                if(conn.State!=ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("KyThi_GetAll_TheoMaLoaiKyThi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiKyThi", SqlDbType.VarChar).Value = ma;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
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
        public string KyThi_NextID()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("KyThi_NextID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaKyThi", SqlDbType.Char, 6));
                cmd.Parameters["@MaKyThi"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.Parameters["@MaKyThi"].Value = "";
                cmd.ExecuteNonQuery();
                string id = cmd.Parameters["@MaKyThi"].Value.ToString();
                conn.Close();
                return id;
            }
            catch (Exception)
            {

            }
            return "";
        }
        public DataTable GetMaTenKyThi_TheoLoaiKyThi(string maloaikythi)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("KyThi_GetMaTen_TheoLoaiKyThi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiKyThi", SqlDbType.VarChar).Value = maloaikythi;
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
        public string GetLop_TheoMaKyThi(string makythi)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("KyThi_GetLop_TheoMaKyThi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKyThi", SqlDbType.VarChar).Value = makythi;

                string tenlop = cmd.ExecuteScalar().ToString();
                conn.Close();
                return tenlop;

            }
            catch
            {
                conn.Close();
                return "";
            }
        }
        public DataTable GetDSThi(string makythi)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("KyThi_GetDSHV", conn);
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
    }
   
}
