using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL
    {
        public static DataTable getListUser()
        {
            SqlConnection conn = Connection.GetConnection();

            string sql = "SELECT Parking.IDCard, MAX(TimeOut) AS Times, Image FROM Revenue, Parking  WHERE Parking.Type = 'USER' AND Parking.IDCard = Revenue.IDCard GROUP BY Parking.IDCard, Image";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            dataadapter.Fill(ds);
            conn.Close();
            return ds;
        }


    }
}
