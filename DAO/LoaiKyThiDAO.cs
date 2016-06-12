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
    public class LoaiKyThiDAO:DBConnection
    {
        public LoaiKyThiDAO() { }
        public DataTable GetAllLoaiKyThi()
        {
            try
            {
                if(conn.State!=ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("LoaiKyThi_GetAll", conn);
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
        public bool AddLoaiKyThi(LoaiKyThi lkt)
        {
            try
            {
                if(conn.State!=ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("LoaiKyThi_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiKyThi", SqlDbType.VarChar).Value = lkt._maloaikythi;
                cmd.Parameters.Add("@TenLoaiKyThi", SqlDbType.NVarChar).Value = lkt._tenloaikythi;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch(Exception e)
            {
                conn.Close();
                return false;
            }
        }
        public bool EditLoaiKyThi(LoaiKyThi lkt)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("LoaiKyThi_Edit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiKyThi", SqlDbType.VarChar).Value = lkt._maloaikythi;
                cmd.Parameters.Add("@TenLoaiKyThi", SqlDbType.NVarChar).Value = lkt._tenloaikythi;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                return false;
            }
        }
        public bool DeleteLoaiKyThi(string malkt)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("LoaiKyThi_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiKyThi", SqlDbType.VarChar).Value = malkt;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                return false;
            }
        }
        public string NextID_LoaiKyThi()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("LoaiKyThi_NextID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@malkt", SqlDbType.Char, 6));
                cmd.Parameters["@malkt"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.Parameters["@malkt"].Value=""; 
                cmd.ExecuteNonQuery();
                string khoa = cmd.Parameters["@malkt"].Value.ToString();
                conn.Close();
                return khoa;
            }
            catch(Exception)
            {

            }
            return "";
        }
        public string GetMa_TheoTen(string ten)
        {
            try
            {
                if(conn.State!=ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("LoaiKyThi_GetMa_TheoTen", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenLoaiKyThi", SqlDbType.NVarChar).Value = ten;
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
