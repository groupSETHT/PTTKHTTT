using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class DBConnection
    {
            protected SqlConnection conn = new SqlConnection();
            public DBConnection()
            {
                try
                {
                    conn.ConnectionString = @"Initial Catalog=SQL_QLTA;Integrated Security=True";
                }
                catch (Exception)
                {
                    throw;
                }
            }
        
    }
}
