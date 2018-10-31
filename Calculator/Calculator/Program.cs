using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATOR" +
                "\n----------");

            var numOne = Console.ReadLine();
            var expression = Console.ReadLine();
            var numTwo = Console.ReadLine();
            
            Console.WriteLine(numOne + expression + numTwo);
            Console.ReadLine();
        }
    }

    //addition class
    //class Addition
    //{
    //    static int Calc(int args)
    //    {
    //        var x = args
    //        var y = args
    //        return x + y;
    //    }
    //}

    //substraction class
    //class Substraction
    //{
    //    static int Calc(int args)
    //    {

    //    }
    //}

    //multiplation class

    //divide class
}
