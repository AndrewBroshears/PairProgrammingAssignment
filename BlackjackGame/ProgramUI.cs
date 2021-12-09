using PlayCard.Repo;
using PlayingCard.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGamesUI
{
    class ProgramUI
    {

        private bool runApplication = true;
        private readonly CardRepo cardRepo = new CardRepo();
        public void Run()
        {
            while (runApplication)
            {
                RunMenu();
            }
        }
        
        public void RunMenu()
        {
            Console.WriteLine("Welcome to the card games machine. \n" +
                "Please Select A Game: \n" +
                "1. Blackjack \n" +
                "2. Exit");

            int userInput = Int32.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    PlayBlackJack();
                    break;
                case 2:
                    runApplication = false;
                    Console.WriteLine("Thank you. Please play again soon.");
                    Console.ReadKey();
                    break;
            }
        }

        public void PlayBlackJack()
        {
            List<Card> playerHand = new List<Card>();
            List<Card> dealerHand = new List<Card>();
            cardRepo.MakeDeckOfCards();
            Console.WriteLine("We're going to play the game here. \n" +
                "Press any key to deal the hands.");
            Console.ReadKey();
            //play game

            //deal two card to each "hand"
            // playerHand.Add(CardRepo.DealCard());
            playerHand.Add(cardRepo.GetRandomCard());
            playerHand.Add(cardRepo.GetRandomCard());
            dealerHand.Add(cardRepo.GetRandomCard());
            dealerHand.Add(cardRepo.GetRandomCard());

            //Display results of dealing:
            Console.WriteLine("Player Hand:");
            cardRepo.DisplayHand(playerHand);
            Console.WriteLine("Player Total Points: " + cardRepo.GetTotalPoints(playerHand));
            Console.WriteLine("Dealer Hand:");
            cardRepo.DisplayHand(dealerHand);
            Console.WriteLine("Dealer Total Points: " + cardRepo.GetTotalPoints(dealerHand));
            Console.ReadKey();
            
            if (cardRepo.GetTotalPoints(playerHand) == 21 && cardRepo.GetTotalPoints(dealerHand) == 21)
            {
                Console.WriteLine("It's a Draw");
            }
            else if (cardRepo.GetTotalPoints(playerHand) == 21)
            {
                Console.WriteLine("Congratulations you win!!!");
            }
            else if (cardRepo.GetTotalPoints(dealerHand) == 21)
            {
                Console.WriteLine("Deal HIT Blackjack... You Lose!");
            }
            else //nobody hit 21 on first draw
            {
                Console.WriteLine("Would you like to hit? y/n");
                string userInput = Console.ReadLine().ToLower();

                //Hit 
                if (userInput == "y") 
                {
                    playerHand.Add(cardRepo.GetRandomCard());
                    Console.WriteLine("Player Hand:");
                    cardRepo.DisplayHand(playerHand);
                    Console.WriteLine("Player Total Points: " + cardRepo.GetTotalPoints(playerHand));
                }
                if (cardRepo.GetTotalPoints(dealerHand) < 17)
                {
                    dealerHand.Add(cardRepo.GetRandomCard());
                    Console.WriteLine("Dealer Hand:");
                    cardRepo.DisplayHand(dealerHand);
                    Console.WriteLine("Dealer Total Points: " + cardRepo.GetTotalPoints(dealerHand));

                }
            }
            Console.ReadLine();


            //prompt user to hit or stay.
            //deal to dealer if totalPoints < 17.
            //repeat while totalPoints is not greater than 21.

            //determine winner, print hand totals.

            //List<Card>
            // deal hands - vars: dealerHand, playerHand
        }
    }
}
