using System;
using System.Collections.Generic;
using System.Text;

namespace MemoCSharp
{
    class Card
    {
        private char Symbol;
        private bool IsDown;
        private ConsoleColor Color;

        public Card(char Symbol, ConsoleColor Color)
        {
            this.Symbol = Symbol;
            Color = ConsoleColor.White;
        }
        public void Rotate(char NewSymbol, ConsoleColor NewColor)
        {
            Symbol = NewSymbol;
            Color = NewColor;
        }
        
    }
}
