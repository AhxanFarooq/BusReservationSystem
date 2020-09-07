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
    public partial class Profile : Form
    {
        private BusReservationEntities db = new BusReservationEntities();
        private Login user = new Login();
        private Customer custUser = new Customer();
        public Profile(Login user)
        {
            this.user = user;
            this.custUser = db.Customers.Where(a => a.Id == user.custId).FirstOrDefault();
            InitializeComponent();

            unLb.Text = user.username;
            mobilLb.Text = custUser.PhoneNo;
            emailTxt.Text = custUser.Email;
        }

        private void ChangePassBtn_Click(object sender, EventArgs e)
        {
            new ChangePassword().Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            this.custUser.Email = emailTxt.Text;
            db.SaveChanges();
            MessageBox.Show("Changings has been saved");
            new CustomerMenu(user).Show();
            this.Hide();
        }
    }
}
