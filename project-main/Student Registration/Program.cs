using System;

namespace Student_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Student Registration Form");

            Console.Write("\n\nEnter first name: ");
            string firstName = Console.ReadLine();

            Console.Write("\nEnter last name: ");
            string lastName = Console.ReadLine();

            string number = "";
            int yearOfBirth;

            while (!Int32.TryParse(number, out yearOfBirth))    // Tries to parse 'number' to int (if this operation returns false loop repeats)
            {
                Console.Write("\nEnter year of birth(xxxx): ");
                number = Console.ReadLine();
            }
            
            //if (!Int32.TryParse(number, out yearOfBirth))
            //{
            //    Console.WriteLine("Failed Parse");
            //}
            //else
            //{
            //    Console.WriteLine("Successful Parse");
            //}

            string password = (firstName + "*" + yearOfBirth);
            Console.WriteLine("\n\nWelcome " + firstName + " " + lastName + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + password);

        }
    }
}
