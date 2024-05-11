using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Scripture scrip = new Scripture(new Reference("John", 3, 16, 17), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        
        
        string choice;
        do
        {
            Console.Clear();
            Console.WriteLine(scrip.GetDisplayText());
            Console.WriteLine(""); // BLANK
            Console.WriteLine("Press the 'enter button' to start hiding words or type 'exit' to quit: ");
            choice = Console.ReadLine();
            if (choice == "exit")
                break;
            if (scrip.IsCompletelyHidden())
                break;

            scrip.HideRandomWords(3);
            
        } 
        while (true);
    }
}