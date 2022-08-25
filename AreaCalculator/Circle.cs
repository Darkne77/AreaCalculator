using System;
using AreaCalculator.Exceptions;

namespace AreaCalculator
{
    public class Circle : GeometricObject
    {
        public double Radius { get; }
        
        public Circle(double radius)
        {
            Radius = radius;
            
            if (!IsCircleValid())
            {
                throw new InvalidCircleRadiusException();
            }
        }

        private bool IsCircleValid()
        {
            return Radius >= 0;
        }

        /// <summary>
        /// Get circle area.
        /// </summary>
        public override double GetArea()
        {
           return Math.PI * Radius * Radius;
        }
    }
}