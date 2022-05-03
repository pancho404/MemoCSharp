using System;

namespace MemoCSharp
{

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int colorNum;
            Console.WriteLine("Hello World!");
            Card[] cards = new Card[6];
            for (int i = 0; i < cards.Length; i++)
            {
                colorNum = rnd.Next(0, 2);
                switch (colorNum)
                {
                    case 0:
                        cards[i]= new Card("█", ConsoleColor.White, CardTypes.Blue);
                        break;
                    case 1:
                        cards[i] = new Card("█", ConsoleColor.White, CardTypes.Blue);
                        break;
                    case 2:
                        cards[i] = new Card("█", ConsoleColor.White, CardTypes.Blue);
                        break;
                    default:
                        break;
                }
            }
            //Card BlueCardOne=new Card("█", ConsoleColor.White);
            //Card BlueCardTwo = new Card("█", ConsoleColor.White);
            //Card RedCardOne = new Card("█", ConsoleColor.White);
            //Card RedCardTwo = new Card("█", ConsoleColor.White);
            //Card GreenCardOne = new Card("█", ConsoleColor.White);
            //Card GreenCardTwo = new Card("█", ConsoleColor.White);

            //Console.WriteLine("TAPADAS");
            //Console.WriteLine(BlueCardOne.GetSymbol());
            //Console.WriteLine(BlueCardTwo.GetSymbol());
            //Console.WriteLine(RedCardOne.GetSymbol());
            //Console.WriteLine(RedCardTwo.GetSymbol());
            //Console.WriteLine(GreenCardOne.GetSymbol());
            //Console.WriteLine(GreenCardTwo.GetSymbol());
            //Console.WriteLine("DESTAPADA");
            //BlueCardOne.Rotate("V", ConsoleColor.Blue);
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine(BlueCardOne.GetSymbol());
            //Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
