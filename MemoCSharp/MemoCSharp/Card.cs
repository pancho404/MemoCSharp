using System;
using System.Collections.Generic;
using System.Text;

namespace MemoCSharp
{
    class Card
    {
        private string Symbol="█";
        private bool IsDown;
        CardTypes type;
        private ConsoleColor Color=ConsoleColor.White;

        public Card(string Symbol, ConsoleColor Color, CardTypes type)
        {
            this.Symbol = Symbol;
            this.IsDown = true;
            this.type = type;
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

        public void SetSymbol(string newSymbol)
        {
            
        }
        public void SetIsDown()
        {
            
        }

        public void SetColor()
        {
            
        }

    }

}
