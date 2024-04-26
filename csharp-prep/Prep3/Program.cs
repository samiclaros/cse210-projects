using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magin number?: ");
        string number = Console.ReadLine();
        int numberConversion = int.Parse(number);

        string keyWord = "yes";

        while (keyWord == "yes")
        Console.Write("What is your guess?: ");
        string guess = Console.ReadLine();
        int guessConversion = int.Parse(number);

        if (guessConversion == numberConversion)
        {
            Console.Write(""); //BLANK
            Console.Write("You guessed it");
        }
        else if (guessConversion > numberConversion)
        {
            Console.Write(""); //BLANK
            Console.Write("Lower");
        }
        else
        {
            Console.Write(""); //BLANK
            Console.Write("Higher");
        }
    }
}