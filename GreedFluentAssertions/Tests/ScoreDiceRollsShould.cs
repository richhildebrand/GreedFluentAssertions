using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using GreedFluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ScoreDiceRollsShould
    {
        private Greed _greed;

        [SetUp]
        public void SetUp()
        {
            _greed = new Greed();
        }

        [Test]
        public void Return100_WhenGivenOneOne()
        {
            var diceRolls = new List<int>() { 1 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(100);
        }

        [Test]
        public void Return50_WhenGivenOneFive()
        {
            var diceRolls = new List<int>() { 5 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(50);
        }

        [Test]
        public void Return1000_WhenGivenThreeOnes()
        {
            var diceRolls = new List<int>() { 1, 1, 1 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(1000);
        }

        [Test]
        public void Return1200_WhenGivenFiveOnes()
        {
            var diceRolls = new List<int>() { 1, 1, 1, 1, 1 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(1200);
        }

        [Test]
        public void Return2100_WhenGivenSevenOnes()
        {
            var diceRolls = new List<int>() { 1, 1, 1, 1, 1, 1, 1 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(2100);
        }

        [Test]
        public void ReturnZero_WhenGivenTwoTwos()
        {
            var diceRolls = new List<int> { 2, 2 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(0);
        }

        [Test]
        public void Return200_WhenGivenThreeTwos()
        {
            var diceRolls = new List<int> { 2, 2, 2 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(200);
        }

        [Test]
        public void Return300_WhenGivenFourThrees()
        {
            var diceRolls = new List<int> { 3, 3, 3 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(300);
        }

        [Test]
        public void Return800_WhenGivenSixFours()
        {
            var diceRolls = new List<int> { 4, 4, 4, 4, 4, 4 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(800);
        }

        [Test]
        public void Return600_WhenGivenThreeSixes()
        {
            var diceRolls = new List<int> { 6, 6, 6 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(600);
        }

        [Test]
        public void Return1150_WhenGivenTheFollowing()
        {
            var diceRolls = new List<int> { 1, 1, 1, 5, 1 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(1150);
        }

        [Test]
        public void Return0_WhenGivenTheFollowing()
        {
            var diceRolls = new List<int> { 2, 3, 4, 6, 2 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(0);
        }

        [Test]
        public void Return350_WhenGiven()
        {
            var diceRolls = new List<int> { 3, 4, 5, 3, 3 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(350);
        }

        [Test]
        public void Return250_WhenGiven()
        {
            var diceRolls = new List<int> { 1, 5, 1, 2, 4 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(250);
        }

        [Test]
        public void Return600_WhenGivenFiveFives()
        {
            var diceRolls = new List<int> { 5, 5, 5, 5, 5 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(600);
        }
    }
}
