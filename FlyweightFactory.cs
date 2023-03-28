using Assi1.Abstracts;
using Assi1.Concretes;
using Assi1.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1
{
    public class FlyweightFactory
    {
        protected Dictionary<string, IStrategy> strategies;
        public enum StackingType
        {
            bottomWeight,
            pyramid,
            topple
        }
        public FlyweightFactory()
        {
            strategies = new Dictionary<string, IStrategy>();
        }

        public IStrategy GetFlyweight(string strategyType)
        {
            IStrategy strategy = null;

            //check if the strategy exists already
            if (strategies.ContainsKey(strategyType))
            {
                strategy = strategies[strategyType];
            }
            else
            {
                //create a new instance of our strategy class (flyweight object)
                switch (strategyType)
                {
                    case "bottomWeight":
                        strategy = new BottomWeightStrat();
                        break;

                    case "pyramid":
                        strategy = new PyramidStrat();
                        break;

                    case "topple":
                        strategy = new ToppleStrat();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(strategyType), strategyType, "Bad Strategy Type");
                }

                //don't forget to add it to the dictionary so we don't create any 
                //new instances of a strategy (just return the existing)
                strategies[strategyType] = strategy;
            }

            return strategy;
        }

    }
}
