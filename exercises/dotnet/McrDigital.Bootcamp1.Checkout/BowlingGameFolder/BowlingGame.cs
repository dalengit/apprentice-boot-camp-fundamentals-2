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
                score += currentFrame.Total;

                if (currentFrame.Total == 10 && !currentFrame.IsStrike)
                {
                    var nextFrame = frames[frameIndex + 1];
                    score += nextFrame.FirstBowl;
                }

                if (currentFrame.IsStrike)
                {
                    score = Strike(frames, score, frameIndex);
                }
            }

            return score;
        }

        private static int Strike(Frame[] frames, int score, int frameIndex)
        {
            var nextFrame = frames[frameIndex + 1];

            score += nextFrame.FirstBowl;

            if (nextFrame.IsStrike)
            {
                score += frames[frameIndex + 2].FirstBowl;
            }
            else
            {
                score += nextFrame.SecondBowl.Value;
            }

            return score;
        }
    }
}
