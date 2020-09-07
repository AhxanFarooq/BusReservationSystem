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
    public partial class TicketInfo : Form
    {
        private Login user = new Login();
        private BusReservationEntities db = new BusReservationEntities();
        public TicketInfo(Login user)
        {
            this.user = user;
            try
            {
                var bookData = db.TicketDetails.Where(a => a.custId == user.custId).FirstOrDefault();
                var busDate = db.BusInfoes.Where(c => c.id == bookData.BusId).FirstOrDefault();
                int countSeat = db.SeatInfoes.Count(me => me.BusId == bookData.BusId && me.custId == user.custId);

                InitializeComponent();

                routeLb.Text = busDate.Source + " - " + busDate.Destination;
                aTimeLb.Text = busDate.ArivalTime;
                seatLb.Text = bookData.seatNo;
                dateLb.Text = bookData.dateOfTicket.ToString();
                bookNoLb.Text = bookData.Id.ToString();
                nameLb.Text = user.username;
                dNameLb.Text = busDate.Source;
                dTimeLb.Text = busDate.DepartureTime;
                aNameLb.Text = busDate.Destination;
                aTimeLb.Text = busDate.ArivalTime;
                tFareLb.Text = (countSeat*busDate.Fare).ToString();
                bookNoLb.Text = bookData.Id.ToString();
                dateLb2.Text = bookData.dateOfTicket.ToString();
                qtyLb.Text = countSeat.ToString();
                priceLb.Text = busDate.Fare.ToString();
            }
            catch (Exception)
            {
                this.Hide();
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            new CustomerMenu(user).Show();
            this.Hide();
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your payment has been done successfully");
        }
    }
}
