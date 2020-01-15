using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Widget
{
    public class Drawing
    {
        List<WidgetBase> Widgets { get; set; }

        public Drawing()
        {
            Widgets = new List<WidgetBase>();
        }

        public void Add(WidgetBase widget)
        {
            Widgets.Add(widget);
        }

        public List<WidgetBase> GetWidgets()
        {
            return Widgets;
        }
    }
}
