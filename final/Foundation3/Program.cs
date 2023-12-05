using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "83440");
        Address address2 = new Address("135 S Chinden Blvd", "Meridian", "ID", "83669");
        Address address3 = new Address("123 E 2nd S", "Rexburg", "ID", "83440");

        List<Event> events = new List<Event>
        {
            new Lecture("C# Programming", "Learn C# Programming", "2024-01-01", "10:00", address1.GetFullAddress(), "Tim Thayne", 100),
            new Reception("Wedding Reception", "Come celebrate the marriage of Luke and Becky", "2023-04-08", "09:00", address2.GetFullAddress(), "example@gmail.com"),
            new OutdoorGathering("Family Reunion", "Come meet your cousins", "2022-07-04", "12:00", address3.GetFullAddress(), "The weather will be warm and sunny")
        };

        foreach (Event e in events)
        {
            Console.WriteLine($"Standard Details: \n{e.GetStandardDetails()}");
            Console.WriteLine();
            Console.WriteLine($"Full Details: \n{e.GetFullDetails()}");
            Console.WriteLine();
            Console.WriteLine($"Short Description: \n{e.GetShortDescription()}");
            Console.WriteLine();
        }
        
    }
}