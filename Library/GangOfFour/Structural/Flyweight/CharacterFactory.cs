using System.Collections.Generic;

namespace Library.GangOfFour.Structural.Flyweight;

public class CharacterFactory
{
    private Dictionary<char, Character> _characters = [];

    public Character? GetCharacter(char key)
    {
        if (_characters.TryGetValue(key, out var value))
        {
            return value;
        }

        Character? character = key switch
        {
            'A' => new CharacterA(),
            'B' => new CharacterB(),
            'Z' => new CharacterZ(),
            _ => null
        };

        if (character is not null)
        {
            _characters.Add(key, character);
        }

        return character;
    }
}