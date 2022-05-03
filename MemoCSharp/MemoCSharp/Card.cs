using System;
using System.Collections.Generic;
using System.Text;

namespace MemoCSharp
{
    class Card
    {
        private string Symbol = "█";
        private bool IsDown;
        private int Pos;
        CardTypes Type;
        private ConsoleColor Color = ConsoleColor.White;

        public Card(string Symbol, ConsoleColor Color, CardTypes type, int pos)
        {
            this.Symbol = Symbol;
            this.IsDown = true;
            this.Type = type;
            this.Color = Color;
            this.Pos = pos;
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

        public CardTypes GetCardType()
        {
            return Type;
        }

        public int GetPos()
        {
            return Pos;
        }
        

    }

}
