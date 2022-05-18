using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class UserConsults:BData
    {
        public bool Login(string rut, string clave)
        {
            var conn = OpenFrom();

            {
                conn.Open();
                using (var scmd = new SqlCommand())
                {
                    scmd.Connection = conn;
                    scmd.CommandText = "SELECT rut, clave FROM userCrm WHERE rut= @vrut AND clave= @vclave ";
                    scmd.Parameters.AddWithValue("@vrut", rut);
                    scmd.Parameters.AddWithValue("@vclave", clave);
                    scmd.CommandType = CommandType.Text;
                    SqlDataReader read2 = scmd.ExecuteReader();
                    if (read2.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
