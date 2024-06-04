public class Outdoors : Event
{
    private string _weather;

    public Outdoors(string typeOfEvent, string title, string description, string date, string time, Adress adress, string weather) : base(typeOfEvent, title, description, date, time, adress)
    {
        _weather = weather;
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
        Console.WriteLine($"This event will depend on the weather, if the weather it's not good this event will not be available");
        Console.WriteLine($"Actual weather: {_weather}");
    }
}