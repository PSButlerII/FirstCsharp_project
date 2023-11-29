using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        Player player1;
        Player player2;

        public Game()
        {
            // Initialize players
            player1 = new Player("Player 1", true);  // Human player
            player2 = new Player("CPU", false);     // CPU player
        }

        public void StartGame()
        {
            // Main game logic, like playing rounds, checking scores, etc.
        }

       
    }
}
