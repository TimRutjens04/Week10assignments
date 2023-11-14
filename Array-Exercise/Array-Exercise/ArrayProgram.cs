using System;

namespace ArrayExc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount of people: ");
            int amountOfPeople = int.Parse(Console.ReadLine());

            // Arrays to store names and ages
            string[] names = new string[amountOfPeople];
            int[] ages = new int[amountOfPeople];

            for (int i = 0; i < amountOfPeople; i++)
            {
                Console.WriteLine($"Enter the name of person {i + 1}: ");
                names[i] = Console.ReadLine();

                Console.WriteLine($"Enter the age of person {i + 1}: ");
                ages[i] = int.Parse(Console.ReadLine());
            }

            // Displaying names and ages
            Console.WriteLine("\nDetails of People:");
            for (int i = 0; i < amountOfPeople; i++)
            {
                Console.WriteLine($"Name: {names[i]}, Age: {ages[i]}");
            }
        }
    }
}
