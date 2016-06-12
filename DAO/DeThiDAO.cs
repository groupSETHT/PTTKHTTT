using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class DeThiDAO : DBConnection
    {
        public DataTable GetAllDeThi_TheoMa_LoaiDeThi(string ma)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("DeThi_GetAll_TheoMa_LoaiDeThi", conn);
                cmd.Parameters.Add("@MaLoaiDeThi", SqlDbType.VarChar).Value = ma;
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
        public bool AddDeThi(DeThi dethi)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("DeThi_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDeThi", SqlDbType.VarChar).Value = dethi._madethi;
                cmd.Parameters.Add("@TenDeThi", SqlDbType.NVarChar).Value = dethi._tendethi;
                cmd.Parameters.Add("@MaLoaiDeThi", SqlDbType.VarChar).Value = dethi._maloaidethi;
                cmd.Parameters.Add("@NgayLap", SqlDbType.SmallDateTime).Value = dethi._ngaylap;
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

        public bool EditDeThi(DeThi dethi)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("DeThi_Edit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDeThi", SqlDbType.VarChar).Value = dethi._madethi;
                cmd.Parameters.Add("@TenDeThi", SqlDbType.NVarChar).Value = dethi._tendethi;
                cmd.Parameters.Add("@MaLoaiDeThi", SqlDbType.VarChar).Value = dethi._maloaidethi;
                cmd.Parameters.Add("@NgayLap", SqlDbType.SmallDateTime).Value = dethi._ngaylap;
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

        public bool DeleteDeThi(string ma)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("DeThi_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDeThi", SqlDbType.VarChar).Value = ma;
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
        public string NextID_DeThi()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeThi_NextID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaDeThi", SqlDbType.Char, 6));
                cmd.Parameters["@MaDeThi"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.Parameters["@MaDeThi"].Value = "";
                cmd.ExecuteNonQuery();
                string madethi = cmd.Parameters["@MaDeThi"].Value.ToString();
                conn.Close();
                return madethi;
            }
            catch (Exception)
            {

            }
            return "";
        }
        public DataTable GetTen_TheoMa_LoaiDeThi(string ma)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("DeThi_GetTen_TheoMa_LoaiDeThi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiDeThi", SqlDbType.VarChar).Value = ma;
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
        public string GetTen_TheoMa(string ma)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("DeThi_GetTen_TheoMa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDeThi", SqlDbType.VarChar).Value = ma;
                string ten = cmd.ExecuteScalar().ToString();
                return ten;
            }
            catch
            {
                conn.Close();
                return "";
            }
        }
        public string GetMa_TheoTen(string ten)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("DeThi_GetMa_TheoTen", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenDeThi", SqlDbType.VarChar).Value = ten;
                string ma = cmd.ExecuteScalar().ToString();
                return ma;
            }
            catch
            {
                conn.Close();
                return "";
            }
        }

    }
}

