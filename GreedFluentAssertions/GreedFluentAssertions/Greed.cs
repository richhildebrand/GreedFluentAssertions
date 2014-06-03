using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedFluentAssertions
{
    public class Greed
    {
        public int ScoreDiceRolls(List<int> diceRolls)
        {
            var score = 0;
            score += ScoreOnes(diceRolls);
            score += ScoreTwos(diceRolls);
            score += ScoreThrees(diceRolls);
            score += ScoreFours(diceRolls);
            score += ScoreFives(diceRolls);

            return score;
        }

        private int ScoreOnes(List<int> diceRolls)
        {
            var ones = diceRolls.Where(dr => dr == 1).Count();

            int setsOfThree = ones / 3;
            ones -= setsOfThree * 3;

            return ones * 100 + setsOfThree * 1000;
        }

        private int ScoreTwos(List<int> diceRolls)
        {
            var twos = diceRolls.Where(dr => dr == 2).Count();
            var setsOfThree = twos / 3;
            return setsOfThree * 200;
        }

        private int ScoreThrees(List<int> diceRolls)
        {
            var threes = diceRolls.Where(dr => dr == 3).Count();
            var setsOfThree = threes / 3;

            return setsOfThree * 300;
        }
  
        private int ScoreFours(List<int> diceRolls)
        {
            var fours = diceRolls.Where(dr => dr == 4).Count();
            var setsOfThree = fours / 3;

            return setsOfThree * 400;
        }
  
        private int ScoreFives(List<int> diceRolls)
        {
            var fives = diceRolls.Where(dr => dr == 5).Count();
            return fives * 50;
        }
    }
}