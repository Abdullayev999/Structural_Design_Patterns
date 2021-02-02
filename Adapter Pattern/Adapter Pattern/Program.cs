using System.Collections.Generic;

namespace Adapter_Pattern
{
    #region GOOD
    interface IShape
    {
        void Draw(int x1, int y1, int x2, int y2);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>
            {
                new RectangleAdapter(new Rectangle()),
                new LineAdapter(new Line()),
                new CircleAdapter(new Circle())
            };

            foreach (var item in shapes)
            {
                item.Draw(5, 5, 15, 15);
            }
        }
    }
    #endregion

    #region BAD
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var shapes = new List<object>
    //        {
    //            new Rectangle(),
    //            new Line(),
    //            new Circle()
    //        };

    //        foreach (var item in shapes)
    //        {
    //            if (item is Rectangle)
    //            {
    //                (item as Rectangle).Draw(5, 5, 10, 10);
    //            }
    //            else if (item is Line)
    //            {
    //                (item as Line).Draw(5, 5, 15, 15);
    //            }
    //            else if (item is Circle)
    //            {
    //                (item as Circle).Draw(10, 10, 5);
    //            }
    //        }
    //    }
    //}
    #endregion
}
