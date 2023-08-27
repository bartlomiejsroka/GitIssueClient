using GitIssues;

namespace GitIssueClient
{
    public partial class CloseIssue : Form
    {
        private readonly IGitIssues _gitIssues;
        private readonly IHttpCodesValidator _httpCodesValidator;

        public CloseIssue(IGitIssues gitIssues)
        {
            InitializeComponent();
            _gitIssues = gitIssues;
            _httpCodesValidator = new HttpCodesValidator();
        }

        private async void btnClose_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBoxIssueNumber.Text, out var issueNumber))
            {
                MessageBox.Show("Issue number is not valid");
                return;
            }

            var cancellationToken = new CancellationToken();
            var response = await _gitIssues.CloseIssue(issueNumber, cancellationToken);

            _httpCodesValidator.Validate(response, cancellationToken);
        }
    }
}
