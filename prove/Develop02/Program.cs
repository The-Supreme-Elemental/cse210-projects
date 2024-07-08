using System;
using System.Net;

class Program
{


    static void Main(string[] args)
    {
        int choice = 0;
        Journal journal = new Journal();


        Prompt prompt = new Prompt();
        Console.WriteLine(prompt.GivePrompt());
        while (choice != 5)
        {

            Console.WriteLine("Please choose an option below.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit.");

            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Entries entries = new Entries(DateTime.Now, "");
                string entry = entries.InputEntry();
                journal.appendToJournal(entries);
            }
            if (choice == 2)
            {
                Console.WriteLine("Sure! Here are your entries!");
                journal.DisplayJournal();
            }
            if (choice == 3)
            {
                journal = new Journal();
                Console.WriteLine("What file name would you like to load?");
                string fileName = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(" ~|~ ");

                    string date = parts[0];
                    string question = parts[1];
                    string response = parts[2];

                    Entries entries = new Entries(DateTime.Parse(date), question, response);
                    journal.appendToJournal(entries);
                }


            }
            if (choice == 4)
            {
                Console.WriteLine("What would you like your journal to be called?");
                string fileName = Console.ReadLine();


                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.Write($"{journal.SaveJournal()}");
                    // // You can add text to the file with the WriteLine method
                    // outputFile.WriteLine("This will be the first line in the file.");

                    // // You can use the $ and include variables just like with Console.WriteLine
                    // string color = "Blue";
                    // outputFile.WriteLine($"My favorite color is {color}");

                }
            }
        }


    }
}