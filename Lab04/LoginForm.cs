using System.Text.RegularExpressions;

namespace Lab04
{
    public partial class LoginForm : Form
    {
        private readonly DatabaseContext _dbContext;
        public Customer? CurrentCustomer { get; private set; } = null;
        public LoginForm(DatabaseContext customersContext)
        {
            _dbContext = customersContext;
            InitializeComponent();
        }
        private Customer? ValidateLoginInfo()
        {
            string username = txtbxUsername.Text;

            if (string.IsNullOrWhiteSpace(username) || username.Contains(' '))
            {
                lblError.Text = "Username required. Cannot be empty or consists of whitespaces.";
                return null;
            }

            if (username.Length < 8 || username.Length > 20)
            {
                lblError.Text = "Invalid username length. Must be > 8 and < 20.";
                return null;
            }

            string regex = @"^[\w@.-]*$";
            if (!Regex.IsMatch(username, regex, RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                lblError.Text = "Username can only consist of alphanumeric characters or the following symbols: @ . - _";
                return null;
            }

            var customer = _dbContext.Customers.SingleOrDefault(c => c.UserName == txtbxUsername.Text);
            if (customer == null)
            {
                lblError.Text = "User not exists. Check spelling or try registering.";
                return null;
            }

            string password = txtbxPassword.Text;

            if (string.IsNullOrWhiteSpace(password) || password.Contains(' '))
            {
                lblError.Text = "Password required. Cannot be empty or consists of whitespaces.";
                return null;
            }

            if (password.Length < 8 || password.Length > 20)
            {
                lblError.Text = "Invalid password length. Must be > 8 and < 20.";
                return null;
            }

            if (!Regex.IsMatch(password, regex, RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                lblError.Text = "Password can only consist of alphanumeric characters or the following symbols: @ . - _";
                return null;
            }

            if (password != customer.UserPassword)
            {
                lblError.Text = $"Incorrect password. Check spelling and try again.";
                return null;
            }

            return customer;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_dbContext == null)
            {
                lblError.Text = "Database error. Try reopening the program.";
                return;
            };

            CurrentCustomer = ValidateLoginInfo();

            if (CurrentCustomer == null)
            {
                return;
            }

            MessageBox.Show("Logged in successfullly. Welcome back, " + CurrentCustomer.CustomerName + "!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new(_dbContext);
            regForm.ShowDialog();
        }
    }
}
