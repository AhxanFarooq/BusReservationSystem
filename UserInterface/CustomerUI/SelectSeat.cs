using BusReservationSystem.UserInterface;
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
    public partial class SelectSeat : Form
    {
        public const int SIZE = 39;
        private Boolean[] flag = new Boolean[SIZE];
        private int[] seatsCount = new int[SIZE];
        public static List<int> selectedSeats = new List<int>();
        public static string seats = "";
        private int seatInc = 1;
        private BusReservationEntities db;
        private Login user = new Login();
        private BusInfo busUser = new BusInfo();

        public SelectSeat(Login user, BusInfo busUser)
        {
            this.user = user;
            db = new BusReservationEntities();
            for (int i = 0; i < SIZE; i++)
            {
                flag[i] = true;
                seatsCount[i] = 0;
            }
            this.busUser = busUser;
            var seatsItems = db.SeatInfoes.Where(b => b.BusId == busUser.id).ToList();
            List<object> array = new List<object>();
            foreach (var items in seatsItems)
            {
                array.Add(items.seatNo);
            }
            InitializeComponent();

            busIdLb.Text = busUser.BusNo.ToString();

            for (int l = 0; l < SIZE; l++)
            {
                for (int m = 0; m < selectedSeats.Count; m++)
                {
                    if (pic[l].Name == "pictureBox" + selectedSeats[m].ToString())
                    {
                        pic[l].Image = global::BusReservationSystem.Properties.Resources.armchairGreen;

                    }
                }
            }

            for (int k = 0; k < SIZE; k++)
            {
                for (int j = 0; j < array.Count; j++)
                {
                    if (pic[k].Name == "pictureBox" + array[j].ToString())
                    {
                        pic[k].Image = global::BusReservationSystem.Properties.Resources.armchairRed;
                        pic[k].Enabled = false;
                    }
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (flag[0] == true)
            {
                pictureBox1.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[0] = false;
                seatsCount[0] = 1;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox1.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[0] = true;
                seatsCount[0] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (flag[20] == true)
            {
                pictureBox3.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[20] = false;
                seatsCount[2] = 3;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox3.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[20] = true;
                seatsCount[2] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (flag[21] == true)
            {
                pictureBox4.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[21] = false;
                seatsCount[3] = 4;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox4.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[21] = true;
                seatsCount[3] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            if (flag[1] == true)
            {
                pictureBox5.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[1] = false;
                seatsCount[4] = 5;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox5.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[1] = true;
                seatsCount[4] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            if (flag[3] == true)
            {
                pictureBox6.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[3] = false;
                seatsCount[5] = 6;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox6.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[3] = true;
                seatsCount[5] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            if (flag[22] == true)
            {
                pictureBox7.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[22] = false;
                seatsCount[6] = 7;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox7.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[22] = true;
                seatsCount[6] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            if (flag[23] == true)
            {
                pictureBox8.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[23] = false;
                seatsCount[7] = 8;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox8.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[23] = true;
                seatsCount[7] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            if (flag[4] == true)
            {
                pictureBox9.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[4] = false;
                seatsCount[8] = 9;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox9.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[4] = true;
                seatsCount[8] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            if (flag[5] == true)
            {
                pictureBox10.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[5] = false;
                seatsCount[9] = 10;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox10.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[5] = true;
                seatsCount[9] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            if (flag[24] == true)
            {
                pictureBox11.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[24] = false;
                seatsCount[10] = 11;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox11.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[24] = true;
                seatsCount[10] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            if (flag[25] == true)
            {
                pictureBox12.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[25] = false;
                seatsCount[11] = 12;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox12.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[25] = true;
                seatsCount[11] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            if (flag[6] == true)
            {
                pictureBox13.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[6] = false;
                seatsCount[12] = 13;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox13.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[6] = true;
                seatsCount[12] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            if (flag[7] == true)
            {
                pictureBox14.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[7] = false;
                seatsCount[14] = 14;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox14.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[7] = true;
                seatsCount[14] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            if (flag[26] == true)
            {
                pictureBox15.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[26] = false;
                seatsCount[14] = 15;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox15.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[26] = true;
                seatsCount[14] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {
            if (flag[27] == true)
            {
                pictureBox16.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[27] = false;
                seatsCount[15] = 16;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox16.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[27] = true;
                seatsCount[15] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox17_Click(object sender, EventArgs e)
        {
            if (flag[8] == true)
            {
                pictureBox17.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[8] = false;
                seatsCount[16] = 17;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox17.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[8] = true;
                seatsCount[16] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox18_Click(object sender, EventArgs e)
        {
            if (flag[9] == true)
            {
                pictureBox18.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[9] = false;
                seatsCount[17] = 18;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox18.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[9] = true;
                seatsCount[17] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox19_Click(object sender, EventArgs e)
        {
            if (flag[28] == true)
            {
                pictureBox19.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[28] = false;
                seatsCount[18] = 19;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox19.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[28] = true;
                seatsCount[18] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox20_Click(object sender, EventArgs e)
        {
            if (flag[29] == true)
            {
                pictureBox20.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[29] = false;
                seatsCount[19] = 20;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox20.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[29] = true;
                seatsCount[19] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox21_Click(object sender, EventArgs e)
        {
            if (flag[10] == true)
            {
                pictureBox21.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[10] = false;
                seatsCount[20] = 21;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox21.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[10] = true;
                seatsCount[20] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox22_Click(object sender, EventArgs e)
        {
            if (flag[11] == true)
            {
                pictureBox22.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[11] = false;
                seatsCount[21] = 22;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox22.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[11] = true;
                seatsCount[21] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox23_Click(object sender, EventArgs e)
        {
            if (flag[30] == true)
            {
                pictureBox23.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[30] = false;
                seatsCount[22] = 23;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox23.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[30] = true;
                seatsCount[22] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox24_Click(object sender, EventArgs e)
        {
            if (flag[31] == true)
            {
                pictureBox24.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[31] = false;
                seatsCount[23] = 24;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox24.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[31] = true;
                seatsCount[23] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox25_Click(object sender, EventArgs e)
        {
            if (flag[12] == true)
            {
                pictureBox25.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[12] = false;
                seatsCount[24] = 25;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox25.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[12] = true;
                seatsCount[24] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox26_Click(object sender, EventArgs e)
        {
            if (flag[13] == true)
            {
                pictureBox26.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[13] = false;
                seatsCount[25] = 26;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox26.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[13] = true;
                seatsCount[25] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox27_Click(object sender, EventArgs e)
        {
            if (flag[32] == true)
            {
                pictureBox27.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[32] = false;
                seatsCount[26] = 27;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox27.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[32] = true;
                seatsCount[26] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox28_Click(object sender, EventArgs e)
        {
            if (flag[33] == true)
            {
                pictureBox28.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[33] = false;
                seatsCount[27] = 28;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox28.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[33] = true;
                seatsCount[27] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox29_Click(object sender, EventArgs e)
        {
            if (flag[14] == true)
            {
                pictureBox29.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[14] = false;
                seatsCount[28] = 29;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox29.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[14] = true;
                seatsCount[28] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox30_Click(object sender, EventArgs e)
        {
            if (flag[15] == true)
            {
                pictureBox30.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[15] = false;
                seatsCount[29] = 30;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox30.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[15] = true;
                seatsCount[29] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox31_Click(object sender, EventArgs e)
        {
            if (flag[34] == true)
            {
                pictureBox31.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[34] = false;
                seatsCount[30] = 31;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox31.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[34] = true;
                seatsCount[30] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox32_Click(object sender, EventArgs e)
        {
            if (flag[35] == true)
            {
                pictureBox32.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[35] = false;
                seatsCount[31] = 32;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox32.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[35] = true;
                seatsCount[31] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox33_Click(object sender, EventArgs e)
        {
            if (flag[16] == true)
            {
                pictureBox33.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[16] = false;
                seatsCount[15] = 16;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox33.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[16] = true;
                seatsCount[15] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox34_Click(object sender, EventArgs e)
        {
            if (flag[17] == true)
            {
                pictureBox34.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[17] = false;
                seatsCount[33] = 34;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox34.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[17] = true;
                seatsCount[33] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox35_Click(object sender, EventArgs e)
        {
            if (flag[36] == true)
            {
                pictureBox35.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[36] = false;
                seatsCount[34] = 35;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox35.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[36] = true;
                seatsCount[34] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox36_Click(object sender, EventArgs e)
        {
            if (flag[37] == true)
            {
                pictureBox36.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[37] = false;
                seatsCount[35] = 36;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox36.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[37] = true;
                seatsCount[35] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox37_Click(object sender, EventArgs e)
        {
            if (flag[18] == true)
            {
                pictureBox37.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[18] = false;
                seatsCount[36] = 37;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox37.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[18] = true;
                seatsCount[36] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox38_Click(object sender, EventArgs e)
        {
            if (flag[19] == true)
            {
                pictureBox38.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[19] = false;
                seatsCount[37] = 38;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox38.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[19] = true;
                seatsCount[37] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox39_Click(object sender, EventArgs e)
        {
            if (flag[38] == true)
            {
                pictureBox39.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[38] = false;
                seatsCount[38] = 39;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox39.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[38] = true;
                seatsCount[38] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void PictureBox40_Click(object sender, EventArgs e)
        {
            if (flag[39] == true)
            {
                pictureBox40.Image = global::BusReservationSystem.Properties.Resources.armchairGreen;
                flag[39] = false;
                seatsCount[39] = 40;
                selectSeatsLb.Text = seatInc++.ToString();
            }
            else
            {
                pictureBox40.Image = global::BusReservationSystem.Properties.Resources.armchairBlue;
                flag[39] = true;
                seatsCount[39] = 0;
                selectSeatsLb.Text = seatInc--.ToString();
            }
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            selectedSeats = new List<int>();
            seats = "";

            for (int i = 0; i < SIZE; i++)
            {
                if (seatsCount[i] > 0)
                {
                    selectedSeats.Add(seatsCount[i]);
                }
            }
            for (int j = 0; j < selectedSeats.Count; j++)
            {
                seats = seats + selectedSeats[j] + ",";
            }

            this.Hide();
            new CustomerTicketReservation(user, busUser).ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new CustomerTicketReservation(user, busUser).Show();
            this.Hide();
        }
    }
}
