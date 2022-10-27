namespace simple
{
    public partial class Hi : Form
    {
        public Hi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string userName = tbName.Text.Trim();
            if (userName.Length < 3)
            {
                MessageBox.Show("Enter the name");

            }
            else
            {
                MessageBox.Show("Hello "+userName);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}