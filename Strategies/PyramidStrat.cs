using Assi1.Abstracts;
using Assi1.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    public class PyramidStrat : IStrategy
    {
        public float EvaluateStack(ObjectDictionary<int, HeavyObject> list)
        {
            float largest = list.At(0).Volume;
            float score = 0;
            for (IIterator<HeavyObject> i = list.CreateIterator(); !i.IsCompleted(); i.Next())
            {
                if (largest > i.CurrentItem().Volume)
                {
                    score++;
                }
                else if (largest < i.CurrentItem().Volume)
                {
                    largest = i.CurrentItem().Volume;
                    score--;
                }
            }

            return score;
        }
    }
}
