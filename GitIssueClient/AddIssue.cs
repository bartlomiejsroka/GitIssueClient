using GitIssues;
using GitIssues.Models;

namespace GitIssueClient
{
    public partial class AddIssue : Form
    {
        private readonly IGitIssues _gitIssues;
        private readonly IHttpCodesValidator _httpCodesValidator;

        public AddIssue(IGitIssues gitIssues)
        {
            InitializeComponent();
            _gitIssues = gitIssues;
            _httpCodesValidator = new HttpCodesValidator();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (MandatoryFieldsAreEmpty())
            {
                MessageBox.Show("All fields are mandatory!");
                return;
            }

            var cancellationToken = new CancellationToken();
            var issueRequest = new Issue(textBoxTitle.Text, textBoxDescription.Text);
            var response = await _gitIssues.CreateIssue(issueRequest, cancellationToken);

            _httpCodesValidator.Validate(response, cancellationToken);
        }

        private bool MandatoryFieldsAreEmpty()
            =>  string.IsNullOrEmpty(textBoxTitle.Text) || string.IsNullOrEmpty(textBoxDescription.Text);
    }
}
