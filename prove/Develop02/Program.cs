using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Entry entry = new();
        Journal journal = new();
        Console.WriteLine("Welcome to the Journal Program!");
        int decision;
        do
        {
            Console.WriteLine("Please select an action from the options below!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            decision = int.Parse(Console.ReadLine());

            switch (decision)
            {
                case 1:
                    string prompt = entry.GeneratePrompt(prompts);
                    entry.Prompt = prompt;
                    Console.WriteLine($"{prompt}");
                    entry.Response = Console.ReadLine();
                    journal.Entries.Add(entry.Response);
                    entry.SaveResponse();
                    break;
                case 2:
                    entry.DisplayResponses();
                    break;
                case 3:
                    Console.WriteLine("What is the name of your file?");
                    string loadFilename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(loadFilename);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(",");
                        entry.Response = parts[0];
                    }
                    break;
                case 4:
                    Console.WriteLine("What would you like your file to be called?");
                    string saveFilename = Console.ReadLine();
                    journal.SaveEntry(saveFilename);
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        } while (decision != 5);

    }
}