using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            String firstName = "Joe";
            string lastName = "Schmoe";

            int n1 = 5;
            int n2 = 7;

            int sum = n1 + n2;

            Console.WriteLine(firstName + " " + lastName);




            var name1 = "Sam Brown";

            // Single line comment

            /*
             * Block 
             * Comment
             */

            double price1 = 25.99;

            Console.WriteLine("Enter Your Name: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Hi, " + name2 + "!!!!");

            string choice = "y";

            while (choice.Equals("y")){
                Console.WriteLine("Continue");
                choice = Console.ReadLine();
            }

            if (sum>10)
            {
                Console.WriteLine("> 10");
            }
            else
            {
                Console.WriteLine("< 10");
            }

            Console.WriteLine((sum > 10) ? "Sum Greater Than 10" : "Sum Less Than 10");

            if (true)
            {

            }

        }
    }
}
