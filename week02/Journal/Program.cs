using System;

// EXCEEDING REQUIREMENTS:
// - Included 10 thought-provoking prompts (exceeds minimum of 5).
// - Implemented clean separation of concerns using 4 well-defined classes.
// - Added error handling for file I/O operations (save/load).
// - Matched the exact output format shown in the assignment demo.
// - Used professional Git practices (`.gitignore` to exclude build files).

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal, promptGen);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    LoadJournal(journal);
                    break;
                case "4":
                    SaveJournal(journal);
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void WriteNewEntry(Journal journal, PromptGenerator promptGen)
    {
        string prompt = promptGen.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("M/d/yyyy"); // e.g., 12/9/2022

        Entry newEntry = new Entry(prompt, response, date);
        journal.AddEntry(newEntry);
        // No confirmation message — returns directly to menu
    }

    static void SaveJournal(Journal journal)
    {
        if (journal.Count == 0)
        {
            Console.WriteLine("No entries to save.");
            return;
        }
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    static void LoadJournal(Journal journal)
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}