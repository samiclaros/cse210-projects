using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int percentageNumber = int.Parse(percentage);

        string letter = "";

        if (percentageNumber >= 80)
        {
            letter = "A";
        }
        else if (percentageNumber >= 70)
        {
            letter = "B";
        }
        else if (percentageNumber >= 60)
        {
            letter = "C";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percentageNumber >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course");
        }
        else
        {
            Console.WriteLine("You have to do more for the next semester!");
        }
    }
}
