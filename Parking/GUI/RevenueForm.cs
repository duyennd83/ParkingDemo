using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class RevenueForm : Form
    {
        BindingSource revenueList= new BindingSource();
        
        public RevenueForm()
        {
            InitializeComponent();

            Loaddtgv();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void Loaddtgv()
        {
            
            dtgRevenue.DataSource = revenueList;
            LoadListStatis();


        }

        void LoadListStatis()
        {
            RevenueDAL dalrev = new RevenueDAL();

            dtpDay.Format = DateTimePickerFormat.Custom;
            dtpDay.CustomFormat = "dd";
            dtpDay.ShowUpDown = true;

            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.CustomFormat = "M";
            dtpMonth.ShowUpDown = true;

            dtpYear.Format = DateTimePickerFormat.Custom;
            dtpYear.CustomFormat = "yyyy";
            dtpYear.ShowUpDown = true;

           revenueList.DataSource = dalrev.getReDate(dtpFrom.Value.ToString("yyyy-M-dd"), dtpTo.Value.ToString("yyyy-M-dd"));

            //statisList.DataSource = GuestDAL.Instance.getStatisticalDBByDate(dtpkSortByDay.Value.ToString("yyyy-M-dd"), dtpkSortByDay.Value.ToString("yyyy-M-dd"));

            customStatisgv();


        }

        void customStatisgv()
        {


            this.dtgRevenue.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgRevenue.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgRevenue.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgRevenue.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgRevenue.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgRevenue.Columns[0].HeaderText = "cardID";
            this.dtgRevenue.Columns[1].HeaderText = "timeIn";
            this.dtgRevenue.Columns[2].HeaderText = "timeOut";
            this.dtgRevenue.Columns[3].HeaderText = "type";
            this.dtgRevenue.Columns[4].HeaderText = "money";

        }

        public string textValue = "";
        public bool exist = false;

        void LoadrevenueDay()
        {
            RevenueDAL dalrev = new RevenueDAL();

            revenueList.DataSource = dalrev.getDay(dtpDay.Value.Day.ToString(), dtpMonth.Value.Month.ToString(), dtpYear.Value.Year.ToString());


        }

        void LoadrevenueMonth()
        {
            RevenueDAL dalrev = new RevenueDAL();

            revenueList.DataSource = dalrev.getMonth(dtpMonth.Value.Month.ToString(), dtpYear.Value.Year.ToString());


        }        
        void LoadrevenueYear()
        {
            RevenueDAL dalrev = new RevenueDAL();

            revenueList.DataSource = dalrev.getYear( dtpYear.Value.Year.ToString());


        }
        
        private void btnDay_Click(object sender, EventArgs e)
        {
            LoadrevenueDay();
            dtgRevenue.DataSource = revenueList;
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            LoadrevenueMonth();
            dtgRevenue.DataSource = revenueList;
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            LoadrevenueYear();
            dtgRevenue.DataSource = revenueList;
        }

        private void dtgRevenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
