using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        String CardID;
        DateTime Times;
        String image;

        public User(string cardID, DateTime times, string image)
        {
            CardID = cardID;
            Times = times;
            this.image = image;
        }

        public User()
        {

        }

        public string CardID1 { get => CardID; set => CardID = value; }
        public DateTime Times1 { get => Times; set => Times = value; }
        public string Image { get => image; set => image = value; }
    }
}
