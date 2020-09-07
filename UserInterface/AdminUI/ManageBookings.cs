using BusReservationSystem.PresistenceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusReservationSystem.UserInterface.AdminUI
{
    public partial class ManageBookings : Form
    {
        int id = 0;
        private DBAccess db = new DBAccess();
        public ManageBookings()
        {
            InitializeComponent();
            noOfBookLb.Text = db.TotalNoOBook().ToString();
        }

        private void DriverBtn_Click(object sender, EventArgs e)
        {
            new ManageBookings().Show();
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

        private void ManageBookings_Load(object sender, EventArgs e)
        {
            bookingGridView1.DataSource = db.GetAllBookings();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new AdminMenu().Show();
            this.Hide();
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
            if (comboBox1.Text.Equals("front side bookings"))
            {
                bookingGridView1.DataSource = db.GetFronBookings();
            }
            else if (comboBox1.Text.Equals("middle bookings"))
            {
                bookingGridView1.DataSource = db.GetMiddleBookings();
            }
            else if (comboBox1.Text.Equals("back side bookings"))
            {
                bookingGridView1.DataSource = db.GetBackBookings();
            }
            else if (comboBox1.Text.Equals("which have 2 or more seats reserved"))
            {
                bookingGridView1.DataSource = db.Get2OrMoreResBookings();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text.Equals("ID"))
            {
                bookingGridView1.DataSource = db.GetBookingDetailsByID(searchBox.Text);
            }
            else if (comboBox2.Text.Equals("CustID"))
            {
                bookingGridView1.DataSource = db.GetBookingDetailsByCustID(searchBox.Text);
            }
            else if (comboBox2.Text.Equals("BusID"))
            {
                bookingGridView1.DataSource = db.GetBookingDetailsByBusID(searchBox.Text);
            }
        }

        private void BookingGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(bookingGridView1.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception)
            {

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            db.DeleteFromBookings(id);
            bookingGridView1.DataSource = db.GetAllBookings();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
