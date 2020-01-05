using System.Net;
using SolidPrinciples.DIP.IoCContainer.Exceptions;

namespace SolidPrinciples.DIP.IoCContainer.DocStorage
{
    public class HttpInputRetriever : IInputRetriever
    {
        public string GetData(string fileName)
        {
            if (!fileName.StartsWith("http"))
            {
                throw new InvalidTargetException();
            }

            var client = new WebClient();
            var input = client.DownloadString(fileName);

            return input;
        }
    }
}