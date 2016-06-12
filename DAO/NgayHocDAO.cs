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
    public class NgayHocDAO :DBConnection
    {
        public NgayHocDAO() : base() { }
        public DataTable GetAllNgayHoc()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("NgayHoc_GetAll", conn);
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
        public string GetMa_TheoTen(string ten)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("NgayHoc_GetMa_TheoTen", conn);
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
        public string GetTen_TheoMa(string mangay)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("NgayHoc_GetTen_TheoMa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNgay", SqlDbType.VarChar).Value = mangay;
                string danhsachngay = cmd.ExecuteScalar().ToString();
                return danhsachngay;
            }
            catch
            {
                conn.Close();

            }
            return "";
        }
    }
}
