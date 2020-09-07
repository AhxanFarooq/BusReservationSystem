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
    public partial class CustomerTicketReservation : Form
    {
        private BusReservationEntities db;
        private Boolean flag = true;
        private Login user = new Login();
        private BusInfo busUser = new BusInfo();
        List<int> selectedSeats;
        public CustomerTicketReservation(Login user, BusInfo busUser)
        {
            this.user = user;
            this.busUser = busUser;
            this.selectedSeats = SelectSeat.selectedSeats;

            db = new BusReservationEntities();

            InitializeComponent();
            usernameLb.Text = user.username.ToUpper();
            try{
                busId.Text = this.busUser.BusNo.ToString();
            }catch (Exception)
            {

            }

            var item = db.Customers.Where(a => a.Id == this.user.custId).FirstOrDefault();
            CustomerId.Text = item.Id.ToString();
            try
            {
                customerNameTxt.Text = item.Name;
                fatherNameTxt.Text = item.FatherName;
                dateTimePicker1.Text = item.DateOfBirth.ToString();
                emailTxt.Text = item.Email;
                phoneNumTxt.Text = item.PhoneNo;
                addressTxt.Text = item.Address;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.GetBaseException().ToString());

            }

            selectSeatLb.Text = SelectSeat.seats;

            BindSource();
            BindDestination();
        }

        private void BindDestination()
        {
            var item = db.BusInfoes.ToList();
            List<string> destination = item.Select(a => a.Destination).Distinct().ToList();
            destinationCombo.DataSource = destination;
        }

        private void BindSource()
        {
            var item = db.BusInfoes.ToList();
            List<string> source = item.Select(a => a.Source).Distinct().ToList();
            sourceCombo.DataSource = source;
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            if (sourceCombo.Text != destinationCombo.Text)
            {
                var item = db.BusInfoes.Where(a => a.Source.Equals(sourceCombo.Text) && a.Destination.Equals(destinationCombo.Text)).ToList();
                // List<string> source = item.Select(a => a.id && a.name && a.arivalTime && a.departureTime).
                dataGridView1.DataSource = item;
            }
        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            var bookData = db.TicketDetails.Where(a => a.custId == user.custId).FirstOrDefault();
            if (bookData == null)
            {
                try
                {
                    db.TicketDetails.Add(new TicketDetail
                    {
                        BusId = busUser.id,
                        custId = user.custId,
                        dateOfTicket = dateOfJurDt.Value,
                        seatNo = SelectSeat.seats
                    });
                    db.SaveChanges();
                    this.bookedSeat(this.selectedSeats);
                    MessageBox.Show(SelectSeat.seats + " Seats are booked");
                    new TicketInfo(user).Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please select seats First");
                }
            }
            else
            {
                MessageBox.Show("You Allredy Booked a seat");
            }
            
        }

        public void bookedSeat(List<int> selectedSeats)
        {
            string seatsType = "";

            for (int j = 0; j < selectedSeats.Count; j++)
            {
                if (selectedSeats[j] <= 12)
                    seatsType = "Front Seat";
                else if (selectedSeats[j] > 12 && selectedSeats[j] < 28)
                    seatsType = "Middle Seat";
                else
                    seatsType = "Back Seat";
                db.SeatInfoes.Add(new SeatInfo
                {
                    status = "Booked",
                    type = seatsType.ToString(),
                    BusId = busUser.id,
                    seatNo = selectedSeats[j],
                    custId = this.user.custId
                });
                db.SaveChanges();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new CustomerMenu(user).Show();
            this.Close();
        }

        private void ViewSeatsBtn_Click_1(object sender, EventArgs e)
        {
            var bookData = db.TicketDetails.Where(a => a.custId == user.custId).FirstOrDefault();
            //var countSeat = db.SeatInfoes.Where(me => me.BusId == bookData.BusId && me.custId == user.custId).ToList(); ;
            if (bookData == null)
            {
                try
                {
                    this.Hide();
                    new SelectSeat(user, busUser).ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Bus First");
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("You Allredy reserve seat");
            }
        }

        private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try { 
                var busid = dataGridView1.SelectedRows[0].Cells[1].Value;
                busId.Text = busid.ToString();
                var user = db.BusInfoes.Where(a => a.BusNo.Equals(busId.Text)).FirstOrDefault();
                busUser = user;
            }
            catch (Exception)
            {

            }

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

        private void Button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            new Profile(user).Show();
            //this.Hide();
        }
    }
}
