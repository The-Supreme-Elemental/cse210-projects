using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Prompt prompt = new Prompt();
        Console.WriteLine(prompt.GivePrompt());

        Console.WriteLine("Please write your entry below. ");
        string response = Console.ReadLine();
        

    }
}