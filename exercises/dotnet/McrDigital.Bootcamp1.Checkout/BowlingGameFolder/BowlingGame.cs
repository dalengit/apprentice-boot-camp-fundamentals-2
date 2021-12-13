﻿using System;
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

                if (currentFrame.Total == 10 && !currentFrame.Strike)
                {
                    score += frames[frameIndex + 1].FirstBowl;
                }

                if (currentFrame.Strike)
                {
                    score += frames[frameIndex + 1].FirstBowl;

                    if (frames[frameIndex + 1].Strike)
                    {
                        score += frames[frameIndex + 2].FirstBowl;
                    }
                    else
                    {
                        score += frames[frameIndex + 1].SecondBowl.Value;
                    }
                }
            }

            return score;
        }
    }
}
