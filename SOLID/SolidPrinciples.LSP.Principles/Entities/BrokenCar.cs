using System;
using System.Drawing;

namespace SolidPrinciples.LSP.Principles.Entities
{
    public class BrokenCar : Car
    {
        public BrokenCar(Color color) : base(color)
        {
        }

        public override void StartEngine()
        {
            throw new NotImplementedException();
        }
    }
}