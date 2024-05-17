// Here I didn't used GetRandomPrompt and GetRandomQuestion, because I don't see that methods were necessary..

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless",
    };
    private List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Write("> We are going to start in 10 seconds, get ready: ");
        ShowCountDown(10);
        Console.WriteLine(" "); // BLANK

        Console.WriteLine("Consider the following prompt");
        Console.WriteLine(" "); // BLANK
        Console.WriteLine($"  ------- {GetRandomPrompt()} -------  ");
        Console.WriteLine(" "); // BLANK

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("> Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine(" "); // BLANK
        Console.Write("You will start in: ");
        ShowCountDown(10);
        Console.WriteLine(); // Move the cursor to a new line

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        do
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(5);
            Console.WriteLine();
        } while (DateTime.Now < stopTime);
        
        DisplayEndingMessage();
        // Console.Clear();
        
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int prompt = randomGenerator.Next(0, _prompts.Count);
        return _prompts[prompt];
    }

    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int question = randomGenerator.Next(0, _questions.Count);
        return _questions[question];
    }

    // public void DisplayPrompt()
    // {

    // }

    // public void DisplayQuestions()
    // {
        
    // }
}