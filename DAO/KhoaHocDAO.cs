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
    public class KhoaHocDAO : DBConnection
    {
        public KhoaHocDAO() :base() { }
        public DataTable GetAllKhoaHoc()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("KhoaHoc_GetAll", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();

                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                conn.Close();
            }
            return null;
        }
        public bool AddKhoaHoc(KhoaHoc kh)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("KhoaHoc_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar).Value = kh._makhoahoc;
                cmd.Parameters.Add("@TenKhoaHoc", SqlDbType.NVarChar).Value = kh._tenkhoahoc;
                cmd.Parameters.Add("@HocPhi", SqlDbType.Money).Value = kh._hocphi;
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
        public bool EditKhoaHoc(KhoaHoc kh)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("KhoaHoc_Edit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar).Value = kh._makhoahoc;
                cmd.Parameters.Add("@TenKhoaHoc", SqlDbType.NVarChar).Value = kh._tenkhoahoc;
                cmd.Parameters.Add("@HocPhi", SqlDbType.Money).Value = kh._hocphi;
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
        public bool DeleteKhoaHoc(String maKh)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("KhoaHoc_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar).Value = maKh;
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
        public DataTable GetAllTenKhoaHoc()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("KhoaHoc_GetTen", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();

                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                conn.Close();
            }
            return null;
        }
        public string NextIDKhoaHoc()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("KhoaHoc_NextID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@khoa", SqlDbType.Char, 6));
                cmd.Parameters["@khoa"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.Parameters["@khoa"].Value = "";
                cmd.ExecuteNonQuery();
                string khoa = cmd.Parameters["@khoa"].Value.ToString();
                conn.Close();
                return khoa;
            }
            catch(Exception )
            {
              
            }
            return "";
        }
        public DataTable GetMaTenKhoaHoc()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("KhoaHoc_GetMaTen", conn);
                cmd.CommandType = CommandType.StoredProcedure;

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
            }
            return null;
        }
        public string GetMa_TheoTen(string ten)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("KhoaHoc_GetMa_TheoTen", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = ten;
                string ma = cmd.ExecuteScalar().ToString();
                return ma;
            }
            catch
            {
                conn.Close();

            }
            return "";
        }
    }
}
