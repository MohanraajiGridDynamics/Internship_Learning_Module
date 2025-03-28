// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        try
        {
          
            CreateUser(name: "Mohan", age: 22, email: "mohanraj@gmail.com");

          
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void CreateUser(string name, int age, string email)
    {
        
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be null or empty.", nameof(name));
        }

        if (age < 18)
        {
            throw new ArgumentException("Age must be 18 or older.", nameof(age));
        }

        if (string.IsNullOrEmpty(email) || !email.Contains("@"))
        {
            throw new ArgumentException("Email must be a valid email address.", nameof(email));
        }

        Console.WriteLine($"User created successfully: {name}, Age: {age}, Email: {email}");
    }
}
