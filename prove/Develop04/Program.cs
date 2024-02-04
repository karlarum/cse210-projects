using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 5)
        {
            DisplayMenu();

            Console.Write("Select a choice from the menu: ");

            if (int.TryParse(Console.ReadLine(), out int selectedChoice))
            {
                choice = selectedChoice;
                ProcessChoice(choice);
            }
            else
            {
                Console.WriteLine("Please choose a number between 1-5");
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Start Stretching Activity");
        Console.WriteLine("5. Quit");
    }

    static void ProcessChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                BreathingActivity breathingActivity = new BreathingActivity(
                    // "@" preserves formatting so it isn't one long line
                    "Breathing Activity", 
                    @"This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 
                    0 // Set the initial duration to 0 to allow user input
                );
                breathingActivity.Run();
                break;
            case 2:
                ReflectingActivity reflectingActivity = new ReflectingActivity(
                    "Reflecting Activity", 
                    @"This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 
                    0 //setting this to 0 to allow user input
                );
                reflectingActivity.Run();
                break;
            case 3:
                ListingActivity listingActivity = new ListingActivity(
                    "Listing Activity", 
                    @"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
                    0, // setting this to 0 to allow user input
                    0 // setting this to 0 to allow user input
                );
                listingActivity.Run();
                break;
            case 4:
                StretchingActivity stretchingActivity = new StretchingActivity(
                    "Stretching Activity",
                    @"This activity will help you lower your cardiovascular risk and improve life expectancy.",
                    0
                );
                stretchingActivity.Run();
                break;
            case 5:
                Environment.Exit(0);
                break;
        }
    }
}