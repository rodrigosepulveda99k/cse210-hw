using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a scripture object
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world...");

        // Display the complete scripture
        Console.Clear();
        Console.WriteLine(scripture.GetFormattedScripture());

        // Prompt the user
        Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
        string input = Console.ReadLine().ToLower();

        // Continue hiding words until all are hidden or the user quits
        while (!scripture.AllWordsHidden() && input != "quit")
        {
            // Clear the console screen
            Console.Clear();

            // Hide a few random words
            scripture.HideRandomWords();

            // Display the scripture with hidden words
            Console.WriteLine(scripture.GetFormattedScripture());

            // Prompt the user
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            input = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Program ended.");
    }
}

// Class to represent a single word
class Word
{
    public string Value { get; }
    public bool IsHidden { get; set; }

    public Word(string value)
    {
        Value = value;
        IsHidden = false;
    }

    public override string ToString()
    {
        return IsHidden ? "_____" : Value;
    }
}

// Class to represent a scripture reference
class Reference
{
    public string Book { get; }
    public int StartVerse { get; }
    public int EndVerse { get; }

    public Reference(string reference)
    {
        string[] parts = reference.Split(':');
        Book = parts[0];
        string[] verses = parts[1].Split('-');
        StartVerse = int.Parse(verses[0]);
        EndVerse = verses.Length > 1 ? int.Parse(verses[1]) : StartVerse;
    }
}

// Class to represent a scripture
class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(string referenceStr, string text)
    {
        reference = new Reference(referenceStr);
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetFormattedScripture()
    {
        return $"{reference.Book} {reference.StartVerse}:{reference.EndVerse}\n" +
               string.Join(" ", words.Select(word => word.ToString()));
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, words.Count / 2); // Hiding up to half of the words
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(0, words.Count);
            words[index].IsHidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }
}
