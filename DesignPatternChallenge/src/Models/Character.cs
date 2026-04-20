using System;
using DesignPatternChallenge.src.Interfaces;

namespace DesignPatternChallenge.Models
{
    public class Character : ICharacter
    {
        
        public string FontFamily { get; set; }
        public int FontSize { get; set; }
        public string Color { get; set; }
        public bool IsBold { get; set; }
        public bool IsItalic { get; set; }
        public bool IsUnderline { get; set; }


        public Character(string fontFamily, int fontSize, string color,
            bool isBold, bool isItalic, bool isUnderline)
        {
            FontFamily = fontFamily;
            FontSize = fontSize;
            Color = color;
            IsBold = isBold;
            IsItalic = isItalic;
            IsUnderline = isUnderline;
        }

        public void Render(char symbol, int row, int column)
        {
            var style = "";
            if (IsBold) style += "B";
            if (IsItalic) style += "I";
            if (IsUnderline) style += "U";

            Console.WriteLine($"[{row},{column}] '{symbol}' {FontFamily} {FontSize}pt {Color} {style}");
        }

        public int GetMemorySize()
        {
            return sizeof(char) +
                   32 +
                   sizeof(int) +
                   32 +
                   3 * sizeof(bool) +
                   2 * sizeof(int);
        }
    }
}
