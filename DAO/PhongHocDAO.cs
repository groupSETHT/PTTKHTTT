using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class PhongHocDAO : DBConnection
    {
         public PhongHocDAO() :base() { }
        public DataTable GetMaTen()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("PhongHoc_GetMaTen", conn);
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
                SqlCommand cmd = new SqlCommand("PhongHoc_GetMa_TheoTen", conn);
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
        public string GetTen_TheoMa(string ma)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("PhongHoc_GetTen_TheoMa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaPhong", SqlDbType.NVarChar).Value = ma;
                string ten= cmd.ExecuteScalar().ToString();
                return ten;
            }
            catch
            {
                conn.Close();

            }
            return "";
        }
        public DataTable    GetAllPhongHoc()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("PhongHoc_GetAll", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
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
        public string PhongHoc_NextID()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PhongHoc_NextID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@phonghoc", SqlDbType.Char, 6));
                cmd.Parameters["@phonghoc"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.Parameters["@phonghoc"].Value = "";
                cmd.ExecuteNonQuery();
                string lop = cmd.Parameters["@phonghoc"].Value.ToString();
                conn.Close();
                return lop;
            }
            catch (Exception)
            {

            }
            return "";
        }
        public bool AddPhongHoc(PhongHoc objphonghoc)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("PhongHoc_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = objphonghoc._maphong;
                cmd.Parameters.Add("@TenPhong", SqlDbType.NVarChar).Value = objphonghoc._tenphong;
                cmd.Parameters.Add("@DiaDiem", SqlDbType.NVarChar).Value = objphonghoc._diadiem;
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
        public DataTable Find_PhongHoc(string ten)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("PhongHoc_FindCT_TheoTen", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenPhong", SqlDbType.NVarChar).Value = ten;
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
        public bool EditPhongHoc(PhongHoc objphonghoc)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("PhongHoc_Edit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = objphonghoc._maphong;
                cmd.Parameters.Add("@TenPhong", SqlDbType.NVarChar).Value = objphonghoc._tenphong;
                cmd.Parameters.Add("@DiaDiem", SqlDbType.NVarChar).Value = objphonghoc._diadiem;
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
        public bool DeletePhongHoc(string maphong)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("PhongHoc_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = maphong;
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
    }
}
