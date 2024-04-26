using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number?: ");
        // string number = Console.ReadLine();
        // int numberConversion = int.Parse(number);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,200);
        int proTip = 0;

        while (proTip == 0)
        {
            Console.Write("What is your guess?: ");
            string guess = Console.ReadLine();
            int guessConversion = int.Parse(guess);

            if (guessConversion == number)
            {
                Console.WriteLine("You guessed it");
                Console.Write(""); //BLANK
                break;
            }
            else if (guessConversion > number)
            {
                Console.WriteLine("Lower");
                Console.Write(""); //BLANK
            }
            else if (guessConversion < number)
            {
                Console.WriteLine("Higher");
                Console.Write(""); //BLANK
            }
        }
    }
}