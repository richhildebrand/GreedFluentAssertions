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
            score += ScoreFives(diceRolls);

            return score;
        }
  
        private int ScoreFives(List<int> diceRolls)
        {
            var fives = diceRolls.Where(dr => dr == 5).Count();
            return fives * 50;
        }
  
        private int ScoreOnes(List<int> diceRolls)
        {
            var ones = diceRolls.Where(dr => dr == 1).Count();
            return ones * 100;
        }
    }
}
