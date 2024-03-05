using  System;
using JournalApp;
class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();

            bool running = true;
            while (running)
            {
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Quit");

                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.Write("Enter your response: ");
                        string response = Console.ReadLine();
                        string date = DateTime.Now.ToString("yyyy-MM-dd");
                        Entry newEntry = new Entry(prompt, response, date);
                        journal.AddEntry(newEntry);
                        Console.WriteLine("Entry added successfully!");
                        break;
                    case "2":
                        Console.WriteLine("Journal Entries:");
                        journal.DisplayEntries();
                        break;
                    case "3":
                        Console.Write("Enter filename to save: ");
                        string saveFilename = Console.ReadLine();
                        journal.SaveToFile(saveFilename);
                        Console.WriteLine("Journal saved successfully!");
                        break;
                    case "4":
                        Console.Write("Enter filename to load: ");
                        string loadFilename = Console.ReadLine();
                        journal.LoadFromFile(loadFilename);
                        Console.WriteLine("Journal loaded successfully!");
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }