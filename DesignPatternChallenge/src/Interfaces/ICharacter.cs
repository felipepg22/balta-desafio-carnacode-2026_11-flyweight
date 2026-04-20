using System;

namespace DesignPatternChallenge.src.Interfaces;

public interface ICharacter
{
    public void Render(char symbol, int row, int column);

    public int GetMemorySize();
}
