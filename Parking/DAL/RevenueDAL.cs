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
    public class RevenueDAL
    {
        public void AddRevenueDB(Revenue myrevenue)
        {

            SqlConnection conn = Connection.GetConnection();

            //SQL

            string SQL = string.Format("INSERT INTO Revenue(IDCard, TimeIn, TimeOut, Type, Pay) " +
                "VALUES ('{0}', '{1}', '{2}','{3}','{4}')", myrevenue.CardID1, myrevenue.TimeIn1, myrevenue.TimeOut1, myrevenue.Type1, myrevenue.Pay1);

            SqlCommand cmd = new SqlCommand(SQL, conn);

            cmd.Connection = conn;

            //Open connection

            //Insert
            cmd.ExecuteNonQuery();

            //Close connection
            conn.Close();


        }

        public List<Revenue> getReDate(string TimeIn, string TimeOut)
        {
            List<Revenue> revenueList = new List<Revenue>();
            SqlConnection conn = Connection.GetConnection();
            string SQL = string.Format("SELECT * FROM Statistical WHERE TimeIn >= '" + TimeIn + "' AND TimeIn <= '" + TimeOut + "'");
            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            dataadapter.Fill(ds);
            foreach (DataRow item in ds.Rows)
            {
                Revenue revenue = new Revenue(item);
                revenueList.Add(revenue);
            }
            return revenueList;

        }

        public List<Revenue>  getDay(string day, string month, string year)
        {
            List<Revenue> revenueList = new List<Revenue>();
            SqlConnection conn = Connection.GetConnection();

            string SQL = string.Format("SELECT * FROM Revenue WHERE DAY(TimeIn) = '{0}' AND MONTH(TimeIn) = '{1}' AND YEAR(TimeIn) = '{2}'", day, month, year);
            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            dataadapter.Fill(ds);
            foreach (DataRow item in ds.Rows)
            {
                Revenue revenue = new Revenue(item);
                revenueList.Add(revenue);
            }
            return revenueList;

        }
        public List<Revenue>  getMonth(string month, string year)
        {
            List<Revenue> revenueList = new List<Revenue>();
            SqlConnection conn = Connection.GetConnection();

            string SQL = string.Format("SELECT * FROM Revenue WHERE MONTH(TimeIn) = '{0}' AND YEAR(TimeIn) = '{1}'", month, year);
            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            dataadapter.Fill(ds);
            foreach (DataRow item in ds.Rows)
            {
                Revenue revenue = new Revenue(item);
                revenueList.Add(revenue);
            }
            return revenueList;

        }        
        public List<Revenue>  getYear(string year)
        {
            List<Revenue> revenueList = new List<Revenue>();
            SqlConnection conn = Connection.GetConnection();

            string SQL = string.Format("SELECT * FROM Revenue WHERE YEAR(TimeIn) = '{0}'", year);
            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            dataadapter.Fill(ds);
            foreach (DataRow item in ds.Rows)
            {
                Revenue revenue = new Revenue(item);
                revenueList.Add(revenue);
            }
            return revenueList;

        }


    }
}
