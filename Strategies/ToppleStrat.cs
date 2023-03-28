using Assi1.Abstracts;
using Assi1.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    public class ToppleStrat : IStrategy
    {
        public float EvaluateStack(ObjectDictionary<int, HeavyObject> list)
        {
            float largest = list.At(0).Length;
            float heaviest = list.At(0).Mass;
            float biggest = list.At(0).Volume;
            float score = 0;
            for (IIterator<HeavyObject> i = list.CreateIterator(); !i.IsCompleted(); i.Next())
            {
                //LARGEST
                if (largest < i.CurrentItem().Length)
                {
                    largest = i.CurrentItem().Length;
                    score++;
                }
                else if (largest > i.CurrentItem().Length)
                {
                    score--;
                }

                //HEAVIEST
                if (heaviest < i.CurrentItem().Mass)
                {
                    heaviest = i.CurrentItem().Mass;
                    score++;
                }
                else if (heaviest > i.CurrentItem().Mass)
                {
                    score--;
                }

                //BIGGEST
                if (biggest < i.CurrentItem().Volume)
                {
                    biggest = i.CurrentItem().Volume;
                    score++;
                }
                else if (biggest > i.CurrentItem().Volume)
                {
                    score--;
                }
            }

            return score;
        }
    }
}
