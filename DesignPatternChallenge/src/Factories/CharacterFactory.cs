using System;
using DesignPatternChallenge.Models;
using DesignPatternChallenge.src.Interfaces;

namespace DesignPatternChallenge.src.Factories;

public class CharacterFactory
{
    private readonly Dictionary<string, ICharacter> _characters = new();

    public ICharacter GetCharacter(string fontFamily, 
                                   int fontSize, 
                                   string color,
                                   bool isBold, 
                                   bool isItalic, 
                                   bool isUnderline)
    {
        var key = $"{fontFamily}-{fontSize}-{color}-{isBold}-{isItalic}-{isUnderline}";

        if (!_characters.ContainsKey(key))
            _characters[key] = new Character(fontFamily, fontSize, color, isBold, isItalic, isUnderline);

        return _characters[key];
    }

    public int GetMemoryUsage()
    {
        int totalMemory = 0;

        foreach(var character in _characters)
        {
            totalMemory += character.Value.GetMemorySize();
        }

        return totalMemory;
    }
}
