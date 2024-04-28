using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        int grade = Console.Readline();

        if (90 <= grade <= 100)
        {
            Console.WriteLine("Your grade is an A.")
        } 
        else if (80 <= grade <= 89)
        {
            Console.WriteLine("Your grade is a B.")
        }
        else if (70 <= grade <= 79)
        {
            Console.WriteLine("Your grade is a C.")
        }
        else if (60 <= grade <= 69)
        {
            Console.WriteLine("Your grade is a D.")
        }
        else if (0 <= grade <= 50)
        {
            Console.WriteLine("Your grade is an F.")
        }
        else if (grade < 0)
        {
            Console.WriteLine("I'm....not sure how you got this. Congratulations, question mark?")
        }
    }
}