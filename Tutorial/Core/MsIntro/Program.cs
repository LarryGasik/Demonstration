using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tutorial from 
            //https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/intro
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("The Current Time is " + DateTime.Now);
            MessageGenerator mg = new MessageGenerator();

            List<string> myList = new List<string>();
            myList.Add("Hello");
            myList.Add("My Friend");
            myList.Add("Hello");
            myList.Add(mg.GenerateSomeMessage());

            foreach (string x in myList)
            {
                Console.WriteLine(x);
            }
            //Execute this by typing 
            //dotnet run
            //in the console
        }
    }
}
