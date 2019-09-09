using System;

namespace trimmedSelfContained
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"test.txt");

            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            Console.WriteLine("Press a key to exit.");
            Console.Read();
        }
    }
}
