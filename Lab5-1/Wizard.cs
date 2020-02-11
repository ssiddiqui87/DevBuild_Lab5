﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;

        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber) : base(name, strength, intelligence, magicalEnergy)
        {
            this.SpellNumber = spellNumber;
        }

        public override string Play()
        {
            return base.Play() + $", {spellNumber} spells";
        }

        public int SpellNumber { get => spellNumber; set => spellNumber = value; }
    }
}
