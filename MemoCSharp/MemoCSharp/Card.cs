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
        public void Rotate()
        {
            if (Color==ConsoleColor.White)
            {
                switch (Type)
                {
                    case CardTypes.Blue:
                        Color = ConsoleColor.Blue;
                        break;
                    case CardTypes.Red:
                        Color = ConsoleColor.Red;
                        break;
                    case CardTypes.Green:
                        Color = ConsoleColor.Green;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Color = ConsoleColor.White;
                IsDown = true;
            }
            
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
        
        public void SetPos(int pos)
        {
            Pos = pos;
        }
    }

}
