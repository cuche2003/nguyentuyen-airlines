namespace Lab04
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblUsername = new Label();
            lblPassword = new Label();
            txtbxUsername = new TextBox();
            txtbxPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            grpbxLogin = new GroupBox();
            lblError = new Label();
            ptbxLogo = new PictureBox();
            grpbxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(62, 68);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(67, 101);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // txtbxUsername
            // 
            txtbxUsername.Anchor = AnchorStyles.None;
            txtbxUsername.Location = new Point(146, 65);
            txtbxUsername.MaxLength = 20;
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.PlaceholderText = "Type your username here...";
            txtbxUsername.Size = new Size(282, 27);
            txtbxUsername.TabIndex = 2;
            // 
            // txtbxPassword
            // 
            txtbxPassword.Anchor = AnchorStyles.None;
            txtbxPassword.Location = new Point(146, 98);
            txtbxPassword.MaxLength = 20;
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.PasswordChar = '*';
            txtbxPassword.PlaceholderText = "Type your password here...";
            txtbxPassword.Size = new Size(282, 27);
            txtbxPassword.TabIndex = 3;
            txtbxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleRight;
            btnLogin.Location = new Point(146, 137);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.Image = (Image)resources.GetObject("btnRegister.Image");
            btnRegister.ImageAlign = ContentAlignment.MiddleRight;
            btnRegister.Location = new Point(334, 137);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // grpbxLogin
            // 
            grpbxLogin.Anchor = AnchorStyles.None;
            grpbxLogin.Controls.Add(lblError);
            grpbxLogin.Controls.Add(lblUsername);
            grpbxLogin.Controls.Add(btnRegister);
            grpbxLogin.Controls.Add(lblPassword);
            grpbxLogin.Controls.Add(btnLogin);
            grpbxLogin.Controls.Add(txtbxUsername);
            grpbxLogin.Controls.Add(txtbxPassword);
            grpbxLogin.Location = new Point(149, 292);
            grpbxLogin.Name = "grpbxLogin";
            grpbxLogin.Size = new Size(497, 205);
            grpbxLogin.TabIndex = 7;
            grpbxLogin.TabStop = false;
            grpbxLogin.Text = "Login Information";
            // 
            // lblError
            // 
            lblError.Dock = DockStyle.Top;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(3, 23);
            lblError.Name = "lblError";
            lblError.Size = new Size(491, 28);
            lblError.TabIndex = 7;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ptbxLogo
            // 
            ptbxLogo.BackgroundImage = (Image)resources.GetObject("ptbxLogo.BackgroundImage");
            ptbxLogo.BackgroundImageLayout = ImageLayout.Center;
            ptbxLogo.Dock = DockStyle.Top;
            ptbxLogo.Location = new Point(0, 0);
            ptbxLogo.Name = "ptbxLogo";
            ptbxLogo.Size = new Size(800, 275);
            ptbxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbxLogo.TabIndex = 8;
            ptbxLogo.TabStop = false;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(ptbxLogo);
            Controls.Add(grpbxLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Login";
            grpbxLogin.ResumeLayout(false);
            grpbxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtbxUsername;
        private TextBox txtbxPassword;
        private Button btnLogin;
        private Button btnRegister;
        private GroupBox grpbxLogin;
        private PictureBox ptbxLogo;
        private Label lblError;
    }
}
