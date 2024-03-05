using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace JournalApp
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    class Journal
    {
        private List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void AddEntry(Entry entry)
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
                    writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
                }
            }
        }

public void LoadFromFile(string filename)
{
    entries.Clear();
    try
    {
        string line;
        using (StreamReader reader = new StreamReader(filename))
        {
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[1], parts[2], parts[0]);
                    entries.Add(entry);
                }
            }
        }
        Console.WriteLine("Journal loaded successfully!");
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine($"Error: The file '{filename}' could not be found.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred while loading the journal: {ex.Message}");
    }
}

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}