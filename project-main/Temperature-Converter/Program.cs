using System;

namespace Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temperature converter");

            string choice = "y";

            while (choice.Equals("y")) 
            {
                string number = "";
                double tempF;

                while (!Double.TryParse(number, out tempF))
                {
                    Console.Write("\nEnter degrees in Fahrenheit: ");
                    number = Console.ReadLine();
                }

                double tempC;
                tempC = (tempF - 32) * (5.0 / 9.0);

                Console.WriteLine("Degrees in Celsius: " + tempC);

                Console.Write("\nContinue(y/n)?");
                choice = Console.ReadLine();
            }

            Console.WriteLine("Exiting application");
        }
    }
}
