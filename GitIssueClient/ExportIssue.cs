using GitIssues;

namespace GitIssueClient
{
    public partial class ExportIssue : Form
    {
        private readonly IGitIssues _gitIssues;
        private readonly IJsonFileWriter _jsonFileWriter;
        private string _path;

        public ExportIssue(IGitIssues gitIssues)
        {
            InitializeComponent();
            _gitIssues = gitIssues;
            _jsonFileWriter = new JsonFileWriter();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            var folderPicker = new FolderBrowserDialog();
            folderPicker.ShowDialog();
            var path = folderPicker.SelectedPath;
            if (!string.IsNullOrEmpty(path))
            {
                _path = path;
                btnExport.Enabled = true;
                textBoxPath.Text = path;
            }
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            var cancellationToken = new CancellationToken();
            try
            {
                var exportResuilt = await _gitIssues.ExportAll(cancellationToken);
                if (exportResuilt != null)
                {
                    _jsonFileWriter.WriteIssueCollectionToFile(_path, exportResuilt);
                }
                else
                    MessageBox.Show("No issues to export");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
