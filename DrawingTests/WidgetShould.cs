using Widget;
using Widget.Widgets;
using Xunit;

namespace DrawingTests
{
    public class WidgetShould
    {
        [Fact]
        public void AddWidget()
        {
            var circle = new Circle(5, 10);

            Assert.IsAssignableFrom<WidgetBase>(circle);
        }
    }
}
