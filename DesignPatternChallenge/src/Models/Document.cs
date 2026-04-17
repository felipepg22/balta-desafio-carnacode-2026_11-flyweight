using System;
using System.Collections.Generic;

namespace DesignPatternChallenge.Models
{
    public class Document
    {
        private List<Character> _characters;

        public Document()
        {
            _characters = new List<Character>();
        }

        public void AddCharacter(char symbol, string fontFamily, int fontSize, string color,
            bool isBold, bool isItalic, bool isUnderline, int row, int column)
        {
            var character = new Character(symbol, fontFamily, fontSize, color,
                isBold, isItalic, isUnderline, row, column);
            _characters.Add(character);
        }

        public void Render()
        {
            foreach (var character in _characters)
            {
                character.Render();
            }
        }

        public void PrintMemoryUsage()
        {
            long totalMemory = 0;
            foreach (var character in _characters)
            {
                totalMemory += character.GetMemorySize();
            }

            Console.WriteLine("\n=== Uso de Memória ===");
            Console.WriteLine($"Total de caracteres: {_characters.Count}");
            Console.WriteLine($"Memória aproximada: {totalMemory:N0} bytes ({totalMemory / 1024.0:N2} KB)");
            Console.WriteLine($"Memória por caractere: ~{totalMemory / _characters.Count} bytes");
        }
    }
}
