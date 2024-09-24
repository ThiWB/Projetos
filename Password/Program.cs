using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Password Creation and Authentication System");

        // Entering the first attempt of password
        Console.WriteLine("Enter your password: ");
        string password = Console.ReadLine();

        // Validations and requirements for password
        if (password.Length < 8)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Password must be at least 8 characters long");
            System.Environment.Exit(0);
        }
        else if (!password.Any(char.IsUpper))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Password must contain at least one uppercase letter");
            System.Environment.Exit(0);
        }
        else if (!password.Any(char.IsLower))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Password must contain at least one lowercase letter");
            System.Environment.Exit(0);
        }
        else if (!password.Any(char.IsDigit))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Password must contain at least one number");
            System.Environment.Exit(0);
        }
        else if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Password must contain at least one symbol");
            System.Environment.Exit(0);
        }
        else
        {
            // If the password meets the requirements, it will be confirmed
            Console.WriteLine("Confirm your password: ");
            string confirmPassword = Console.ReadLine();

            // Confirmation system for the password creation
            if (password == confirmPassword)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password created successfully");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Passwords do not match");
            }
            
        }

        // After the password is created, the user will be asked to enter the password to log in to the system
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Please, enter your password to log in: ");
        string passwordAuth = Console.ReadLine();

        // If the password entered matches the password created, the user will be logged in
        if (password == passwordAuth)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You are logged in, Welcome!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect password");
        }
    }
}


