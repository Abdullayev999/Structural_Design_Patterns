namespace Adapter_Pattern
{
    class RectangleAdapter : IShape
    {
        private readonly Rectangle adaptee;

        public RectangleAdapter(Rectangle adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Draw(int x1, int y1, int x2, int y2)
        {
            int width = x2 - x1;
            int height = y2 - y1;
            adaptee.Draw(x1, y1, width, height);
        }
    }
}
