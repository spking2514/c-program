using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Bill
    {
        static void Main(string[] args)
        {
            double total_amount;
        l: Console.WriteLine("Enter from following choices.\n\n1.Press 1=>> Demostic\n2.Press 2=>> Commercial\n3.Press 3=>> Industrial");
            Console.Write("\n\nYou hava entered the choice: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1 || choice == 2 || choice == 3)
            {
            r: Console.Write("\nEnter Previous Reading: ");
                long previous_reading = long.Parse(Console.ReadLine());
                Console.Write("Enter Present  Reading: ");
                long present_reading = long.Parse(Console.ReadLine());
                if (present_reading > previous_reading)
                {
                    long total_reading = (present_reading - previous_reading);
                    switch (choice)
                    {
                        case 1:
                            if (total_reading >= 0 && total_reading <= 50)
                            {
                                total_amount = total_reading * 1.50;
                                Console.WriteLine("\nThe Amount For Total Reading {0} units Is Rs.{1}/-", total_reading, total_amount);
                            }
                            else if (total_reading >= 51 && total_reading <= 100)
                            {
                                total_amount = total_reading * 2.0;
                                Console.WriteLine("\nThe Amount For Total Reading {0} units Is Rs.{1}/-", total_reading, total_amount);
                            }
                            else if (total_reading > 100)
                            {
                                total_amount = total_reading * 2.50;
                                Console.WriteLine("\nThe Amount For Total Reading {0} units Is Rs.{1}/-", total_reading, total_amount);
                            }
                            break;
                        case 2:
                            if (total_reading >= 0 && total_reading <= 50)
                            {
                                total_amount = total_reading * 2.50;
                                Console.WriteLine("\nThe Amount For Total Reading {0} units Is Rs.{1}/-", total_reading, total_amount);
                            }
                            else if (total_reading >= 51 && total_reading <= 100)
                            {
                                total_amount = total_reading * 3.0;
                                Console.WriteLine("\nThe Amount For Total Reading {0} units Is Rs.{1}/-", total_reading, total_amount);
                            }
                            else if (total_reading > 100)
                            {
                                total_amount = total_reading * 3.50;
                                Console.WriteLine("\nThe Amount For Total Reading {0} units Is Rs.{1}/-", total_reading, total_amount);
                            }
                            break;
                        default:
                            if (total_reading >= 0 && total_reading <= 50)
                            {
                                total_amount = total_reading * 3.50;
                                Console.WriteLine("\nThe Amount For Total Reading {0} units Is Rs.{1}/-", total_reading, total_amount);
                            }
                            else if (total_reading >= 51 && total_reading <= 100)
                            {
                                total_amount = total_reading * 4.0;
                                Console.WriteLine("\nThe Amount For Total Reading {0} units Is Rs.{1}/-", total_reading, total_amount);
                            }
                            else if (total_reading > 100)
                            {
                                total_amount = total_reading * 4.50;
                                Console.WriteLine("\nThe Amount For Total Reading {0} units Is Rs.{1}/-", total_reading, total_amount);
                            }
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid Input Reading....");
                    Console.Write("\nWould You Like To Continue Y or N: ");
                    string d = Console.ReadLine();
                    if (d == "y" || d == "Y")
                    {
                        goto r;
                    }
                    else
                    {
                        Console.WriteLine("Your Good For Nothing.....");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Input");
                Console.Write("\nWould You Like To Continue Y or N: ");
                string d = Console.ReadLine();
                if (d == "y" || d == "Y")
                {
                    goto l;
                }
                else
                {
                    Console.WriteLine("Your Good For Nothing.....");
                }
            }
            Console.ReadLine();
        }
    }
}



