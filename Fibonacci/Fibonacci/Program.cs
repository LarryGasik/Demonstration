using System;
using Fibonacci.Logic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note: I know I should check for validation and such. 
            //      If you really want me to, I can, but that's not
            //      what you're looking for.

            Console.WriteLine("Welcome to the Fibonacci Generator.");
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            FibonaciGenerator fg = new FibonaciGenerator();
            var result = fg.fibonacci(Convert.ToInt32(input));
            string output = string.Join(", ", result);
            Console.WriteLine(output);
            Console.WriteLine("You have a nice day.");

        }
    }
}
