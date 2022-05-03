using System;
using System.Collections.Generic;
using System.Text;

namespace MemoCSharp
{
    class Card
    {
        private string Symbol="█";
        private bool IsDown;
        private ConsoleColor Color=ConsoleColor.White;

        public Card(string Symbol, ConsoleColor Color)
        {
            this.Symbol = Symbol;
            this.IsDown = true;
            Color = ConsoleColor.White;
        }
        public void Rotate(string NewSymbol, ConsoleColor NewColor)
        {
            Symbol = NewSymbol;
            Color = NewColor;
            IsDown = false;
        }
        public string GetSymbol()
        {
            return Symbol;
        }
        public bool GetIsDown()
        {
            return IsDown;
        }

        public ConsoleColor GetColor()
        {
            return Color;
        }

        public void etSymbol()
        {
            return Symbol;
        }
        public void GetIsDown()
        {
            return IsDown;
        }

        public void GetColor()
        {
            return Color;
        }

    }

}
