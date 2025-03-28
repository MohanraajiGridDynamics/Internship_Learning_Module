// See https://aka.ms/new-console-template for more information

using System;

// Define a custom exception class
public class AgeValidationException : Exception
{
    // Default constructor
    public AgeValidationException() { }

    // Constructor that accepts a message
    public AgeValidationException(string message) : base(message) { }

    // Constructor that accepts a message and inner exception
    public AgeValidationException(string message, Exception innerException) 
        : base(message, innerException) { }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            // Validate the age
            if (age < 18)
            {
                throw new AgeValidationException("Age must be 18 or older.");
            }

            Console.WriteLine("You are eligible.");
        }
        catch (AgeValidationException ex)
        {
            Console.WriteLine("Validation Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("End of program.");
        }
    }
}
