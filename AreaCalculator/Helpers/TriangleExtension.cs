using System;

namespace AreaCalculator.Helpers
{
    public static class TriangleExtension
    {
        public static bool IsRectangular(this Triangle tr)
        {
            var sides = new int[] {tr.A, tr.B, tr.C};
            Array.Sort(sides);
            var (catA, catB, hypo) = (sides[0], sides[1], sides[2]);
            return hypo * hypo == catA * catA + catB * catB;
        }
    }
}