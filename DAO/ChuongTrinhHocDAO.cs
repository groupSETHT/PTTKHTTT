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
    public class ChuongTrinhHocDAO : DBConnection
    {
        public ChuongTrinhHocDAO() : base() { }

        public DataTable GetAllKhoaHoc()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("ChuongTrinhHoc_GetAll", conn);
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

        public bool AddChuongTrinhHoc(ChuongTrinhHoc cth)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("ChuongTrinhHoc_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaChuongTrinhHoc", SqlDbType.VarChar).Value = cth._machuongtrinhhoc;
                cmd.Parameters.Add("@TenChuongTrinhHoc", SqlDbType.NVarChar).Value = cth._chuongtrinhhoc;
                cmd.Parameters.Add("@MaTrinhDo", SqlDbType.VarChar).Value = cth._matrinhdo;
                cmd.Parameters.Add("@HocPhi", SqlDbType.Money).Value = cth._hocphi;
                cmd.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar).Value = cth._makhoahoc;
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


        public bool EditChuongTrinhHoc(ChuongTrinhHoc cth)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("ChuongTrinhHoc_Edit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaChuongTrinhHoc", SqlDbType.VarChar).Value = cth._machuongtrinhhoc;
                cmd.Parameters.Add("@TenChuongTrinhHoc", SqlDbType.NVarChar).Value = cth._chuongtrinhhoc;
                cmd.Parameters.Add("@MaTrinhDo", SqlDbType.VarChar).Value = cth._matrinhdo;
                cmd.Parameters.Add("@HocPhi", SqlDbType.Money).Value = cth._hocphi;
                cmd.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar).Value = cth._makhoahoc;
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


        public bool DeleteChuongTrinhHoc(string ma_cth)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("ChuongTrinhHoc_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaChuongTrinhHoc", SqlDbType.VarChar).Value = ma_cth;
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


        public string NextID_ChuongTrinhHoc()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ChuongTrinhHoc_NextID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@cth", SqlDbType.Char, 6));
                cmd.Parameters["@cth"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.Parameters["@cth"].Value = "";
                cmd.ExecuteNonQuery();
                string khoa = cmd.Parameters["@cth"].Value.ToString();
                conn.Close();
                return khoa;
            }
            catch (Exception)
            {

            }
            return "";
        }
        public DataTable GetChuongTrinhHoc_TheoKhoaHoc(string makh)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("ChuongTrinhHoc_LietKe_TheoKhoaHoc", conn);
                cmd.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar).Value = makh;

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

        public String GetMa_TheoKhoa(string ten)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("ChuongTrinhHoc_GetMa_TheoKhoaHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Ten", SqlDbType.VarChar).Value = ten;
                string ma = cmd.ExecuteScalar().ToString();
                return ma;
            }
            catch
            {
                conn.Close();
            }
            return "";
        }
        public DataTable GetMaTen_TheoKhoa(string makhoa)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("ChuongTrinhHoc_GetMaTen_TheoKhoaHoc", conn);
                cmd.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar).Value = makhoa;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close() ;
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
                SqlCommand cmd = new SqlCommand("ChuongTrinhHoc_GetMa_TheoTen", conn);
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
        public double GetHocPhi_TheoMaChuongTrinhHoc(string machuongtrinhhoc)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("ChuongTrinhHoc_GetHocPhi_TheoMaChuongTrinhHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaChuongTrinhHoc", SqlDbType.VarChar).Value = machuongtrinhhoc;
                double hocphi = double.Parse(cmd.ExecuteScalar().ToString());
                return hocphi;
            }
            catch
            {
                conn.Close();

            }
            return 0;
        }
    }
}
