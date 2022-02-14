using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication5
{
    class operators
    {
        static void Main(string[] args)
        {
            int result;
            int x = 10, y = 5;

            // Addition
            Console.WriteLine("Addition Operator: " + (x + y));

            // Subtraction
            Console.WriteLine("Subtraction Operator: " + (x - y));

            // Multiplication
            Console.WriteLine("Multiplication Operator: " + (x * y));

            // Division
            Console.WriteLine("Division Operator: " + (x / y));

            // Modulo
            Console.WriteLine("Modulo Operator: " + (x % y));
            Console.ReadLine();
        }
    }
}
