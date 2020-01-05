using System.Drawing;
using SolidPrinciples.Lsp.Principles.Exceptions;

namespace SolidPrinciples.LSP.Principles.Entities
{
    public class Car
    {
        private bool _hasFuel = true;

        public Car(Color color)
        {
            Color = color;
        }

        public virtual void StartEngine()
        {
            if (!_hasFuel)
                throw new OutOfFuelException("Can't start a car without gas in tank...");

            IsEngineRunning = true;
        }
        public virtual void StopEngine()
        {
            IsEngineRunning = false;
        }

        public bool IsEngineRunning { get; private set; }
        public Color Color { get; protected set; }
    }
}
