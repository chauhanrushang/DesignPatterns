using System;
using System.IO;

namespace SolidPrinciples.OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\Input Documents\\Document1.xml");
            var targetFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\Output Documents\\Document1.json");
            //var sourceFileName = "http://www.xyzsite.com/Document1.xml";
            //var targetFileName = "https://abc.blob.core.windows.net/converted-documents/Document1.json";

            var formatConverter = new FormatConverter();
            if (!formatConverter.ConvertFormat(sourceFileName, targetFileName))
            {
                Console.WriteLine("Conversion failed...");
                Console.ReadKey();
            }
        }
    }
}
