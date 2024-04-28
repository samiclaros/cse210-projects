using System;

class Program
{
    static void Main(string[] args)
    {
            DisplayMessage();

            string userName = PromptUserName();
            int userNumber = PromptUserNumber();

            int squaredNumber = SquareNumber(userNumber);
            
            FinalDisplay(userName, squaredNumber);
    }
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userNumber = Console.ReadLine();
            int userNumberConversion = int.Parse(userNumber);
            return userNumberConversion;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        
        static void FinalDisplay(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    
}