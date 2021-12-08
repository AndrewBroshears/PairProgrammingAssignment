using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayingCard.POCO;

namespace PlayCard.Repo
{
    public class CardRepo
    {
        private readonly List<Card> _deckOfCards = new List<Card>();
        private int _cardId = 0;
        //CRUD and helper methods on deck of cards.
      
        //Create deck of cards
        public void MakeDeckOfCards()
        {   
            //iterate through and assign number
            for (int i = 1; i < 15; i ++)
            {
                //iterate through and assign suit
                for (int j = 1; j < 5; j++)
                {
                    Card cardToBeAdded = new Card(i.ToString(), (Card.Suit)j, false, 1);
                    _deckOfCards.Add(cardToBeAdded);
                }
            }
        }

        //GetCardByID

        //DealCard (get random card that isPlayed == false)

        // print deck of cards (print all cards with all details.
        public void PrintDeck()
        {
            foreach (Card c in _deckOfCards)
            {
                Console.WriteLine($"CardNumber: {c.CardName} \t CardSuit: {c.CardSuit} \t IsPlayed: {c.IsPlayed}");
            }

        }

    }
}
