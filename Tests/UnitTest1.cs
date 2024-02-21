using Areas;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(5, ExpectedResult = 78.5398)]
        public double CircleTest(double a)
        {
            return new Circle(a).Area();
        }

        [TestCase(2, 3, 4, ExpectedResult = 2.9047)]
        public double TriangleTest(double a, double b, double c)
        {
            return new Triangle(a, b, c).Area();
        }

        [TestCase(4.3, ExpectedResult = 18.49)]
        public double SquareTest(double a)
        {
            return new Square(a).Area();
        }

        [TestCase(2, 5, ExpectedResult = 10)]
        public double RectangleTest(double a, double b)
        {
            return new Rectangle(a, b).Area();
        }

        [Test]
        public void ParallelogramTest()
        {
            var para1 = new Parallelogram(5, 3);
            var para2 = new Parallelogram(5, 3, 45);
            double expected1 = 15;
            double expected2 = 10.6066;

            double result1 = para1.Area();
            double result2 = para2.Area();

            Assert.That(result1, Is.EqualTo(expected1));
            Assert.That(result2, Is.EqualTo(expected2));
        }

        [TestCase(5, 5, 45, ExpectedResult = 8.8388)]
        public double QuadrangleTest(double a, double b, double c)
        {
            return new Quadrangle(a, b, c).Area();
        }

        [Test]
        public void RhombusTest()
        {
            var rhomubs1 = new Rhombus(5, 45.56);
            var rhomubs2 = new Rhombus();
            rhomubs2.SetDiagonales(5, 4);
            double expected1 = 17.8496;
            double expected2 = 10;

            double result1 = rhomubs1.Area();
            double result2 = rhomubs2.Area();

            Assert.That(result1, Is.EqualTo(expected1));
            Assert.That(result2, Is.EqualTo(expected2));
        }
    }
}