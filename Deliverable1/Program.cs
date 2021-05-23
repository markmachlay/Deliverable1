using System;
using System.Dynamic;
using System.Globalization;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueProgram = "";
            do
            {
                Console.WriteLine("Input measurement type");
                string measurement = Console.ReadLine();

                Console.WriteLine("Please input a measurement");
                double number = double.Parse(Console.ReadLine());

                string unit;
                double conversion = 0;
                if (measurement == "inch")
                {
                    unit = "fidget spinners";
                    conversion = number * 3.5;
                }
                else if (measurement == "fidget spinners")
                {
                    unit = "inch";
                    conversion = number / 3.5;
                }
                else if (measurement == "foot")
                {
                    unit = "meme";
                    conversion = number * 5;
                }
                else
                {
                    unit = "foot";
                    conversion = number / 5;
                }

                Console.WriteLine($"The measurement selected was {measurement}." + "\r\n" + $"The input was {number}. The outcome is {conversion} {unit}.");

                bool isValid;

                do
                {
                    Console.WriteLine("Would you like to continue?: (y/n)");
                    continueProgram = Console.ReadLine();
                    isValid = continueProgram == "y" || continueProgram == "n";
                } while (!isValid);


            } while (continueProgram == "y");
        }
    }
}
