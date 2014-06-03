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
            score += ScoreSixes(diceRolls);

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
            return ScoreSetsOfThree(2, diceRolls);
        }

        private int ScoreThrees(List<int> diceRolls)
        {
            return ScoreSetsOfThree(3, diceRolls);
        }
  
        private int ScoreFours(List<int> diceRolls)
        {
            return ScoreSetsOfThree(4, diceRolls);
        }
  
        private int ScoreFives(List<int> diceRolls)
        {
            var fives = diceRolls.Where(dr => dr == 5).Count();

            int setsOfThree = fives / 3;
            fives -= setsOfThree * 3;

            return fives * 50 + setsOfThree * 500;
        }

        private int ScoreSixes(List<int> diceRolls)
        {
            return ScoreSetsOfThree(6, diceRolls);
        }

        private int ScoreSetsOfThree(int dieSide, List<int> diceRolls)
        {
            var dieSideCount = diceRolls.Where(dr => dr == dieSide).Count();
            var setsOfThree = dieSideCount / 3;

            return setsOfThree * 100 * dieSide;
        }
    }
}