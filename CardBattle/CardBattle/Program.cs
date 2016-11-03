using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardBattle.Models;

namespace CardBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            var clubAce = new Card(Values.Ace, Suit.Clubs);

            /*for (int i = 0; i < (int)Values.End; i++)
            {
                for (int j = 0; j < (int)Suit.End; j++)
                {

                }
            }*/

            Console.WriteLine("I created a card : " + clubAce);

            Console.ReadLine();
        }
    }
}
