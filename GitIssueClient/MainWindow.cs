namespace GitIssueClient
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gitHubTokenWindow = new GitHubToken();
            gitHubTokenWindow.ShowDialog();
        }

        private void btnGitLab_Click(object sender, EventArgs e)
        {
            var gitLabTokenWindow = new GitLabToken();
            gitLabTokenWindow.ShowDialog();
        }
    }
}