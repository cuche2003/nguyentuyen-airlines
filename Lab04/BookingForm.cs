using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Lab04
{
    public partial class BookingForm : Form
    {
        private readonly DatabaseContext _dbContext;

        private readonly BindingList<Flight> _availableFlights;
        private readonly BindingList<Flight> _bookingFlights;
        private readonly BindingList<Flight> _bookedFlights;

        public Customer CurrentCustomer { get; private set; }
        public bool DidLogOut { get; private set; } = false;


        public BookingForm(Customer customer, DatabaseContext dbContext)
        {
            InitializeComponent();

            _dbContext = dbContext;
            CurrentCustomer =
                _dbContext.Customers
                          .Include(c => c.Flights)
                          .Single(c => c.CustomerID == customer.CustomerID);

            _availableFlights = _dbContext.Flights.Local.ToBindingList();
            _bookingFlights = new();
            _bookedFlights = new(CurrentCustomer.Flights);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            DisplayUserInfo();

            lstbxAvailableFlights.DataSource = _availableFlights;
            lstbxBookingFlights.DataSource = _bookingFlights;
            lstbxBookedFlights.DataSource = _bookedFlights;
        }

        private void DisplayUserInfo()
        {
            lblUsername.Text = "Hi " + CurrentCustomer.CustomerName + "!";
            ptrbxAvatar.Image = Utils.ByteArrayToImage(CurrentCustomer.Avatar);
            ptrbxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
            {
                return;
            }
            DidLogOut = true;
            Close();
        }

        private void lstbxAvailableFlights_SelectedValueChanged(object sender, EventArgs e)
        {
            var flight = GetSelectedAvailableFlight();

            if (flight == null)
            {
                return;
            }

            DisplayFlightInfo(flight);
        }

        private void lstbxBookingFlights_SelectedValueChanged(object sender, EventArgs e)
        {
            var flight = GetSelectedBookingFlight();

            if (flight == null)
            {
                return;
            }

            DisplayFlightInfo(flight);
        }

        private void lstbxBookedFlights_SelectedValueChanged(object sender, EventArgs e)
        {
            var flight = GetSelectedBookedFlight();

            if (flight == null)
            {
                return;
            }

            DisplayFlightInfo(flight);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var flight = GetSelectedAvailableFlight();
            if (flight == null)
            {
                return;
            }

            if (_bookingFlights.Contains(flight))
            {
                MessageBox.Show("Flight already booking.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (_bookedFlights.Contains(flight))
            {
                MessageBox.Show("Flight already booked.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _bookingFlights.Add(flight);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var flight = GetSelectedBookingFlight();
            if (flight == null)
            {
                return;
            }
            _bookingFlights.Remove(flight);
        }

        private Flight? GetSelectedAvailableFlight()
        {
            return (Flight?)lstbxAvailableFlights.SelectedValue;
        }

        private Flight? GetSelectedBookingFlight()
        {
            return (Flight?)lstbxBookingFlights.SelectedValue;
        }

        private Flight? GetSelectedBookedFlight()
        {
            return (Flight?)lstbxBookedFlights.SelectedValue;
        }

        private void DisplayFlightInfo(Flight flight)
        {
            txtbxFlightType.Text = flight.FlightType.ToString();
            txtbxArrivalTime.Text = flight.TimeArrival.ToString();
            txtbxDepartureTime.Text = flight.TimeDepart.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really want to book these flights? (This action is irreversible)", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
            {
                return;
            }
            foreach (var flight in _bookingFlights)
            {
                if (_bookedFlights.Contains(flight))
                {
                    continue;
                }
                _bookedFlights.Add(flight);
            }
            _dbContext.SaveChanges();
            _bookingFlights.Clear();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new(_dbContext, CurrentCustomer);
            profileForm.ShowDialog();
            DisplayUserInfo();
        }
    }
}
