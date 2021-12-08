using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCard.POCO
{
    public class Card
    {   
        public enum Suit {Club, Diamond, Heart, Spade };
        //POCO has properties of the object and constructors.

        public string CardNumber { get; set; }
        public Suit CardSuit { get; set; }
        public bool IsPlayed { get; set; }

        public Card() { }

        public Card(string cardNumber, Suit suit, bool isPlayed)
        {
            CardNumber = cardNumber;
            CardSuit = suit;
            IsPlayed = isPlayed;

        }
    }


}
