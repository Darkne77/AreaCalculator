using System;
using AreaCalculator;
using AreaCalculator.Exceptions;
using FluentAssertions;
using NUnit.Framework;

namespace AreaCalculatorTests
{
    public class CircleTests
    {
        [TestCase(8, ExpectedResult = 201.0619)]
        [TestCase(0, ExpectedResult = 0)]
        public double GetArea_CalculateValidAreaWithCorrectData(int radius)
        {
            var circle = new Circle(radius);

            var result = circle.GetArea();

            return Math.Round(result,4);
        }

        [TestCase(-1)]
        public void Constructor_ThrowInvalidCircleRadiusExceptionWhenRadiusIsInvalid(int radius)
        {
            Action act = () => new Circle(radius);

            act.Should().Throw<InvalidCircleRadiusException>();
        }
    }
}