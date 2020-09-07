using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BusReservationSystem.UserInterface
{
    public partial class CustomerDetail : Form
    {
        BusReservationEntities db;
        int id = 0;
        public CustomerDetail(int? Id)
        {
            InitializeComponent();
            if (Id != null)
            {
                addbtn.Visible = false;
                db = new BusReservationEntities();
                Customer customers = db.Customers.Where(a => a.Id == Id).FirstOrDefault();
                id = customers.Id;
                nametxt.Text = customers.Name;
                fnametxt.Text = customers.FatherName;
                emailtext.Text = customers.Email;
                birthdate.Value = (DateTime)customers.DateOfBirth;
                phonetxt.Text = customers.PhoneNo;
                addresstext.Text = customers.Address;
            }
            else
            {
                updatebtn.Visible = false;
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            db = new BusReservationEntities();
            Customer customers = db.Customers.Where(a => a.Id == id).FirstOrDefault();
            customers.Name = nametxt.Text;
            customers.FatherName = fnametxt.Text;
            customers.Email = emailtext.Text;
            customers.DateOfBirth = birthdate.Value;
            customers.PhoneNo = phonetxt.Text;
            customers.Address = addresstext.Text;
            db.SaveChanges();
            MessageBox.Show("Record Updated");
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            BusReservationEntities db = new BusReservationEntities();
            Customer customers = new Customer
            {
                Name = nametxt.Text,
                FatherName = fnametxt.Text,
                DateOfBirth = birthdate.Value,
                Email = emailtext.Text,
                PhoneNo = phonetxt.Text,
                Address = addresstext.Text
            };
            
            
            if (passText.Text == passConfText.Text)
            {
                db.Customers.Add(customers);
                db.SaveChanges();
                db.Logins.Add(new Login
                {
                    custId = customers.Id,
                    username = nametxt.Text,
                    password = passText.Text
                });
                db.SaveChanges();
                MessageBox.Show("Customer is added");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password is not match with Confrim password");
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
           // new LoginForm().Show();
            this.Hide();
        }
    }
}
