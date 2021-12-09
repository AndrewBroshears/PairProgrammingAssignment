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
            for (int i = 1; i < 14; i ++)
            {
                //iterate through and assign suit
                for (int j = 1; j < 5; j++)
                {
                    int valueToAssign;
                    string nameToAssign;
                    if (i == 1)  //if i = 1 cardValue = 10, cardName = "Ace"
                    {
                        valueToAssign = 11;
                        nameToAssign = "Ace";
                        Card cardToBeAdded = new Card(nameToAssign, (Card.Suit)j, false, valueToAssign);
                        _deckOfCards.Add(cardToBeAdded);
                    }
                    else if (i == 11) // elseif i = 11, cardValue = 10 cardName = "Jack"
                    {
                        valueToAssign = 10;
                        nameToAssign = "Jack";
                        Card cardToBeAdded = new Card(nameToAssign, (Card.Suit)j, false, valueToAssign);
                        _deckOfCards.Add(cardToBeAdded);
                    }
                    else if (i == 12)  // else if i = 12, cardValue = 10, cardName = "Queen"
                    {
                        valueToAssign = 10;
                        nameToAssign = "Queen";
                        Card cardToBeAdded = new Card(nameToAssign, (Card.Suit)j, false, valueToAssign);
                        _deckOfCards.Add(cardToBeAdded);
                    }
                    else if (i == 13) // else if i - 13, cardValue = 10, cardName = "King"
                    {
                        valueToAssign = 10;
                        nameToAssign = "King";
                        Card cardToBeAdded = new Card(nameToAssign, (Card.Suit)j, false, valueToAssign);
                        _deckOfCards.Add(cardToBeAdded);
                    }
                    else
                    {
                        Card cardToBeAdded = new Card(i.ToString(), (Card.Suit)j, false, i);
                        _deckOfCards.Add(cardToBeAdded);
                    }
                    
                }
            }
        }

        //GetCardByID

        //DealCard (get random card that isPlayed == false)

        public Card GetRandomCard()
        {
            //get a "random" number between 1 and 52.
            // set IsPlayed = true;;
            // return _deckOfCards[int].. something like that.

            bool findCard = true;
            Card cardToReturn = new Card();
            while(findCard)
            {
                Random rnd = new Random();
                int randomCard = rnd.Next(52);
                if (_deckOfCards[randomCard].IsPlayed == false)
                {
                    _deckOfCards[randomCard].IsPlayed = true;
                    cardToReturn = _deckOfCards[randomCard];
                    findCard = false;
                }
            }
            return cardToReturn;
        }

        // print deck of cards (print all cards with all details.
        public void PrintDeck()
        {
            foreach (Card c in _deckOfCards)
            {
                Console.WriteLine($"CardName: {c.CardName}  \t\t CardSuit: {c.CardSuit} \t CardValue: {c.CardValue} \t IsPlayed: {c.IsPlayed}");
            }

        }

        //get total points for a list of cards
        public int GetTotalPoints(List<Card> listOfCards)
        {
            int totalPoints = 0;
            foreach (Card c in listOfCards)
            {
                totalPoints += c.CardValue;
            }
            return totalPoints;
        }

        public void DisplayHand(List<Card> hand)
        {
            foreach (Card c in hand)
            {
                Console.WriteLine($"CardName: {c.CardName}  \t\t CardSuit: {c.CardSuit} \t CardValue: {c.CardValue} \t IsPlayed: {c.IsPlayed}");
            }
        }

        public void PrintCard(Card c)
        {
            Console.WriteLine($"CardName: {c.CardName}  \t\t CardSuit: {c.CardSuit} \t CardValue: {c.CardValue} \t IsPlayed: {c.IsPlayed}");
        }

    }
}
