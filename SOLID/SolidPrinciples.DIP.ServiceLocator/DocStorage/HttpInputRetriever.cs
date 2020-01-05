using System.Net;
using SolidPrinciples.DIP.ServiceLocator.Exceptions;

namespace SolidPrinciples.DIP.ServiceLocator.DocStorage
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