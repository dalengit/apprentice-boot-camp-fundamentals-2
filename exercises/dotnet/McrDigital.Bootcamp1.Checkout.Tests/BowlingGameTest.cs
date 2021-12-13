using System;
using System.Runtime.Serialization;
using McrDigital.Bootcamp1.Checkout.BowlingGameFolder;
using Xunit;

namespace McrDigital.Bootcamp1.Checkout.Tests
{
    public class BowlingGameTests
    {
        private readonly BowlingGame _game = new BowlingGame();

        [Fact]
        public void Score_returns_zero()
        {
            var bowls = new [] 
            {
              new Frame(0, 0),
              new Frame(0, 0),
              new Frame(0, 0),
              new Frame(0, 0),
              new Frame(0, 0),
              new Frame(0, 0),
              new Frame(0, 0),
              new Frame(0, 0),
              new Frame(0, 0),
              new Frame(0, 0),
            };
            
            var result = _game.Score(bowls);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Score_returns_correct_score()
        {
            var bowls = new [] 
            {
                new Frame(1, 1),
                new Frame(1, 1),
                new Frame(1, 1),
                new Frame(1, 1),
                new Frame(1, 1),
                new Frame(1, 1),
                new Frame(1, 1),
                new Frame(1, 1),
                new Frame(1, 1),
                new Frame(1, 1),
            };

            var result = _game.Score(bowls);

            Assert.Equal(20, result);
        }

        [Fact]
        public void Score_accounts_for_spare()
        {
            var bowls = new []
            {
                new Frame(5, 5),
                new Frame(1, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
            };

            var result = _game.Score(bowls);

            Assert.Equal(12, result);
        }

        [Fact]
        public void Strike_is_a_strike()
        {
            var strike = new Frame(10);

            Assert.Equal(true, strike.Strike);
        }

        [Fact]
        public void Score_accounts_for_strike()
        {
            var bowls = new[]
            {
                new Frame(10),
                new Frame(1, 1),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
            };

            var result = _game.Score(bowls);

            Assert.Equal(14, result);
        }

        [Fact]
        public void Strike_followed_by_two_consecutive_strikes()
        {
            var bowls = new[]
            {
                new Frame(10),
                new Frame(10),
                new Frame(10),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
                new Frame(0, 0),
            };

            var result = _game.Score(bowls);

            Assert.Equal(60, result);
        }
    }
}