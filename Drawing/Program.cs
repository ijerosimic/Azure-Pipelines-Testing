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

            Print(drawing);
        }

        public static void Print()
        {
            Console.WriteLine("Widgets:");

            foreach (var widget in drawing.GetWidgets())
                Console.WriteLine(widget.Display());
        }
    }
}
