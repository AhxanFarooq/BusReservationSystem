using BusReservationSystem.PresistenceLayer;
using BusReservationSystem.UserInterface.AdminUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusReservationSystem.UserInterface
{
    public partial class ManageBuses : Form
    {
        private DBAccess db = new DBAccess();
        static int id = 0;
        public ManageBuses()
        {
            InitializeComponent();
            noOfBusLb.Text = db.TotalNoOBus().ToString();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new AdminMenu().Show();
            this.Hide();
        }

        private void CustBtn_Click(object sender, EventArgs e)
        {
            new ManageCustomer().Show();
            this.Close();
        }

        private void BusBtn_Click(object sender, EventArgs e)
        {
            new ManageBuses().Show();
            this.Hide();
        }

        private void DriverBtn_Click(object sender, EventArgs e)
        {
            new ManageBookings().Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            new AddBuses().Show();
            this.Hide();
        }

        private void ManageBuses_Load(object sender, EventArgs e)
        {
            busGridView1.DataSource = db.GetAllBuses();
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            this.searchBox.Text = "";
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (this.searchBox.Text == string.Empty)
            {
                this.searchBox.Text = "Search..";
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("those buses which have all seats are booked"))
            {
                busGridView1.DataSource =  db.GetFullBookedBuses();
            }
            else if (comboBox1.Text.Equals("those which have no seats booked"))
            {
                busGridView1.DataSource = db.getEmptyBuses();
            }
            else if (comboBox1.Text.Equals("back side bookingsthose which arival time is in evening"))
            {

            }
            else if (comboBox1.Text.Equals("those which arival time is in morning"))
            {

            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void BusGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            id = Convert.ToInt32(busGridView1.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception)
            {

            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text.Equals("BusNo"))
            {
                busGridView1.DataSource = db.GetBusesByNo(searchBox.Text);
            }
            else if (comboBox2.Text.Equals("ID"))
            {
                busGridView1.DataSource = db.GetBusesByID(searchBox.Text);
            }
            else if (comboBox2.Text.Equals("Source"))
            {
                busGridView1.DataSource = db.GetBusesBySource(searchBox.Text);
            }
            else if (comboBox2.Text.Equals("Destination"))
            {
                busGridView1.DataSource = db.GetBusesByDestination(searchBox.Text);
            }
            else if (comboBox2.Text.Equals("Fare"))
            {
                busGridView1.DataSource = db.GetBusesByFare(searchBox.Text);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            db.DeleteFromBusInfo(id);
            busGridView1.DataSource = db.GetAllBuses();
        }
    }
}
