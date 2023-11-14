using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Please enter an integer. Press Enter to proceed.");
        string input = Console.ReadLine();

        while (input != "")
        {
            int value;
            if (!int.TryParse(input, out value))
            {
                Console.WriteLine("Please enter a valid integer.");
            }
            else
            {
                numbers.Add(value);
            }

            Console.WriteLine("Please enter another integer or press Enter to proceed.");
            input = Console.ReadLine();
        }

        // Calculate and display statistics
        if (numbers.Count > 0)
        {
            Console.WriteLine($"Average: {CalculateAverage(numbers)}");
            Console.WriteLine($"Max: {numbers.Max()}");
            Console.WriteLine($"Min: {numbers.Min()}");
            Console.WriteLine($"Sum: {numbers.Sum()}");
            Console.WriteLine($"Multiplication: {CalculateMultiplication(numbers)}");
        }
        else
        {
            Console.WriteLine("No numbers entered.");
        }
    }

    static double CalculateAverage(List<int> numbers)
    {
        return numbers.Average();
    }

    static int CalculateMultiplication(List<int> numbers)
    {
        int result = 1;
        foreach (int number in numbers)
        {
            result *= number;
        }
        return result;
    }
}
