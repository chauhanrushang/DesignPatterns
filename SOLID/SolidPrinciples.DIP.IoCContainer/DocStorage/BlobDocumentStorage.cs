using System;
using System.Net;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using SolidPrinciples.DIP.IoCContainer.Exceptions;

namespace SolidPrinciples.DIP.IoCContainer.DocStorage
{
    public class BlobDocumentStorage : DocumentStorage
    {
        private readonly CloudBlobClient _blobClient;

        public BlobDocumentStorage(string storageAccount, string storageKey)
        {
            var account = new CloudStorageAccount(new StorageCredentials(storageAccount, storageKey), true);
            _blobClient = account.CreateCloudBlobClient();
        }

        public override string GetData(string fileName)
        {
            if (!fileName.StartsWith(_blobClient.BaseUri.ToString()))
            {
                throw new InvalidTargetException();
            }

            var client = new WebClient();
            var input = client.DownloadString(fileName);

            return input;
        }
        public override void PersistDocument(string serializedDocument, string targetFileName)
        {
            if (!targetFileName.StartsWith(_blobClient.BaseUri.ToString()))
            {
                throw new InvalidTargetException();
            }

            var uri = new Uri(targetFileName);
            var containerName = uri.AbsolutePath.Substring(1, uri.AbsolutePath.IndexOf('/', 1) - 1);
            var container = _blobClient.GetContainerReference(containerName);
            container.CreateIfNotExists(BlobContainerPublicAccessType.Container);
            var blob = container.GetBlockBlobReference(targetFileName.Replace(_blobClient.BaseUri + containerName + "/", ""));
            blob.UploadText(serializedDocument);
        }
    }
}