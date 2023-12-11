namespace Lab04
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            lblUsername = new Label();
            btnLogout = new Button();
            ptrbxAvatar = new PictureBox();
            lstbxAvailableFlights = new ListBox();
            flightBindingSource = new BindingSource(components);
            lstbxBookingFlights = new ListBox();
            grpbxFlightInfo = new GroupBox();
            txtbxArrivalTime = new TextBox();
            lblArrivalTime = new Label();
            txtbxDepartureTime = new TextBox();
            lblDepartureType = new Label();
            txtbxFlightType = new TextBox();
            lblFlightType = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            label4 = new Label();
            label5 = new Label();
            lblBookedFlights = new Label();
            lstbxBookedFlights = new ListBox();
            btnConfirm = new Button();
            btnProfile = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptrbxAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flightBindingSource).BeginInit();
            grpbxFlightInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(1064, 7);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(28, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Hi!";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleRight;
            btnLogout.Location = new Point(1132, 34);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 20;
            btnLogout.Text = "Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // ptrbxAvatar
            // 
            ptrbxAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptrbxAvatar.Location = new Point(1032, 5);
            ptrbxAvatar.Name = "ptrbxAvatar";
            ptrbxAvatar.Size = new Size(26, 26);
            ptrbxAvatar.TabIndex = 2;
            ptrbxAvatar.TabStop = false;
            // 
            // lstbxAvailableFlights
            // 
            lstbxAvailableFlights.Anchor = AnchorStyles.None;
            lstbxAvailableFlights.DataSource = flightBindingSource;
            lstbxAvailableFlights.DisplayMember = "FlightID";
            lstbxAvailableFlights.FormattingEnabled = true;
            lstbxAvailableFlights.ItemHeight = 20;
            lstbxAvailableFlights.Location = new Point(292, 108);
            lstbxAvailableFlights.Name = "lstbxAvailableFlights";
            lstbxAvailableFlights.Size = new Size(200, 284);
            lstbxAvailableFlights.TabIndex = 3;
            lstbxAvailableFlights.SelectedValueChanged += lstbxAvailableFlights_SelectedValueChanged;
            // 
            // flightBindingSource
            // 
            flightBindingSource.DataSource = typeof(Flight);
            // 
            // lstbxBookingFlights
            // 
            lstbxBookingFlights.Anchor = AnchorStyles.None;
            lstbxBookingFlights.DataSource = flightBindingSource;
            lstbxBookingFlights.DisplayMember = "FlightID";
            lstbxBookingFlights.FormattingEnabled = true;
            lstbxBookingFlights.ItemHeight = 20;
            lstbxBookingFlights.Location = new Point(618, 108);
            lstbxBookingFlights.Name = "lstbxBookingFlights";
            lstbxBookingFlights.Size = new Size(200, 284);
            lstbxBookingFlights.TabIndex = 7;
            lstbxBookingFlights.SelectedValueChanged += lstbxBookingFlights_SelectedValueChanged;
            // 
            // grpbxFlightInfo
            // 
            grpbxFlightInfo.Anchor = AnchorStyles.None;
            grpbxFlightInfo.Controls.Add(txtbxArrivalTime);
            grpbxFlightInfo.Controls.Add(lblArrivalTime);
            grpbxFlightInfo.Controls.Add(txtbxDepartureTime);
            grpbxFlightInfo.Controls.Add(lblDepartureType);
            grpbxFlightInfo.Controls.Add(txtbxFlightType);
            grpbxFlightInfo.Controls.Add(lblFlightType);
            grpbxFlightInfo.Location = new Point(69, 85);
            grpbxFlightInfo.Name = "grpbxFlightInfo";
            grpbxFlightInfo.Size = new Size(200, 307);
            grpbxFlightInfo.TabIndex = 5;
            grpbxFlightInfo.TabStop = false;
            grpbxFlightInfo.Text = "Flight Information";
            // 
            // txtbxArrivalTime
            // 
            txtbxArrivalTime.Location = new Point(6, 192);
            txtbxArrivalTime.Name = "txtbxArrivalTime";
            txtbxArrivalTime.ReadOnly = true;
            txtbxArrivalTime.Size = new Size(186, 27);
            txtbxArrivalTime.TabIndex = 5;
            txtbxArrivalTime.TabStop = false;
            // 
            // lblArrivalTime
            // 
            lblArrivalTime.AutoSize = true;
            lblArrivalTime.Location = new Point(6, 169);
            lblArrivalTime.Name = "lblArrivalTime";
            lblArrivalTime.Size = new Size(92, 20);
            lblArrivalTime.TabIndex = 4;
            lblArrivalTime.Text = "Arrival Time:";
            // 
            // txtbxDepartureTime
            // 
            txtbxDepartureTime.Location = new Point(6, 124);
            txtbxDepartureTime.Name = "txtbxDepartureTime";
            txtbxDepartureTime.ReadOnly = true;
            txtbxDepartureTime.Size = new Size(186, 27);
            txtbxDepartureTime.TabIndex = 3;
            txtbxDepartureTime.TabStop = false;
            // 
            // lblDepartureType
            // 
            lblDepartureType.AutoSize = true;
            lblDepartureType.Location = new Point(6, 101);
            lblDepartureType.Name = "lblDepartureType";
            lblDepartureType.Size = new Size(116, 20);
            lblDepartureType.TabIndex = 2;
            lblDepartureType.Text = "Departure Time:";
            // 
            // txtbxFlightType
            // 
            txtbxFlightType.Location = new Point(6, 59);
            txtbxFlightType.Name = "txtbxFlightType";
            txtbxFlightType.ReadOnly = true;
            txtbxFlightType.Size = new Size(186, 27);
            txtbxFlightType.TabIndex = 1;
            txtbxFlightType.TabStop = false;
            // 
            // lblFlightType
            // 
            lblFlightType.AutoSize = true;
            lblFlightType.Location = new Point(6, 36);
            lblFlightType.Name = "lblFlightType";
            lblFlightType.Size = new Size(84, 20);
            lblFlightType.TabIndex = 0;
            lblFlightType.Text = "Flight Type:";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(509, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.None;
            btnRemove.Image = (Image)resources.GetObject("btnRemove.Image");
            btnRemove.ImageAlign = ContentAlignment.MiddleRight;
            btnRemove.Location = new Point(509, 256);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(292, 85);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 8;
            label4.Text = "Available Flights:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(618, 85);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 9;
            label5.Text = "Booking Flights:";
            // 
            // lblBookedFlights
            // 
            lblBookedFlights.Anchor = AnchorStyles.None;
            lblBookedFlights.AutoSize = true;
            lblBookedFlights.Location = new Point(940, 85);
            lblBookedFlights.Name = "lblBookedFlights";
            lblBookedFlights.Size = new Size(110, 20);
            lblBookedFlights.TabIndex = 11;
            lblBookedFlights.Text = "Booked Flights:";
            // 
            // lstbxBookedFlights
            // 
            lstbxBookedFlights.Anchor = AnchorStyles.None;
            lstbxBookedFlights.DataSource = flightBindingSource;
            lstbxBookedFlights.DisplayMember = "FlightID";
            lstbxBookedFlights.FormattingEnabled = true;
            lstbxBookedFlights.ItemHeight = 20;
            lstbxBookedFlights.Location = new Point(940, 108);
            lstbxBookedFlights.Name = "lstbxBookedFlights";
            lstbxBookedFlights.Size = new Size(200, 284);
            lstbxBookedFlights.TabIndex = 12;
            lstbxBookedFlights.SelectedValueChanged += lstbxBookedFlights_SelectedValueChanged;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.None;
            btnConfirm.Image = (Image)resources.GetObject("btnConfirm.Image");
            btnConfirm.ImageAlign = ContentAlignment.MiddleRight;
            btnConfirm.Location = new Point(832, 224);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "Confirm";
            btnConfirm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnProfile
            // 
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.ImageAlign = ContentAlignment.MiddleRight;
            btnProfile.Location = new Point(1032, 34);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(94, 29);
            btnProfile.TabIndex = 13;
            btnProfile.Text = "Profile";
            btnProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 62);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // BookingForm
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnLogout;
            ClientSize = new Size(1240, 500);
            Controls.Add(pictureBox1);
            Controls.Add(btnProfile);
            Controls.Add(btnConfirm);
            Controls.Add(lblBookedFlights);
            Controls.Add(lstbxBookedFlights);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(grpbxFlightInfo);
            Controls.Add(lstbxBookingFlights);
            Controls.Add(lstbxAvailableFlights);
            Controls.Add(ptrbxAvatar);
            Controls.Add(btnLogout);
            Controls.Add(lblUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BookingForm";
            Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)ptrbxAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)flightBindingSource).EndInit();
            grpbxFlightInfo.ResumeLayout(false);
            grpbxFlightInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Button btnLogout;
        private PictureBox ptrbxAvatar;
        private ListBox lstbxAvailableFlights;
        private ListBox lstbxBookingFlights;
        private GroupBox grpbxFlightInfo;
        private Label lblFlightType;
        private Label lblDepartureType;
        private TextBox txtbxFlightType;
        private TextBox txtbxArrivalTime;
        private Label lblArrivalTime;
        private TextBox txtbxDepartureTime;
        private Button btnAdd;
        private Button btnRemove;
        private Label label4;
        private Label label5;
        private BindingSource flightBindingSource;
        private Label lblBookedFlights;
        private ListBox lstbxBookedFlights;
        private Button btnConfirm;
        private Button btnProfile;
        private PictureBox pictureBox1;
    }
}