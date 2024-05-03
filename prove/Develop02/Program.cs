using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal!");
        string choice;
        Journal journal = new();
        do
        {
            Console.WriteLine("Please select one of the following sentences: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?: ");
            Console.Write(""); // BLANK
            choice = Console.ReadLine();
            if (choice == "1")
            {
                PromptGenerator _prompts = new PromptGenerator();
                string randomPrompt = _prompts.GetRandomPrompt();
                Console.WriteLine(""); // BLANK
                Console.WriteLine(randomPrompt);
                string response = Console.ReadLine();
                //
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Entry entry = new()
                {
                    _date = dateText,
                    _promptText = randomPrompt,
                    _entryText = response
                };
                //
                journal._entries.Add(entry);
                Console.WriteLine(""); // BLANK
            }
            else if (choice == "2")
            {
                Console.WriteLine(""); // BLANK
                journal.DisplayAll();
                Console.WriteLine(""); // BLANK
            }
            else if (choice == "3")
            {
                Console.WriteLine(""); // BLANK
                Console.WriteLine("What is the name of the file? (Add .txt or .csv) ");
                string file = Console.ReadLine();
                //
                journal._file = file;
                journal.LoadFromFile(journal._file);
                Console.WriteLine(""); // BLANK
                Console.WriteLine($"File was opened correctly");
            }
            else if (choice == "4")
            {
                Console.WriteLine(""); // BLANK
                Console.WriteLine("What is the name of the file?");
                string fileName = Console.ReadLine();
                //
                journal._file = fileName;
                journal.SaveToFile(journal._entries);
                Console.WriteLine(""); // BLANK
                Console.WriteLine($"File saved as {fileName}");
                journal._entries.Clear();
            }
            else if (choice == "5")
            {
                Console.WriteLine(""); // BLANK
                Console.WriteLine("Thanks for watch your Journal today!");
                Console.WriteLine(""); // BLANK
            }
            else
            {
                Console.WriteLine(); // BLANK
                Console.WriteLine("> Invalid Choice");
                Console.WriteLine(); // BLANK
            }
        } 
        while (choice != "5");
    }
}