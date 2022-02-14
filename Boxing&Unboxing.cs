using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication6
{
    class boxingandunboxing
    {
        static void Main(string[] args)
        {
            //Boxing
            int num = 40;
            object num1 = num;
            //Unboxing
            int num2 = (int)num1;

            Console.Write(num2);
            Console.Read();

        }
    }
}
