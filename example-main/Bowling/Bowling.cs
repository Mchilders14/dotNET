using System;
using System.Collections.Generic;

namespace Bowling
{
    public class Bowling
    {
        Random rand = new Random();
        List<int> game = new List<int>();

        public int Bowl()
        {
            for (var idx = 1; idx <= 10; idx++)
            {
                var score = rand.Next(31);
                game.Add(score);

            }

            var total = 0;
            foreach (var score in game)
            {
                total += score;
            }

            return total;
        }
    }
}
