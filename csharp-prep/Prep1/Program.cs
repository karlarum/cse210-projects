using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for their first name
        Console.WriteLine("What is your first name?");
        string first = Console.ReadLine();

        // Ask user for their last name
        Console.WriteLine("What is your last name?");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}