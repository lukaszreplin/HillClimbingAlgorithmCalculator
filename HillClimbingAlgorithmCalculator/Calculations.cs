using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillClimbingAlgorithmCalculator.Models
{
    public class Calculations
    {
        private readonly Parameters _parameters;

        private int resolution;

        public int Resolution
        {
            get
            {
                if (resolution == default)
                {
                    resolution = GetL();
                }
                return resolution;
            }
            private set { resolution = value; }
        }


        public Calculations(Parameters parameters)
        {
            _parameters = parameters;
        }

        private int GetL()
        {
            return int.Parse(Math.Ceiling(Math.Log(((_parameters.To - _parameters.From) /
                _parameters.Precision) + 1, 2)).ToString());
        }

        public double GetFunctionResult(double input)
        {
            return (input % 1) * (Math.Cos(20 * Math.PI * input) - Math.Sin(input));
        }

        public double BinToReal(string input)
        {
            return Math.Round((Convert.ToInt32(input, 2) * (_parameters.To - _parameters.From) / (Math.Pow(2, Resolution) - 1))
                + _parameters.From, GetPrecisionInt(_parameters.Precision.ToString()));
        }

        private int GetPrecisionInt(string precision)
        {
            var s1 = precision.Substring(2);
            return s1.IndexOf('1') + 1;
        }
    }
}
