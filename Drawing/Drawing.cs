using System;
using System.Collections.Generic;
using System.Text;
namespace Widget
{
    public class Drawing
    {
        public List<WidgetBase> Widgets { get; set; }

        public Drawing()
        {
            Widgets = new List<WidgetBase>();
        }

        public void Add(WidgetBase widget)
        {
            Widgets.Add(widget);
        }

        public IEnumerable<string> Print()
        {
            foreach (var widget in Widgets)
                yield return widget.Display();
        }
    }
}
