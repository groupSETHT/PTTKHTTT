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
    public class CaHocDAO:DBConnection
    {
        public CaHocDAO() : base() { }
        public DataTable GetMaTen()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("CaHoc_GetMaTen", conn);
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
        public DataTable Get_CT(string maca)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("CaHoc_GetCT", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaCa", SqlDbType.VarChar).Value = maca;
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
                SqlCommand cmd = new SqlCommand("CaHoc_GetMa_TheoTen", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = ten;

                string ma = cmd.ExecuteScalar().ToString();
                return ma;
            }
            catch
            {
                conn.Close();
                return "";
            }
         
        }
        public bool AddCaHoc(CaHoc ca)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("CaHoc_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaCa", SqlDbType.VarChar).Value =ca._maca;
                cmd.Parameters.Add("@TenCa", SqlDbType.NVarChar).Value = ca._tenca;
                cmd.Parameters.Add("@GioBatDau", SqlDbType.VarChar).Value = ca._giobatdau;
                cmd.Parameters.Add("@GioKetThuc", SqlDbType.VarChar).Value = ca._gioketthuc;
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
        public string NextIDCaHoc()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("CaHoc_NextID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@cahoc", SqlDbType.Char, 6));
                cmd.Parameters["@cahoc"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.Parameters["@cahoc"].Value = "";
                cmd.ExecuteNonQuery();
                string khoa = cmd.Parameters["@cahoc"].Value.ToString();
                conn.Close();
                return khoa;
            }
            catch (Exception)
            {

            }
            return "";

        }
        public DataTable GetAllCaHoc()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("CaHoc_GetAll", conn);
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
        public string GetTen_TheoMa(string maca)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("CaHoc_GetTen_TheoMa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaCa", SqlDbType.VarChar).Value = maca;
                string tenca = cmd.ExecuteScalar().ToString();
                return tenca;
            }
            catch
            {
                conn.Close();

            }
            return "";
        }
        public bool DeleteCaHoc(string maca)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("CaHoc_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaCa", SqlDbType.VarChar).Value = maca;
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
        public bool EditCaHoc(CaHoc ca)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("CaHoc_Edit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaCa", SqlDbType.VarChar).Value = ca._maca;
                cmd.Parameters.Add("@TenCa", SqlDbType.NVarChar).Value = ca._tenca;
                cmd.Parameters.Add("@GioBatDau", SqlDbType.NVarChar).Value = ca._giobatdau;
                cmd.Parameters.Add("@GioKetThuc", SqlDbType.NVarChar).Value = ca._gioketthuc;
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
