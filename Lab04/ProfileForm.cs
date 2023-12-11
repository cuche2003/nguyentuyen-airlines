﻿using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace Lab04
{
    public partial class ProfileForm : Form
    {
        private readonly DatabaseContext _dbContext;
        private readonly Customer _customer;

        public ProfileForm(DatabaseContext databaseContext, Customer customer)
        {
            _dbContext = databaseContext;
            InitializeComponent();

            cmbbxNationality.DataSource = Utils.GetCountryList();
            _customer = customer;
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            var codecs = ImageCodecInfo.GetImageEncoders();
            var codecFilter = "Image Files|";
            foreach (var codec in codecs)
            {
                codecFilter += codec.FilenameExtension + ";";
            }
            dlg.Filter = codecFilter;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtbxAvatarPath.Text = dlg.FileName == string.Empty ? "No File Chosen" : dlg.FileName;
                return;
            }

            txtbxAvatarPath.Text = "No File Chosen";

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            txtbxUsername.Text = _customer.UserName;
            txtbxPassword.Text = _customer.UserPassword;
            txtbxRetypePassword.Text = _customer.UserPassword;
            txtbxName.Text = _customer.CustomerName;
            dtpkBirthday.Value = _customer.Birthday;
            txtbxPassport.Text = _customer.PassPortNbr;
            cmbbxNationality.SelectedIndex = cmbbxNationality.Items.IndexOf(_customer.Nationality);
        }

        private bool ValidateUserName()
        {
            string username = txtbxUsername.Text;

            if (string.IsNullOrWhiteSpace(username) || username.Contains(' '))
            {
                lblError.Text = "Username required. Cannot be empty or consists of whitespaces.";
                return false;
            }

            if (username.Length < 8 || username.Length > 20)
            {
                lblError.Text = "Invalid username length. Must be > 8 and < 20.";
                return false;
            }

            string regex = @"^[\w@.-]*$";
            if (!Regex.IsMatch(username, regex, RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                lblError.Text = "Username can only consist of alphanumeric characters or the following symbols: @ . - _";
                return false;
            }

            var existed = _dbContext.Customers.SingleOrDefault(c => c.UserName == txtbxUsername.Text);
            if (existed != null && existed.CustomerID != _customer.CustomerID)
            {
                lblError.Text = "User already exists. Try another.";
                return false;
            }


            return true;
        }
        private bool ValidatePassword()
        {
            string password = txtbxPassword.Text;

            if (string.IsNullOrWhiteSpace(password) || password.Contains(' '))
            {
                lblError.Text = "Password required. Cannot be empty or consists of whitespaces.";
                return false;
            }

            if (password.Length < 8 || password.Length > 20)
            {
                lblError.Text = "Invalid password length. Must be > 8 and < 20.";
                return false;
            }

            string regex = @"^[\w@.-]*$";
            if (!Regex.IsMatch(password, regex, RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                lblError.Text = "Password can only consist of alphanumeric characters or the following symbols: @ . - _";
                return false;
            }

            if (txtbxPassword.Text != txtbxRetypePassword.Text)
            {
                lblError.Text = "Password and retyped password not match. Check spelling and type again.";
                return false;
            }

            return true;
        }
        private bool ValidateName()
        {
            string name = txtbxPassword.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                lblError.Text = "Name required. Cannot be empty or only whitespaces.";
                return false;
            }

            string regex = @"^[A-Za-z0-9]*$";
            if (!Regex.IsMatch(name, regex, RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                lblError.Text = "Name can only consist of alphanumeric characters.";
                return false;
            }

            return true;
        }
        private bool ValidateBirthday()
        {
            if (dtpkBirthday.Value >= DateTime.Now)
            {
                lblError.Text = "You are not a time traveller.";
                return false;
            }

            if ((DateTime.Now - dtpkBirthday.Value).TotalDays < 365)
            {
                lblError.Text = "Only users with age > 1 can use this app.";
                return false;
            }

            return true;
        }
        private bool ValidatePassport()
        {
            string passport = txtbxPassport.Text;

            if (string.IsNullOrWhiteSpace(passport) || passport.Contains(' '))
            {
                lblError.Text = "Passport required. Cannot be empty or consists of whitespaces.";
                return false;
            }

            if (passport.Length != 9)
            {
                lblError.Text = "Invalid passport length. Must be exactly 9 characters.";
                return false;
            }

            string regex = @"^[A-Za-z][0-9]{8}$";
            if (!Regex.IsMatch(passport, regex, RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                lblError.Text = "Passport must consist of exactly 1 letter, followed by 8 digits.";
                return false;
            }

            return true;
        }
        private bool ValidateNationality()
        {
            string nationality = cmbbxNationality.Text;

            if (!cmbbxNationality.Items.Contains(nationality))
            {
                lblError.Text = "Nationality not exists.";
                return false;
            }

            return true;
        }
        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            if (_dbContext == null)
            {
                MessageBox.Show("Database error. Try reopening the program.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            if
            (
                !ValidateUserName() ||
                !ValidatePassword() ||
                !ValidateName() ||
                !ValidateBirthday() ||
                !ValidatePassport() ||
                !ValidateNationality()
            )
            {
                return;
            }

            var entity = _dbContext.Customers.FirstOrDefault(c => c.CustomerID == _customer.CustomerID);
            if (entity == null)
            {
                MessageBox.Show("Invalide User", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            entity.UserName = txtbxUsername.Text;
            entity.UserPassword = txtbxPassword.Text;
            entity.CustomerName = txtbxName.Text;
            entity.Birthday = dtpkBirthday.Value;
            entity.Nationality = cmbbxNationality.Text;
            entity.PassPortNbr = txtbxPassport.Text;

            if (txtbxAvatarPath.Text == "No File Chosen")
            {
                entity.Avatar = Utils.ImageToByteArray(Image.FromFile(".\\resources\\profile.png"));
            }
            else if (txtbxAvatarPath.Text != "Unchanged")
            {
                entity.Avatar = Utils.ImageToByteArray(Image.FromFile(txtbxAvatarPath.Text));
            }

            _dbContext.SaveChanges();
            MessageBox.Show("Profile updated successfully", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
