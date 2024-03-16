using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world...");

        Console.Clear();
        Console.WriteLine(scripture.GetFormattedScripture());

        Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
        string input = Console.ReadLine().ToLower();

        while (!scripture.AllWordsHidden() && input != "quit")
        {
            Console.Clear();

            scripture.HideRandomWords();

            Console.WriteLine(scripture.GetFormattedScripture());

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            input = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Program ended.");
    }
}
