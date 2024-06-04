using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new()
        {
            new Run(60, 60),
            new Bicycles(60, 60),
            new Swimming(60, 60)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}