using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillClimbingAlgorithmCalculator.Models
{
    public class Results
    {
        public double XRealBest { get; set; }

        public string XBinBest { get; set; }

        public double FXBest { get; set; }

        public List<List<double>> ResValues { get; set; }

        public List<double> Bests { get; set; }

        public int FoundIn { get; set; }
    }
}
