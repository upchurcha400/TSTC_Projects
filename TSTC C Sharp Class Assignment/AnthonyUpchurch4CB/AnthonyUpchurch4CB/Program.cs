using System;
using static System.Console; 

namespace AnthonyUpchurch4CB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display table headers
            Write("    "); 
            for (int header = 1; header <= 10; header++)
            {
                Write($"{header,4}"); // Print column headers
            }
            WriteLine(); 
            WriteLine(new string('-', 45)); 

            // Nested loop for multiplication table
            for (int row = 1; row <= 10; row++)
            {
                Write($"{row,2} |"); 
                for (int col = 1; col <= 10; col++)
                {
                    Write($"{row * col,4}"); // Print results
                }
                WriteLine(); // Add anew line after each row for readabilty
            }
        }
    }
}