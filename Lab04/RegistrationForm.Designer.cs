namespace Lab04
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            btnRegister = new Button();
            txtbxPassword = new TextBox();
            txtbxUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            txtbxRetypePassword = new TextBox();
            lblRetypePassword = new Label();
            txtbxName = new TextBox();
            lblName = new Label();
            lblBirthday = new Label();
            dtpkBirthday = new DateTimePicker();
            txtbxPassport = new TextBox();
            lblPassport = new Label();
            lblNationality = new Label();
            cmbbxNationality = new ComboBox();
            lblAvatar = new Label();
            btnAvatar = new Button();
            txtbxAvatarPath = new TextBox();
            grpbxRegistrationInfo = new GroupBox();
            lblError = new Label();
            pictureBox1 = new PictureBox();
            grpbxRegistrationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegister.Dock = DockStyle.Bottom;
            btnRegister.Image = (Image)resources.GetObject("btnRegister.Image");
            btnRegister.ImageAlign = ContentAlignment.MiddleRight;
            btnRegister.Location = new Point(0, 421);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(800, 48);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtbxPassword
            // 
            txtbxPassword.Anchor = AnchorStyles.None;
            txtbxPassword.Location = new Point(245, 92);
            txtbxPassword.MaxLength = 20;
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.PasswordChar = '*';
            txtbxPassword.PlaceholderText = "Type your password here...";
            txtbxPassword.Size = new Size(287, 27);
            txtbxPassword.TabIndex = 9;
            txtbxPassword.UseSystemPasswordChar = true;
            // 
            // txtbxUsername
            // 
            txtbxUsername.Anchor = AnchorStyles.None;
            txtbxUsername.Location = new Point(245, 59);
            txtbxUsername.MaxLength = 20;
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.PlaceholderText = "Type your username here...";
            txtbxUsername.Size = new Size(287, 27);
            txtbxUsername.TabIndex = 8;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(166, 95);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(161, 62);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username:";
            // 
            // txtbxRetypePassword
            // 
            txtbxRetypePassword.Anchor = AnchorStyles.None;
            txtbxRetypePassword.Location = new Point(245, 125);
            txtbxRetypePassword.MaxLength = 20;
            txtbxRetypePassword.Name = "txtbxRetypePassword";
            txtbxRetypePassword.PasswordChar = '*';
            txtbxRetypePassword.PlaceholderText = "Retype your password here...";
            txtbxRetypePassword.Size = new Size(287, 27);
            txtbxRetypePassword.TabIndex = 10;
            txtbxRetypePassword.UseSystemPasswordChar = true;
            // 
            // lblRetypePassword
            // 
            lblRetypePassword.Anchor = AnchorStyles.None;
            lblRetypePassword.AutoSize = true;
            lblRetypePassword.Location = new Point(114, 128);
            lblRetypePassword.Name = "lblRetypePassword";
            lblRetypePassword.Size = new Size(125, 20);
            lblRetypePassword.TabIndex = 12;
            lblRetypePassword.Text = "Retype password:";
            // 
            // txtbxName
            // 
            txtbxName.Anchor = AnchorStyles.None;
            txtbxName.Location = new Point(245, 158);
            txtbxName.MaxLength = 20;
            txtbxName.Name = "txtbxName";
            txtbxName.PlaceholderText = "Type your full name here...";
            txtbxName.Size = new Size(287, 27);
            txtbxName.TabIndex = 14;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Location = new Point(187, 161);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 15;
            lblName.Text = "Name:";
            // 
            // lblBirthday
            // 
            lblBirthday.Anchor = AnchorStyles.None;
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(172, 194);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(67, 20);
            lblBirthday.TabIndex = 17;
            lblBirthday.Text = "Birthday:";
            // 
            // dtpkBirthday
            // 
            dtpkBirthday.Anchor = AnchorStyles.None;
            dtpkBirthday.Location = new Point(245, 191);
            dtpkBirthday.Name = "dtpkBirthday";
            dtpkBirthday.Size = new Size(287, 27);
            dtpkBirthday.TabIndex = 18;
            // 
            // txtbxPassport
            // 
            txtbxPassport.Anchor = AnchorStyles.None;
            txtbxPassport.Location = new Point(245, 224);
            txtbxPassport.MaxLength = 20;
            txtbxPassport.Name = "txtbxPassport";
            txtbxPassport.PlaceholderText = "Type your passport number here...";
            txtbxPassport.Size = new Size(287, 27);
            txtbxPassport.TabIndex = 19;
            // 
            // lblPassport
            // 
            lblPassport.Anchor = AnchorStyles.None;
            lblPassport.AutoSize = true;
            lblPassport.Location = new Point(114, 227);
            lblPassport.Name = "lblPassport";
            lblPassport.Size = new Size(125, 20);
            lblPassport.TabIndex = 20;
            lblPassport.Text = "Passport Number:";
            // 
            // lblNationality
            // 
            lblNationality.Anchor = AnchorStyles.None;
            lblNationality.AutoSize = true;
            lblNationality.Location = new Point(154, 260);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(85, 20);
            lblNationality.TabIndex = 22;
            lblNationality.Text = "Nationality:";
            // 
            // cmbbxNationality
            // 
            cmbbxNationality.Anchor = AnchorStyles.None;
            cmbbxNationality.FormattingEnabled = true;
            cmbbxNationality.Location = new Point(245, 257);
            cmbbxNationality.Name = "cmbbxNationality";
            cmbbxNationality.Size = new Size(287, 28);
            cmbbxNationality.TabIndex = 23;
            // 
            // lblAvatar
            // 
            lblAvatar.Anchor = AnchorStyles.None;
            lblAvatar.AutoSize = true;
            lblAvatar.Location = new Point(184, 294);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(55, 20);
            lblAvatar.TabIndex = 25;
            lblAvatar.Text = "Avatar:";
            // 
            // btnAvatar
            // 
            btnAvatar.Anchor = AnchorStyles.None;
            btnAvatar.Location = new Point(245, 291);
            btnAvatar.Name = "btnAvatar";
            btnAvatar.Size = new Size(119, 29);
            btnAvatar.TabIndex = 26;
            btnAvatar.Text = "Choose Image";
            btnAvatar.UseVisualStyleBackColor = true;
            btnAvatar.Click += btnAvatar_Click;
            // 
            // txtbxAvatarPath
            // 
            txtbxAvatarPath.Anchor = AnchorStyles.None;
            txtbxAvatarPath.Location = new Point(370, 292);
            txtbxAvatarPath.Name = "txtbxAvatarPath";
            txtbxAvatarPath.ReadOnly = true;
            txtbxAvatarPath.Size = new Size(162, 27);
            txtbxAvatarPath.TabIndex = 27;
            txtbxAvatarPath.Text = "No File Chosen";
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
            grpbxRegistrationInfo.Location = new Point(41, 72);
            grpbxRegistrationInfo.Name = "grpbxRegistrationInfo";
            grpbxRegistrationInfo.Size = new Size(724, 333);
            grpbxRegistrationInfo.TabIndex = 28;
            grpbxRegistrationInfo.TabStop = false;
            grpbxRegistrationInfo.Text = "Registration Information";
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(6, 21);
            lblError.Name = "lblError";
            lblError.Size = new Size(712, 25);
            lblError.TabIndex = 28;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(9, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 62);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // RegistrationForm
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(pictureBox1);
            Controls.Add(grpbxRegistrationInfo);
            Controls.Add(btnRegister);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrationForm";
            Text = "Registration";
            grpbxRegistrationInfo.ResumeLayout(false);
            grpbxRegistrationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRegister;
        private TextBox txtbxPassword;
        private TextBox txtbxUsername;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtbxRetypePassword;
        private Label lblRetypePassword;
        private TextBox txtbxName;
        private Label lblName;
        private Label lblBirthday;
        private DateTimePicker dtpkBirthday;
        private TextBox txtbxPassport;
        private Label lblPassport;
        private Label lblNationality;
        private ComboBox cmbbxNationality;
        private Label lblAvatar;
        private Button btnAvatar;
        private TextBox txtbxAvatarPath;
        private GroupBox grpbxRegistrationInfo;
        private Label lblError;
        private PictureBox pictureBox1;
    }
}