using System;
using Widget.Widgets;

namespace Widget
{
    class Program
    {
        static void Main(string[] args)
        {
            var drawing = new Drawing();

            drawing.Add(new Circle(5, 10));

            foreach (var widget in drawing.Print())
                Console.WriteLine(widget);
        }
    }
}
