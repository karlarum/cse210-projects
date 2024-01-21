using System;
//use system.IO for reading and writing files
//using system.IO lets C# know where to find the SteamWriter class
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";
        Journal theJournal = new Journal();
        PromptGenerator aPrompt = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != "6")
        {
            DisplayMenu();

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (int.TryParse(choice, out int selectedChoice))
            {
                ProcessChoice(selectedChoice, theJournal, aPrompt);
            }
            else
            {
                Console.WriteLine("Please choose a number between 1-6");
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Delete Journal"); // New option to delete all entries
        Console.WriteLine("6. Quit");
    }

    static void ProcessChoice(int choice, Journal journal, PromptGenerator promptGenerator)
    {
        switch (choice)
        {
            case 1:
                WriteEntry(journal, promptGenerator);
                break;
            case 2:
                journal.DisplayAll();
                break;
            case 3:
                LoadJournal(journal);
                break;
            case 4:
                SaveJournal(journal);
                break;
            case 5:
                DeleteJournal(journal); // New case for deleting all entries
                break;
            case 6:
                Environment.Exit(0);
                break;
        }
    }

    static void WriteEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string randomPrompt = promptGenerator.GetRandomPrompt();

        //Create new entry and add to journal
        Entry newEntry = new Entry();
        newEntry._entryText = Console.ReadLine();
        newEntry._prompts.Add(randomPrompt);

        journal.AddEntry(newEntry);
    }

    static void LoadJournal(Journal journal)
    {
        Console.WriteLine("What is the filename? ");
        string loadFileName = Console.ReadLine();
        journal.LoadFromFile(loadFileName);
    }

    static void SaveJournal(Journal journal)
    {
        Console.WriteLine("What is the filename? ");
        string saveFileName = Console.ReadLine();
        journal.SaveToFile(saveFileName);
    }

    static void DeleteJournal(Journal journal)
    {
        Console.WriteLine("Are you sure you want to delete all entries? (Y/N) ");
        string confirmation = Console.ReadLine();

        if (confirmation.ToUpper() == "Y")
        {
            journal.ClearAllEntries();
            Console.WriteLine("All entries deleted.");
        }
        else
        {
            Console.WriteLine("Clear canceled.");
        }
    }
}