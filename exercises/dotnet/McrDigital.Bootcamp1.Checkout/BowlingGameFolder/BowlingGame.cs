using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout.BowlingGameFolder
{
    public class BowlingGame
    {
        public int Score(Frame[] bowls)
        {
            return bowls.Sum(x => x.FirstBowl + x.SecondBowl);
        }
    }
}
