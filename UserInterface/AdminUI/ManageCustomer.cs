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
    public partial class ManageCustomer : Form
    {
        int id = 0;
        private DBAccess db = new DBAccess();
        public ManageCustomer()
        {
            InitializeComponent();
            noOfCustLb.Text = db.TotalNoOCust().ToString();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new AdminMenu().Show();
            this.Close();
        }

        private void BusBtn_Click(object sender, EventArgs e)
        {
            new ManageBuses().Show();
            this.Close();
        }

        private void DriverBtn_Click(object sender, EventArgs e)
        {
            new ManageBookings().Show();
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            new AddCustomer().Show();
            this.Close();
        }

        private void CustBtn_Click(object sender, EventArgs e)
        {
            new ManageCustomer().Show();
            this.Hide();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            new AdminLogins().Show();
            this.Close();
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            custGridView.DataSource = db.GetAllCustomers();
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
            if (comboBox1.Text.Equals("Customers who makes booking"))
            {
                custGridView.DataSource = db.GetBookCustomers();
            }
            else if (comboBox1.Text.Equals("Customers who did not make any booking"))
            {
                custGridView.DataSource = db.GetNoMakeBookCustomers();
            }
            else if (comboBox1.Text.Equals("Customers who booked 2 or more seats"))
            {
                custGridView.DataSource = db.Get2OrMoreBookCustomers();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text.Equals("Name"))
            {
                custGridView.DataSource = db.GetCustomersName(searchBox.Text);
            }
            else if (comboBox2.Text.Equals("ID"))
            {
                custGridView.DataSource = db.GetCustomersByID(searchBox.Text);
            }
            else if (comboBox2.Text.Equals("PhoneNo"))
            {
                custGridView.DataSource = db.GetCustomersByPhoneNo(searchBox.Text);
            }
            else if (comboBox2.Text.Equals("Email"))
            {
                custGridView.DataSource = db.GetCustomersByEmail(searchBox.Text);
            }
        }

        private void CustGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            id = Convert.ToInt32(custGridView.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception)
            {

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            db.DeleteCustomer(id);
            custGridView.DataSource = db.GetAllCustomers();
        }
    }
}
