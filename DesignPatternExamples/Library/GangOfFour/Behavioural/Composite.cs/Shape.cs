using System;

namespace Library.GangOfFour.Behavioural.Composite;

public class Shape : IComparable<Shape>
{
    private readonly string _name;

    public Shape(string name)
    {
        _name = name;
    }

    public override string ToString() => _name;

    public int CompareTo(Shape? other) => this == other ? 0 : -1;
}