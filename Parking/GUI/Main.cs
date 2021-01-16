using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public Boolean kiemtraHienMotform(string sFormname)
        {

            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(sFormname))
                {
                    f.Activate();
                    return true;
                }
            }
            return false;
        }
        private void parkingMn_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Parking")) return;
            else
            {
                ParkingForm Parking = new ParkingForm();
                Parking.Show();
            }
        }

        private void revenueMn_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Revenue")) return;
            else
            {
                RevenueForm Revenue = new RevenueForm();
                Revenue.Show();
            }
        }

        private void adminMn_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Admin")) return;
            else
            {
                AdminForm Admin = new AdminForm();
                Admin.Show();
            }
        }
    }
}
