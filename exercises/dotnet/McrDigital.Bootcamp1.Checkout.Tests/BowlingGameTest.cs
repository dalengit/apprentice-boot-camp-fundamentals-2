using System;
using Xunit;

namespace McrDigital.Bootcamp1.Checkout.Tests
{
    public class BowlingGameTests
    {
        [Fact]
        public void Bowl_returns_zero()
        {
            var game = new BowlingGame();
            var bowls = new Array [
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0];

            var result = game.Score(bowls);

            Assert.Equal(0, result);
        }
    }
}