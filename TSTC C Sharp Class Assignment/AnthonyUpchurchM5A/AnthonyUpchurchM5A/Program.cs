using System;
using static System.Console;

namespace AnthonyUpchurchM5A
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Write("Enter the number of miles: ");

            int miles;
            bool isValid = int.TryParse(Console.ReadLine(), out miles);

            if (isValid && miles >= 0)
            {
                int feet = ConvertIt(miles);

                WriteLine(miles + " miles is " + feet + " feet.");
            }
            else
            {
                WriteLine("Invalid input. Please enter a non-negative integer.");
            }
        }

        static int ConvertIt(int miles)
        {
            return miles * 5280;
        }
    }
}