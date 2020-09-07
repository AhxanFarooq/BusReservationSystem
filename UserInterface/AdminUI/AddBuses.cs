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
    public partial class AddBuses : Form
    {
        private DBAccess db = new DBAccess();
        public AddBuses()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new ManageBuses().Show();
            this.Hide();
        }

        private void AddBusBtn_Click(object sender, EventArgs e)
        {
            db.InsertBus(busNoTxt.Text,busClassTxt.Text,sourceTxt.Text,destinationTxt.Text,dTimeTxt.Text,arivalTxt.Text,fareTxt.Text);
            MessageBox.Show("Data is Inserted");
        }
    }
}
