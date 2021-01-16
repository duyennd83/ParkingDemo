using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ParkingDAL
    {

        public void AddDB(Parking myparking)
        {

            SqlConnection conn = Connection.GetConnection();

            //SQL
            
            string SQL = string.Format("INSERT INTO Parking(IDCard, Times, Status, Type, Image) " +
                "VALUES ('{0}', '{1}', '{2}','{3}','{4}')", myparking.CardID1, myparking.Time1, myparking.Status1, myparking.Type1, myparking.Image);
            
            SqlCommand cmd = new SqlCommand(SQL, conn);
            
            cmd.Connection = conn;

            //Open connection

            //Insert
            cmd.ExecuteNonQuery();

            //Close connection
            conn.Close();

           
        }

        public void UpdateDB(Parking myparking)
        {
            SqlConnection conn = Connection.GetConnection();

            //SQL
            string SQL = string.Format("UPDATE Parking SET IDCard = '{0}', Times= '{1}', Status = '{2}', Type = '{3}', Image = '{4}' " +
                "WHERE IDCard = {5}", myparking.CardID1, myparking.Time1, myparking.Status1, myparking.Type1, myparking.Image, myparking.CardID1);

            SqlCommand cmd = new SqlCommand(SQL, conn);
            //Open connection

            //Insert
            cmd.ExecuteNonQuery();

            //Close connection
            conn.Close();
        }

        public void DeleteDB(String idcard)
        {
            SqlConnection conn = Connection.GetConnection();


            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "DELETE FROM Parking WHERE IDCard= @id;";

            SqlParameter paramId = new SqlParameter();
            paramId.ParameterName = "@id";
            paramId.Value = idcard;
            cmd.Parameters.Add(paramId);
            cmd.Connection = conn;

            //Open connection

            //Insert
            cmd.ExecuteNonQuery();

            //Close connection
            conn.Close();
        }

       public Parking getID (string idcard)
        {
            SqlConnection conn = Connection.GetConnection();

            string SQL = string.Format("SELECT * FROM Parking WHERE IDCard = '{0}' ORDER BY Times DESC", idcard);
            SqlCommand cmd = new SqlCommand(SQL,conn);

            SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            dataadapter.Fill(ds);

            foreach (DataRow item in ds.Rows)
            {
                return new Parking(item);
            }
            return null;
        } 

       
    }
}
