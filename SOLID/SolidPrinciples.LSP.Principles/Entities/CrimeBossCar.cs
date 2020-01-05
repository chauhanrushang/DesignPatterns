using System.Drawing;
using SolidPrinciples.Lsp.Principles.Exceptions;

namespace SolidPrinciples.LSP.Principles.Entities
{
    public class CrimeBossCar : Car
    {
        private readonly bool _boobyTrapped;

        public CrimeBossCar(Color color, bool boobyTrap)
            : base(color)
        {
            _boobyTrapped = boobyTrap;
        }

        public override void StartEngine()
        {
            if (_boobyTrapped)
                throw new MetYourMakerException("Boom! You are dead!");

            base.StartEngine();
        }
    }
}