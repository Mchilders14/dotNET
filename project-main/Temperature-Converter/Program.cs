using System;
using System.Globalization;

namespace Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo setPrecision = new NumberFormatInfo();
            setPrecision.NumberDecimalDigits = 3;   // Setting number of decimal digits

            Console.WriteLine("Welcome to the temperature converter");

            string choice = "y";

            while (choice.Equals("y")) 
            {
                string number = "";
                double tempF;

                while (!Double.TryParse(number, out tempF)) // function to parse string -> double : returns boolean
                {
                    Console.Write("\nEnter degrees in Fahrenheit: ");
                    number = Console.ReadLine();
                }

                double tempC;
                tempC = (tempF - 32) * (5.0 / 9.0);

                Console.WriteLine($"Degrees in Celsius: {tempC.ToString("string", setPrecision)}"); // Using set precision instead of rounding

                Console.Write("\nContinue(y/n)?");
                choice = Console.ReadLine();
            }

            Console.WriteLine("Exiting application");
        }
    }
}
