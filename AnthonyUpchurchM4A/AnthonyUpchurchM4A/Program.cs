using System;
using System.Runtime.InteropServices;
using static System.Console;
namespace AnthonyUpchurchM4A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bugsTotal = 0;
            double daffyTotal = 0;
            double elmerTotal = 0;
            double grandTotal = 0;

            while(true)
            {
                Console.WriteLine("Enter your initial or Z for totals: ");
                string input = Console.ReadLine().ToUpper();
                if (input == "Z")
                {
                    break;
                }

                if (input == "B" || input == "D" || input == "E")
                {
                    Console.WriteLine("Enter the amount of the sale: ");
                    string saleInput = Console.ReadLine();
                    double saleAmount;

                    if (double.TryParse(saleInput, out saleAmount) && saleAmount > 0)
                    {
                        if (input =="B")
                        {
                            bugsTotal += saleAmount;
                        }
                        else if (input == "D")
                        {
                            daffyTotal += saleAmount;
                        }
                        else if (input == "E")
                        {
                            elmerTotal += saleAmount;
                        }
                        grandTotal += saleAmount;
                    }
                    else
                    { 
                        Console.WriteLine("Invalid sale amount. Please enter a positive number.");
                    }

                }
                else
                {
                    Console.WriteLine("Sorry - invalid salesperson");
                }
            }
            Console.WriteLine("\n----- Sales Totals -----");
            Console.WriteLine("Bugs: $" + bugsTotal);
            Console.WriteLine("Daffy: $" + daffyTotal);
            Console.WriteLine("Elmer: $" + elmerTotal);
            Console.WriteLine("------------------------");
            Console.WriteLine("Grand Total: $" + grandTotal);

            string topSalesperson = "None";
            double highestTotal = 0;

            if (bugsTotal > highestTotal)
            {
                highestTotal = bugsTotal;
                topSalesperson = "Bugs";
            }

            if (daffyTotal > highestTotal)
            {
                highestTotal = daffyTotal;
                topSalesperson = "Daffy";
            }

            if (elmerTotal > highestTotal)
            {
                highestTotal = elmerTotal;
                topSalesperson = "Elmer";
            }

            // Display the top salesperson
            Console.WriteLine("Top Salesperson: " + topSalesperson);
        }
    }
}
