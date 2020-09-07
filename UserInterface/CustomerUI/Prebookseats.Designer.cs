namespace BusReservationSystem.UserInterface
{
    partial class Prebookseats
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookNoTxt = new System.Windows.Forms.TextBox();
            this.buyTicBtn = new System.Windows.Forms.Button();
            this.phoneNoTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(43, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(43, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone No.";
            // 
            // bookNoTxt
            // 
            this.bookNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookNoTxt.Location = new System.Drawing.Point(181, 121);
            this.bookNoTxt.Name = "bookNoTxt";
            this.bookNoTxt.Size = new System.Drawing.Size(160, 13);
            this.bookNoTxt.TabIndex = 3;
            this.bookNoTxt.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // buyTicBtn
            // 
            this.buyTicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buyTicBtn.FlatAppearance.BorderSize = 0;
            this.buyTicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicBtn.ForeColor = System.Drawing.Color.White;
            this.buyTicBtn.Location = new System.Drawing.Point(243, 238);
            this.buyTicBtn.Name = "buyTicBtn";
            this.buyTicBtn.Size = new System.Drawing.Size(98, 36);
            this.buyTicBtn.TabIndex = 25;
            this.buyTicBtn.Text = "Buy Tickets";
            this.buyTicBtn.UseVisualStyleBackColor = false;
            this.buyTicBtn.Click += new System.EventHandler(this.BuyTicBtn_Click);
            // 
            // phoneNoTxt
            // 
            this.phoneNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNoTxt.Location = new System.Drawing.Point(180, 174);
            this.phoneNoTxt.Name = "phoneNoTxt";
            this.phoneNoTxt.Size = new System.Drawing.Size(161, 13);
            this.phoneNoTxt.TabIndex = 3;
            this.phoneNoTxt.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(62, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 37);
            this.label7.TabIndex = 38;
            this.label7.Text = "PRE BOOKED SEATS";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::BusReservationSystem.Properties.Resources.Back_Arrow_50px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 40);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Prebookseats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(395, 320);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buyTicBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.phoneNoTxt);
            this.Controls.Add(this.bookNoTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prebookseats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prebookseats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookNoTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buyTicBtn;
        private System.Windows.Forms.TextBox phoneNoTxt;
        private System.Windows.Forms.Label label7;
    }
}