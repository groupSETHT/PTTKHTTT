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
    public class ThongTinDangKyDAO : DBConnection
    {
        public ThongTinDangKyDAO() : base() { }

        DataTable dt = new DataTable();
     
    
        public bool AddThongTinDangKy(ThongTinDangKy ttdk)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("ThongTinDangKy_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHV", SqlDbType.VarChar).Value = ttdk._mahv;
                cmd.Parameters.Add("@NgayDangKy", SqlDbType.SmallDateTime).Value =ttdk._ngaydangky;
                cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = ttdk._trangthai;
                cmd.Parameters.Add("@SoLuongCuocHen", SqlDbType.Int).Value = ttdk._soluongcuochen;
                cmd.Parameters.Add("@MaNgayRanh", SqlDbType.VarChar).Value = ttdk._mangayranh;
                cmd.Parameters.Add("@MaCaRanh", SqlDbType.VarChar).Value = ttdk._macaranh;
                cmd.Parameters.Add("@MaTrinhDoHienTai", SqlDbType.VarChar).Value = ttdk._matrinhdohientai;
                cmd.Parameters.Add("@MaTrinhDoMuonHoc", SqlDbType.VarChar).Value = ttdk._matrinhdomuonhoc;
                cmd.Parameters.Add("@MaTrinhDoDuocHoc", SqlDbType.VarChar).Value = ttdk._matrinhdoduochoc;
                cmd.Parameters.Add("@MaKiThiXepLop", SqlDbType.VarChar).Value =ttdk._makithixeplop;
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

        public bool DeleteThongTinDangKy(string mathongtindangky)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("ThongTinDangKy_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHV", SqlDbType.VarChar).Value = mathongtindangky;
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

        public bool EditThongTinDangKy(ThongTinDangKy ttdk)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("ThongTinDangKy_Edit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHV", SqlDbType.VarChar).Value = ttdk._mahv;
                cmd.Parameters.Add("@NgayDangKy", SqlDbType.SmallDateTime).Value = ttdk._ngaydangky;
                cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = ttdk._trangthai;
                cmd.Parameters.Add("@SoLuongCuocHen", SqlDbType.Int).Value = ttdk._soluongcuochen;
                cmd.Parameters.Add("@MaNgayRanh", SqlDbType.VarChar).Value = ttdk._mangayranh;
                cmd.Parameters.Add("@MaCaRanh", SqlDbType.VarChar).Value = ttdk._macaranh;
                cmd.Parameters.Add("@MaTrinhDoHienTai", SqlDbType.VarChar).Value = ttdk._matrinhdohientai;
                cmd.Parameters.Add("@MaTrinhDoMuonHoc", SqlDbType.VarChar).Value = ttdk._matrinhdomuonhoc;
                cmd.Parameters.Add("@MaTrinhDoDuocHoc", SqlDbType.VarChar).Value = ttdk._matrinhdoduochoc;
                cmd.Parameters.Add("@MaKiThiXepLop", SqlDbType.VarChar).Value = ttdk._makithixeplop;
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
        public bool Edit_TrangThai_ThongTinDangKy(string mahocvien, string trangthai)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("ThongTinDangKy_Edit_TrangThai", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHV", SqlDbType.VarChar).Value = mahocvien;
                cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = trangthai;
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
