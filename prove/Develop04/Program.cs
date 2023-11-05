using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        Console.Clear();
        Console.WriteLine("Welcome to the mindfulness program!");
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity\n 2. Start reflection activity\n 3. Start listing activity\n 4. Quit");
            Console.WriteLine("Please select one of the menu options 1-4: ");
            choice = int.Parse(Console.ReadLine());
            
            Stopwatch stopwatch = new Stopwatch();
        

            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new();
                    breathingActivity.GetUserTime();
                    PauseTime(5);
                    breathingActivity.DisplayStartMessage();
                    PauseTime(5);
                    stopwatch.Start();
                    while (stopwatch.Elapsed.TotalSeconds < breathingActivity.Duration)
                    {
                        breathingActivity.BreatheIn();
                        breathingActivity.BreatheOut();
                        Console.WriteLine();
                    }
                    breathingActivity.DisplayEndMessage();
                    PauseTime(5);
                    
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new();
                    reflectionActivity.GetUserTime();
                    PauseTime(5);
                    reflectionActivity.DisplayStartMessage();
                    PauseTime(5);
                    stopwatch.Start();
                    string reflectionPrompt = reflectionActivity.GetPrompt();
                    Console.WriteLine(reflectionPrompt);
                    PauseTime(8);
                    while (stopwatch.Elapsed.TotalSeconds < reflectionActivity.Duration)
                    {
                        Console.WriteLine(reflectionActivity.GetReflectQuestion());
                        PauseTime(8);
                    }
                    reflectionActivity.DisplayEndMessage();
                    PauseTime(5);

                    break;
                case 3:
                    ListingActivity listingActivity = new();
                    listingActivity.GetUserTime();
                    PauseTime(5);
                    listingActivity.DisplayStartMessage();
                    PauseTime(5);
                    stopwatch.Start();
                    Console.WriteLine(listingActivity.GetPrompt());
                    PauseTime(8);
                    List<string> responses = listingActivity.GenerateResponseList(listingActivity.Duration);
                    Console.WriteLine($"You typed {responses.Count} responses");
                    listingActivity.DisplayEndMessage();
                    PauseTime(5);
                    
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

        } while (choice != 4);


    }
    public static void PauseTime(int time)
    {
        for (int i = 0; i <= time; i++)
        {
            Console.Write("+");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("=");

        }
        Console.WriteLine();
    }
}