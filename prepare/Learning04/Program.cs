using System;

class Program
{
    static void Main(string[] args)
    {
        //Create an assignment for base class
        Assignment assignment1 = new Assignment("John Doe", "C#");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        //Create an assignment for math sub class
        MathAssignment assignment2 = new MathAssignment("Jane Doe", "Calculus", "3.4", "7-12");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();

        //Create an assignment for writing sub class
        WritingAssignment assignment3 = new WritingAssignment("Sherlock Holmes", "Detective 101", "Unsolved Cases");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
        Console.WriteLine();

    }
}