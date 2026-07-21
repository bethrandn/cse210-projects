// Creativity:
// I exceeded the core requirements by:
// 1. Adding additional journal prompts to provide more variety.
// 2. Handling attempts to load a file that does not exist,
//    preventing the program from crashing and displaying
//    a friendly error message instead.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.Write("Your response: ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry entry = new Entry();
                entry.Date = date;
                entry.Prompt = prompt;
                entry.Response = response;

                journal.AddEntry(entry);

                Console.WriteLine("Entry added successfully!");

            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

                Console.WriteLine("Journal saved successfully!");
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);

                Console.WriteLine("Journal loaded successfully!");
            }
        }
        Console.WriteLine("Goodbye!");
    }
}