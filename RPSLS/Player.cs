using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Player
    {
        //member variable
        public string name;        
        public int score;
        public bool isHuman;        
        public string chosenGesture;
        public List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spoke" };


        //constructor
      

        


        //member methods

        public void Human()
        {
            isHuman = true;
        }
        public void CPU()
        {
            isCPU = true;
        }
        public void pickGesture()

        {
            Console.WriteLine("pick a gesture:");
            chosenGesture = Console.ReadLine();
        }
        public void RandomNumber()
        {

        }
    }
}
