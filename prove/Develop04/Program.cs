using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        var choice = "";
        do
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new();
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new();
                reflectingActivity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity =  new();
                listingActivity.Run();
            }
            else if (choice ==  "4")
            {
                Console.WriteLine("Thanks for priorize youe health! Stay safe!");
            }
            else
            {
                Console.WriteLine("Invalid character, please select a number from the menu");
                Console.WriteLine(); // BLANK
            }
        } while (choice != "4");
    }
}