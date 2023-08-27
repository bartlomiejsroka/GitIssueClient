using GitIssues;
using GitIssues.Models;
using ServiceStack;

namespace GitIssueClient
{
    public partial class ImportIssues : Form
    {
        private readonly IGitIssues _gitIssues;
        private string _path;
        private string _issuesToImport;

        public ImportIssues(IGitIssues gitIssues)
        {
            InitializeComponent();
            _gitIssues = gitIssues;
        }

        private async void btnImport_Click(object sender, EventArgs e)
        {
            var cancellationToken = new CancellationToken();
            try
            {
                var result = await _gitIssues.Import(_issuesToImport.FromJson<IReadOnlyCollection<Issue>>(), cancellationToken);
                if (result == System.Net.HttpStatusCode.Created)
                {
                    MessageBox.Show("Imported");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);            
            }

        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var file = openFileDialog1.FileName;
                _path = openFileDialog1.FileName;
                try
                {
                    _issuesToImport = File.ReadAllText(file);
                    btnImport.Enabled = true;
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            textBoxPath.Text = _path;
        }
    }
}
