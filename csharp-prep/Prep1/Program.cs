using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your fisrt name? ");
        Console.Write("");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        Console.Write("");
        string last_name = Console.ReadLine();
        Console.Write("");
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}");
    }
}

