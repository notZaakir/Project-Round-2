
namespace HotelManagementSystem
{
    partial class BookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.rgbYes = new System.Windows.Forms.RadioButton();
            this.rgbNo = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.txtBookingGuestID = new System.Windows.Forms.TextBox();
            this.txtBookingRoomID = new System.Windows.Forms.TextBox();
            this.txtBookingRate = new System.Windows.Forms.TextBox();
            this.txtBookingDeposit = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 100);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(527, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bookings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(74, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(75, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "RoomID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(76, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "GuestID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(75, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "BookingID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(74, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Deposit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(74, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "End Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(74, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "Start Date:";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.dateTimeStart.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimeStart.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.dateTimeStart.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStart.Location = new System.Drawing.Point(262, 490);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(200, 25);
            this.dateTimeStart.TabIndex = 13;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimeEnd.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimeEnd.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.dateTimeEnd.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEnd.Location = new System.Drawing.Point(262, 556);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(200, 25);
            this.dateTimeEnd.TabIndex = 14;
            // 
            // rgbYes
            // 
            this.rgbYes.AutoSize = true;
            this.rgbYes.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbYes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rgbYes.Location = new System.Drawing.Point(307, 619);
            this.rgbYes.Name = "rgbYes";
            this.rgbYes.Size = new System.Drawing.Size(49, 21);
            this.rgbYes.TabIndex = 15;
            this.rgbYes.TabStop = true;
            this.rgbYes.Text = "Yes";
            this.rgbYes.UseVisualStyleBackColor = true;
            // 
            // rgbNo
            // 
            this.rgbNo.AutoSize = true;
            this.rgbNo.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbNo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rgbNo.Location = new System.Drawing.Point(395, 619);
            this.rgbNo.Name = "rgbNo";
            this.rgbNo.Size = new System.Drawing.Size(44, 21);
            this.rgbNo.TabIndex = 16;
            this.rgbNo.TabStop = true;
            this.rgbNo.Text = "No";
            this.rgbNo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(75, 613);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "Deposit Paid:";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(262, 154);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(100, 20);
            this.txtBookingID.TabIndex = 18;
            // 
            // txtBookingGuestID
            // 
            this.txtBookingGuestID.Location = new System.Drawing.Point(262, 222);
            this.txtBookingGuestID.Name = "txtBookingGuestID";
            this.txtBookingGuestID.Size = new System.Drawing.Size(100, 20);
            this.txtBookingGuestID.TabIndex = 19;
            // 
            // txtBookingRoomID
            // 
            this.txtBookingRoomID.Location = new System.Drawing.Point(262, 287);
            this.txtBookingRoomID.Name = "txtBookingRoomID";
            this.txtBookingRoomID.Size = new System.Drawing.Size(100, 20);
            this.txtBookingRoomID.TabIndex = 20;
            // 
            // txtBookingRate
            // 
            this.txtBookingRate.Location = new System.Drawing.Point(262, 356);
            this.txtBookingRate.Name = "txtBookingRate";
            this.txtBookingRate.Size = new System.Drawing.Size(100, 20);
            this.txtBookingRate.TabIndex = 21;
            // 
            // txtBookingDeposit
            // 
            this.txtBookingDeposit.Location = new System.Drawing.Point(262, 425);
            this.txtBookingDeposit.Name = "txtBookingDeposit";
            this.txtBookingDeposit.Size = new System.Drawing.Size(145, 20);
            this.txtBookingDeposit.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(525, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 448);
            this.dataGridView1.TabIndex = 23;
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnDeleteBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBooking.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBooking.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeleteBooking.Location = new System.Drawing.Point(1177, 619);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(90, 33);
            this.btnDeleteBooking.TabIndex = 26;
            this.btnDeleteBooking.Text = "Delete";
            this.btnDeleteBooking.UseVisualStyleBackColor = false;
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnEditBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBooking.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBooking.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditBooking.Location = new System.Drawing.Point(1030, 619);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(92, 33);
            this.btnEditBooking.TabIndex = 25;
            this.btnEditBooking.Text = "Edit";
            this.btnEditBooking.UseVisualStyleBackColor = false;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAddBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBooking.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooking.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddBooking.Location = new System.Drawing.Point(864, 619);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(104, 33);
            this.btnAddBooking.TabIndex = 24;
            this.btnAddBooking.Text = "Add";
            this.btnAddBooking.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(1177, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 75);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1308, 686);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.btnEditBooking);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBookingDeposit);
            this.Controls.Add(this.txtBookingRate);
            this.Controls.Add(this.txtBookingRoomID);
            this.Controls.Add(this.txtBookingGuestID);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rgbNo);
            this.Controls.Add(this.rgbYes);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.RadioButton rgbYes;
        private System.Windows.Forms.RadioButton rgbNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.TextBox txtBookingGuestID;
        private System.Windows.Forms.TextBox txtBookingRoomID;
        private System.Windows.Forms.TextBox txtBookingRate;
        private System.Windows.Forms.TextBox txtBookingDeposit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnEditBooking;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Button btnBack;
    }
}