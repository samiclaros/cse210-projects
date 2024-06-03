public class Reception : Event
{
    private string _email;

    public Reception(string typeOfEvent, string title, string description, string date, string time, Adress adress, string email) : base(typeOfEvent, title, description, date, time, adress)
    {
        _email = email;
    }

    public void FullDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Adress: {_adress.GetAdress()}");
        Console.WriteLine(" "); // BLANK

        Console.WriteLine(">>>>> Adittional information <<<<<< ");
        Console.WriteLine($"We have a RSVP to send the invitation, we have an email ({_email}) to confirm the attendance to the event. With that we can schedule a better agenda for the event");
    }
}