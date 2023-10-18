using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string verse = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        List<Word> words = new List<Word>();
        string[] verseArray = verse.Split(' ');
        foreach (string word in verseArray)
        {
            words.Add(new Word(word));
        }

        Scripture scripture = new Scripture("John 3:16", words);
        Console.Clear();
        scripture.DisplayText();
        Console.WriteLine("");
        Console.WriteLine("Choose the difficulty by typing an option 1-10 (10 being the most difficult):");
        int difficulty = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
        string input;
        do
        {
            input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            else if (string.IsNullOrEmpty(input))
            {
                scripture.HideRandomWords(difficulty);

                Console.Clear();
                scripture.DisplayText();
                Console.WriteLine("");
                Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            }
        } while (!scripture.IsCompletelyHidden());

        Console.WriteLine("Memorization complete. Press Enter to exit.");
        Console.ReadLine();
    }
}
