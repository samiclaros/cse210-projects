using System.Diagnostics.Metrics;
using System.Net.Sockets;
using System.Runtime.Versioning;

public class Event
{
    protected string _typeOfEvent;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time; // I understand that this is the hours I will take, as a reservation of the place
    
    protected Adress _adress;

    public Event(string typeOfEvent, string title, string description, string date, string time, Adress adress) // I want to be sure if I can just declare the names in the child classes
    {
        _typeOfEvent = typeOfEvent;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _adress = adress;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Adress: {_adress.GetAdress()}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($"Type of Event: {_typeOfEvent}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}