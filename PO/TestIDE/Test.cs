using NUnit.Framework;
using Point = IDEuse.Point;
using Rectangle = IDEuse.Rectangle;

namespace TestIDE
{
    
    [TestFixture]
    public class TestIDE
    {
        readonly Point point = new Point(1, 1);
        readonly Rectangle rectangle = new Rectangle(new Point(0, 0), new Point(5, 0), new Point(5, 10), new Point(0, 10));

        [Test]
        public void PerimeterTest()
        {
            double expectation = 30;
            var result = rectangle.getPerimeter();
            Assert.AreEqual(expectation, result);
        }
        
        [Test]
        public void AreaTest()
        {
            double expectation = 50;
            double result = rectangle.getSquare();
            Assert.AreEqual(expectation, result);
        }
    
        [Test]
        public void moveTest()
        {
            string expectation = "A:(1,1) B:(6,1) C:(6,11) D:(1,11)";
            string result = rectangle.moveFigure(point).ToString();
            Assert.AreEqual(expectation, result);
        }
        
        [Test]
        public void diagonalTest()
        {
            double expectation = 11.180339887498949d;
            double result = rectangle.getDiagonal();
            Assert.AreEqual(expectation, result);
        }
        
        [Test]
        public void radiusTest()
        {
            double expectation = 5.5901699437494745d;
            double result = rectangle.circleRadius();
            Assert.AreEqual(expectation, result);
        }
    }
}