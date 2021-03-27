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
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ParkingForm : Form
    {
        List<Parking> ParkingList = new List<Parking>();
        
        List<Revenue> RevenueList = new List<Revenue>();

        public ParkingForm()
        {
            InitializeComponent();
            GUI_Load();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
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
            int value = Int32.Parse(FindTexValueInParking(textValue).ToString());
            // case1
            if (value == -1)
            {
                txtReader.Text = textValue;
                txtTime.Text = DateTime.Now.ToString();
                txtStatus.Text = "IN";
                txtType.Text = "GUEST";

                Bitmap myImg;
                string directory = @"D:\Material\SIU_LYTHUYET\CNPTPMTT\Parking_Basic\images\";

                int id = Int32.Parse(textValue[textValue.Length - 1].ToString()) + Int32.Parse(textValue[textValue.Length - 2].ToString());
                directory = directory + id.ToString() + ".png";
                myImg = new Bitmap(directory);
                picBox.ClientSize = new Size(myImg.Width, myImg.Height);
                picBox.Image = (Image)myImg;
            }
            else
            {
                ParkingDAL dalpark = new ParkingDAL();

                if(dalpark.getID(textValue) !=null )
                {
                    txtType.Text = dalpark.getID(textValue).Type1;
                    //case 2
                    if (dalpark.getID(textValue).Status1.ToString().Equals("IN") == true && dalpark.getID(textValue).Type1.ToString().Equals("USER") == true)
                    {
                        Bitmap myImg;
                        string directory = @"D:\Material\SIU_LYTHUYET\CNPTPMTT\Parking_Basic\images\";

                        int id = Int32.Parse(textValue[textValue.Length - 1].ToString()) + Int32.Parse(textValue[textValue.Length - 2].ToString());
                        directory = directory + id.ToString() + ".png";
                        myImg = new Bitmap(directory);

                        txtReader.Text = dalpark.getID(textValue).CardID1;
                        txtTime.Text = dalpark.getID(textValue).Time1.ToString();
                        txtStatus.Text = dalpark.getID(textValue).Status1;
                        txtType.Text = dalpark.getID(textValue).Type1;
                        picBox.ClientSize = new Size(myImg.Width, myImg.Height);
                        picBox.Image = (Image)myImg;


                        txtReaderOut.Text = dalpark.getID(textValue).CardID1;
                        txtTimeOut.Text = DateTime.Now.ToString();
                        txtStatusOut.Text = "OUT";
                        txtTypeOut.Text = "USER";
                        pbOut.ClientSize = new Size(myImg.Width, myImg.Height);
                        pbOut.Image = (Image)myImg;

                    }
                    //case 3
                    else
                        if (dalpark.getID(textValue).Status1.ToString().Equals("OUT") == true && dalpark.getID(textValue).Type1.ToString().Equals("USER") == true)
                        {
                            Bitmap myImg;
                            string directory = @"D:\Material\SIU_LYTHUYET\CNPTPMTT\Parking_Basic\images\";

                            int id = Int32.Parse(textValue[textValue.Length - 1].ToString()) + Int32.Parse(textValue[textValue.Length - 2].ToString());

                            directory = directory + id.ToString() + ".png";
                            myImg = new Bitmap(directory);

                            txtReader.Text = dalpark.getID(textValue).CardID1;
                            txtTime.Text = dalpark.getID(textValue).Time1.ToString();
                            txtStatus.Text = dalpark.getID(textValue).Status1;
                            txtType.Text = dalpark.getID(textValue).Type1;
                            picBox.ClientSize = new Size(myImg.Width, myImg.Height);
                            picBox.Image = (Image)myImg;


                            txtReaderOut.Text = dalpark.getID(textValue).CardID1;
                            txtTimeOut.Text = DateTime.Now.ToString();
                            txtStatusOut.Text = "IN";
                            txtTypeOut.Text = "USER";
                            pbOut.ClientSize = new Size(myImg.Width, myImg.Height);
                            pbOut.Image = (Image)myImg;

                        }
                    //case 4
                    else
                       if (dalpark.getID(textValue).Status1.ToString().Equals("IN") == true && dalpark.getID(textValue).Type1.ToString().Equals("GUEST") == true)
                       {
                            Bitmap myImg;
                            string directory = @"D:\Material\SIU_LYTHUYET\CNPTPMTT\Parking_Basic\images\";

                            int id = Int32.Parse(textValue[textValue.Length - 1].ToString()) + Int32.Parse(textValue[textValue.Length - 2].ToString());

                            directory = directory + id.ToString() + ".png";
                            myImg = new Bitmap(directory);

                            txtReader.Text = dalpark.getID(textValue).CardID1;
                            txtTime.Text = dalpark.getID(textValue).Time1.ToString();
                            txtStatus.Text = dalpark.getID(textValue).Status1;
                            txtType.Text = dalpark.getID(textValue).Type1;
                            picBox.ClientSize = new Size(myImg.Width, myImg.Height);
                            picBox.Image = (Image)myImg;


                            txtReaderOut.Text = dalpark.getID(textValue).CardID1;
                            txtTimeOut.Text = DateTime.Now.ToString();
                            txtStatusOut.Text = "OUT";
                            txtTypeOut.Text = "GUEST";
                            pbOut.ClientSize = new Size(myImg.Width, myImg.Height);
                            pbOut.Image = (Image)myImg;
                        
                       }
                }
                    


            }
        }

       

        private int FindTexValueInParking(string textValue)
        {
            int value = -1;

            for(int i=0; i<ParkingList.Count; i++)
            {
                if(textValue.CompareTo(ParkingList[i].CardID1) ==0)
                {
                    value = 1;
                }
            }
            return value;
        }



        private void GUI_Load()
        {

            SqlConnection conn = Connection.GetConnection();


            string sql = "SELECT * FROM Parking";

            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds);
            DataTable dt = ds.Tables[0];

            int rows = dt.Rows.Count;

            for (int i = 0; i < rows; i++)
            {
                Parking parking = new Parking();
                parking.CardID1 = dt.Rows[i]["IDCard"].ToString();
                /*string v = dt.Rows[i]["Times"].ToString()*/;
                parking.Time1 = DateTime.Parse(dt.Rows[i]["Times"].ToString());
                parking.Image = dt.Rows[i]["Image"].ToString();
                parking.Status1 = dt.Rows[i]["Status"].ToString();
                parking.Type1 = dt.Rows[i]["Type"].ToString();
                ParkingList.Add(parking);
            }
            conn.Close();

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(FindTexValueInParking(textValue).ToString());
            ParkingDAL dalpark = new ParkingDAL();
            RevenueDAL dalrev = new RevenueDAL();
            double Pay = 0;
            // case1
            if (value == -1)
            {
                txtReader.Text = textValue;
                txtTime.Text = DateTime.Now.ToString();
                txtStatus.Text = "IN";
                txtType.Text = "GUEST";

                Bitmap myImg;
                string directory = @"D:\Material\SIU_LYTHUYET\CNPTPMTT\Parking_Basic\images\";

                int id = Int32.Parse(textValue[textValue.Length - 1].ToString()) + Int32.Parse(textValue[textValue.Length - 2].ToString());
                directory = directory + id.ToString() + ".png";
                myImg = new Bitmap(directory);
                picBox.ClientSize = new Size(myImg.Width, myImg.Height);
                picBox.Image = (Image)myImg;

                Parking myparking = new Parking(txtReader.Text, DateTime.Now, txtStatus.Text, txtType.Text, id.ToString());
                dalpark.AddDB(myparking);
            }
            else
            {


                if (dalpark.getID(textValue) != null)
                {
                    txtType.Text = dalpark.getID(textValue).Type1;
                    //case 2
                    if (dalpark.getID(textValue).Status1.ToString().Equals("IN") == true && dalpark.getID(textValue).Type1.ToString().Equals("USER") == true)
                    {
                        Bitmap myImg;
                        string directory = @"D:\Material\SIU_LYTHUYET\CNPTPMTT\Parking_Basic\images\";

                        int id = Int32.Parse(textValue[textValue.Length - 1].ToString()) + Int32.Parse(textValue[textValue.Length - 2].ToString());
                        directory = directory + id.ToString() + ".png";
                        myImg = new Bitmap(directory);

                        txtReader.Text = dalpark.getID(textValue).CardID1;
                        txtTime.Text = dalpark.getID(textValue).Time1.ToString();
                        txtStatus.Text = dalpark.getID(textValue).Status1;
                        txtType.Text = dalpark.getID(textValue).Type1;
                        picBox.ClientSize = new Size(myImg.Width, myImg.Height);
                        picBox.Image = (Image)myImg;


                        txtReaderOut.Text = dalpark.getID(textValue).CardID1;
                        txtTimeOut.Text = DateTime.Now.ToString();
                        txtStatusOut.Text = "OUT";
                        txtTypeOut.Text = "USER";
                        pbOut.ClientSize = new Size(myImg.Width, myImg.Height);
                        pbOut.Image = (Image)myImg;

                        Parking myparking = new Parking(txtReaderOut.Text, DateTime.Now, txtStatusOut.Text, txtTypeOut.Text, id.ToString());
                        dalpark.UpdateDB(myparking);
                    }
                    //case 3
                    else
                        if (dalpark.getID(textValue).Status1.ToString().Equals("OUT") == true && dalpark.getID(textValue).Type1.ToString().Equals("USER") == true)
                    {
                        Bitmap myImg;
                        string directory = @"D:\Material\SIU_LYTHUYET\CNPTPMTT\Parking_Basic\images\";

                        int id = Int32.Parse(textValue[textValue.Length - 1].ToString()) + Int32.Parse(textValue[textValue.Length - 2].ToString());

                        directory = directory + id.ToString() + ".png";
                        myImg = new Bitmap(directory);

                        txtReader.Text = dalpark.getID(textValue).CardID1;
                        txtTime.Text = dalpark.getID(textValue).Time1.ToString();
                        txtStatus.Text = dalpark.getID(textValue).Status1;
                        txtType.Text = dalpark.getID(textValue).Type1;
                        picBox.ClientSize = new Size(myImg.Width, myImg.Height);
                        picBox.Image = (Image)myImg;


                        txtReaderOut.Text = dalpark.getID(textValue).CardID1;
                        txtTimeOut.Text = DateTime.Now.ToString();
                        txtStatusOut.Text = "IN";
                        txtTypeOut.Text = "USER";
                        pbOut.ClientSize = new Size(myImg.Width, myImg.Height);
                        pbOut.Image = (Image)myImg;

                        Parking myparking = new Parking(txtReaderOut.Text, DateTime.Now, txtStatusOut.Text, txtTypeOut.Text, id.ToString());
                        dalpark.UpdateDB(myparking);
                    }
                    //case 4
                    else
                       if (dalpark.getID(textValue).Status1.ToString().Equals("IN") == true && dalpark.getID(textValue).Type1.ToString().Equals("GUEST") == true)
                    {
                        Bitmap myImg;
                        string directory = @"D:\Material\SIU_LYTHUYET\CNPTPMTT\Parking_Basic\images\";

                        int id = Int32.Parse(textValue[textValue.Length - 1].ToString()) + Int32.Parse(textValue[textValue.Length - 2].ToString());

                        directory = directory + id.ToString() + ".png";
                        myImg = new Bitmap(directory);

                        txtReader.Text = dalpark.getID(textValue).CardID1;
                        txtTime.Text = dalpark.getID(textValue).Time1.ToString();
                        txtStatus.Text = dalpark.getID(textValue).Status1;
                        txtType.Text = dalpark.getID(textValue).Type1;
                        picBox.ClientSize = new Size(myImg.Width, myImg.Height);
                        picBox.Image = (Image)myImg;


                        txtReaderOut.Text = dalpark.getID(textValue).CardID1;
                        txtTimeOut.Text = DateTime.Now.ToString();
                        txtStatusOut.Text = "OUT";
                        txtTypeOut.Text = "GUEST";
                        pbOut.ClientSize = new Size(myImg.Width, myImg.Height);
                        pbOut.Image = (Image)myImg;

                        TimeSpan difference = DateTime.Parse(txtTimeOut.Text) - DateTime.Parse(txtTime.Text);
                        Pay = (float)(difference.TotalHours * 0.1 + 1000);

                        DialogResult dr = MessageBox.Show(string.Format("Số tiền cần phải trả là {0} đồng \nThời gian xe vào {1}", Pay, dalpark.getID(textValue).Time1.ToString()), "Trả tiền", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                Revenue revenue = new Revenue(dalpark.getID(textValue).CardID1, DateTime.Parse(dalpark.getID(textValue).Time1.ToString()), DateTime.Now, dalpark.getID(textValue).Type1, (float)Pay);
                                dalrev.AddRevenueDB(revenue);
                                dalpark.DeleteDB(dalpark.getID(textValue).CardID1);
                                MessageBox.Show("Tính tiền thành công", " Thành công");
                                break;
                            case DialogResult.No:
                                MessageBox.Show("Tính tiền thất bại", " Thất bại");
                                break;
                        }
                    }
                }


            }

            txtReader.Text = "";
            txtTime.Text = "";
            txtStatus.Text = "";
            txtType.Text = "";
            textValue = "";
            picBox.Image = null;

            txtReaderOut.Text = "";
            txtTimeOut.Text = "";
            txtStatusOut.Text = "";
            txtTypeOut.Text = "";
            textValue = "";
            pbOut.Image = null;
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtReader.Text = "";
            txtTime.Text = "";
            txtStatus.Text = "";
            txtType.Text = "";
            picBox.Image = null;
            textValue = "";

            txtReaderOut.Text = "";
            txtTimeOut.Text = "";
            txtStatusOut.Text = "";
            txtTypeOut.Text = "";
            pbOut.Image = null;
            textValue = "";

            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
