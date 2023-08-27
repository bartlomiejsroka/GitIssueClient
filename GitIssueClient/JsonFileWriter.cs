using GitIssues.Models;
using ServiceStack;

namespace GitIssueClient
{
    internal interface IJsonFileWriter
    {
        public void WriteIssueCollectionToFile(string path, IReadOnlyCollection<Issue> issues);
    }

    internal class JsonFileWriter : IJsonFileWriter
    {
        public const string dateTimeFormat = "yyyy_MM_dd_hh_mm_ss";
        public const string fileFormat = ".json";

        public void WriteIssueCollectionToFile(string path, IReadOnlyCollection<Issue> issues)
        {
            var fileName = path + "/export" + "_" + DateTime.Now.ToString(dateTimeFormat) + fileFormat;
            var scv = issues.ToJson();
            using (var sw = new StreamWriter(fileName))
            {
                sw.Write(scv);
            }
            MessageBox.Show("Exprted");
        }
    }
}
