using System;

namespace Widget
{
    public abstract class WidgetBase
    {
        public int X { get; set; }
        public int Y { get; set; }

        public WidgetBase(
            int X,
            int Y)
        {
            if (X < 0)
                throw new ArgumentException("Invalid value for argument X");

            if (Y < 0)
                throw new ArgumentException("Invalid value for argument Y");

            this.X = X;
            this.Y = Y;
        }

        public abstract string Display();
    }
}
