using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCard.POCO
{
    public class Card
    {   
        public enum Suit {Club = 1, Diamond, Heart, Spade };
        //POCO has properties of the object and constructors.

        public string CardName { get; set; }
        public Suit CardSuit { get; set; }
        public bool IsPlayed { get; set; }
        public int CardValue { get; set; }

        public Card() { }

        public Card(string cardNumber, Suit suit, bool isPlayed, int cardValue)
        {
            CardName = cardNumber;
            CardSuit = suit;
            IsPlayed = isPlayed;
            CardValue = cardValue;

        }
    }


}
