namespace Adapter_Pattern
{
    class LineAdapter : IShape
    {
        private readonly Line adaptee;

        public LineAdapter(Line adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Draw(int x1, int y1, int x2, int y2)
        {
            adaptee.DrawLine(x1, y1, x2, y2);
        }
    }
}
