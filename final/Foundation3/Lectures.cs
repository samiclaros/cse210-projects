using System.Reflection;

public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string typeOfEvent, string title, string description, string date, string time, Adress adress, string speaker, int capacity) : base(typeOfEvent, title, description, date, time, adress)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void FullDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Adress: {_adress.GetFullAdress()}");
        Console.WriteLine(" "); // BLANK

        Console.WriteLine(">>>>> Adittional information <<<<<< ");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"The capacity is: {_capacity}");

    }
}