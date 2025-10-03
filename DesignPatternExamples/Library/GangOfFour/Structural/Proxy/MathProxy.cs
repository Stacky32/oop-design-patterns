using System.Threading;

namespace Library.GangOfFour.Structural.Proxy;

public class MathProxy : IMath
{
    private readonly int _waitTime = 500;
    private readonly Math _math = new();

    public double Add(double x, double y)
    {
        Thread.Sleep(_waitTime);
        return _math.Add(x, y);
    }

    public double Subtract(double x, double y)
    {
        Thread.Sleep(_waitTime);
        return _math.Subtract(x, y);
    }
    
    public double Multiply(double x, double y)
    {
        Thread.Sleep(_waitTime);
        return _math.Multiply(x, y);
    }
    
    public double Divide(double x, double y)
    {
        Thread.Sleep(_waitTime);
        return _math.Divide(x, y);
    }
}