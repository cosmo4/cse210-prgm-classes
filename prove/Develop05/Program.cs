using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        int points = 0;
        int choice;
        Console.Clear();
        Console.WriteLine("Welcome to the Eternal Quest Goal Program!");

        List<Goal> goals = new();

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create new goal\n 2. List goals\n 3. Save goals\n 4. Load goals\n 5. Record Event\n 6. Quit");
            Console.Write("Select an option from the menu: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int goalType;
                    string name;
                    string description;
                    int pointValue;
                    Console.WriteLine("Types of Goals:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\nSelect a type of goal: ");
                    goalType = int.Parse(Console.ReadLine());

                    Console.WriteLine("What is the name of your goal? ");
                    name = Console.ReadLine();

                    Console.WriteLine("Write a short description of your goal: ");
                    description = Console.ReadLine();

                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    pointValue = int.Parse(Console.ReadLine());

                    switch (goalType)
                    {
                        case 1:
                            SimpleGoal simpleGoal = new(name, description, pointValue);
                            goals.Add(simpleGoal);
                            break;
                        case 2:
                            EternalGoal eternalGoal = new(name, description, pointValue);
                            goals.Add(eternalGoal);
                            break;
                        case 3:
                            Console.WriteLine("How many times should this goal be completed for a bonus? ");
                            int denominator = int.Parse(Console.ReadLine());

                            Console.WriteLine("How many points in the bonus? ");
                            int bonusPoints = int.Parse(Console.ReadLine());

                            ChecklistGoal checklistGoal = new(name, description, pointValue, denominator, bonusPoints);
                            goals.Add(checklistGoal);
                            break;
                    }
                    Console.WriteLine($"\nYou have {points} points\n");
                    break;
                case 2:
                    DisplayAllGoals(goals);
                    Console.WriteLine($"\nYou have {points} points\n");
                    break;
                case 3:
                    // Save goals
                    Console.WriteLine("What is the file name for the goals: ");
                    string fileName = Console.ReadLine();

                    SaveData saveData = new SaveData(points, goals);
                    string json = JsonSerializer.Serialize(saveData);
                    File.WriteAllText(fileName, json);

                    Console.WriteLine("Goals saved successfully!");                        
                    break;
                case 4:
                    // Load goals
                    Console.WriteLine("What is the file name of the goals: ");
                    string loadFileName = Console.ReadLine();

                    if (File.Exists(loadFileName))
                    {
                        string loadJson = File.ReadAllText(loadFileName);
                        SaveData loadedData = JsonSerializer.Deserialize<SaveData>(loadJson);
                        points = loadedData.Points;
                        goals = loadedData.Goals;

                        Console.WriteLine("Goals loaded successfully!");
                        Console.WriteLine($"\nYou have {points} points\n");
                    }
                    else
                    {
                        Console.WriteLine("File not found!");
                    }
                    break;
                case 5:
                    // record event
                    Console.WriteLine("Great job! Which goal was it? (Type the number) ");
                    DisplayAllGoals(goals);
                    int goalNumber = int.Parse(Console.ReadLine());
                    points = goals[goalNumber - 1].RecordEvent(points);
                    Console.WriteLine($"\nYou have {points} points\n");

                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }
            Thread.Sleep(3000);

        } while (choice != 6);





    }
    public static void DisplayAllGoals(List<Goal> goals)
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{i}. {goal.DisplayGoal()}");
            i++;
        }
    }
}