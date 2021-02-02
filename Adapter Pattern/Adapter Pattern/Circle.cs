using System;

namespace Adapter_Pattern
{
    class Circle
    {
        public void PaintCircle(int x, int y, int radius)
        {
            Console.WriteLine("Circle:");
            Console.WriteLine($"X: {x}; Y: {y}");
            Console.WriteLine($"Radius: {radius}");
        }
    }
}
