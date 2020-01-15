using Widget;
using Widget.Widgets;
using Xunit;

namespace DrawingTests
{
    public class DrawingShould
    {
        [Fact]
        public void AddWidget()
        {
            var circle = new Circle(5, 10);

            var sut = new Drawing();
            sut.Add(circle);

            var res = sut.GetWidgets();

            Assert.Single(res);
        }
    }
}
