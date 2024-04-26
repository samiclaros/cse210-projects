using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 200);
        string keyWord = "yes";
        int counter = 0;

        while (keyWord == "yes")
        {
            counter = counter + 1;
            Console.Write("What is your guess?: ");
            string guess = Console.ReadLine();
            int guessConversion = int.Parse(guess);

            if (guessConversion == number)
            {
                Console.WriteLine($"You guessed it in {counter} times.");
                Console.Write("Do you want to play again? (yes/no): ");
                keyWord = Console.ReadLine();
            }
            else if (guessConversion > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guessConversion < number)
            {
                Console.WriteLine("Higher");
            }
        }
    }
}

// I tried to do the loop with the "yes" but I can't, I don't know how to make the counter restart from 0 and
// The "random" number in the second try, it's the same.. so Idk why