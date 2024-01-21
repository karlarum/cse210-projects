using System;
using System.Collections.Generic;
//use system.IO for reading and writing files
//using system.IO lets C# know where to find the SteamWriter class
using System.IO;


//Code template for journal category. Will hold and display journal entries.
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        //.Add is used to add a key or value
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string file)
    {
        string fileName = file;
    
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                string promptString = string.Join(", ", entry._prompts);
                outputFile.WriteLine($"{entry._date}   {entry._entryText}   {promptString}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        //This will read the entire file into an array of strings
        string[] lines = System.IO.File.ReadAllLines(file);

        //Iterate through each string
        foreach (string line in lines)
        {
            //This will split the lines
            string[] parts = line.Split("   ");
            
            if (parts.Length == 3)
            {
                Entry loadedEntry = new Entry();
                loadedEntry._date = parts[0];
                loadedEntry._prompts = new List<string>(parts[1].Split("   "));
                loadedEntry._entryText = parts[2];

                _entries.Add(loadedEntry);
            }
        }
    }
    public void ClearAllEntries()
    {
        _entries.Clear();
    }
}