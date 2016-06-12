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
    public class HocVienDAO : DBConnection
    {
        public HocVienDAO() : base() { }

        DataTable dt = new DataTable();
        public DataTable GetMaHocVien()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_GetMaHV", conn);
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
        public DataTable GetAllHocVien()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_GetAll", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns.Add("STT");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
            }
            return null;
        }
        public DataTable GetAllHocVien_ChiTiet()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_GetAll_ChiTiet", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns.Add("STT");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
            }
            return null;
        }
        public bool EditHocVien(HocVien hv)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_Edit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHV", SqlDbType.VarChar).Value = hv._mahv;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = hv._hoten;
                cmd.Parameters.Add("@Phai", SqlDbType.NVarChar).Value = hv._phai;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = hv._diachi;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = hv._sdt;
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = hv._malop;
                cmd.Parameters.Add("@NoHP", SqlDbType.Money).Value = hv._nohp;
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
        public bool DeleteHocVien(string mahv)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHV", SqlDbType.VarChar).Value = mahv;
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
        public bool AddHocVien(HocVien hv)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHV", SqlDbType.VarChar).Value = hv._mahv;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = hv._hoten;
                cmd.Parameters.Add("@Phai", SqlDbType.NVarChar).Value = hv._phai;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = hv._diachi;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = hv._sdt;
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = hv._malop;
                cmd.Parameters.Add("@NoHP", SqlDbType.Money).Value = hv._nohp;
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
        public DataTable FindTenHV(string tenhv)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_Find_ChiTiet", conn);

                cmd.Parameters.Add("@TenHV", SqlDbType.NVarChar).Value = tenhv;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();

                da.Fill(dt);

                dt.Columns.Add("STT");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
            }
            return null;
        }

        public string NextIDHocVien()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("HocVien_NextID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mahocvien", SqlDbType.Char, 6));
                cmd.Parameters["@mahocvien"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.Parameters["@mahocvien"].Value = "";
                cmd.ExecuteNonQuery();
                string mahocvien = cmd.Parameters["@mahocvien"].Value.ToString();
                conn.Close();
                return mahocvien;
            }
            catch (Exception)
            {

            }
            return "";
        }
        public DataTable GetAllHocVienTiemNang()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_GetAllTiemNang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns.Add("STT");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
            }
            return null;
        }
        public DataTable GetAllHocVienTiemNang_ChiTiet()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_GetAll_HocVienTiemNang_ChiTiet", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns.Add("STT");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
            }
            return null;
        }
        public DataTable GetAllHocVienChinhThuc_ChiTiet()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_GetAllHocVienChinhThuc_ChiTiet", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns.Add("STT");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
            }
            return null;
        }
        public DataTable GetAllHocVienTheoMaLop_ChiTiet(string malop)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_GetAllHocVien_TheoMaLop_ChiTiet", conn);
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = malop;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns.Add("STT");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
            }
            return null;
        }
        public bool Edit_MaLop_HocVien(string mahocvien, string malop)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_Edit_MaLop", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHV", SqlDbType.VarChar).Value = mahocvien;
                cmd.Parameters.Add("@MaLop", SqlDbType.NVarChar).Value = malop;
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
        public DataTable FindTenHV_ChinhThuc(string tenhv)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_FindHVChinhThuc_ChiTiet", conn);

                cmd.Parameters.Add("@TenHV", SqlDbType.NVarChar).Value = tenhv;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();

                da.Fill(dt);

                dt.Columns.Add("STT");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
            }
            return null;
        }

        public DataTable FindTenHV_TiemNang(string tenhv)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_FindHVTiemNang_ChiTiet", conn);

                cmd.Parameters.Add("@TenHV", SqlDbType.NVarChar).Value = tenhv;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns.Add("STT");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
            }
            return null;
        }

        public DataTable FindTenHV_ChinhThuc_TheoMaLop_TenHV(string malop, string tenhv)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_FindHVChinhThuc_TheoMaLop_TenHV_ChiTiet", conn);
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = malop;
                cmd.Parameters.Add("@TenHV", SqlDbType.NVarChar).Value = tenhv;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();

                da.Fill(dt);

                dt.Columns.Add("STT");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
            }
            return null;
        }
        public DataTable GetAllHocVienTiemNang_ChiTiet_BaoCao(string month, string year)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_GetAll_HocVienTiemNang_BaoCao", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Month", SqlDbType.Int).Value = int.Parse(month);
                cmd.Parameters.Add("@Year", SqlDbType.Int).Value = int.Parse(year);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
            }
            return null;
        }
        public int GetSoLuong_HocVien_BaoCao(string month, string year)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_SoLuongHVTimNang_BaoCao", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Month", SqlDbType.Int).Value = int.Parse(month);
                cmd.Parameters.Add("@Year", SqlDbType.Int).Value = int.Parse(year);
                return (int)cmd.ExecuteScalar();
            }
            catch
            {
                conn.Close();
            }
            return -1;
        }
        public DataTable GetAllHocVienConNoHP_ChiTiet()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_GetAllHocVienConNoHP_ChiTiet", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns.Add("STT");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
            }
            return null;
        }
        public DataTable FindTenHV_ConNoHP(string tenhv)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_FindHVConNoHP_ChiTiet", conn);

                cmd.Parameters.Add("@TenHV", SqlDbType.NVarChar).Value = tenhv;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();

                da.Fill(dt);

                dt.Columns.Add("STT");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
            }
            return null;
        }
        public bool Edit_NoHP_HocVien(string mahocvien, double nohp)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("HocVien_Edit_NoHP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHV", SqlDbType.VarChar).Value = mahocvien;
                cmd.Parameters.Add("@NoHP", SqlDbType.Money).Value = nohp;
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
