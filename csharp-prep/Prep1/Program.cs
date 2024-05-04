using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int numberGuess;

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);


        // Console.Write("What is the magic number? ");
        // string userInput = Console.ReadLine();
        // int number = int.Parse(userInput);
        do 
        {

            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            numberGuess = int.Parse(userGuess);

            if (numberGuess < number)
            {
                Console.WriteLine("Try a higher number. ");


            }
            else if (numberGuess > number)
            {
                Console.WriteLine("Try a lower number. ");
            }

            else 
            {
                Console.Write("You guessed it! Congratulations! ");
            }
        } while (numberGuess != number);
    }
}


//     // private static string ConsoleReadLine()
//     {
//         throw new NotImplementedException();
//     }
// }}