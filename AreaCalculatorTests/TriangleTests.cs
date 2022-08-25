using System;
using AreaCalculator;
using AreaCalculator.Exceptions;
using FluentAssertions;
using NUnit.Framework;

namespace AreaCalculatorTests
{
    public class TriangleTests
    {
        [TestCase(3, 4, 5,ExpectedResult = 6)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        public double GetArea_CalculateValidAreaWithCorrectData(int a, int b, int c)
        {
            var triangle = new Triangle(a, b, c);

            var result = triangle.GetArea();

            return result;
        }
        
        [TestCase(7000, 1, 2)]
        public void Constructor_ThrowInvalidTriangleSidesExceptionWhenSidesIsInvalid(int a, int b, int c)
        {
            Action act = () => new Triangle(a, b, c);

            act.Should().Throw<InvalidTriangleSidesException>();
        }
    }
}