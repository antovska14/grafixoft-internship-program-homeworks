using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Validator
    {
        public static void ValidateNumbersTriangle(double a, double b, double c)
        {
            bool numbersUnderZero = (a <= 0 || b <= 0 || c <= 0);

            if (numbersUnderZero)
            {
                throw new ArgumentException("Sides should be positive!");
            }
        }

        public static void ValidateNumberToDigit(int number, int numberNameLength)
        {
            if (number > numberNameLength)
            {
                throw new ArgumentException("Number must be smaller than 10!");
            }
        }

        public static void ValidateNumberMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Array has no elements!");
            }
        }
    }
}
