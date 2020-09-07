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
    public partial class AdminLogins : Form
    {
        public AdminLogins()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            BusReservationEntities db = new BusReservationEntities();
            if (usertext.Text != string.Empty && passtext.Text != string.Empty)
            {
                var user = db.AdminLogins.Where(a => a.username.Equals(usertext.Text)).FirstOrDefault();
                //var custUser = db.Customer_login.Where(a => a.Username.Equals(usertext.Text)).SingleOrDefault();
                if (user != null)
                {
                    if (user.password.Equals(passtext.Text))
                    {
                        new AdminMenu().Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username");
                }
            }
            else
            {
                MessageBox.Show("Please fill all form");
            }
            
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Usertext_Click_1(object sender, EventArgs e)
        {
            this.usertext.Text = "";
        }

        private void Usertext_Leave_1(object sender, EventArgs e)
        {
            if (this.usertext.Text == string.Empty)
            {
                this.usertext.Text = "User Name";
            }
        }

        private void Passtext_Click_1(object sender, EventArgs e)
        {
            this.passtext.Text = "";
            this.passtext.PasswordChar = '*';
        }

        private void Passtext_Leave_1(object sender, EventArgs e)
        {
            if (this.passtext.Text == string.Empty)
            {

                this.passtext.PasswordChar = '\0';
                this.passtext.Text = "Password";
            }
        }
    }
}
