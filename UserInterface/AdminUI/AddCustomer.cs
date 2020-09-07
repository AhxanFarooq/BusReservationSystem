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

namespace BusReservationSystem.UserInterface
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new ManageCustomer().Show();
            this.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            if (passText.Text == passConfText.Text)
            {
                int id = db.InsertCustomer(nametxt.Text,fnametxt.Text,birthdate.Value,emailtext.Text,phonetxt.Text,addresstext.Text);
                db.InsertLogin(id, nametxt.Text, passText.Text);
                MessageBox.Show("Customer is added");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password is not match with Confrim password");
            }
        }
    }
}
