using System;
using static System.Console;

namespace AnthonyUpchurch5CB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Write("Enter the number of miles: ");
            double miles = double.Parse(ReadLine());

            
            double kilometers = ConvertToKilos(miles);

            
            WriteLine("{0} miles is {1} kilometers.", miles, kilometers);
        }

        static double ConvertToKilos(double miles)
        {
            const double conversionFactor = 1.60934; 
            return miles * conversionFactor;
        }
    }
}