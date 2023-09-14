using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        string letterGrade;
        bool pass;
        if (grade >= 90)
        {
            letterGrade = "A";
            pass = true;
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            pass = true;
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            pass = true;
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
            pass = false;
        }
        else
        {
            letterGrade = "F";
            pass = false;
        }
        Console.WriteLine($"Your letter grade is {letterGrade}.");
        if (pass)
        {
            Console.WriteLine($"You passed the class!");
        }
        else
        {
            Console.WriteLine($"Sorry, you failed the class.");
        }
    }
}