using System;
using AreaCalculator.Exceptions;

namespace AreaCalculator
{
    public class Triangle : GeometricObject
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }

        public double HalfP => 1 / 2.0 * (A + B + C);

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;

            if (!IsTriangleValid())
            {
                throw new InvalidTriangleSidesException();
            }
        }

        private bool IsTriangleValid()
        {
            return (A <= B + C) && (B <= A + C) && (C <= A + B);
        }
        
        /// <summary>
        /// Get triangle area.
        /// </summary>
        public override double GetArea()
        {
            return Math.Sqrt(HalfP * (HalfP - A) * (HalfP - B) * (HalfP - C));
        }
    }
}