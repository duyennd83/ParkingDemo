using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        public static SqlConnection GetConnection()
        {

            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString =
            "Data Source=DESKTOP-9LU6Q52\\SQLEXPRESS;" +
            "Initial Catalog=ParkingDemo;" +
            "Integrated Security=True;" +
            "User=sa;" +
            "Password=qn261099";

            conn.Open();

            return conn;

        }
    }
}
