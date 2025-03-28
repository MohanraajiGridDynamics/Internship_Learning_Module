// See https://aka.ms/new-console-template for more information

using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int myInteger = 10;
            double myDouble = 3.14;
            string myString = "Hello, World!";
            bool isActive = true;

            int[] myArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine(myString);
            Console.WriteLine("Integer Value: " + myInteger);
            Console.WriteLine("Double Value: " + myDouble);
            Console.WriteLine("Boolean Value: " + isActive);

            Console.WriteLine("Array Elements: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
