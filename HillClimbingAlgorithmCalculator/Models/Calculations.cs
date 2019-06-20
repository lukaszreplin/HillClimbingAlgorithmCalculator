using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillClimbingAlgorithmCalculator.Models
{
    public class Calculations
    {
        public static int GetL(double precision, float from, float to)
        {
            return int.Parse(Math.Ceiling(Math.Log(((to - from) /
                precision) + 1, 2)).ToString());
        }
    }
}
