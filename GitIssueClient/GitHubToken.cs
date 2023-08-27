using GitIssues;
using GitIssues.GitHub;

namespace GitIssueClient
{
    public partial class GitHubToken : Form
    {
        private IGitIssues _gitIssues;

        public GitHubToken()
        {
            InitializeComponent();
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            if (MandatoryFieldsEmpty())
            {
                MessageBox.Show("All field are mandatory");
                return;
            }
            _gitIssues = new GitHubIssueProvider(textBoxToken.Text, textBoxUserName.Text, textBoxRepoName.Text);

            var cancaletaionToken = new CancellationToken();
            var result = await _gitIssues.CheckToken(textBoxToken.Text, cancaletaionToken);

            if (result != System.Net.HttpStatusCode.OK || cancaletaionToken.IsCancellationRequested)
            {
                MessageBox.Show("Invalid token");
                return;
            }

            MessageBox.Show("Token valid!");

            EnableButtons(true);
        }

        private bool MandatoryFieldsEmpty()
            => string.IsNullOrEmpty(textBoxToken.Text) || string.IsNullOrEmpty(textBoxUserName.Text) || string.IsNullOrEmpty(textBoxRepoName.Text);


        private void EnableButtons(bool enabled)
        {

            btnAddNewIssue.Enabled = true;
            btnCloseIssue.Enabled = true;
            btnExportAllIssues.Enabled = true;
            btnImportIssue.Enabled = true;
            btnModifyIssue.Enabled = true;
        }

        private void btnAddNewIssue_Click(object sender, EventArgs e)
        {
            var addIssueWindow = new AddIssue(_gitIssues);
            addIssueWindow.ShowDialog();
        }

        private void btnModifyIssue_Click(object sender, EventArgs e)
        {
            var editIssue = new EditIssue(_gitIssues);
            editIssue.ShowDialog();
        }

        private void btnCloseIssue_Click(object sender, EventArgs e)
        {
            var closeIssue = new CloseIssue(_gitIssues);
            closeIssue.ShowDialog();
        }

        private void btnExportAllIssues_Click(object sender, EventArgs e)
        {
            var exportIssue = new ExportIssue(_gitIssues);
            exportIssue.ShowDialog();
        }

        private void btnImportIssue_Click(object sender, EventArgs e)
        {
            var importIssues = new ImportIssues(_gitIssues);
            importIssues.ShowDialog();
        }
    }
}
