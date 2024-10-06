using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculator
{
    class Program
    {
        public static double CalculateArea(double a, double b, double c)
        {
            double sm = (a + b + c) / 2;
            double area = Math.Sqrt(sm * (sm - a) * (sm - b) * (sm - c));
            return area;
        }
        static void Main(string[] args)
        {
            double a = 4;
            double b = 6;
            double c = 7;

            double area = CalculateArea(a, b, c);
            Console.WriteLine("The area of a triangle is: " + area);
        }
    }
}
