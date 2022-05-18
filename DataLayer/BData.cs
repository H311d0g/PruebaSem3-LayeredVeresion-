using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    public abstract class BData
    {
       protected SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-M51EKPM; Initial Catalog= GaqCrm; Integrated Security= True");
        public SqlConnection OpenFrom()
        {
            conn.Open();
            return conn;
        }
        public SqlConnection CloseFrom()
        {
            conn.Close();
            return conn;
        }
    }
}
