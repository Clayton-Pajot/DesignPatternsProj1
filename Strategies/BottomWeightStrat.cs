using Assi1.Abstracts;
using Assi1.Concretes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    public class BottomWeightStrat : IStrategy
    {
        public BottomWeightStrat() 
        {
            //--
        }
        public float EvaluateStack(ObjectDictionary<int, HeavyObject> list)
        {
            
            float largest = list.At(0).Mass;
            float score = 0;
            for (IIterator<HeavyObject> i = list.CreateIterator(); !i.IsCompleted(); i.Next())
            {
                if(largest > i.CurrentItem().Mass)
                {
                    score++;
                }
                else if (largest < i.CurrentItem().Mass)
                {
                    largest = i.CurrentItem().Mass;
                    score--;
                }
            }

            return score;
            /*string result = null;
            foreach (HeavyObject heavyObject in list)
            {

            }
            return result;*/
        }

    }
}
