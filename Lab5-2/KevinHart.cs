using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class KevinHart : Player
    {
        public KevinHart(string name) : base(name)
        {
            
        }
        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
           // Roshambo roshambo = (Roshambo)(random.Next(0, 3));
            return (Roshambo)random.Next(0, 3);
        }
    }
}
