using System;
using System.Net;
using SolidPrinciples.LSP.Exceptions;

namespace SolidPrinciples.LSP.DocStorage
{
    public class HttpInputRetriever : DocumentStorage
    {
        public override void PersistDocument(string serializedDocument, string targetFileName)
        {
            // Impossible to solve...
            // Fixed in the ISP phase...
            throw new NotImplementedException();
        }

        public override string GetData(string fileName)
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