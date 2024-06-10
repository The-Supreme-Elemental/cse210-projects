using System;

class Program
{

    
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Hello Develop02 World!");

        Prompt prompt = new Prompt();
        Console.WriteLine(prompt.GivePrompt());

        Console.WriteLine("Please choose an option below.");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit.");

        int choice = int.Parse(Console.ReadLine());


        Console.WriteLine("Please write your entry below. ");
        string response = Console.ReadLine();
        
        journal.DisplayJournal();


    }
}