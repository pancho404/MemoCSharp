using System;
using System.Collections.Generic;

namespace MemoCSharp
{

    class Program
    {

        static void Main(string[] args)
        {
            List<Card> Cards2 = new List<Card>();
            Card[] Cards = new Card[6];
            Init(Cards, Cards2);
           // Draw(Cards, Cards2);


        }

        private static void Init(Card[] Cards, List<Card> Cards2)
        {
            //for (int i = 0; i < Cards.Length; i++)
            //{
            //    if (i == 0 || i == 1)
            //    {
            //        Cards[i] = new Card("█", ConsoleColor.Blue, CardTypes.Blue);
            //    }
            //    if (i == 2 || i == 3)
            //    {
            //        Cards[i] = new Card("█", ConsoleColor.White, CardTypes.Red);
            //    }
            //    if (i == 4 || i == 5)
            //    {
            //        Cards[i] = new Card("█", ConsoleColor.White, CardTypes.Green);
            //    }
            //}
            while (Cards2.Count < 6)
            {
                if (Cards2.Count == 0 || Cards2.Count==1)
                {
                    Cards2.Add(new Card("█", ConsoleColor.Blue, CardTypes.Blue, 0));
                }
                if (Cards2.Count == 2 || Cards2.Count == 3)
                {
                    Cards2.Add(new Card("█", ConsoleColor.Red, CardTypes.Red, 0));
                }
                if (Cards2.Count == 4 || Cards2.Count == 5)
                {
                    Cards2.Add(new Card("█", ConsoleColor.Green, CardTypes.Green, 0));
                }
            }

        }

        private static void Draw(Card[] Cards, List<Card> Cards2)
        {
            for (int i = 0; i < Cards.Length; i++)
            {
                Console.ForegroundColor = Cards[i].GetColor();
                Console.WriteLine(Cards[i].GetSymbol());
                Console.WriteLine(" ");
            }
        }

        private static void Update()
        {


        }
    }
}
