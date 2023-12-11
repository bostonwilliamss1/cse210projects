public class Biking : Activity 
{
    private double _speed;
public Biking(double speed, string date, double length) : base(date, length)
{
    _speed = speed;
}
public override double GetSpeed()
{
return _speed;
}
public override double GetPace()
{
return Math.Round(60 / GetSpeed(), 2);
}
public override double GetDistance()
{
return Math.Round(GetLength() / GetPace(), 2);
}
public override string GetSummary()
{
    return $"{GetDate()} - Biking ({GetLength()} minutes)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
}
}