using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, total;
            float per;

            Console.Write("Enter marks of subject 1 :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks of subject 2 :");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks of subject 3 :");
            c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks of subject 4 :");
            d = Convert.ToInt32(Console.ReadLine());

            total = a + b + c + d;
            Console.WriteLine("Total of all subjects is :" + total);



            per = total / 4;
            Console.WriteLine("Percentage of total is :" + per);


            if (per >= 70)
                Console.Write("distinct");
            else if (per >= 60)
                Console.Write("First class");
            else if (per >= 50)
                Console.Write("Second class");
            else if (per >= 40)
                Console.Write("Third class");
            else
                Console.Write(" fail ");

            Console.ReadLine();
        }
    }
}
