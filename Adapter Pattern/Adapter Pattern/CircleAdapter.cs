namespace Adapter_Pattern
{
    class CircleAdapter : IShape
    {
        private readonly Circle adaptee;

        public CircleAdapter(Circle adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Draw(int x1, int y1, int x2, int y2)
        {
            int radius = (x2 - x1) / 2;
            int centerX = x1 + radius;
            int centerY = y1 + radius;
            adaptee.PaintCircle(centerX, centerY, radius);
        }
    }
}
