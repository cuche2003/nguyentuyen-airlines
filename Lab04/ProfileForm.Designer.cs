namespace Lab04
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            grpbxRegistrationInfo = new GroupBox();
            lblError = new Label();
            txtbxUsername = new TextBox();
            txtbxAvatarPath = new TextBox();
            lblUsername = new Label();
            btnAvatar = new Button();
            lblPassword = new Label();
            lblAvatar = new Label();
            txtbxPassword = new TextBox();
            cmbbxNationality = new ComboBox();
            lblRetypePassword = new Label();
            lblNationality = new Label();
            txtbxRetypePassword = new TextBox();
            txtbxPassport = new TextBox();
            lblName = new Label();
            lblPassport = new Label();
            txtbxName = new TextBox();
            dtpkBirthday = new DateTimePicker();
            lblBirthday = new Label();
            btnUpdateProfile = new Button();
            pictureBox1 = new PictureBox();
            grpbxRegistrationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grpbxRegistrationInfo
            // 
            grpbxRegistrationInfo.Anchor = AnchorStyles.None;
            grpbxRegistrationInfo.Controls.Add(lblError);
            grpbxRegistrationInfo.Controls.Add(txtbxUsername);
            grpbxRegistrationInfo.Controls.Add(txtbxAvatarPath);
            grpbxRegistrationInfo.Controls.Add(lblUsername);
            grpbxRegistrationInfo.Controls.Add(btnAvatar);
            grpbxRegistrationInfo.Controls.Add(lblPassword);
            grpbxRegistrationInfo.Controls.Add(lblAvatar);
            grpbxRegistrationInfo.Controls.Add(txtbxPassword);
            grpbxRegistrationInfo.Controls.Add(cmbbxNationality);
            grpbxRegistrationInfo.Controls.Add(lblRetypePassword);
            grpbxRegistrationInfo.Controls.Add(lblNationality);
            grpbxRegistrationInfo.Controls.Add(txtbxRetypePassword);
            grpbxRegistrationInfo.Controls.Add(txtbxPassport);
            grpbxRegistrationInfo.Controls.Add(lblName);
            grpbxRegistrationInfo.Controls.Add(lblPassport);
            grpbxRegistrationInfo.Controls.Add(txtbxName);
            grpbxRegistrationInfo.Controls.Add(dtpkBirthday);
            grpbxRegistrationInfo.Controls.Add(lblBirthday);
            grpbxRegistrationInfo.Location = new Point(36, 82);
            grpbxRegistrationInfo.Name = "grpbxRegistrationInfo";
            grpbxRegistrationInfo.Size = new Size(728, 338);
            grpbxRegistrationInfo.TabIndex = 29;
            grpbxRegistrationInfo.TabStop = false;
            grpbxRegistrationInfo.Text = "Profile Information";
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(6, 27);
            lblError.Name = "lblError";
            lblError.Size = new Size(716, 25);
            lblError.TabIndex = 28;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbxUsername
            // 
            txtbxUsername.Anchor = AnchorStyles.None;
            txtbxUsername.Location = new Point(270, 63);
            txtbxUsername.MaxLength = 20;
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.PlaceholderText = "Type your username here...";
            txtbxUsername.Size = new Size(287, 27);
            txtbxUsername.TabIndex = 8;
            // 
            // txtbxAvatarPath
            // 
            txtbxAvatarPath.Anchor = AnchorStyles.None;
            txtbxAvatarPath.Location = new Point(395, 296);
            txtbxAvatarPath.Name = "txtbxAvatarPath";
            txtbxAvatarPath.ReadOnly = true;
            txtbxAvatarPath.Size = new Size(162, 27);
            txtbxAvatarPath.TabIndex = 27;
            txtbxAvatarPath.Text = "Unchanged";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(186, 66);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username:";
            // 
            // btnAvatar
            // 
            btnAvatar.Anchor = AnchorStyles.None;
            btnAvatar.Location = new Point(270, 295);
            btnAvatar.Name = "btnAvatar";
            btnAvatar.Size = new Size(119, 29);
            btnAvatar.TabIndex = 26;
            btnAvatar.Text = "Choose Image";
            btnAvatar.UseVisualStyleBackColor = true;
            btnAvatar.Click += btnAvatar_Click;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(191, 99);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password:";
            // 
            // lblAvatar
            // 
            lblAvatar.Anchor = AnchorStyles.None;
            lblAvatar.AutoSize = true;
            lblAvatar.Location = new Point(209, 298);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(55, 20);
            lblAvatar.TabIndex = 25;
            lblAvatar.Text = "Avatar:";
            // 
            // txtbxPassword
            // 
            txtbxPassword.Anchor = AnchorStyles.None;
            txtbxPassword.Location = new Point(270, 96);
            txtbxPassword.MaxLength = 20;
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.PasswordChar = '*';
            txtbxPassword.PlaceholderText = "Type your password here...";
            txtbxPassword.Size = new Size(287, 27);
            txtbxPassword.TabIndex = 9;
            txtbxPassword.UseSystemPasswordChar = true;
            // 
            // cmbbxNationality
            // 
            cmbbxNationality.Anchor = AnchorStyles.None;
            cmbbxNationality.FormattingEnabled = true;
            cmbbxNationality.Location = new Point(270, 261);
            cmbbxNationality.Name = "cmbbxNationality";
            cmbbxNationality.Size = new Size(287, 28);
            cmbbxNationality.TabIndex = 23;
            // 
            // lblRetypePassword
            // 
            lblRetypePassword.Anchor = AnchorStyles.None;
            lblRetypePassword.AutoSize = true;
            lblRetypePassword.Location = new Point(139, 132);
            lblRetypePassword.Name = "lblRetypePassword";
            lblRetypePassword.Size = new Size(125, 20);
            lblRetypePassword.TabIndex = 12;
            lblRetypePassword.Text = "Retype password:";
            // 
            // lblNationality
            // 
            lblNationality.Anchor = AnchorStyles.None;
            lblNationality.AutoSize = true;
            lblNationality.Location = new Point(179, 264);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(85, 20);
            lblNationality.TabIndex = 22;
            lblNationality.Text = "Nationality:";
            // 
            // txtbxRetypePassword
            // 
            txtbxRetypePassword.Anchor = AnchorStyles.None;
            txtbxRetypePassword.Location = new Point(270, 129);
            txtbxRetypePassword.MaxLength = 20;
            txtbxRetypePassword.Name = "txtbxRetypePassword";
            txtbxRetypePassword.PasswordChar = '*';
            txtbxRetypePassword.PlaceholderText = "Retype your password here...";
            txtbxRetypePassword.Size = new Size(287, 27);
            txtbxRetypePassword.TabIndex = 10;
            txtbxRetypePassword.UseSystemPasswordChar = true;
            // 
            // txtbxPassport
            // 
            txtbxPassport.Anchor = AnchorStyles.None;
            txtbxPassport.Location = new Point(270, 228);
            txtbxPassport.MaxLength = 20;
            txtbxPassport.Name = "txtbxPassport";
            txtbxPassport.PlaceholderText = "Type your passport number here...";
            txtbxPassport.Size = new Size(287, 27);
            txtbxPassport.TabIndex = 19;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Location = new Point(212, 165);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 15;
            lblName.Text = "Name:";
            // 
            // lblPassport
            // 
            lblPassport.Anchor = AnchorStyles.None;
            lblPassport.AutoSize = true;
            lblPassport.Location = new Point(139, 231);
            lblPassport.Name = "lblPassport";
            lblPassport.Size = new Size(125, 20);
            lblPassport.TabIndex = 20;
            lblPassport.Text = "Passport Number:";
            // 
            // txtbxName
            // 
            txtbxName.Anchor = AnchorStyles.None;
            txtbxName.Location = new Point(270, 162);
            txtbxName.MaxLength = 20;
            txtbxName.Name = "txtbxName";
            txtbxName.PlaceholderText = "Type your full name here...";
            txtbxName.Size = new Size(287, 27);
            txtbxName.TabIndex = 14;
            // 
            // dtpkBirthday
            // 
            dtpkBirthday.Anchor = AnchorStyles.None;
            dtpkBirthday.Location = new Point(270, 195);
            dtpkBirthday.Name = "dtpkBirthday";
            dtpkBirthday.Size = new Size(287, 27);
            dtpkBirthday.TabIndex = 18;
            // 
            // lblBirthday
            // 
            lblBirthday.Anchor = AnchorStyles.None;
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(197, 198);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(67, 20);
            lblBirthday.TabIndex = 17;
            lblBirthday.Text = "Birthday:";
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateProfile.Dock = DockStyle.Bottom;
            btnUpdateProfile.Image = (Image)resources.GetObject("btnUpdateProfile.Image");
            btnUpdateProfile.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdateProfile.Location = new Point(0, 438);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(800, 48);
            btnUpdateProfile.TabIndex = 30;
            btnUpdateProfile.Text = "Update Profile";
            btnUpdateProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateProfile.UseVisualStyleBackColor = true;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 62);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // ProfileForm
            // 
            AcceptButton = btnUpdateProfile;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(pictureBox1);
            Controls.Add(btnUpdateProfile);
            Controls.Add(grpbxRegistrationInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProfileForm";
            Text = "Profile";
            Load += ProfileForm_Load;
            grpbxRegistrationInfo.ResumeLayout(false);
            grpbxRegistrationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbxRegistrationInfo;
        private TextBox txtbxUsername;
        private TextBox txtbxAvatarPath;
        private Label lblUsername;
        private Button btnAvatar;
        private Label lblPassword;
        private Label lblAvatar;
        private TextBox txtbxPassword;
        private ComboBox cmbbxNationality;
        private Label lblRetypePassword;
        private Label lblNationality;
        private TextBox txtbxRetypePassword;
        private TextBox txtbxPassport;
        private Label lblName;
        private Label lblPassport;
        private TextBox txtbxName;
        private DateTimePicker dtpkBirthday;
        private Label lblBirthday;
        private Button btnUpdateProfile;
        private Label lblError;
        private PictureBox pictureBox1;
    }
}