using System;

namespace ProgramLogika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Password: ");
            string password = Console.ReadLine();

            bool isAdult = age > 18; // pernyataan 1
            bool isPasswordValid = password == "admin"; // pernyataan 2

            // menggunakan logika AND
            if (isAdult && isPasswordValid)
            {
                Console.WriteLine("WELCOME TO THE CLUB!");
            }
            else
            {
                Console.WriteLine("Sorry, try again!");
            }
        }
    }
}
