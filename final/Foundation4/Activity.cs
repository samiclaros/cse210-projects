using System.ComponentModel.Design;

public abstract class Activity
{
    private string _date;
    private double _time; // Duration in Minutes
    public Activity(double time)
    {
        _date = DateTime.Now.ToShortDateString();
        _time = time;
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();

    public double GetTime() // Getter
    {
        return _time;
    }

    public string GetSummary()
    {
        return $"{_date} {GetType()}({_time} min): Distance {Distance()} km, Speed {Speed()} kph, Pace {Pace()} min per km"; // GetType is a built in method
    }
}