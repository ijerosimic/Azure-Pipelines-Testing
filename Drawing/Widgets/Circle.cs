using System;

namespace Widget.Widgets
{
    public class Circle : WidgetBase
    {
        public Circle(
            int X,
            int Y)
            : base(X, Y)
        {
        }

        public override string Display()
        {
            return "Drawing Circle";
        }
    }
}
