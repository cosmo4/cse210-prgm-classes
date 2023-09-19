using System;

class Program
{
    static void Main(string[] args)
    {
        Random randGen = new Random();
        int randNum = randGen.Next(1, 100);

        Console.WriteLine("Welcome to the number guessing game... ");
        // int magicNum = int.Parse(Console.ReadLine());
        int numOfGuess = 0;
        bool match = false;
        while (!match) 
        {
            Console.WriteLine("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == randNum) 
            {
                match = true;
                Console.WriteLine("You guessed it!");
                numOfGuess++;
                Console.WriteLine($"Number of Guesses: {numOfGuess}");
            }
            else if (guess < randNum)
            {
                Console.WriteLine("Higher");
                numOfGuess++;
            }
            else 
            {
                Console.WriteLine("Lower");
                numOfGuess++;
            }
        }
    }
}