using System;
using System.Collections.Generic;

namespace MemoCSharp
{

    class Program
    {

        static void Main(string[] args)
        {
            List<Card> Cards = new List<Card>();
            List<Card> DrawableCards = new List<Card>();
            Init(Cards, DrawableCards);
            Update(Cards, DrawableCards);
            Draw(DrawableCards);


        }

        private static void Init(List<Card> Cards, List<Card> DrawableCards)
        {
            while (Cards.Count < 6)
            {
                if (Cards.Count == 0 || Cards.Count == 1)
                {
                    Cards.Add(new Card("█", ConsoleColor.Blue, CardTypes.Blue, 0));
                }
                if (Cards.Count == 2 || Cards.Count == 3)
                {
                    Cards.Add(new Card("█", ConsoleColor.Red, CardTypes.Red, 0));
                }
                if (Cards.Count == 4 || Cards.Count == 5)
                {
                    Cards.Add(new Card("█", ConsoleColor.Green, CardTypes.Green, 0));
                }
            }
            SortCarts(Cards, DrawableCards);
        }

        private static void Draw(List<Card> DrawableCards)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.ForegroundColor = DrawableCards[i].GetColor();
                Console.WriteLine(DrawableCards[i].GetSymbol());
                Console.WriteLine(" ");
            }
        }

        private static void Update(List<Card> Cards, List<Card> Cards2)
        {

        }

        private static void SortCarts(List<Card> Cards, List<Card> DrawableCards)
        {
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                int randomNum = rnd.Next(0, Cards.Count - 1);
                Cards[randomNum].SetPos(i);
                DrawableCards.Add(Cards[randomNum]);
                Cards.RemoveAt(randomNum);
            }
        }
    }
}
