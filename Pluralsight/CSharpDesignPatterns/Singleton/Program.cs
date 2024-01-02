using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Singleton Example";


            Logger instance1 = Logger.Instance;
            Logger instance2 = Logger.Instance;

            if (instance1 == instance2 && instance1 == Logger.Instance)
            {
                Console.WriteLine("All instances are equal");
            }
            instance1.Log($"message from {nameof(instance1)}");
            instance1.Log($"message from {nameof(instance2)}");

            Logger.Instance.Log($"message from {nameof(Logger.Instance)}");

        }
    }
}
