using System;

namespace Library.GangOfFour.Structural.Flyweight;

public abstract class Character
{
    protected char symbol;
    protected int width;
    protected int height;
    protected int pointSize;

    public virtual void Display(int pointSize)
    {
        this.pointSize = pointSize;
        Console.WriteLine($"{symbol} (point size {pointSize})");
    }
}