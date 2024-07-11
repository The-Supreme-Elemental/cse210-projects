using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorizer! Please enter \"quit\" when you are done. ");
        string userInput = Console.ReadLine();

        ScriptureToMemorize scripture = new ScriptureToMemorize();
        while (userInput != "quit")
        {
            scripture.HideRandomWord();
            scripture.HideRandomWord();
            scripture.HideRandomWord();
            Console.WriteLine(scripture.GetText());
            Console.WriteLine(scripture.CompleteyHidden());

            Console.WriteLine("Continue? (press \"quit\" to quit.)");
            userInput = Console.ReadLine();

            if (scripture.CompleteyHidden() == true)
            {
                userInput = "quit";
            }
        }



    }
}