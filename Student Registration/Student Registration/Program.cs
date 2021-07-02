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

            Console.Write("\nEnter year of birth: ");
            string number = Console.ReadLine();
            int yearOfBirth; 
            
            if (!Int32.TryParse(number, out yearOfBirth))
            {
                Console.WriteLine("Failed Parse");
            }
            else
            {
                Console.WriteLine("Successful Parse");
            }

            string password = (firstName + "*" + yearOfBirth);
            Console.WriteLine("\n\nWelcome " + firstName + " " + lastName + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + password);

        }
    }
}
