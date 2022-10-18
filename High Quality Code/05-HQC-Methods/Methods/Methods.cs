using System;
using System.Linq;
using System.Xml.Linq;

namespace Methods
{
    public class Methods
    {
        private static string[] NumberName = new string[] {
            "zero",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine"
        };

        static double CalcTriangleArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c)); 
        }

        static string NumberToDigit(int number)
        {
            return NumberName[number];
        }

        static int FindMax(params int[] elements)
        {
            return elements.Max();
        }

        static void PrintByFormat(object number, string format)
        {
            switch (format) 
            {
                case "f":
                    Console.WriteLine("{0:f2}", number);
                    break;
                case "%":
                    Console.WriteLine("{0:p0}", number);
                    break;
                case "r":
                    Console.WriteLine("{0,8}", number);
                    break;
            }
        }

        static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        static bool IsOlderThan(Student firstStudent, Student secondStudent)
        {
            return firstStudent.DateValue > secondStudent.DateValue;
        }

        static void Main()
        {
            try
            {
                Validator.ValidateNumbersTriangle(3, 4, 5);
                Console.WriteLine(CalcTriangleArea(3, 4, 5));

                Validator.ValidateNumberToDigit(5, NumberName.Length);
                Console.WriteLine(NumberToDigit(5));

                Validator.ValidateNumberMax(5, -1, 3, 2, 14, 2, 3);
                Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            }
            catch (ArgumentException e) 
            {
                Console.WriteLine(e.Message);
            }

            PrintByFormat(1.3, "f");
            PrintByFormat(0.75, "%");
            PrintByFormat(2.30, "r");

            bool isHorizontal = (-1 == 2.5);
            bool isVertical = !isHorizontal;

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + isHorizontal);
            Console.WriteLine("Vertical? " + isVertical);

            Student peter = new Student() 
            { 
                FirstName = "Peter",
                LastName = "Ivanov" 
            };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() 
            { 
                FirstName = "Stella",
                LastName = "Markova" 
            };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, IsOlderThan(peter, stella));
        }
    }
}
