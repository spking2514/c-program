using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Books = new string[5];
            Books[0] = "English";
            Books[1] = "Java";
            Books[2] = "C#";
            Books[3] = "C++";
            Books[4] = "HTML";
 
            Console.WriteLine("All the element of Books array is:\n\n");
 
            int i = 0;
            Console.Write("\t1\t2\t3\t4\t5\n\n\t");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0}\t", Books[i]);
            }
            Console.ReadLine();
        }
    }
}

        
