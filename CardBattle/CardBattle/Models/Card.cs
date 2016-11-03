﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardBattle.Models
{
    public class Card
    {

        public Suit Suit
            { get; set; }

        public Values Value
            { get; set; }

        public Card(Values value, Suit suit)
        {
            Suit = suit;
            Value = value;
        }

    }
}
