using System;
using AreaCalculator;
using AreaCalculator.Exceptions;
using NUnit.Framework;

namespace AreaCalculatorTests
{
    public class TriangleTests
    {
        //TODO use fluent assertion
        [TestCase(3, 4, 5,ExpectedResult = 6)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        public double GetArea_CalculateValidArea(int a, int b, int c)
        {
            var triangle = new Triangle(a, b, c);

            var result = triangle.GetArea();

            return result;
        }
        
        [TestCase(7000, 1, 2)]
        public void Constructor_ThrowInvalidTriangleSidesExceptionWhenSidesIsInvalid(int a, int b, int c)
        {
            TestDelegate act = () => new Triangle(a, b, c);
            
            Assert.Throws<InvalidTriangleSidesException>(act);
        }
    }
}