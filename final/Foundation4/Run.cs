public class Run : Activity
{
    private double _distance;
    public Run(double time, double distance) : base(time)
    {
        _distance = distance;
    }
    
    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        return Distance() / GetTime();
    }

    public override double Pace()
    {
        return GetTime() / Distance();
    }
}