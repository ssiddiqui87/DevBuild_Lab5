using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class DwayneJohnson : Player
    {

        public DwayneJohnson(string name, int value) : base(name, value) 
        {
          
        }
        public override Roshambo GenerateRoshambo()
        {
            Roshambo roshambo = Roshambo.Rock;
            return roshambo;
        }
    }
}
