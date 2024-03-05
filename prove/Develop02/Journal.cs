using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class PromptGenerator
    {
        private List<string> _prompts;

        public PromptGenerator()
        {
            // Initialize prompts
            _prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What did you do today to serve someone?",
                "What did you ponder over in your scriptures today?",
                "What Christ-like attribute did you emulate today and how?",
                "How were you helped today and by who?",
                "What outside event did you witness or ponder today?",
                "What did you do today, that was enjoyable?",
                "What did you learn today?",
                "What did you improve in your life today?",
                "What happened today that you didn't like and how could you manage it better?",
                "What would you like to write in your journal?",
            };
        }

        public string GetRandomPrompt()
        {
            Random rand = new Random();
            int index = rand.Next(_prompts.Count);
            return _prompts[index];
        }
    }

    class JournalEntry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public string Date { get; set; }

        public JournalEntry(string prompt, string response, string date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
        }
    }

    class Journal
    {
        private List<JournalEntry> entries;

        public Journal()
        {
            entries = new List<JournalEntry>();
        }

        public void AddEntry(JournalEntry entry)
        {
            entries.Add(entry);
        }

        public void DisplayEntries()
        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            entries.Clear();
            string line;
            using (StreamReader reader = new StreamReader(filename))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        JournalEntry entry = new JournalEntry(parts[1], parts[2], parts[0]);
                        entries.Add(entry);
                    }
                }
            }
        }
    }

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
                        JournalEntry newEntry = new JournalEntry(prompt, response, date);
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
}
