namespace BusReservationSystem.UserInterface.AdminUI
{
    partial class ManageBookings
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.noOfBookLb = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usernameLb = new System.Windows.Forms.Label();
            this.menuBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.driverBtn = new System.Windows.Forms.Button();
            this.busBtn = new System.Windows.Forms.Button();
            this.custBtn = new System.Windows.Forms.Button();
            this.bookingGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.busReservationDataSet2 = new BusReservationSystem.BusReservationDataSet2();
            //this.bookingDetailTableAdapter = new BusReservationSystem.BusReservationDataSet2TableAdapters.BookingDetailTableAdapter();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.busReservationDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.noOfBookLb);
            this.panel3.Controls.Add(this.lable);
            this.panel3.Controls.Add(this.closeBtn);
            this.panel3.Controls.Add(this.backBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 50);
            this.panel3.TabIndex = 29;
            // 
            // noOfBookLb
            // 
            this.noOfBookLb.AutoSize = true;
            this.noOfBookLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfBookLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.noOfBookLb.Location = new System.Drawing.Point(140, 18);
            this.noOfBookLb.Name = "noOfBookLb";
            this.noOfBookLb.Size = new System.Drawing.Size(122, 20);
            this.noOfBookLb.TabIndex = 9;
            this.noOfBookLb.Text = "Total Customers";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lable.Location = new System.Drawing.Point(12, 18);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(111, 20);
            this.lable.TabIndex = 10;
            this.lable.Text = "Total Bookings";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.closeBtn.Location = new System.Drawing.Point(692, 11);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(99, 27);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backBtn.Location = new System.Drawing.Point(587, 11);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(99, 27);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.usernameLb);
            this.panel1.Controls.Add(this.menuBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 38);
            this.panel1.TabIndex = 28;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBox.Location = new System.Drawing.Point(604, 7);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(137, 25);
            this.searchBox.TabIndex = 10;
            this.searchBox.Text = "Search..";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBtn.Location = new System.Drawing.Point(736, 7);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(56, 25);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ID",
            "CustID",
            "BusID"});
            this.comboBox2.Location = new System.Drawing.Point(510, 7);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(90, 25);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "Search By";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "front side bookings",
            "middle bookings",
            "back side bookings",
            "which have 2 or more seats reserved"});
            this.comboBox1.Location = new System.Drawing.Point(202, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(302, 25);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Show Record of";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // usernameLb
            // 
            this.usernameLb.AutoSize = true;
            this.usernameLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usernameLb.Location = new System.Drawing.Point(34, 9);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(162, 20);
            this.usernameLb.TabIndex = 1;
            this.usernameLb.Text = "BOOKINGS RECORDS";
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.Transparent;
            this.menuBtn.BackgroundImage = global::BusReservationSystem.Properties.Resources.Booking_100px;
            this.menuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuBtn.Location = new System.Drawing.Point(6, 6);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(29, 26);
            this.menuBtn.TabIndex = 0;
            this.menuBtn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.editBtn);
            this.panel4.Controls.Add(this.deleteBtn);
            this.panel4.Controls.Add(this.driverBtn);
            this.panel4.Controls.Add(this.busBtn);
            this.panel4.Controls.Add(this.custBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 362);
            this.panel4.TabIndex = 30;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editBtn.Image = global::BusReservationSystem.Properties.Resources.icons8_Edit_16;
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.Location = new System.Drawing.Point(0, 148);
            this.editBtn.Name = "editBtn";
            this.editBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editBtn.Size = new System.Drawing.Size(165, 37);
            this.editBtn.TabIndex = 10;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteBtn.Image = global::BusReservationSystem.Properties.Resources.icons8_Delete_User_Male_16;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(0, 111);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteBtn.Size = new System.Drawing.Size(165, 37);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // driverBtn
            // 
            this.driverBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.driverBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.driverBtn.FlatAppearance.BorderSize = 0;
            this.driverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.driverBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.driverBtn.Image = global::BusReservationSystem.Properties.Resources.icons8_Booking_16;
            this.driverBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.driverBtn.Location = new System.Drawing.Point(0, 74);
            this.driverBtn.Name = "driverBtn";
            this.driverBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.driverBtn.Size = new System.Drawing.Size(165, 37);
            this.driverBtn.TabIndex = 7;
            this.driverBtn.Text = "Bookings";
            this.driverBtn.UseVisualStyleBackColor = false;
            this.driverBtn.Click += new System.EventHandler(this.DriverBtn_Click);
            // 
            // busBtn
            // 
            this.busBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.busBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.busBtn.FlatAppearance.BorderSize = 0;
            this.busBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.busBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.busBtn.Image = global::BusReservationSystem.Properties.Resources.icons8_Bus_16;
            this.busBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.busBtn.Location = new System.Drawing.Point(0, 37);
            this.busBtn.Name = "busBtn";
            this.busBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.busBtn.Size = new System.Drawing.Size(165, 37);
            this.busBtn.TabIndex = 6;
            this.busBtn.Text = "Bus";
            this.busBtn.UseVisualStyleBackColor = false;
            this.busBtn.Click += new System.EventHandler(this.BusBtn_Click);
            // 
            // custBtn
            // 
            this.custBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.custBtn.FlatAppearance.BorderSize = 0;
            this.custBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.custBtn.Image = global::BusReservationSystem.Properties.Resources.icons8_User_16;
            this.custBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.custBtn.Location = new System.Drawing.Point(0, 0);
            this.custBtn.Name = "custBtn";
            this.custBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.custBtn.Size = new System.Drawing.Size(165, 37);
            this.custBtn.TabIndex = 5;
            this.custBtn.Text = "Customer";
            this.custBtn.UseVisualStyleBackColor = false;
            this.custBtn.Click += new System.EventHandler(this.CustBtn_Click);
            // 
            // bookingGridView1
            // 
            this.bookingGridView1.AutoGenerateColumns = false;
            this.bookingGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.custIdDataGridViewTextBoxColumn,
            this.dateOfTicketDataGridViewTextBoxColumn,
            this.seatNoDataGridViewTextBoxColumn,
            this.busIdDataGridViewTextBoxColumn});
            this.bookingGridView1.DataSource = this.bookingDetailBindingSource;
            this.bookingGridView1.Location = new System.Drawing.Point(171, 44);
            this.bookingGridView1.Name = "bookingGridView1";
            this.bookingGridView1.Size = new System.Drawing.Size(621, 349);
            this.bookingGridView1.TabIndex = 31;
            this.bookingGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookingGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custIdDataGridViewTextBoxColumn
            // 
            this.custIdDataGridViewTextBoxColumn.DataPropertyName = "custId";
            this.custIdDataGridViewTextBoxColumn.HeaderText = "custId";
            this.custIdDataGridViewTextBoxColumn.Name = "custIdDataGridViewTextBoxColumn";
            // 
            // dateOfTicketDataGridViewTextBoxColumn
            // 
            this.dateOfTicketDataGridViewTextBoxColumn.DataPropertyName = "dateOfTicket";
            this.dateOfTicketDataGridViewTextBoxColumn.HeaderText = "dateOfTicket";
            this.dateOfTicketDataGridViewTextBoxColumn.Name = "dateOfTicketDataGridViewTextBoxColumn";
            // 
            // seatNoDataGridViewTextBoxColumn
            // 
            this.seatNoDataGridViewTextBoxColumn.DataPropertyName = "seatNo";
            this.seatNoDataGridViewTextBoxColumn.HeaderText = "seatNo";
            this.seatNoDataGridViewTextBoxColumn.Name = "seatNoDataGridViewTextBoxColumn";
            // 
            // busIdDataGridViewTextBoxColumn
            // 
            this.busIdDataGridViewTextBoxColumn.DataPropertyName = "BusId";
            this.busIdDataGridViewTextBoxColumn.HeaderText = "BusId";
            this.busIdDataGridViewTextBoxColumn.Name = "busIdDataGridViewTextBoxColumn";
            // 
            // bookingDetailBindingSource
            // 
            this.bookingDetailBindingSource.DataMember = "BookingDetail";
            //this.bookingDetailBindingSource.DataSource = this.busReservationDataSet2;
            // 
            // busReservationDataSet2
            // 
            //this.busReservationDataSet2.DataSetName = "BusReservationDataSet2";
            //this.busReservationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingDetailTableAdapter
            // 
           // this.bookingDetailTableAdapter.ClearBeforeFill = true;
            // 
            // ManageBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookingGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBookings";
            this.Load += new System.EventHandler(this.ManageBookings_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.busReservationDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usernameLb;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button driverBtn;
        private System.Windows.Forms.Button busBtn;
        private System.Windows.Forms.Button custBtn;
        private System.Windows.Forms.DataGridView bookingGridView1;
        //private BusReservationDataSet2 busReservationDataSet2;
        private System.Windows.Forms.BindingSource bookingDetailBindingSource;
        //private BusReservationDataSet2TableAdapters.BookingDetailTableAdapter bookingDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label noOfBookLb;
        private System.Windows.Forms.Label lable;
    }
}