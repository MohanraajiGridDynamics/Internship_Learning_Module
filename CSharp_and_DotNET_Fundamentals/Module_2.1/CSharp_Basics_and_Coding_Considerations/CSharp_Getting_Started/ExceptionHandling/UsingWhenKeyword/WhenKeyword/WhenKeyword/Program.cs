// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number to divide 100 by:");
            int number = Convert.ToInt32(Console.ReadLine());

            
            int result = 100 / number;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex) when (DateTime.Now.Hour < 12)
        {
            Console.WriteLine("Error: Cannot divide by zero. It's still morning!");
            Console.WriteLine("Details: " + ex.Message);
        }
        catch (DivideByZeroException ex) 
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine("Details: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            Console.WriteLine("Details: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine("Details: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}
