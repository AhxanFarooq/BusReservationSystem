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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
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

        private void Button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            new AdminLogins().Show();
            this.Close();
        }
    }
}
