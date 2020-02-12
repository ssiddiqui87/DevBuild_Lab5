using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class User : Player
    {
        public User(string name) : base(name)
        {
            
        }
        public override Roshambo GenerateRoshambo()
        {
            Console.Write("Rock, paper or scissors? ");
            string input = Console.ReadLine().ToLower();

            if (input == "rock")
            {
                return Roshambo.Rock;
            }
            else if (input == "paper")
            {
                return Roshambo.Paper;
            }
            else
            {
                return Roshambo.Scissors;
            }
        }
    }
}
