// See https://aka.ms/new-console-template for more information

using System;

namespace LoopsAndControlStatementsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;

            // Expressions and Operators
            int sum = x + y;
            int difference = x - y;
            int product = x * y;
            double division = (double)x / y;
            int remainder = x % y;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Division: " + division);
            Console.WriteLine("Remainder: " + remainder);

            // If-Else Statement
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else if (x < y)
            {
                Console.WriteLine("x is less than y");
            }
            else
            {
                Console.WriteLine("x is equal to y");
            }

            // Switch-Case Statement
            switch (x)
            {
                case 5:
                    Console.WriteLine("x is 5");
                    break;
                case 10:
                    Console.WriteLine("x is 10");
                    break;
                default:
                    Console.WriteLine("x is neither 5 nor 10");
                    break;
            }

            // Switch Expression (Arrow Syntax)
            string result = x switch
            {
                5 => "x is 5",
                10 => "x is 10",
                _ => "x is neither 5 nor 10"
            };
            Console.WriteLine(result);

            // For Loop
            Console.WriteLine("\nFor Loop:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i = " + i);
            }

            // While Loop
            Console.WriteLine("\nWhile Loop:");
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("j = " + j);
                j++;
            }

            // Do-While Loop
            Console.WriteLine("\nDo-While Loop:");
            int k = 0;
            do
            {
                Console.WriteLine("k = " + k);
                k++;
            } while (k < 5);

            // Break Statement in Loop
            Console.WriteLine("\nBreak Statement in Loop:");
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    break; // Exits the loop when i is 3
                }
                Console.WriteLine("i = " + i);
            }

            // Continue Statement in Loop
            Console.WriteLine("\nContinue Statement in Loop:");
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue; // Skips the rest of the loop when i is 3
                }
                Console.WriteLine("i = " + i);
            }

            // Return Statement
            Console.WriteLine("\nReturn Statement:");
            int resultValue = AddNumbers(5, 7);
            Console.WriteLine("Sum of 5 and 7 is: " + resultValue);
        }

        static int AddNumbers(int a, int b)
        {
            return a + b; // Returning sum of a and b
        }
    }
}
