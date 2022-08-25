using AreaCalculator;
using AreaCalculator.Helpers;
using NUnit.Framework;

namespace AreaCalculatorTests.Helpers
{
    public class TriangleExtensionTests
    {
        [TestCase(3, 4, 5,ExpectedResult = true)]
        [TestCase(4, 4, 4,ExpectedResult = false)]
        [TestCase(0, 0, 0,ExpectedResult = true)]
        public bool IsRectangular_CalculateValidResult(int a, int b, int c)
        {
            var triangle = new Triangle(a, b, c);

            var result = triangle.IsRectangular();

            return result;
        }
    }
}