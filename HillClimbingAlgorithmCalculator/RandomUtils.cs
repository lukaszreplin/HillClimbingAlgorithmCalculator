using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillClimbingAlgorithmCalculator
{
    public class RandomUtils
    {
        public static int GetRandomInt(int from, int to, Random random)
        {
            return random.Next(from, to);
        }

        public static double GetRandomNumber(float from, float to, Random random)
        {
            double number;
            number = random.NextDouble() * (to - from) + from;
            return number;
        }
    }
}
