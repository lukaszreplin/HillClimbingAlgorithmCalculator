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
        private Calculations _calculations;

        private Individual _individual;
        private Individual _best = new Individual();
        private List<Individual> _mutated;
        private bool local = false;
        private int _foundIn = 0;

        private List<Individual> VCS = new List<Individual>();
        private List<double> _bests = new List<double>();
        private List<List<double>> _resValues = new List<List<double>>();

        public Algorithm(Parameters parameters)
        {
            _parameters = parameters;
            _randomizer = new Random();
            _calculations = new Calculations(_parameters);
            _size = _calculations.Resolution;
        }

        public Results Start()
        {
            for (int i = 1; i <= _parameters.T; i++)
            {
                Process(i);
            }
            return new Results()
            {
                XRealBest = _best.Real,
                XBinBest = _best.Binary,
                FXBest = _best.FunctionResult,
                ResValues = _resValues,
                Bests = _bests,
                FoundIn = _foundIn
            };
        }

        private void GetRandomIndividual()
        {
            _individual = new Individual();
            for (int i = 0; i < _size; i++)
            {
                _individual.Binary += RandomUtils.GetRandomInt(0, 2, _randomizer).ToString();
            }
        }

        private void Process(int iteration)
        {
            local = false;
            GetRandomIndividual();
            _mutated = new List<Individual>();
            var tempList = new List<double>();
            do
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
                _individual.Real = _calculations.BinToReal(_individual.Binary);
                _individual.FunctionResult = _calculations.GetFunctionResult(_individual.Real);

                // Liczenie wartości funkcji zmutowanych
                foreach (var item in _mutated)
                {
                    item.Real = _calculations.BinToReal(item.Binary);
                    item.FunctionResult = _calculations.GetFunctionResult(item.Real);
                }

                var best = _mutated.OrderByDescending(_ => _.FunctionResult)
                .FirstOrDefault();
                tempList.Add(_individual.FunctionResult);
                if (_individual.FunctionResult < best.FunctionResult)
                {
                    _individual = best;
                }
                else
                {
                    local = true;
                    VCS.Add(_individual);
                    if (_best.FunctionResult < _individual.FunctionResult)
                    {
                        if (_individual.FunctionResult > _best.FunctionResult)
                        {
                            _foundIn = iteration;
                        }
                        _best = _individual;
                        
                    }
                }
            } while (!local);
            _resValues.Add(tempList.OrderBy(_ => _).ToList());
            _bests.Add(_best.FunctionResult);
        }
    }
}
