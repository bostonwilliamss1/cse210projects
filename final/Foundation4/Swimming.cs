public class Swimming : Activity
{
    private double _numOfLaps;
public Swimming(double numOfLaps, string date, double length) : base(date, length)
{
    _numOfLaps = numOfLaps;
}
public override double GetSpeed()
{
return Math.Round(60 / GetPace(), 2);
}
public override double GetPace()
{
return Math.Round(GetLength() / GetDistance(), 2);
}
public override double GetDistance()
{
return Math.Round(_numOfLaps * 50 / 1000 * 0.62, 2);
}
public override string GetSummary()
{
    return $"{GetDate()} - Swimming ({GetLength()} minutes)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
}
}