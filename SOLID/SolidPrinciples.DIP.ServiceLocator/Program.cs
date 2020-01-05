﻿using Microsoft.Practices.Unity;
using SolidPrinciples.DIP.ServiceLocator.DocStorage;
using SolidPrinciples.DIP.ServiceLocator.Parsers;
using SolidPrinciples.DIP.ServiceLocator.Serializers;
using System;
using System.Configuration;
using System.IO;

namespace SolidPrinciples.DIP.ServiceLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\Input Documents\\Document1.xml");
            var targetFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\Output Documents\\Document1.json");
            //var sourceFileName = "http://chris.59north.com/Document1.xml";
            //var targetFileName = "https://abc.blob.core.windows.net/converted-documents/Document1.json";

            ConfigureServiceLocator();
            ConfigureStorage();   

            var formatConverter = new FormatConverter();
            if (!formatConverter.ConvertFormat(sourceFileName, targetFileName))
            {
                Console.WriteLine("Conversion failed...");
                Console.ReadKey();
            }
        }

        private static void ConfigureServiceLocator()
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IDocumentSerializer, CamelCaseJsonSerializer>();
            container.RegisterType<InputParser, JsonInputParser>();

            var locator = new UnityServiceLocator(container);
            Microsoft.Practices.ServiceLocation.ServiceLocator.SetLocatorProvider(() => locator);
        }
        private static void ConfigureStorage()
        {
            var blobStorage = new BlobDocumentStorage(ConfigurationManager.AppSettings["storageAccount"], ConfigurationManager.AppSettings["storageKey"]);
            var fileStorage = new FileDocumentStorage();
            var httpInputRetriever = new HttpInputRetriever();

            InputRetriever.RegisterInputRetriever(x => x.StartsWith("http"), httpInputRetriever);
            InputRetriever.RegisterInputRetriever(IsBlobstorageUrl, blobStorage);
            InputRetriever.RegisterInputRetriever(x => true, fileStorage);
            DocumentPersister.RegisterDocumentPersister(IsBlobstorageUrl, blobStorage);
            DocumentPersister.RegisterDocumentPersister(x => true, fileStorage);
        }
        private static bool IsBlobstorageUrl(string str)
        {
            var storageAccount = ConfigurationManager.AppSettings["storageAccount"];
            return str.StartsWith(string.Format("https://{0}.blob.core.windows.net/", storageAccount));
        }
    }
}
