using System.Text.Json;

namespace Library.GangOfFour.Creational.Prototype;

public class Color : ICloneableObject
{
    public byte Red { get; set; }
    public byte Green { get; set; }
    public byte Blue { get; set; }

    public Color(byte red, byte green, byte blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public object? Clone(bool shallow)
    {
        return shallow ? Clone() : DeepCopy();
    }

    public object Clone() => this.MemberwiseClone();

    public object? DeepCopy()
    {
        var serialised = JsonSerializer.Serialize(this);
        var copy = JsonSerializer.Deserialize<Color>(serialised);

        return copy;
    }

    public override string ToString()
    {
        return $"R: {Red, 3}, G: {Green, 3}, B: {Blue, 3}";
    }
}