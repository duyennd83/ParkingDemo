using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Parking
    {
        String CardID;
        DateTime Times;
        String Status;
        String Type;
        String image;
        

        public Parking()
        {
        }

        public Parking(DataRow row)
        {
            this.CardID1 = row["IDCard"].ToString();
            this.Time1 = DateTime.Parse(row["Times"].ToString());
            this.Status1 = row["Status"].ToString();
            this.Type1 = row["Type"].ToString();
            this.Image = row["Image"].ToString();
        }

        public Parking(string cardID, DateTime time, string status, string type, string image)
        {
            CardID = cardID;
            Times = time;
            Status = status;
            Type = type;
            this.image = image;
        }

        public string CardID1 { get => CardID; set => CardID = value; }
        public DateTime Time1 { get => Times; set => Times = value; }
        public string Status1 { get => Status; set => Status = value; }
        public string Type1 { get => Type; set => Type = value; }
        public string Image { get => image; set => image = value; }
    }
}
