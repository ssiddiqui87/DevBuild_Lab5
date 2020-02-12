using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class DwayneJohnson : Player
    {

        public DwayneJohnson(string name) : base(name) 
        {
          
        }
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
