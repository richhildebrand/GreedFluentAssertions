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
        public void Return100WhenGivenOneOne()
        {
            var diceRolls = new List<int>() { 1 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(100);
        }

        [Test]
        public void Return50WhenGivenOneFive()
        {
            var diceRolls = new List<int>() { 5 };
            var score = _greed.ScoreDiceRolls(diceRolls);

            score.Should().Be(50);
        }

    }
}
