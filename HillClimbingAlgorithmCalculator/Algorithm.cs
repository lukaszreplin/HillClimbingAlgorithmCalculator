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
        private List<Individual> _mutated = new List<Individual>();

        public Algorithm(Parameters parameters)
        {
            _parameters = parameters;
            _randomizer = new Random();
            _size = Calculations.GetL(_parameters.Precision, _parameters.From, _parameters.To);
        }

        public Results Start()
        {
            GetRandomIndividual();
            Process();
            return null;
        }

        private void GetRandomIndividual()
        {
            for (int i = 0; i < _size; i++)
            {
                _individual.Binary += RandomUtils.GetRandomInt(0, 2, _randomizer).ToString();
            }
        }

        private void Process()
        {
            // Utworznie zmutowanej populacji
            for (int i = 0; i < _size; i++)
            {
                if (_individual.Binary[i] == '0')
                    _mutated.Add(new Individual() { Id = i + 1, Binary = _individual.Binary.ReplaceAtIndex(i, '1') });
                else
                    _mutated.Add(new Individual() { Id = i + 1, Binary = _individual.Binary.ReplaceAtIndex(i, '0') });
            }

            // Liczenie wartości funkcji
            _individual.Real = _calc.BinToReal(Individual.Binary);
            _individual.FunctionResult = GetFunctionResult(Individual.Real);

            // Liczenie wartości funkcji zmutowanych
            foreach (var item in _mutated)
            {
                item.Real = _calc.BinToReal(item.Binary);
                item.FunctionResult = GetFunctionResult(item.Real);
            }
        }
    }
}
