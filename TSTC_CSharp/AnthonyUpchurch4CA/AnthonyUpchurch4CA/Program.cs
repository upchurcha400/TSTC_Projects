using System;
using static System.Console;

namespace AnthonyUpchurch4CA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Store the default console colors
            ConsoleColor defaultBackground = BackgroundColor;
            ConsoleColor defaultForeground = ForegroundColor;

            // Set the custom console colors
            BackgroundColor = ConsoleColor.Gray;
            ForegroundColor = ConsoleColor.Black;
            Clear();

            WriteLine("Cannon Blast Warning System");
            WriteLine("----------------------------");

            // Loop through numbers 1 to 100
            for (int crankTurn = 1; crankTurn <= 100; crankTurn++)
            {
                if (crankTurn % 3 == 0 && crankTurn % 5 == 0) // Massive Blast
                {
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine($"Turn {crankTurn}: Massive Combined Blast!");
                }
                else if (crankTurn % 3 == 0) // Fire Blast
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"Turn {crankTurn}: Fire Blast!");
                }
                else if (crankTurn % 5 == 0) // Electric Blast
                {
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine($"Turn {crankTurn}: Electric Blast!");
                }
                else // No Blast
                {
                    ForegroundColor = ConsoleColor.Black;
                    WriteLine($"Turn {crankTurn}: No Blast.");
                }
            }

            // Reseting the console colors to their defaults
            BackgroundColor = defaultBackground;
            ForegroundColor = defaultForeground;
            Clear(); 
        }
    }
}