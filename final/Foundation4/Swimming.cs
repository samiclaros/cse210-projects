public class Swimming : Activity
{
    private double _numberOfLaps;

    public Swimming(double time, double numberOfLaps) : base(time)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double Distance()
    {
        return (_numberOfLaps * 50) / 1000;
    }

    public override double Speed()
    {
        return Distance() / (GetTime() / 60);
    }

    public override double Pace()
    {
        return GetTime() / Distance();
    }
}