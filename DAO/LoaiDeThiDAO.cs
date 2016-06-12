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
    public class LoaiDeThiDAO :DBConnection
    {
        public LoaiDeThiDAO() : base() { }
        public bool AddLoaiDeThi(LoaiDeThi objLoaiDeThi)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("LoaiDeThi_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiDeThi", SqlDbType.VarChar).Value = objLoaiDeThi._maloaidethi;
                cmd.Parameters.Add("@TenLoaiDeThi", SqlDbType.NVarChar).Value = objLoaiDeThi._tenloaidethi;
                cmd.Parameters.Add("@ThoiLuong", SqlDbType.Int).Value = objLoaiDeThi._thoiluongdethi;
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
        public bool EditLoaiDeThi(LoaiDeThi objLoaiDeThi)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("LoaiDeThi_Edit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiDeThi", SqlDbType.VarChar).Value = objLoaiDeThi._maloaidethi;
                cmd.Parameters.Add("@TenLoaiDeThi", SqlDbType.NVarChar).Value = objLoaiDeThi._tenloaidethi;
                cmd.Parameters.Add("@ThoiLuong", SqlDbType.Int).Value = objLoaiDeThi._thoiluongdethi;
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
        public bool DeleteLoaiDeThi(string maloaidethi)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("LoaiDeThi_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiDeThi", SqlDbType.VarChar).Value = maloaidethi;
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
        public DataTable GetAllLoaiDeThi()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("LoaiDeThi_GetAll", conn);
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
                return null;
            }
        }
        public string NextID_LoaiKyThi()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("LoaiDeThi_NextID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@loaidethi", SqlDbType.Char, 6));
                cmd.Parameters["@loaidethi"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.Parameters["@loaidethi"].Value = "";
                cmd.ExecuteNonQuery();
                string maloaidethi = cmd.Parameters["@loaidethi"].Value.ToString();
                conn.Close();
                return maloaidethi;
            }
            catch (Exception)
            {

            }
            return "";
        }
        public string GetMa_TheoTen(string ten)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("LoaiDeThi_GetMa_TheoTen", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenLoaiDeThi", SqlDbType.VarChar).Value = ten;
                string ma = cmd.ExecuteScalar().ToString();
                return ma;
            }
            catch
            {
                conn.Close();
                return "";
            }
        }
            public string GetTen_TheoMa(string ma)
        {
            try
            {
                if(conn.State!=ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("LoaiDeThi_GetTen_TheoMa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiDeThi", SqlDbType.VarChar).Value = ma;
                string ten = cmd.ExecuteScalar().ToString();
                return ten;
            }
            catch
            {
                conn.Close();
                return "";
            }
        }
    }
}
