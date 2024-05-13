// This program will accept inputs and display them in a Bond, James Bond format. 


using System;
using System.Globalization;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        // Displays a greeting to the user. 
        Console.WriteLine("Hello there! \n"); // WriteLine makes a new line afterwards. 

        // This will ask the user for their first and last names. 

        // prompt, input is received on the same line. 
        Console.Write("What is your first name? ");
        // acceptance of prompt
        string firstName = Console.ReadLine();

        // prompt
        Console.Write("What is your last name? ");
        // acceptance
        string lastName = Console.ReadLine();
        Console.WriteLine();

        // This will display the names recieved above in the format (last), (first) (last)
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}. ");
    }
}
