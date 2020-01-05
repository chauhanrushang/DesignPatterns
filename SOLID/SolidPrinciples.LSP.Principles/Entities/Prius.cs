using System.Drawing;

namespace SolidPrinciples.LSP.Principles.Entities
{
    public class Prius : Car
    {
        public Prius(Color color) : base(color)
        {
        }

        public override void StartEngine()
        {
        }
        public override void StopEngine()
        {
        }
    }
}