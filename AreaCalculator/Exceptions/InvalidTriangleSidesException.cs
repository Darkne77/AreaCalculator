using System;

namespace AreaCalculator.Exceptions
{
    public class InvalidTriangleSidesException : Exception
    {
        public InvalidTriangleSidesException()
            : base("A, B, C must satisfy the triangle inequality theorem!")
        {
            
        }
    }
}