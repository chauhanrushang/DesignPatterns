using System.Drawing;

namespace SolidPrinciples.LSP.Principles.Entities
{
    public class PimpedCar : Car
    {
        private readonly Color _color;

        public PimpedCar(Color color) : base(color)
        {
            _color = color;
        }

        public void SetTemperature(int temp)
        {
            if (temp > 20)
                Color = _color;
            else
                Color = Color.Black;
        }
    }
}