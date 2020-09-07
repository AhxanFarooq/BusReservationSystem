namespace BusReservationSystem.UserInterface
{
    partial class CustomerMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buyTicBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameLb = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.Drower = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.contactUsBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookStBtn = new System.Windows.Forms.Button();
            this.myBookBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.preBookBnt = new System.Windows.Forms.Button();
            this.travelBtn = new System.Windows.Forms.Button();
            this.complainBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Drower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buyTicBtn
            // 
            this.buyTicBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buyTicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buyTicBtn.BackgroundImage = global::BusReservationSystem.Properties.Resources.New_Ticket_50px;
            this.buyTicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buyTicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buyTicBtn.Location = new System.Drawing.Point(335, 83);
            this.buyTicBtn.Name = "buyTicBtn";
            this.buyTicBtn.Size = new System.Drawing.Size(165, 159);
            this.buyTicBtn.TabIndex = 23;
            this.buyTicBtn.Text = "Buy Tickets";
            this.buyTicBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buyTicBtn.UseVisualStyleBackColor = false;
            this.buyTicBtn.Click += new System.EventHandler(this.BuyTicBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.usernameLb);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.menuBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(158, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 38);
            this.panel1.TabIndex = 0;
            // 
            // usernameLb
            // 
            this.usernameLb.AutoSize = true;
            this.usernameLb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usernameLb.Location = new System.Drawing.Point(41, 9);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(101, 21);
            this.usernameLb.TabIndex = 1;
            this.usernameLb.Text = "USER NAME";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::BusReservationSystem.Properties.Resources.Delete_100px;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(818, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 26);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.Transparent;
            this.menuBtn.BackgroundImage = global::BusReservationSystem.Properties.Resources.Menu_100px;
            this.menuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuBtn.Location = new System.Drawing.Point(6, 6);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(29, 26);
            this.menuBtn.TabIndex = 0;
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // Drower
            // 
            this.Drower.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Drower.Controls.Add(this.label1);
            this.Drower.Controls.Add(this.logoutBtn);
            this.Drower.Controls.Add(this.contactUsBtn);
            this.Drower.Controls.Add(this.profileBtn);
            this.Drower.Controls.Add(this.homeBtn);
            this.Drower.Controls.Add(this.pictureBox1);
            this.Drower.Dock = System.Windows.Forms.DockStyle.Left;
            this.Drower.Location = new System.Drawing.Point(0, 0);
            this.Drower.Name = "Drower";
            this.Drower.Size = new System.Drawing.Size(158, 538);
            this.Drower.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(5, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Pakistan Express";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logoutBtn.Image = global::BusReservationSystem.Properties.Resources.icons8_Logout_Rounded_Left_16;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 232);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoutBtn.Size = new System.Drawing.Size(158, 37);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // contactUsBtn
            // 
            this.contactUsBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contactUsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactUsBtn.FlatAppearance.BorderSize = 0;
            this.contactUsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactUsBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactUsBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.contactUsBtn.Image = global::BusReservationSystem.Properties.Resources.icons8_Phone_16;
            this.contactUsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactUsBtn.Location = new System.Drawing.Point(0, 195);
            this.contactUsBtn.Name = "contactUsBtn";
            this.contactUsBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.contactUsBtn.Size = new System.Drawing.Size(158, 37);
            this.contactUsBtn.TabIndex = 3;
            this.contactUsBtn.Text = "Contact Us";
            this.contactUsBtn.UseVisualStyleBackColor = false;
            this.contactUsBtn.Click += new System.EventHandler(this.ContactUsBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profileBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.profileBtn.Image = global::BusReservationSystem.Properties.Resources.icons8_User_16;
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Location = new System.Drawing.Point(0, 158);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.profileBtn.Size = new System.Drawing.Size(158, 37);
            this.profileBtn.TabIndex = 2;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.homeBtn.Image = global::BusReservationSystem.Properties.Resources.icons8_Home_161;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 121);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeBtn.Size = new System.Drawing.Size(158, 37);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::BusReservationSystem.Properties.Resources._14g5VJ;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bookStBtn
            // 
            this.bookStBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bookStBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookStBtn.BackgroundImage = global::BusReservationSystem.Properties.Resources.Waiting_Room_50px;
            this.bookStBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bookStBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookStBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookStBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bookStBtn.Location = new System.Drawing.Point(77, 83);
            this.bookStBtn.Name = "bookStBtn";
            this.bookStBtn.Size = new System.Drawing.Size(165, 159);
            this.bookStBtn.TabIndex = 23;
            this.bookStBtn.Text = "Book Seat";
            this.bookStBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bookStBtn.UseVisualStyleBackColor = false;
            this.bookStBtn.Click += new System.EventHandler(this.BookStBtn_Click);
            // 
            // myBookBtn
            // 
            this.myBookBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.myBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myBookBtn.BackgroundImage = global::BusReservationSystem.Properties.Resources.Two_Tickets_50px;
            this.myBookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.myBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myBookBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myBookBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.myBookBtn.Location = new System.Drawing.Point(592, 83);
            this.myBookBtn.Name = "myBookBtn";
            this.myBookBtn.Size = new System.Drawing.Size(165, 159);
            this.myBookBtn.TabIndex = 23;
            this.myBookBtn.Text = "My Bookings";
            this.myBookBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.myBookBtn.UseVisualStyleBackColor = false;
            this.myBookBtn.Click += new System.EventHandler(this.MyBookBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.preBookBnt);
            this.panel2.Controls.Add(this.bookStBtn);
            this.panel2.Controls.Add(this.travelBtn);
            this.panel2.Controls.Add(this.myBookBtn);
            this.panel2.Controls.Add(this.complainBtn);
            this.panel2.Controls.Add(this.buyTicBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(158, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 500);
            this.panel2.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BusReservationSystem.Properties.Resources.icons8_Notification_32;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(798, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 43);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "DASHBOARD";
            // 
            // preBookBnt
            // 
            this.preBookBnt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.preBookBnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.preBookBnt.BackgroundImage = global::BusReservationSystem.Properties.Resources.Cash_in_Hand_50px;
            this.preBookBnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.preBookBnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preBookBnt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preBookBnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.preBookBnt.Location = new System.Drawing.Point(77, 273);
            this.preBookBnt.Name = "preBookBnt";
            this.preBookBnt.Size = new System.Drawing.Size(165, 159);
            this.preBookBnt.TabIndex = 23;
            this.preBookBnt.Text = "Buy Pre Book Seats";
            this.preBookBnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.preBookBnt.UseVisualStyleBackColor = false;
            this.preBookBnt.Click += new System.EventHandler(this.PreBookBnt_Click);
            // 
            // travelBtn
            // 
            this.travelBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.travelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.travelBtn.BackgroundImage = global::BusReservationSystem.Properties.Resources.Time_Machine_64px;
            this.travelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.travelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.travelBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.travelBtn.Location = new System.Drawing.Point(592, 273);
            this.travelBtn.Name = "travelBtn";
            this.travelBtn.Size = new System.Drawing.Size(165, 159);
            this.travelBtn.TabIndex = 23;
            this.travelBtn.Text = "Traveling History";
            this.travelBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.travelBtn.UseVisualStyleBackColor = false;
            this.travelBtn.Click += new System.EventHandler(this.TravelBtn_Click);
            // 
            // complainBtn
            // 
            this.complainBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.complainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.complainBtn.BackgroundImage = global::BusReservationSystem.Properties.Resources.Test_Passed_50px;
            this.complainBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.complainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.complainBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complainBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.complainBtn.Location = new System.Drawing.Point(335, 273);
            this.complainBtn.Name = "complainBtn";
            this.complainBtn.Size = new System.Drawing.Size(165, 159);
            this.complainBtn.TabIndex = 23;
            this.complainBtn.Text = "Complaints";
            this.complainBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.complainBtn.UseVisualStyleBackColor = false;
            this.complainBtn.Click += new System.EventHandler(this.ComplainBtn_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BusReservationSystem.Properties.Resources.unnamed_12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Drower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Drower.ResumeLayout(false);
            this.Drower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buyTicBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usernameLb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Panel Drower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button contactUsBtn;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bookStBtn;
        private System.Windows.Forms.Button myBookBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button preBookBnt;
        private System.Windows.Forms.Button travelBtn;
        private System.Windows.Forms.Button complainBtn;
        private System.Windows.Forms.Button button1;
    }
}