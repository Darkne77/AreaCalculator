using System;

namespace AreaCalculator
{
    public class Triangle : GeometricObject
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }

        public double S => 1 / 2 * (A + B + C);

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            return Math.Sqrt(S * (S - A) * (S - B) * (S - C));
        }
    }
}