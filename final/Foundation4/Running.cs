public class Running : Activity
{
    private double _distance;

public Running(double distance, string date, double length) : base(date, length)
{
    _distance = distance;
}
public override double GetSpeed()
{
return Math.Round(60 / GetPace(), 2);
}
public override double GetPace()
{
    return Math.Round(GetLength() / _distance, 2);
}
public override double GetDistance()
{
return _distance;
}
public override string GetSummary()
{
    return $"{GetDate()} - Running ({GetLength()} minutes)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
}
}