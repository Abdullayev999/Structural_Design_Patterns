using System;

namespace Adapter_Pattern
{
    class Rectangle
    {
        public void Draw(int x, int y, int width, int height)
        {
            Console.WriteLine("Rectangle:");
            Console.WriteLine($"X: {x}; Y: {y}");
            Console.WriteLine($"Width: {width}; Height: {height}");
        }
    }
}
