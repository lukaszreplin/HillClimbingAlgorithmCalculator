using HillClimbingAlgorithmCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillClimbingAlgorithmCalculator
{
    public class Algorithm
    {
        private readonly Parameters _parameters;
        private readonly Random _randomizer;
        private readonly int _size;

        private Individual _individual = new Individual();

        public Algorithm(Parameters parameters)
        {
            _parameters = parameters;
            _randomizer = new Random();
            _size = Calculations.GetL(_parameters.Precision, _parameters.From, _parameters.To);
        }

        public Results Start()
        {
            GetRandomIndividual();
            return null;
        }

        public void GetRandomIndividual()
        {
            for (int i = 0; i < _size; i++)
            {
                _individual.Binary += RandomUtils.GetRandomInt(0, 2, _randomizer).ToString();
            }
        }
    }
}
