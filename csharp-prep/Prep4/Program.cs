using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        bool notZero = true;
        do
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                notZero = false;
            }
            numbers.Add(num);
        } while (notZero);
        
        int sum = 0;
        int max = 0;

        foreach (int item in numbers)
        {
            sum += item;
            if (item > max)
            {
                max = item;
            }
        }
        int average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}