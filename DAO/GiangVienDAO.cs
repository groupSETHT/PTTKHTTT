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
    public class GiangVienDAO : DBConnection
    {
        public GiangVienDAO() :base() { }

        public DataTable GetAllGiangVien()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("GiangVien_GetAll", conn);
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
        public bool AddGiangVien(GiangVien gv)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("GiangVien_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaGV", SqlDbType.VarChar).Value = gv._magv;
                cmd.Parameters.Add("@TenGV", SqlDbType.NVarChar).Value = gv._tengv;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime).Value = gv._ngaysinh;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = gv._gioitinh;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = gv._sdt;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = gv._diachi;
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

        public bool EditGiangVien(GiangVien gv)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("GiangVien_Edit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaGV", SqlDbType.VarChar).Value = gv._magv;
                cmd.Parameters.Add("@TenGV", SqlDbType.NVarChar).Value = gv._tengv;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime).Value = gv._ngaysinh;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = gv._gioitinh;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = gv._sdt;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = gv._diachi;
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

        public bool DeleteGiangVien(string maGV)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("GiangVien_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaGV", SqlDbType.VarChar).Value = maGV;
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
        public string NextID_GiangVien()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("GiangVien_NextID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@GV", SqlDbType.Char, 6));
                cmd.Parameters["@GV"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.Parameters["@GV"].Value = "";
                cmd.ExecuteNonQuery();
                string khoa = cmd.Parameters["@GV"].Value.ToString();
                conn.Close();
                return khoa;
            }
            catch (Exception)
            {

            }
            return "";
        }
        public DataTable TimGiangVien(string tengv)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("GiangVien_TimTen", conn);
                cmd.Parameters.Add("@TenGV", SqlDbType.NVarChar).Value = tengv;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
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
        public DataTable GetMaTenGV()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("GiangVien_GetMaTen", conn);
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
        public string GetMa_TheoTen(string ten)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("GiangVien_GetMa_TheoTen", conn);
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
