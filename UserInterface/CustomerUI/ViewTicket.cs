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
    public partial class ViewTicket : Form
    {
        private Login user = new Login();
        private BusReservationEntities db = new BusReservationEntities();
        private TicketDetail ticket = new TicketDetail();
        private BusInfo bus = new BusInfo();
        private List<SeatInfo> seats = new List<SeatInfo>();
        public ViewTicket(Login user)
        {
            this.user = user;
            try
            {
                
                var bookData = db.TicketDetails.Where(a => a.custId == user.custId).FirstOrDefault();
                var busDate = db.BusInfoes.Where(c => c.id == bookData.BusId).FirstOrDefault();
                var countSeat = db.SeatInfoes.Where(me => me.BusId == bookData.BusId && me.custId == user.custId).ToList();

                this.ticket = bookData;
                this.bus = busDate;
                this.seats = countSeat;

                InitializeComponent();

                routeLb.Text = busDate.Source + " - " + busDate.Destination;
                timeLb.Text = busDate.ArivalTime;
                seatLb.Text = bookData.seatNo;
                dateLb.Text = bookData.dateOfTicket.ToString();
                bookNoLb.Text = bookData.Id.ToString();
                unlbl.Text = user.username.ToUpper();
            }
            catch (Exception)
            {
                this.Hide();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           // new CustomerMenu(user).Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(ticket != null && seats != null)
            {
                db.TicketDetails.Remove(ticket);
                for (int i = 0; i<seats.Count();i++)
                {
                    db.SeatInfoes.Remove(seats[i]);
                }
                db.SaveChanges();
                MessageBox.Show("Ticket has been removed");
                this.Hide();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Paymentbtn_Click(object sender, EventArgs e)
        {
            new TicketInfo(user).Show();
        }
    }
}