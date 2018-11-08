using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number to add:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number to add:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = " + Add(a, b), a, b);
            Console.WriteLine("Press a key to exit...");
            Console.ReadLine();
        }

        static public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
