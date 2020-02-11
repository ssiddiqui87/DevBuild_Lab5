using System;
using System.Collections.Generic;

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();

            gameCharacters.Add(new Warrior("Khal Drogo", 95, 50, "Arakh of Khal Drogo"));
            gameCharacters.Add(new Warrior("Jamie Lannister", 85, 90, "Sword"));
            gameCharacters.Add(new Wizard("Danaerys Targaryen", 75, 20, 10, 5));
            gameCharacters.Add(new Wizard("Lady Witherell the Wizard", 65, 74, 80, 15));
            gameCharacters.Add(new Wizard("Pearl the Magician", 45, 82, 30, 6));

            foreach (GameCharacter character in gameCharacters)
            {
                Console.WriteLine(character.Play());
            }



        }
    }
}
