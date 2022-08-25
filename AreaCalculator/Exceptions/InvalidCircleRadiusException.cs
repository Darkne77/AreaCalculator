using System;

namespace AreaCalculator.Exceptions
{
    public class InvalidCircleRadiusException : Exception
    {
        public InvalidCircleRadiusException() : base("Circle radius must be >= 0")
        {
            
        }
    }
}