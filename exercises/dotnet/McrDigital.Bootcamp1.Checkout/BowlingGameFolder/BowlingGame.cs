using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout.BowlingGameFolder
{
    public class BowlingGame
    {
        public int Score(Frame[] frames)
        {
            var score = 0;

            for (int frameIndex = 0; frameIndex < 10; frameIndex++)
            {
                var currentFrame = frames[frameIndex];
                score += currentFrame.FirstBowl + currentFrame.SecondBowl;

                if (currentFrame.FirstBowl + currentFrame.SecondBowl == 10)
                {
                    score += frames[frameIndex + 1].FirstBowl;
                }
            }

            return score;
        }
    }
}
