using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Please enter a number (or type 'exit' to end): ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                break;
            }

            if (int.TryParse(userInput, out int userMultiplicationsInt))
            {
                Console.Write($"Enter the number of times to multiply {userMultiplicationsInt}: ");
                string timesInput = Console.ReadLine();

                if (int.TryParse(timesInput, out int numberOfTimes))
                {
                    int multiplicationsLeft = 0;
                    while (multiplicationsLeft < numberOfTimes)
                    {
                        multiplicationsLeft = multiplicationsLeft + 1;
                        Console.WriteLine($"{userMultiplicationsInt} X {multiplicationsLeft} = {userMultiplicationsInt * multiplicationsLeft}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for the number of times. Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number or 'exit' to end.");
            }
        }
    }
}
