using System.Net;

namespace GitIssueClient
{
    internal interface IHttpCodesValidator
    {
        public void Validate(HttpStatusCode statusCode, CancellationToken cancellationToken);
    }

    internal class HttpCodesValidator : IHttpCodesValidator
    {
        public void Validate(HttpStatusCode statusCode, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) MessageBox.Show("Operation canceled");

            switch (statusCode)
            {
                case HttpStatusCode.Forbidden:
                    MessageBox.Show("You don't have permission to perform this action");
                    break;
                case HttpStatusCode.NotFound:
                    MessageBox.Show("User/Repo not found");
                    break;
                case HttpStatusCode.Created:
                    MessageBox.Show("Operation successful");
                    break;
                case HttpStatusCode.OK:
                    MessageBox.Show("Operation successful");
                    break;
                default:
                    MessageBox.Show("Unknow error occured");
                    break;
            }
        }
    }
}
