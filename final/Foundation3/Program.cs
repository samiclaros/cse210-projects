using System;

class Program
{
    static void Main(string[] args)
    {
        Adress adressLecture = new("Av. Blanco Galindo #1869, San Siro");
        Lectures lecture = new("Lectures", "Reading the Book of Mormon", "We read the book of Mormon with the whole people, we talk about Christ and we love him", "05/06/2024", "19:00 pm", adressLecture, "The speaker will be selected from the leaders of the Church, all of them are guided by God.. you will feel it", 2500);
        Console.WriteLine(" "); // BLANK
        Console.WriteLine("Standard Details: ");
        lecture.StandardDetails();
        Console.WriteLine(" "); // BLANK
        Console.WriteLine("Full Details: ");
        lecture.FullDetails();
        Console.WriteLine(" "); // BLANK
        Console.WriteLine("Short Description: ");
        lecture.ShortDescription();
        Console.WriteLine(" "); // BLANK
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");

        Adress adressReception = new("Av. Pedro Sarmiento #1984, White Building, in front of the Cobija bridge");
        Reception reception = new("Reception", "Attend to the Church", "Speak with the missionaries, they are the teachers here. Here you can know more about JesusChrist and the Gospel he teachs", "Every Saturday (09/06/2024)", "09:00 am", adressReception, "missionaries@gmail.com");
        Console.WriteLine(" "); // BLANK
        Console.WriteLine("Standard Details: ");
        reception.StandardDetails();
        Console.WriteLine(" "); // BLANK
        Console.WriteLine("Full Details: ");
        reception.FullDetails();
        Console.WriteLine(" "); // BLANK
        Console.WriteLine("Short Description: ");
        reception.ShortDescription();
        Console.WriteLine(" "); // BLANK
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");

        Adress adressOutdoors = new("Av. B. Cardenas and Av. Blanco Galindo, White Building - [The Church of Jesus Christ of Latter Day Saints]");
        Outdoors outdoors = new("Outdoors Gatherings", "Little CCM", "In this event you can have a day as a Missionary of the Church of Jesus Christ of Latter Day Saints, you will live as a Missionary in the Mission", "Since 20/06/2024 until 22/06/2024", "Three days", adressOutdoors, "Sunny"); // string typeOfEvent, string title, string description, string date, string time, Adress adress, string weather
        Console.WriteLine(" "); // BLANK
        Console.WriteLine("Standard Details: ");
        outdoors.StandardDetails();
        Console.WriteLine(" "); // BLANK
        Console.WriteLine("Full Details: ");
        outdoors.FullDetails();
        Console.WriteLine(" "); // BLANK
        Console.WriteLine("Short Description: ");
        outdoors.ShortDescription();
    }
}