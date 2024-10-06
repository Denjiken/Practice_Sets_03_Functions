using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            bool leapYear = LeapYear(year);
            if (leapYear)
            {
                Console.WriteLine($"{year} is leapyear.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leapyear.");
            }
        }
        static bool LeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
