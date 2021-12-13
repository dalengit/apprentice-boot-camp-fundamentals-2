using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout.BowlingGameFolder
{
    public class Frame
    {
        public int FirstBowl { get; set; }
        public int? SecondBowl { get; set; }
        public int Total { get; set; }
        public bool IsStrike { get; set; }

        public Frame(int firstBowl, int secondBowl)
        {
            FirstBowl = firstBowl;
            SecondBowl = secondBowl;
            Total = firstBowl + secondBowl;
        }

        public Frame(int firstBowl)
        {
            FirstBowl = firstBowl;
            Total = firstBowl;
            IsStrike = true;
        }
    }
}