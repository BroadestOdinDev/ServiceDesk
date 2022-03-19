namespace ServiceDesk
{
    public partial class VisualisationTicket : Form
    {
        public VisualisationTicket()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ULogin LoginForm = new ULogin();
            LoginForm.ShowDialog();
        }
    }
}