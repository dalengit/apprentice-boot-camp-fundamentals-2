using System;
using Xunit;

namespace McrDigital.Bootcamp1.Checkout.Tests
{
    public class BowlingGameTests
    {
        private readonly BowlingGame _game = new BowlingGame();

        [Fact]
        public void Bowl_returns_zero()
        {
            var bowls = new int[] 
            {
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0
            };
            
            var result = _game.Score(bowls);

            Assert.Equal(0, result);
        }

        [Fact]

        public void Bowl_returns_correct_score()
        {
            var bowls = new int [] 
            {
               1, 1,
               1, 1,
               1, 1,
               1, 1,
               1, 1,
               1, 1,
               1, 1,
               1, 1,
               1, 1,
               1, 1
            };

            var result = _game.Score(bowls);

            Assert.Equal(20, result);
        }
    }
}