using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AdminForm : Form
    {
        BindingSource userList = new BindingSource();
        public AdminForm()
        {
            InitializeComponent();
        }

        public string textValue = "";
        public bool exist = false;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;


            String location = @"D:\Material\SIU_LYTHUYET\CNPTPMTT\Parking_Basic\parktext.txt";
            if (File.Exists(location))
            {
                while (textValue == "")
                {
                    StreamReader sr = new StreamReader(location);

                    string line = sr.ReadLine();
                    while (line != null)
                    {

                        backgroundWorker1.CancelAsync();


                        textValue = line;
                        line = sr.ReadLine();


                    }

                    sr.Close();
                    StreamWriter sw = new StreamWriter(location);
                    sw.WriteLine("");
                    sw.Close();

                    if (textValue == "")
                    {
                        System.Threading.Thread.Sleep(1000);
                    }
                }

            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

    
              txtReader.Text = textValue;
              DateTime aDateTime = DateTime.Now;
              DateTime newDatetime = DateTime.Now.AddMonths(1);
              txtTime.Text = newDatetime.ToString();
               

              Bitmap myImg;
              string directory = @"D:\Material\SIU_LYTHUYET\CNPTPMTT\Parking_Basic\images\";

              int id = Int32.Parse(textValue[textValue.Length - 1].ToString()) + Int32.Parse(textValue[textValue.Length - 2].ToString());
              directory = directory + id.ToString() + ".png";
              myImg = new Bitmap(directory);
              picBox.ClientSize = new Size(myImg.Width, myImg.Height);
              picBox.Image = (Image)myImg;
          


        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
   
            LoadGridViewData();
        }

        void LoadGridViewData()
        {

            DataTable ds = UserDAL.getListUser();

            dtgvUser.DataSource = ds;
        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (textValue != "")
            {
                ParkingDAL dalpark = new ParkingDAL();
                RevenueDAL dalRev = new RevenueDAL();
                int id = Int32.Parse(textValue[textValue.Length - 1].ToString()) + Int32.Parse(textValue[textValue.Length - 2].ToString());
                DateTime aDateTime = DateTime.Now;
                DateTime newDatetime = DateTime.Now.AddMonths(1);
                txtTime.Text = newDatetime.ToString();
                String status = "IN";
                String type = "USER";

                if (dalpark.getID(textValue) == null)
                {
                    Parking myparking = new Parking(txtReader.Text, aDateTime, id.ToString(), status, type);
                    Revenue myrevenue = new Revenue(txtReader.Text, aDateTime, newDatetime, type, 200000);
                    dalpark.AddDB(myparking);
                    dalRev.AddRevenueDB(myrevenue);


                    LoadGridViewData();


                    MessageBox.Show("Thêm tài khoản thành công", "Thành Công");
                }
            }
        }

        private void dtgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
