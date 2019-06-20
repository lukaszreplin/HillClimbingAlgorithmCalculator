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

        public static double GetFunctionResult(double input)
        {
            return (input % 1) * (Math.Cos(20 * Math.PI * input) - Math.Sin(input));
        }

        public static double BinToReal(string input, Parameters @params)
        {
            return Math.Round((Convert.ToInt32(input, 2) * (@params.To - @params.From) / (Math.Pow(2, _individualResolution) - 1))
                + @params.From, GetPrecisionInt(@params.Precision.ToString()));
        }

        private static int GetPrecisionInt(string precision)
        {
            var s1 = precision.Substring(2);
            return s1.IndexOf('1') + 1;
        }
    }
}
