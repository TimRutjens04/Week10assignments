using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string Username = Console.ReadLine();
            Console.WriteLine($"Hello {Username}");
        }
    }
}