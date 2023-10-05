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
                    Console.WriteLine($"{prompt}\n >");
                    entry.Response = Console.ReadLine();
                    entry.SaveResponse();
                    break;
                case 2:
                    entry.DisplayResponses();
                    break;
                case 3:
                    // Implement loading functionality
                    break;
                case 4:
                    // Implement saving functionality
                    break;
                case 5:
                    // The user selected "Quit," so exit the loop
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        } while (decision != 5);

        

        
        


    }
}