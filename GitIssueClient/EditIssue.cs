using GitIssues;
using GitIssues.Models;

namespace GitIssueClient
{
    public partial class EditIssue : Form
    {
        private readonly IGitIssues _gitIssues;
        private readonly IHttpCodesValidator _httpCodesValidator;

        public EditIssue(IGitIssues gitIssues)
        {
            InitializeComponent();
            _gitIssues = gitIssues;
            _httpCodesValidator = new HttpCodesValidator();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MandatoryFieldsAreEmpty())
            {
                MessageBox.Show("All fields are mandatory!");
                return;
            }
            
            if (!int.TryParse(textBoxIssueNumber.Text, out var issueNumber))
            {
                MessageBox.Show("Issue number is not valid");
                return;
            }

            var issueRequest = new Issue(textBoxTitle.Text, textBoxDescription.Text);
            var cancellationToken = new CancellationToken();

            var response  = await _gitIssues.UpdateIssue(issueNumber, issueRequest, cancellationToken);

            _httpCodesValidator.Validate(response, cancellationToken);
        }

        private bool MandatoryFieldsAreEmpty()
           => string.IsNullOrEmpty(textBoxTitle.Text) || string.IsNullOrEmpty(textBoxDescription.Text) || string.IsNullOrEmpty(textBoxIssueNumber.Text);
    }
}
