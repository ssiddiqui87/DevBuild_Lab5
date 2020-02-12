using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    abstract class Player
    {
        private string name;
        private Roshambo value;

        public Player(string name, Roshambo value)
        {
            this.Name = name;
            this.Value = value;
        }
        public Player(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }
        public Roshambo Value { get => value; set => this.value = value; }

        public abstract Roshambo GenerateRoshambo();
    }
}
