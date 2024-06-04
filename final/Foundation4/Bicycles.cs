public class Bicycles : Activity
{
    private double _speed;
    public Bicycles(double time, double speed) : base(time)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return Speed() * (GetTime() / 60); // speed = distance / time ---> distance = speed * time
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return GetTime() / Distance();
    }
}