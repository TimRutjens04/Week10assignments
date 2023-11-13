using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number, and this program will show you if it is odd or even: ");
        string input = Console.ReadLine();

        int number;
        if (int.TryParse(input, out number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
