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
    public partial class Prebookseats : Form
    {
        private Login user = new Login();
        private BusReservationEntities db = new BusReservationEntities();
        public Prebookseats(Login user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BuyTicBtn_Click(object sender, EventArgs e)
        {
            if (bookNoTxt.Text!=string.Empty && phoneNoTxt.Text != string.Empty)
            {
                var bookData = db.TicketDetails.Where(a => a.custId == user.custId).FirstOrDefault();
                var cust = db.Customers.Where(a => a.Id == user.custId).FirstOrDefault();
                if (bookNoTxt.Text.Equals(bookData.Id.ToString()))
                {
                    if (phoneNoTxt.Text.Equals(cust.PhoneNo))
                    {
                        new TicketInfo(user).Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Phone No");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Booking No");
                }
            }
            else
            {
                MessageBox.Show("Please fill all information");
            }
        }
    }
}
