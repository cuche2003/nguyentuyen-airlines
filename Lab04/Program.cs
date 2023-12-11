using Microsoft.EntityFrameworkCore;

namespace Lab04
{
    internal static class Program
    {
        private static DatabaseContext? _dbContext;
        private static void LoadDatabaseContext()
        {
            DisposeDatabaseContext();
            _dbContext = new();

            _dbContext.Database.EnsureCreated();

            if (_dbContext == null)
            {
                return;
            }

            _dbContext.Customers.Load();
            _dbContext.Flights.Load();
        }

        private static void DisposeDatabaseContext()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
                _dbContext = null;
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new LoadingForm());
            LoadDatabaseContext();
            if (_dbContext == null)
            {
                return;
            }
            LoginForm loginForm = new(_dbContext);
            Application.Run(loginForm);

            while (loginForm.CurrentCustomer != null)
            {
                BookingForm bookingForm = new(loginForm.CurrentCustomer, _dbContext);
                Application.Run(bookingForm);

                if (bookingForm.DidLogOut)
                {
                    loginForm = new(_dbContext);
                    Application.Run(loginForm);
                }
                else
                {
                    break;
                }
            }
            DisposeDatabaseContext();
        }
    }
}