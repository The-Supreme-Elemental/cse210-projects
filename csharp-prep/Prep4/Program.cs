using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Please enter a list of numbers, enter 0 when finished. ");
        
        // Makes an empty list.
        List<int> numbers = [];
        int number;

        do 
        {
        //The program asks for numbers to make up the list.  
        Console.Write(" Enter number. ");
        string userInput = Console.ReadLine();
        try
        {
        number = int.Parse(userInput); 
        numbers.Add(number);
        if (number == 0);
        } catch (FormatException)
        {
            Console.WriteLine("I'm sorry, I don't recognize that. Please try again. ");
        }
        
        {
        Console.WriteLine($"Your list is: {string.Join(", ", numbers)}");        }

        } while (number != 0);


        

    }
}