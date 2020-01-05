using System;
using System.Xml.Linq;
using SolidPrinciples.DIP.IoCContainer.Exceptions;

namespace SolidPrinciples.DIP.IoCContainer.Parsers
{
    public class InputParser
    {
        public virtual Document ParseInput(string input)
        {
            Document doc;
            try
            {
                var xdoc = XDocument.Parse(input);
                doc = new Document();
                doc.Title = xdoc.Root.Element("title").Value;
                doc.Text = xdoc.Root.Element("text").Value;
            }
            catch (Exception)
            {
                throw new InvalidInputFormatException();
            }

            return doc;
        }
    }
}