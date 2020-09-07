namespace BusReservationSystem.UserInterface
{
    partial class AdminMenu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuPane = new System.Windows.Forms.Panel();
            this.driverBtn = new System.Windows.Forms.Button();
            this.busBtn = new System.Windows.Forms.Button();
            this.custBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.driveroBtn = new System.Windows.Forms.Button();
            this.busoBtn = new System.Windows.Forms.Button();
            this.custoBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameLb = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.menuPane.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.menuPane);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 27;
            // 
            // menuPane
            // 
            this.menuPane.Controls.Add(this.driverBtn);
            this.menuPane.Controls.Add(this.busBtn);
            this.menuPane.Controls.Add(this.custBtn);
            this.menuPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPane.Location = new System.Drawing.Point(164, 38);
            this.menuPane.Name = "menuPane";
            this.menuPane.Size = new System.Drawing.Size(636, 362);
            this.menuPane.TabIndex = 30;
            // 
            // driverBtn
            // 
            this.driverBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.driverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.driverBtn.BackgroundImage = global::BusReservationSystem.Properties.Resources.Booking_100px;
            this.driverBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.driverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.driverBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.driverBtn.Location = new System.Drawing.Point(436, 91);
            this.driverBtn.Name = "driverBtn";
            this.driverBtn.Size = new System.Drawing.Size(178, 192);
            this.driverBtn.TabIndex = 23;
            this.driverBtn.Text = "Manage Bookings";
            this.driverBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.driverBtn.UseVisualStyleBackColor = false;
            this.driverBtn.Click += new System.EventHandler(this.DriverBtn_Click);
            // 
            // busBtn
            // 
            this.busBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.busBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.busBtn.BackgroundImage = global::BusReservationSystem.Properties.Resources.Bus_100px;
            this.busBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.busBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.busBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.busBtn.Location = new System.Drawing.Point(232, 91);
            this.busBtn.Name = "busBtn";
            this.busBtn.Size = new System.Drawing.Size(178, 192);
            this.busBtn.TabIndex = 23;
            this.busBtn.Text = "Manage Buses";
            this.busBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.busBtn.UseVisualStyleBackColor = false;
            this.busBtn.Click += new System.EventHandler(this.BusBtn_Click);
            // 
            // custBtn
            // 
            this.custBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.custBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.custBtn.BackgroundImage = global::BusReservationSystem.Properties.Resources.User_100px;
            this.custBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.custBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.custBtn.Location = new System.Drawing.Point(26, 91);
            this.custBtn.Name = "custBtn";
            this.custBtn.Size = new System.Drawing.Size(178, 192);
            this.custBtn.TabIndex = 23;
            this.custBtn.Text = "Manage Customer";
            this.custBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.custBtn.UseVisualStyleBackColor = false;
            this.custBtn.Click += new System.EventHandler(this.CustBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.logoutBtn);
            this.panel4.Controls.Add(this.driveroBtn);
            this.panel4.Controls.Add(this.busoBtn);
            this.panel4.Controls.Add(this.custoBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 362);
            this.panel4.TabIndex = 29;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logoutBtn.Image = global::BusReservationSystem.Properties.Resources.icons8_Logout_Rounded_Left_16;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 325);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoutBtn.Size = new System.Drawing.Size(164, 37);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // driveroBtn
            // 
            this.driveroBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.driveroBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.driveroBtn.FlatAppearance.BorderSize = 0;
            this.driveroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.driveroBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveroBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.driveroBtn.Image = global::BusReservationSystem.Properties.Resources.icons8_Booking_16;
            this.driveroBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.driveroBtn.Location = new System.Drawing.Point(0, 74);
            this.driveroBtn.Name = "driveroBtn";
            this.driveroBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.driveroBtn.Size = new System.Drawing.Size(164, 37);
            this.driveroBtn.TabIndex = 7;
            this.driveroBtn.Text = "Bookings";
            this.driveroBtn.UseVisualStyleBackColor = false;
            this.driveroBtn.Click += new System.EventHandler(this.DriverBtn_Click);
            // 
            // busoBtn
            // 
            this.busoBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.busoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.busoBtn.FlatAppearance.BorderSize = 0;
            this.busoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.busoBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busoBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.busoBtn.Image = global::BusReservationSystem.Properties.Resources.icons8_Bus_16;
            this.busoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.busoBtn.Location = new System.Drawing.Point(0, 37);
            this.busoBtn.Name = "busoBtn";
            this.busoBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.busoBtn.Size = new System.Drawing.Size(164, 37);
            this.busoBtn.TabIndex = 6;
            this.busoBtn.Text = "Bus";
            this.busoBtn.UseVisualStyleBackColor = false;
            this.busoBtn.Click += new System.EventHandler(this.BusBtn_Click);
            // 
            // custoBtn
            // 
            this.custoBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.custoBtn.FlatAppearance.BorderSize = 0;
            this.custoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custoBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custoBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.custoBtn.Image = global::BusReservationSystem.Properties.Resources.icons8_User_16;
            this.custoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.custoBtn.Location = new System.Drawing.Point(0, 0);
            this.custoBtn.Name = "custoBtn";
            this.custoBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.custoBtn.Size = new System.Drawing.Size(164, 37);
            this.custoBtn.TabIndex = 5;
            this.custoBtn.Text = "Customer";
            this.custoBtn.UseVisualStyleBackColor = false;
            this.custoBtn.Click += new System.EventHandler(this.CustBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.button4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 50);
            this.panel3.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Location = new System.Drawing.Point(689, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 27);
            this.button4.TabIndex = 1;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.usernameLb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 38);
            this.panel1.TabIndex = 25;
            // 
            // usernameLb
            // 
            this.usernameLb.AutoSize = true;
            this.usernameLb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usernameLb.Location = new System.Drawing.Point(12, 9);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(112, 21);
            this.usernameLb.TabIndex = 2;
            this.usernameLb.Text = "DASHBOARD";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.panel2.ResumeLayout(false);
            this.menuPane.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button custBtn;
        private System.Windows.Forms.Button driverBtn;
        private System.Windows.Forms.Button busBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usernameLb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button driveroBtn;
        private System.Windows.Forms.Button busoBtn;
        private System.Windows.Forms.Button custoBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Panel menuPane;
    }
}