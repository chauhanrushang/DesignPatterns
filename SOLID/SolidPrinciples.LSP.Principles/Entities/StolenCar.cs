using System.Drawing;

namespace SolidPrinciples.LSP.Principles.Entities
{
    public class StolenCar : Car
    {
        private bool _ignitionWiresStripped;

        public StolenCar(Color color) : base(color)
        {
        }

        public void StripIgnitionWires()
        {
            _ignitionWiresStripped = true;
        }
        public override void StartEngine()
        {
            if (!_ignitionWiresStripped) return;

            base.StartEngine();
        }
    }
}