using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class LopDAO : DBConnection
    {
        public LopDAO() : base() { }
        public string Lop_NextID()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("LopHoc_NextID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@lop", SqlDbType.Char, 6));
                cmd.Parameters["@lop"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.Parameters["@lop"].Value = "";
                cmd.ExecuteNonQuery();
                string lop = cmd.Parameters["@lop"].Value.ToString();
                conn.Close();
                return lop;
            }
            catch (Exception)
            {

            }
            return "";
        }
        public bool AddLop(Lop objlop)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("LopHoc_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = objlop._malop;
                cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = objlop._tenlop;
                cmd.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar).Value = objlop._makhoahoc;
                cmd.Parameters.Add("@MaChuongTrinhHoc", SqlDbType.VarChar).Value = objlop._machuongtrinhhoc;
                cmd.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = objlop._ngaybatdau;
                cmd.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = objlop._ngayketthuc;
                cmd.Parameters.Add("@MaCa", SqlDbType.VarChar).Value = objlop._maca;
                cmd.Parameters.Add("@MaNgay", SqlDbType.VarChar).Value = objlop._mangay;
                cmd.Parameters.Add("@MaGiangVien", SqlDbType.VarChar).Value = objlop._magiangvien;
                cmd.Parameters.Add("@MaPhongHoc", SqlDbType.VarChar).Value = objlop._maphonghoc;
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
        public DataTable GetAll_CT()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("LopHoc_GetAll_CT", conn);
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
        public DataTable FindCT_TheoTenLop(string tenlop)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("LopHoc_FindCT_TheoTen", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = tenlop;
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
        public bool DeleteLop(string malop)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("LopHoc_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = malop;
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

        public bool EditLop(Lop objlop)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("LopHoc_Edit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = objlop._malop;
                cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = objlop._tenlop;
                cmd.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar).Value = objlop._makhoahoc;
                cmd.Parameters.Add("@MaChuongTrinhHoc", SqlDbType.VarChar).Value = objlop._machuongtrinhhoc;
                cmd.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = objlop._ngaybatdau;
                cmd.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = objlop._ngayketthuc;
                cmd.Parameters.Add("@MaCa", SqlDbType.VarChar).Value = objlop._maca;
                cmd.Parameters.Add("@MaNgay", SqlDbType.VarChar).Value = objlop._mangay;
                cmd.Parameters.Add("@MaGiangVien", SqlDbType.VarChar).Value = objlop._magiangvien;
                cmd.Parameters.Add("@MaPhongHoc", SqlDbType.VarChar).Value = objlop._maphonghoc;
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
        public DataTable GetAllLop()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("LopHoc_GetAll", conn);
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
        public string GetMa_TheoTen(string ten)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("LopHoc_GetMa_TheoTen", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = ten;
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
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("LopHoc_GetTen_TheoMa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = ma;
                string ten = cmd.ExecuteScalar().ToString();
                return ten;
            }
            catch
            {
                conn.Close();
                return "";
            }
        }
        public DataTable GetMaTen_TheoChuongTrinhHoc(string machuongtrinhhoc)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("LopHoc_GetMaTen_TheoChuongTrinhHoc", conn);
                cmd.Parameters.Add("@MaChuongTrinhHoc", SqlDbType.VarChar).Value = machuongtrinhhoc;
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
        public DataTable GetAll_TheoCTH_KH(string makhoa, string machuongtrinhhoc)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("LopHoc_GetAll_TheoCTH_KH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("MaKhoaHoc", SqlDbType.VarChar).Value = makhoa;
                cmd.Parameters.Add("MaChuongTrinhHoc", SqlDbType.VarChar).Value = machuongtrinhhoc;
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
        public int GetSoLuongHocVien(string malop)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("LopHoc_GetSLHV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = malop;
                int dem = (int)cmd.ExecuteScalar();
                return dem;
            }
            catch (Exception)
            {
                conn.Close();
            }
            return -1;
        }
        public DataTable FindCT_TheoTen_KhoaHoc_ChuongTrinhHoc(string tenlop, string makhoa, string machuongtrinhhoc)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("LopHoc_FindCT_TheoTen_KhoaHoc_ChuongTrinhHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = tenlop;
                cmd.Parameters.Add("@MaKhoaHoc", SqlDbType.VarChar).Value = makhoa;
                cmd.Parameters.Add("@MaChuongTrinhHoc", SqlDbType.VarChar).Value = machuongtrinhhoc;
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
