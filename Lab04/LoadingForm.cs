namespace Lab04
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void tmLoading_Tick(object sender, EventArgs e)
        {
            tmLoading.Stop();
            Close();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            tmLoading.Start();
        }
    }
}
