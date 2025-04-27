using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using static System.Console;

namespace AnthonyUpchurch5CA
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Write("Enter the lenght of the room in feet: ");
            int length = int.Parse(ReadLine());

            Write("Enter the width of the room in feet: ");
            int width = int.Parse(ReadLine());

            double cost = ComputeCost(length, width);

            WriteLine("Cost of job for {0} X {1} foot room is {2}", length, width, cost.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        }

        static double ComputeCost(int length, int width)
        {
            const int height = 9;
            const double pricePerSquareFoot = 6.0;

            int totalWallArea = 2 * (length * height) + 2 * (width * height);


            return totalWallArea * pricePerSquareFoot; ;
        }
    }
}
