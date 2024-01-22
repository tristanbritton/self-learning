using System;
using System.Transactions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double x = 0;
                double y = 0;
                double result = 0;

                Console.WriteLine("Tristan's Calculator");
                Console.WriteLine("--------------------");

                Console.Write("Enter First Digit: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter First Digit: ");
                y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t* : Mulitply");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t/ : Division");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = x + y;
                        Console.WriteLine($"{x} + {y} = " + result);
                        break;

                    case "-":
                        result = x - y;
                        Console.WriteLine($"{x} - {y} = " + result);
                        break;

                    case "*":
                        result = x * y;
                        Console.WriteLine($"{x} * {y} = " + result);
                        break;

                    case "/":
                        result = x / y;
                        Console.WriteLine($"{x} / {y} = " + result);
                        break;

                    default:
                        Console.WriteLine("That was not an option");
                        break;

                }
                Console.WriteLine("Would you like to continue? (Y = yes, N = no): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Goodbye!");

        }    
    }
}

