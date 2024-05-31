using System.Diagnostics.Metrics;
using System.Net.Sockets;
using System.Runtime.Versioning;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time; // I understand that this is the hours I will use the "room" of the event
    private Adress _adress;

    public Event(string title, string description, string time, Adress adress)
    {
        _title = title;
        _description = description;
        _date = DateTime.Now.ToShortDateString();
        _time = time;
        _adress = adress;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"1. {_title}");
        Console.WriteLine($"2. {_description}");
        Console.WriteLine($"3. {_date}");
        Console.WriteLine("");
    }

    public void ShortDescription()
    {

    }
}