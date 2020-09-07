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
    public partial class LoginForm : Form
    {
       private BusReservationEntities db = new BusReservationEntities();
        private Login user = new Login();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            CustomerDetail customer = new CustomerDetail(null);
            customer.ShowDialog();
        }

        private void Usertext_Click(object sender, EventArgs e)
        {
            this.usertext.Text = "";
        }

        private void Passtext_Click(object sender, EventArgs e)
        {
            this.passtext.Text = "";
            this.passtext.PasswordChar = '*';
        }

        private void Usertext_Leave(object sender, EventArgs e)
        {
            if(this.usertext.Text == string.Empty)
            {
                this.usertext.Text = "User Name";
            }
        }

        private void Passtext_Leave(object sender, EventArgs e)
        {
            if (this.passtext.Text == string.Empty)
            {
                
                this.passtext.PasswordChar = '\0';
                this.passtext.Text = "Password";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            BusReservationEntities db = new BusReservationEntities();
            if (usertext.Text != "User Name" && passtext.Text != "Password")
            {
                var user = db.Logins.Where(a => a.username.Equals(usertext.Text)).FirstOrDefault();
                //var custUser = db.Customer_login.Where(a => a.Username.Equals(usertext.Text)).SingleOrDefault();
                if (user != null)
                {
                    if (user.password.Equals(passtext.Text))
                    {
                        //MessageBox.Show("you are login");
                        if (remmechk.Checked)
                        {
                            Properties.Settings.Default.UserName = usertext.Text;
                            Properties.Settings.Default.Password = passtext.Text;
                            Properties.Settings.Default.Save();
                        }
                        
                        new CustomerMenu(user).Show();
                        this.Hide();
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

        private void Remmechk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                usertext.Text = Properties.Settings.Default.UserName;
                passtext.Text = Properties.Settings.Default.Password;
                passtext.PasswordChar = '*';
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new AdminLogins().Show();
            this.Hide();
        }

        private void Passtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
