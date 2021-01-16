using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Revenue
    {
        String CardID;
        DateTime TimeIn;
        DateTime TimeOut;
        String Type;
        double Pay;
        public Revenue()
        {
        }

        public Revenue(DataRow row)
        {
            this.CardID1 = row["IDCard"].ToString();
            this.TimeIn1 = DateTime.Parse(row["TimeIn"].ToString());
            this.TimeOut1 = DateTime.Parse(row["TimeOut"].ToString());
            this.Type1 = row["Type"].ToString();
            this.Pay1 = (float)row["Pay"];
        }

        public Revenue(string cardID, DateTime timeIn, DateTime timeOut, string type, double pay)
        {
            CardID1 = cardID;
            TimeIn1 = timeIn;
            TimeOut1 = timeOut;
            Type1 = type;
            Pay1 = pay;
        }

        public string CardID1 { get => CardID; set => CardID = value; }
        public DateTime TimeIn1 { get => TimeIn; set => TimeIn = value; }
        public DateTime TimeOut1 { get => TimeOut; set => TimeOut = value; }
        public string Type1 { get => Type; set => Type = value; }
        public double Pay1 { get => Pay; set => Pay = value; }



    }
}
