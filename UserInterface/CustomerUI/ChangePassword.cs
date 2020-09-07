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

namespace BusReservationSystem
{
    public partial class ChangePassword : Form
    {
        DBAccess db = new DBAccess();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            
                if (oldPassTxt.Text != string.Empty && newPassTxt.Text != string.Empty && confPassTxt.Text != string.Empty)
                {
                    var user = db.GetUserByPass(oldPassTxt.Text);
                    //var custUser = db.Customer_login.Where(a => a.Username.Equals(usertext.Text)).SingleOrDefault();
                if (user != null)
                    {
                        if (newPassTxt.Text.Equals(confPassTxt.Text))
                        {
                            db.ChangePass(user, newPassTxt.Text);
                            MessageBox.Show("Password has been changed");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("New password is not match with confirm password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong old password");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all required fields");
                }
        }
    }
}
