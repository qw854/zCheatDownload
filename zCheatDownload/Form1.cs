namespace zCheatDownload
{
    public partial class zCheatDownload : Form
    {
        public zCheatDownload()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GhostClients().ShowDialog ();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new InGameClients().ShowDialog ();
        }
    }
}