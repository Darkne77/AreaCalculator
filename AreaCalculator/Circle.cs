using System;

namespace AreaCalculator
{
    public class Circle : GeometricObject
    {
        public double Radius { get; }
        
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}