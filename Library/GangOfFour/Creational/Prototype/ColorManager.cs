using System.Collections.Generic;

namespace Library.GangOfFour.Creational.Prototype;

public record ColorManager
{
    private readonly Dictionary<ColorType, Color> colors = [];

    public Color this[ColorType type]
    {
        get => colors[type];
        set => colors[type] = value;
    }
}