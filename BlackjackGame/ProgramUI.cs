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
            Console.WriteLine("We're going to play the game here. \n" +
                "Press any key to deal the hands.");
            Console.ReadKey();

        }
    }
}
