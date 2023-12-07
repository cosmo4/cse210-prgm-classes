using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();


        Run run1 = new("01 Dec 2023", 60, 5.3);
        Bike bike1 = new("02 Dec 2023", 30, 15.0);
        Swim swim1 = new("03 Dec 2023", 30, 15);

        activities.Add(run1);
        activities.Add(bike1);
        activities.Add(swim1);

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"{activity.GetSummary()}\n");
        }
    }
}