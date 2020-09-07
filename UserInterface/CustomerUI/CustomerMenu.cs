using BusReservationSystem.UserInterface.CustomerUI;
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
    public partial class CustomerMenu : Form
    {
        private Boolean flag = true;
        private Login user = new Login();
        public CustomerMenu(Login user)
        {
            this.user = user;
            InitializeComponent();
            usernameLb.Text = user.username.ToUpper();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                Drower.Visible = false;
                flag = false;
            }
            else
            {
                Drower.Visible = true;
                flag = true;
            }
        }

        private void BookSeatPictureBox_Click(object sender, EventArgs e)
        {
           
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            new CustomerMenu(user).Show();
            this.Close();
        }

        private void MyTicPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            new Profile(user).Show();
        }

        private void BuyTicPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void BookStBtn_Click(object sender, EventArgs e)
        {
            CustomerTicketReservation ticket = new CustomerTicketReservation(this.user, null);
            ticket.Show();
            this.Close();
        }

        private void BuyTicBtn_Click(object sender, EventArgs e)
        {
            new TicketInfo(user).Show();
        }

        private void MyBookBtn_Click(object sender, EventArgs e)
        {
            new ViewTicket(user).Show();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ContactUsBtn_Click(object sender, EventArgs e)
        {

        }

        private void PreBookBnt_Click(object sender, EventArgs e)
        {
            new Prebookseats(user).Show();
        }

        private void ComplainBtn_Click(object sender, EventArgs e)
        {
            new Complaints().Show();
        }

        private void TravelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
