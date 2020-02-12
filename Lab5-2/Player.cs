using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    abstract class Player
    {
        private string name;
        private int value;

        public Player(string name, int value)
        {
            this.Name = name;
            this.Value = value;
        }

        public string Name { get => name; set => name = value; }
        public int Value { get => value; set => this.value = value; }

        public abstract Roshambo GenerateRoshambo();
    }
}
