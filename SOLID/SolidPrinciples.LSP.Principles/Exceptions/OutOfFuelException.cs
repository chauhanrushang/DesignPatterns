using System;

namespace SolidPrinciples.Lsp.Principles.Exceptions
{
    public class OutOfFuelException : Exception
    {
        public OutOfFuelException(string message) : base(message)
        {
            
        }
    }
}