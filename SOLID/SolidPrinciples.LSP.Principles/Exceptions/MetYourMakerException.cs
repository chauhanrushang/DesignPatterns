using System;

namespace SolidPrinciples.Lsp.Principles.Exceptions
{
    public class MetYourMakerException : Exception
    {
        public MetYourMakerException(string message) : base(message)
        {

        }
    }
}