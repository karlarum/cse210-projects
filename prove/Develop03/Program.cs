using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Revelation", 1, 3);
        List<Word> words = new List<Word>
        {
            new Word(" Blessed "),
            new Word("is "),
            new Word("he "),
            new Word("that "),
            new Word("readeth, "),
            new Word("and "),
            new Word("they "),
            new Word("that "),
            new Word("hear "),
            new Word("the "),
            new Word("words "),
            new Word("of "),
            new Word("this "),
            new Word("prophesy, "),
            new Word("and "),
            new Word("keep "),
            new Word("those "),
            new Word("things "),
            new Word("which "),
            new Word("are "),
            new Word("written "),
            new Word("therein: "),
            new Word("for "),
            new Word("the "),
            new Word("time "),
            new Word("is "),
            new Word("at "),
            new Word("hand.")
        };

        Scripture scripture = new Scripture(reference, words);
        Console.WriteLine(scripture.GetDisplayText());

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Please enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }

    }
}