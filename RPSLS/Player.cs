using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Player
    {
        public string name;
        public int score;
        public bool isHuman;
        public string chosenGesture;
        public List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };

        public Player(string name, bool isHuman)
        {
            this.name = name;
            this.isHuman = isHuman;
            this.score = 0;
        }

        public void pickGesture()
        {
            if (isHuman)
            {
                Console.WriteLine($"{name}, pick a gesture (rock, paper, scissors, lizard, spock):");
                chosenGesture = Console.ReadLine().ToLower();
            }
            else
            {
                RandomNumber();
            }
        }

        public void RandomNumber()
        {
            Random rnd = new Random();
            int index = rnd.Next(gestures.Count);
            chosenGesture = gestures[index];
            Console.WriteLine($"{name} (CPU) picked: {chosenGesture}");
        }
    }

}
