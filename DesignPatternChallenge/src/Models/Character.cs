using System;

namespace DesignPatternChallenge.Models
{
    public class Character
    {
        public char Symbol { get; set; }
        public string FontFamily { get; set; }
        public int FontSize { get; set; }
        public string Color { get; set; }
        public bool IsBold { get; set; }
        public bool IsItalic { get; set; }
        public bool IsUnderline { get; set; }

        public int Row { get; set; }
        public int Column { get; set; }

        public Character(char symbol, string fontFamily, int fontSize, string color,
            bool isBold, bool isItalic, bool isUnderline, int row, int column)
        {
            Symbol = symbol;
            FontFamily = fontFamily;
            FontSize = fontSize;
            Color = color;
            IsBold = isBold;
            IsItalic = isItalic;
            IsUnderline = isUnderline;
            Row = row;
            Column = column;
        }

        public void Render()
        {
            var style = "";
            if (IsBold) style += "B";
            if (IsItalic) style += "I";
            if (IsUnderline) style += "U";

            Console.WriteLine($"[{Row},{Column}] '{Symbol}' {FontFamily} {FontSize}pt {Color} {style}");
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
