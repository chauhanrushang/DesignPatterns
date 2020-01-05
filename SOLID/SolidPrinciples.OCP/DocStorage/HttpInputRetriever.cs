using System;
using System.Net;
using SolidPrinciples.OCP.Exceptions;

namespace SolidPrinciples.OCP.DocStorage
{
    public class HttpInputRetriever : DocumentStorage
    {
        public override void PersistDocument(string serializedDocument, string targetFileName)
        {
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